using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Linq.Mapping;
using Steag.Framework.Model;

namespace Steag.Data
{
    public partial class DataContext
    {
        #region Extensibility Method Definitions
        partial void OnCreated();
        partial void InsertSystemSettings(SystemSettings instance);
        partial void UpdateSystemSettings(SystemSettings instance);
        partial void DeleteSystemSettings(SystemSettings instance);
        partial void InsertUserAccount(UserAccount instance);
        partial void UpdateUserAccount(UserAccount instance);
        partial void DeleteUserAccount(UserAccount instance);
        partial void InsertUserRole(UserRole instance);
        partial void UpdateUserRole(UserRole instance);
        partial void DeleteUserRole(UserRole instance);
        partial void InsertUserRoleWebPage(UserRoleWebPage instance);
        partial void UpdateUserRoleWebPage(UserRoleWebPage instance);
        partial void DeleteUserRoleWebPage(UserRoleWebPage instance);
        partial void InsertWebPageRegistry(WebPageRegistry instance);
        partial void UpdateWebPageRegistry(WebPageRegistry instance);
        partial void DeleteWebPageRegistry(WebPageRegistry instance);
        #endregion
		
		public DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}

        public DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SystemSettings> SystemSettings
		{
			get
			{
				return this.GetTable<SystemSettings>();
			}
		}
		
		public System.Data.Linq.Table<UserAccount> UserAccount
		{
			get
			{
				return this.GetTable<UserAccount>();
			}
		}
		
		public System.Data.Linq.Table<UserRole> UserRole
		{
			get
			{
				return this.GetTable<UserRole>();
			}
		}
		
		public System.Data.Linq.Table<UserRoleWebPage> UserRoleWebPage
		{
			get
			{
				return this.GetTable<UserRoleWebPage>();
			}
		}
		
		public System.Data.Linq.Table<WebPageRegistry> WebPageRegistry
		{
			get
			{
				return this.GetTable<WebPageRegistry>();
			}
		}
    }
}
