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
    partial void InsertBadgeRegistry(BadgeRegistry instance);
    partial void UpdateBadgeRegistry(BadgeRegistry instance);
    partial void DeleteBadgeRegistry(BadgeRegistry instance);
    partial void InsertCompany(Company instance);
    partial void UpdateCompany(Company instance);
    partial void DeleteCompany(Company instance);
    partial void InsertEACS(EACS instance);
    partial void UpdateEACS(EACS instance);
    partial void DeleteEACS(EACS instance);
    partial void InsertEACSPersons(EACSPersons instance);
    partial void UpdateEACSPersons(EACSPersons instance);
    partial void DeleteEACSPersons(EACSPersons instance);
    partial void InsertEACSVehicles(EACSVehicles instance);
    partial void UpdateEACSVehicles(EACSVehicles instance);
    partial void DeleteEACSVehicles(EACSVehicles instance);
    partial void InsertECDAP(ECDAP instance);
    partial void UpdateECDAP(ECDAP instance);
    partial void DeleteECDAP(ECDAP instance);
    partial void InsertPerson(Person instance);
    partial void UpdatePerson(Person instance);
    partial void DeletePerson(Person instance);
    partial void InsertSARF(SARF instance);
    partial void UpdateSARF(SARF instance);
    partial void DeleteSARF(SARF instance);
    partial void InsertSARFPersons(SARFPersons instance);
    partial void UpdateSARFPersons(SARFPersons instance);
    partial void DeleteSARFPersons(SARFPersons instance);
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
    partial void InsertWatchList(WatchList instance);
    partial void UpdateWatchList(WatchList instance);
    partial void DeleteWatchList(WatchList instance);
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

        public System.Data.Linq.Table<AutoNumbering> AutoNumbering
        {
            get
            {
                return this.GetTable<AutoNumbering>();
            }
        }

        public System.Data.Linq.Table<BadgeRegistry> BadgeRegistry
        {
            get
            {
                return this.GetTable<BadgeRegistry>();
            }
        }

        public System.Data.Linq.Table<Company> Company
        {
            get
            {
                return this.GetTable<Company>();
            }
        }

        public System.Data.Linq.Table<EACS> EACS
        {
            get
            {
                return this.GetTable<EACS>();
            }
        }

        public System.Data.Linq.Table<EACSPersons> EACSPersons
        {
            get
            {
                return this.GetTable<EACSPersons>();
            }
        }

        public System.Data.Linq.Table<EACSVehicles> EACSVehicles
        {
            get
            {
                return this.GetTable<EACSVehicles>();
            }
        }

        public System.Data.Linq.Table<ECDAP> ECDAP
        {
            get
            {
                return this.GetTable<ECDAP>();
            }
        }

        public System.Data.Linq.Table<Person> Person
        {
            get
            {
                return this.GetTable<Person>();
            }
        }

        public System.Data.Linq.Table<SARF> SARF
        {
            get
            {
                return this.GetTable<SARF>();
            }
        }

        public System.Data.Linq.Table<SARFPersons> SARFPersons
        {
            get
            {
                return this.GetTable<SARFPersons>();
            }
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

        public System.Data.Linq.Table<WatchList> WatchList
        {
            get
            {
                return this.GetTable<WatchList>();
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
