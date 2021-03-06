﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.WindowsAzure.MediaServices.Client.Properties {
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [DebuggerNonUserCode()]
    [CompilerGenerated()]
    internal class Resources {
        
        private static ResourceManager resourceMan;
        
        private static CultureInfo resourceCulture;
        
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager {
            get {
                if (ReferenceEquals(resourceMan, null)) {
                    ResourceManager temp = new ResourceManager("Microsoft.WindowsAzure.MediaServices.Client.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create channel operation {0}, operation id: {1}, {2}.
        /// </summary>
        internal static string ErrorCreateChannelFailedFormat {
            get {
                return ResourceManager.GetString("ErrorCreateChannelFailedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create streaming endpoint operation {0}, operation id: {1}, {2}.
        /// </summary>
        internal static string ErrorCreateStreamingEndpointFailedFormat {
            get {
                return ResourceManager.GetString("ErrorCreateStreamingEndpointFailedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete channel operation {0}, operation id: {1}, {2}.
        /// </summary>
        internal static string ErrorDeleteChannelFailedFormat {
            get {
                return ResourceManager.GetString("ErrorDeleteChannelFailedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete streaming endpoint operation {0}, operation id: {1}, {2}.
        /// </summary>
        internal static string ErrorDeleteStreamingEndpointFailedFormat {
            get {
                return ResourceManager.GetString("ErrorDeleteStreamingEndpointFailedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Channel input IP allow list must be set..
        /// </summary>
        internal static string ErrorEmptyChannelInputIPAllowList {
            get {
                return ResourceManager.GetString("ErrorEmptyChannelInputIPAllowList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Channel name must not be empty..
        /// </summary>
        internal static string ErrorEmptyChannelName {
            get {
                return ResourceManager.GetString("ErrorEmptyChannelName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Program name must not be empty..
        /// </summary>
        internal static string ErrorEmptyProgramName {
            get {
                return ResourceManager.GetString("ErrorEmptyProgramName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Streaming endpoint name must not be empty..
        /// </summary>
        internal static string ErrorEmptyStreamingEndpointName {
            get {
                return ResourceManager.GetString("ErrorEmptyStreamingEndpointName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entity doesn&apos;t have Id.
        /// </summary>
        internal static string ErrorEntityWithoutId {
            get {
                return ResourceManager.GetString("ErrorEntityWithoutId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Streaming endpoint scale units must be a positive number.
        /// </summary>
        internal static string ErrorInvalidStreamingEndpointScaleUnits {
            get {
                return ResourceManager.GetString("ErrorInvalidStreamingEndpointScaleUnits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} operation {1}, operation id: {2}.
        /// </summary>
        internal static string ErrorOperationFailedFormat {
            get {
                return ResourceManager.GetString("ErrorOperationFailedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal server error. Operation not found: {0}.
        /// </summary>
        internal static string ErrorOperationNotFoundFormat {
            get {
                return ResourceManager.GetString("ErrorOperationNotFoundFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a program that is not a child of a channel..
        /// </summary>
        internal static string ErrorOrphanProgram {
            get {
                return ResourceManager.GetString("ErrorOrphanProgram", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update operation {0}, operation id: {1}, {2}.
        /// </summary>
        internal static string ErrorUpdateFailedFormat {
            get {
                return ResourceManager.GetString("ErrorUpdateFailedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to failed.
        /// </summary>
        internal static string Failed {
            get {
                return ResourceManager.GetString("Failed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to in invalid state:.
        /// </summary>
        internal static string InInvalidState {
            get {
                return ResourceManager.GetString("InInvalidState", resourceCulture);
            }
        }
    }
}
