﻿//-----------------------------------------------------------------------
// <copyright file="OAuthDataServiceAdapter.cs" company="Microsoft">Copyright 2012 Microsoft Corporation</copyright>
// <license>
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </license>


using System;
using System.Data.Services.Client;
using System.Globalization;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Microsoft.WindowsAzure.MediaServices.Client.RequestAdapters;

namespace Microsoft.WindowsAzure.MediaServices.Client.OAuth
{

    /// <summary>
    /// An OAuth adapter for a data service.
    /// </summary>
    public class OAuthDataServiceAdapter : IDataServiceContextAdapter
    {
        private const string AuthorizationHeader = "Authorization";
        private const string BearerTokenFormat = "Bearer {0}";
        private const int ExpirationTimeBufferInSeconds = 600;  // The token has an expiration time in hours, 
                                                                // so setting the buffer as 10 minutes is safe for 
                                                                // the network latency and clock skew.

        private readonly MediaServicesCredentials _credentials;
        private readonly static object _acsRefreshLock = new object();
        private readonly string _trustedRestCertificateHash;
        private readonly string _trustedRestSubject;

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthDataServiceAdapter"/> class.
        /// </summary>
        /// <param name="credentials">Microsoft WindowsAzure Media Services credentials.</param>
        /// <param name="trustedRestCertificateHash">The trusted rest certificate hash.</param>
        /// <param name="trustedRestSubject">The trusted rest subject.</param>
        public OAuthDataServiceAdapter(MediaServicesCredentials credentials, string trustedRestCertificateHash, string trustedRestSubject)
        {
            this._credentials = credentials;
            this._trustedRestCertificateHash = trustedRestCertificateHash;
            this._trustedRestSubject = trustedRestSubject;
        }

        /// <summary>
        /// Adapts the specified data service context.
        /// </summary>
        /// <param name="dataServiceContext">The data service context.</param>
        public void Adapt(DataServiceContext dataServiceContext)
        {
            if (dataServiceContext == null) { throw new ArgumentNullException("dataServiceContext"); }
            dataServiceContext.SendingRequest2 += this.OnSendingRequest;
        }

        /// <summary>
        /// Adds the access token to request.
        /// </summary>
        /// <param name="request">The request.</param>
        public void AddAccessTokenToRequest(WebRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            if (request.Headers[AuthorizationHeader] == null)
            {
                RefreshToken();
                request.Headers.Add(AuthorizationHeader, string.Format(CultureInfo.InvariantCulture, BearerTokenFormat, this._credentials.AccessToken));
            }
        }

        private void RefreshToken()
        {
            lock (_acsRefreshLock)
            {
                if (DateTime.UtcNow.AddSeconds(ExpirationTimeBufferInSeconds) > this._credentials.TokenExpiration)
                {
                    this._credentials.RefreshToken();
                }
            }
        }

        /// <summary> 
        /// When sending Http Data requests to the Azure Marketplace, inject authorization header based on the current Access token.
        /// </summary> 
        /// <param name="sender">Event sender.</param> 
        /// <param name="e">Event arguments.</param> 
        private void OnSendingRequest(object sender, SendingRequest2EventArgs e)
        {
            if (e.RequestMessage.GetHeader(AuthorizationHeader) == null)
            {
                RefreshToken();
                e.RequestMessage.SetHeader(AuthorizationHeader, string.Format(CultureInfo.InvariantCulture, BearerTokenFormat, this._credentials.AccessToken));
            }
        }
    }
}
