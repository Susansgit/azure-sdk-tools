﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.ResourceManager.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.ResourceManager.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to cancel the active deployment of resource group &apos;{0}&apos;?.
        /// </summary>
        internal static string CancelResourceGroupDeployment {
            get {
                return ResourceManager.GetString("CancelResourceGroupDeployment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cancelling active resource group deployment ....
        /// </summary>
        internal static string CancelResourceGroupDeploymentMessage {
            get {
                return ResourceManager.GetString("CancelResourceGroupDeploymentMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find a deployment that matches the parameter values..
        /// </summary>
        internal static string DeploymentNotFound {
            get {
                return ResourceManager.GetString("DeploymentNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot parse {0} &apos;{1}&apos;.
        /// </summary>
        internal static string FailedToParseProperty {
            get {
                return ResourceManager.GetString("FailedToParseProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot set parameter &apos;{0}&apos; from TemplateParameterFile. Incompatible value &apos;{1}&apos;..
        /// </summary>
        internal static string FailureParsingTemplateParameterFile {
            get {
                return ResourceManager.GetString("FailureParsingTemplateParameterFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot set parameter &apos;{0}&apos; from TemplateParameterObject. Incompatible value &apos;{1}&apos;..
        /// </summary>
        internal static string FailureParsingTemplateParameterObject {
            get {
                return ResourceManager.GetString("FailureParsingTemplateParameterObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replacing resource group ....
        /// </summary>
        internal static string NewResourceGroupMessage {
            get {
                return ResourceManager.GetString("NewResourceGroupMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replacing resource ....
        /// </summary>
        internal static string NewResourceMessage {
            get {
                return ResourceManager.GetString("NewResourceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing resource group ....
        /// </summary>
        internal static string RemoveResourceGroupMessage {
            get {
                return ResourceManager.GetString("RemoveResourceGroupMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing resource ....
        /// </summary>
        internal static string RemoveResourceMessage {
            get {
                return ResourceManager.GetString("RemoveResourceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove resource &apos;{0}&apos;.
        /// </summary>
        internal static string RemovingResource {
            get {
                return ResourceManager.GetString("RemovingResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove resource group &apos;{0}&apos;.
        /// </summary>
        internal static string RemovingResourceGroup {
            get {
                return ResourceManager.GetString("RemovingResourceGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provided resource already exists. Are you sure you want to replace it?.
        /// </summary>
        internal static string ResourceAlreadyExists {
            get {
                return ResourceManager.GetString("ResourceAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provided resource does not exist..
        /// </summary>
        internal static string ResourceDoesntExists {
            get {
                return ResourceManager.GetString("ResourceDoesntExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provided resource group already exists. Are you sure you want to replace it?.
        /// </summary>
        internal static string ResourceGroupAlreadyExists {
            get {
                return ResourceManager.GetString("ResourceGroupAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provided resource group does not exist..
        /// </summary>
        internal static string ResourceGroupDoesntExists {
            get {
                return ResourceManager.GetString("ResourceGroupDoesntExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource type needs to be in the ResourceProvider/type format. For example Microsoft.Web/sites..
        /// </summary>
        internal static string ResourceTypeFormat {
            get {
                return ResourceManager.GetString("ResourceTypeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must specify StorageAccountName as a parameter or the CurrentStorageAccountName on the current subscription must be specified..
        /// </summary>
        internal static string StorageAccountNameNeedsToBeSpecified {
            get {
                return ResourceManager.GetString("StorageAccountNameNeedsToBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template is valid..
        /// </summary>
        internal static string TemplateValid {
            get {
                return ResourceManager.GetString("TemplateValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find Gallery item &apos;{0}&apos;.
        /// </summary>
        internal static string UnableToFindGallery {
            get {
                return ResourceManager.GetString("UnableToFindGallery", resourceCulture);
            }
        }
    }
}
