﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace reexjungle.xcal.application.server.web.dev1.Properties {
    
    
    [CompilerGenerated()]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("xCal - iCalendar Web Services (DEV1)")]
        public string service_name {
            get {
                return ((string)(this["service_name"]));
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("xcal_dev1_db")]
        public string main_db_name {
            get {
                return ((string)(this["main_db_name"]));
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("False")]
        public bool overwrite_db {
            get {
                return ((bool)(this["overwrite_db"]));
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("xcal_elmah_dev1_db")]
        public string elmah_db_name {
            get {
                return ((string)(this["elmah_db_name"]));
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("elmah_error")]
        public string elmah_error_table {
            get {
                return ((string)(this["elmah_error_table"]));
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("xcal_nlog_dev1_db")]
        public string nlog_db_name {
            get {
                return ((string)(this["nlog_db_name"]));
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("localhost:6379")]
        public string redis_server {
            get {
                return ((string)(this["redis_server"]));
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("Server=localhost;Uid = dev;Pwd=dev;allow user variables=true")]
        public string mysql_server {
            get {
                return ((string)(this["mysql_server"]));
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [SpecialSetting(SpecialSetting.ConnectionString)]
        [DefaultSettingValue("Server=localhost;Uid =dev;Pwd=dev;Database=xcal_elmah_dev1_db;allow user variable" +
            "s=true")]
        public string elmah_mysql_db {
            get {
                return ((string)(this["elmah_mysql_db"]));
            }
        }
    }
}
