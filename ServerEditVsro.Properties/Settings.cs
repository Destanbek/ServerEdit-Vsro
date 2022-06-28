using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ServerEditVsro.Properties
{
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	[CompilerGenerated]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

		public static Settings Default
		{
			get
			{
				return defaultInstance;
			}
		}

		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue(".\\SQLEXPRESS")]
		public string SQL_Name
		{
			get
			{
				return (string)this["SQL_Name"];
			}
			set
			{
				this["SQL_Name"] = value;
			}
		}

		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string SQL_User
		{
			get
			{
				return (string)this["SQL_User"];
			}
			set
			{
				this["SQL_User"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string SQL_Pass
		{
			get
			{
				return (string)this["SQL_Pass"];
			}
			set
			{
				this["SQL_Pass"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string DB_Acc
		{
			get
			{
				return (string)this["DB_Acc"];
			}
			set
			{
				this["DB_Acc"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string DB_Log
		{
			get
			{
				return (string)this["DB_Log"];
			}
			set
			{
				this["DB_Log"] = value;
			}
		}

		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string DB_Shard
		{
			get
			{
				return (string)this["DB_Shard"];
			}
			set
			{
				this["DB_Shard"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool SQL_ConnectAuto
		{
			get
			{
				return (bool)this["SQL_ConnectAuto"];
			}
			set
			{
				this["SQL_ConnectAuto"] = value;
			}
		}

		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=94.101.91.195;Initial Catalog=Program;Persist Security Info=True;User ID=sa;Password=1907Fener")]
		[DebuggerNonUserCode]
		[ApplicationScopedSetting]
		public string ProgramConnectionString
		{
			get
			{
				return (string)this["ProgramConnectionString"];
			}
		}
	}
}
