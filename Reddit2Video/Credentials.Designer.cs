﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reddit2Video {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Credentials : global::System.Configuration.ApplicationSettingsBase {
        
        private static Credentials defaultInstance = ((Credentials)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Credentials())));
        
        public static Credentials Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("RedditVideoBot321")]
        public string RedditUsername {
            get {
                return ((string)(this["RedditUsername"]));
            }
            set {
                this["RedditUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("JaettuP4ssu")]
        public string RedditPassword {
            get {
                return ((string)(this["RedditPassword"]));
            }
            set {
                this["RedditPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TODO")]
        public string YoutubeUsername {
            get {
                return ((string)(this["YoutubeUsername"]));
            }
            set {
                this["YoutubeUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TODO")]
        public string YoutubePassword {
            get {
                return ((string)(this["YoutubePassword"]));
            }
            set {
                this["YoutubePassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("hW1GKIG_4_lSHgAb7U_lIQ")]
        public string RedditClientID {
            get {
                return ((string)(this["RedditClientID"]));
            }
            set {
                this["RedditClientID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("rDm7CdO39fvls1lkMJhGi-OVeMrgUQ")]
        public string RedditSecret {
            get {
                return ((string)(this["RedditSecret"]));
            }
            set {
                this["RedditSecret"] = value;
            }
        }
    }
}
