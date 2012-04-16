using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data.Linq;

namespace Steag.Framework.Model
{
    public partial class SystemSettings : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private long _ID;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(long value);
        partial void OnIDChanged();
        #endregion

        public SystemSettings()
        {
            OnCreated();
        }

        public long ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._ID = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public partial class UserAccount : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private long _ID;

        private string _UserName;

        private string _Password;

        private string _Salt;

        private long _UserRoleID;

        private string _FirstName;

        private string _MiddleName;

        private string _LastName;

        private System.Nullable<bool> _IsActive;

        private System.Nullable<long> _UserCreated;

        private System.Nullable<System.DateTime> _DateCreated;

        private System.Nullable<long> _UserModified;

        private System.Nullable<System.DateTime> _DateModified;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(long value);
        partial void OnIDChanged();
        partial void OnUserNameChanging(string value);
        partial void OnUserNameChanged();
        partial void OnPasswordChanging(string value);
        partial void OnPasswordChanged();
        partial void OnSaltChanging(string value);
        partial void OnSaltChanged();
        partial void OnUserRoleIDChanging(System.Nullable<long> value);
        partial void OnUserRoleIDChanged();
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        partial void OnMiddleNameChanging(string value);
        partial void OnMiddleNameChanged();
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
        partial void OnIsActiveChanging(System.Nullable<bool> value);
        partial void OnIsActiveChanged();
        partial void OnUserCreatedChanging(System.Nullable<long> value);
        partial void OnUserCreatedChanged();
        partial void OnDateCreatedChanging(System.Nullable<System.DateTime> value);
        partial void OnDateCreatedChanged();
        partial void OnUserModifiedChanging(System.Nullable<long> value);
        partial void OnUserModifiedChanged();
        partial void OnDateModifiedChanging(System.Nullable<System.DateTime> value);
        partial void OnDateModifiedChanged();
        #endregion

        public UserAccount()
        {
            OnCreated();
        }

        public long ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._ID = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        public string UserName
        {
            get
            {
                return this._UserName;
            }
            set
            {
                if ((this._UserName != value))
                {
                    this.OnUserNameChanging(value);
                    this.SendPropertyChanging();
                    this._UserName = value;
                    this.SendPropertyChanged("UserName");
                    this.OnUserNameChanged();
                }
            }
        }

        public string Password
        {
            get
            {
                return this._Password;
            }
            set
            {
                if ((this._Password != value))
                {
                    this.OnPasswordChanging(value);
                    this.SendPropertyChanging();
                    this._Password = value;
                    this.SendPropertyChanged("Password");
                    this.OnPasswordChanged();
                }
            }
        }

        public string Salt
        {
            get
            {
                return this._Salt;
            }
            set
            {
                if ((this._Salt != value))
                {
                    this.OnSaltChanging(value);
                    this.SendPropertyChanging();
                    this._Salt = value;
                    this.SendPropertyChanged("Salt");
                    this.OnSaltChanged();
                }
            }
        }

        public long UserRoleID
        {
            get
            {
                return this._UserRoleID;
            }
            set
            {
                if ((this._UserRoleID != value))
                {
                    this.OnUserRoleIDChanging(value);
                    this.SendPropertyChanging();
                    this._UserRoleID = value;
                    this.SendPropertyChanged("UserRoleID");
                    this.OnUserRoleIDChanged();
                }
            }
        }

        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                if ((this._FirstName != value))
                {
                    this.OnFirstNameChanging(value);
                    this.SendPropertyChanging();
                    this._FirstName = value;
                    this.SendPropertyChanged("FirstName");
                    this.OnFirstNameChanged();
                }
            }
        }

        public string MiddleName
        {
            get
            {
                return this._MiddleName;
            }
            set
            {
                if ((this._MiddleName != value))
                {
                    this.OnMiddleNameChanging(value);
                    this.SendPropertyChanging();
                    this._MiddleName = value;
                    this.SendPropertyChanged("MiddleName");
                    this.OnMiddleNameChanged();
                }
            }
        }

        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                if ((this._LastName != value))
                {
                    this.OnLastNameChanging(value);
                    this.SendPropertyChanging();
                    this._LastName = value;
                    this.SendPropertyChanged("LastName");
                    this.OnLastNameChanged();
                }
            }
        }

        public System.Nullable<bool> IsActive
        {
            get
            {
                return this._IsActive;
            }
            set
            {
                if ((this._IsActive != value))
                {
                    this.OnIsActiveChanging(value);
                    this.SendPropertyChanging();
                    this._IsActive = value;
                    this.SendPropertyChanged("IsActive");
                    this.OnIsActiveChanged();
                }
            }
        }

        public System.Nullable<long> UserCreated
        {
            get
            {
                return this._UserCreated;
            }
            set
            {
                if ((this._UserCreated != value))
                {
                    this.OnUserCreatedChanging(value);
                    this.SendPropertyChanging();
                    this._UserCreated = value;
                    this.SendPropertyChanged("UserCreated");
                    this.OnUserCreatedChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> DateCreated
        {
            get
            {
                return this._DateCreated;
            }
            set
            {
                if ((this._DateCreated != value))
                {
                    this.OnDateCreatedChanging(value);
                    this.SendPropertyChanging();
                    this._DateCreated = value;
                    this.SendPropertyChanged("DateCreated");
                    this.OnDateCreatedChanged();
                }
            }
        }

        public System.Nullable<long> UserModified
        {
            get
            {
                return this._UserModified;
            }
            set
            {
                if ((this._UserModified != value))
                {
                    this.OnUserModifiedChanging(value);
                    this.SendPropertyChanging();
                    this._UserModified = value;
                    this.SendPropertyChanged("UserModified");
                    this.OnUserModifiedChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> DateModified
        {
            get
            {
                return this._DateModified;
            }
            set
            {
                if ((this._DateModified != value))
                {
                    this.OnDateModifiedChanging(value);
                    this.SendPropertyChanging();
                    this._DateModified = value;
                    this.SendPropertyChanged("DateModified");
                    this.OnDateModifiedChanged();
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public partial class UserRole : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private long _ID;

        private string _RoleCode;

        private string _Description;

        private bool _IsTemplate;

        private System.Nullable<bool> _IsActive;

        private System.Nullable<long> _UserCreated;

        private System.Nullable<System.DateTime> _DateCreated;

        private System.Nullable<long> _UserModified;

        private System.Nullable<System.DateTime> _DateModified;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(long value);
        partial void OnIDChanged();
        partial void OnRoleCodeChanging(string value);
        partial void OnRoleCodeChanged();
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        partial void OnIsTemplateChanging(bool value);
        partial void OnIsTemplateChanged();
        partial void OnIsActiveChanging(System.Nullable<bool> value);
        partial void OnIsActiveChanged();
        partial void OnUserCreatedChanging(System.Nullable<long> value);
        partial void OnUserCreatedChanged();
        partial void OnDateCreatedChanging(System.Nullable<System.DateTime> value);
        partial void OnDateCreatedChanged();
        partial void OnUserModifiedChanging(System.Nullable<long> value);
        partial void OnUserModifiedChanged();
        partial void OnDateModifiedChanging(System.Nullable<System.DateTime> value);
        partial void OnDateModifiedChanged();
        #endregion

        public UserRole()
        {
            OnCreated();
        }

        public long ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._ID = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        public string RoleCode
        {
            get
            {
                return this._RoleCode;
            }
            set
            {
                if ((this._RoleCode != value))
                {
                    this.OnRoleCodeChanging(value);
                    this.SendPropertyChanging();
                    this._RoleCode = value;
                    this.SendPropertyChanged("RoleCode");
                    this.OnRoleCodeChanged();
                }
            }
        }

        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                if ((this._Description != value))
                {
                    this.OnDescriptionChanging(value);
                    this.SendPropertyChanging();
                    this._Description = value;
                    this.SendPropertyChanged("Description");
                    this.OnDescriptionChanged();
                }
            }
        }

        public bool IsTemplate
        {
            get
            {
                return this._IsTemplate;
            }
            set
            {
                if ((this._IsTemplate != value))
                {
                    this.OnIsTemplateChanging(value);
                    this.SendPropertyChanging();
                    this._IsTemplate = value;
                    this.SendPropertyChanged("IsTemplate");
                    this.OnIsTemplateChanged();
                }
            }
        }

        public System.Nullable<bool> IsActive
        {
            get
            {
                return this._IsActive;
            }
            set
            {
                if ((this._IsActive != value))
                {
                    this.OnIsActiveChanging(value);
                    this.SendPropertyChanging();
                    this._IsActive = value;
                    this.SendPropertyChanged("IsActive");
                    this.OnIsActiveChanged();
                }
            }
        }

        public System.Nullable<long> UserCreated
        {
            get
            {
                return this._UserCreated;
            }
            set
            {
                if ((this._UserCreated != value))
                {
                    this.OnUserCreatedChanging(value);
                    this.SendPropertyChanging();
                    this._UserCreated = value;
                    this.SendPropertyChanged("UserCreated");
                    this.OnUserCreatedChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> DateCreated
        {
            get
            {
                return this._DateCreated;
            }
            set
            {
                if ((this._DateCreated != value))
                {
                    this.OnDateCreatedChanging(value);
                    this.SendPropertyChanging();
                    this._DateCreated = value;
                    this.SendPropertyChanged("DateCreated");
                    this.OnDateCreatedChanged();
                }
            }
        }

        public System.Nullable<long> UserModified
        {
            get
            {
                return this._UserModified;
            }
            set
            {
                if ((this._UserModified != value))
                {
                    this.OnUserModifiedChanging(value);
                    this.SendPropertyChanging();
                    this._UserModified = value;
                    this.SendPropertyChanged("UserModified");
                    this.OnUserModifiedChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> DateModified
        {
            get
            {
                return this._DateModified;
            }
            set
            {
                if ((this._DateModified != value))
                {
                    this.OnDateModifiedChanging(value);
                    this.SendPropertyChanging();
                    this._DateModified = value;
                    this.SendPropertyChanged("DateModified");
                    this.OnDateModifiedChanged();
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public partial class UserRoleWebPage : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private long _ID;

        private long _UserRoleID;

        private long _WebPageID;

        private System.Nullable<bool> _IsActive;

        private System.Nullable<long> _UserCreated;

        private System.Nullable<System.DateTime> _DateCreated;

        private System.Nullable<long> _UserModified;

        private System.Nullable<System.DateTime> _DateModififed;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(long value);
        partial void OnIDChanged();
        partial void OnUserRoleIDChanging(long value);
        partial void OnUserRoleIDChanged();
        partial void OnWebPageIDChanging(long value);
        partial void OnWebPageIDChanged();
        partial void OnIsActiveChanging(System.Nullable<bool> value);
        partial void OnIsActiveChanged();
        partial void OnUserCreatedChanging(System.Nullable<long> value);
        partial void OnUserCreatedChanged();
        partial void OnDateCreatedChanging(System.Nullable<System.DateTime> value);
        partial void OnDateCreatedChanged();
        partial void OnUserModifiedChanging(System.Nullable<long> value);
        partial void OnUserModifiedChanged();
        partial void OnDateModififedChanging(System.Nullable<System.DateTime> value);
        partial void OnDateModififedChanged();
        #endregion

        public UserRoleWebPage()
        {
            OnCreated();
        }

        public long ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._ID = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        public long UserRoleID
        {
            get
            {
                return this._UserRoleID;
            }
            set
            {
                if ((this._UserRoleID != value))
                {
                    this.OnUserRoleIDChanging(value);
                    this.SendPropertyChanging();
                    this._UserRoleID = value;
                    this.SendPropertyChanged("UserRoleID");
                    this.OnUserRoleIDChanged();
                }
            }
        }

        public long WebPageID
        {
            get
            {
                return this._WebPageID;
            }
            set
            {
                if ((this._WebPageID != value))
                {
                    this.OnWebPageIDChanging(value);
                    this.SendPropertyChanging();
                    this._WebPageID = value;
                    this.SendPropertyChanged("WebPageID");
                    this.OnWebPageIDChanged();
                }
            }
        }

        public System.Nullable<bool> IsActive
        {
            get
            {
                return this._IsActive;
            }
            set
            {
                if ((this._IsActive != value))
                {
                    this.OnIsActiveChanging(value);
                    this.SendPropertyChanging();
                    this._IsActive = value;
                    this.SendPropertyChanged("IsActive");
                    this.OnIsActiveChanged();
                }
            }
        }

        public System.Nullable<long> UserCreated
        {
            get
            {
                return this._UserCreated;
            }
            set
            {
                if ((this._UserCreated != value))
                {
                    this.OnUserCreatedChanging(value);
                    this.SendPropertyChanging();
                    this._UserCreated = value;
                    this.SendPropertyChanged("UserCreated");
                    this.OnUserCreatedChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> DateCreated
        {
            get
            {
                return this._DateCreated;
            }
            set
            {
                if ((this._DateCreated != value))
                {
                    this.OnDateCreatedChanging(value);
                    this.SendPropertyChanging();
                    this._DateCreated = value;
                    this.SendPropertyChanged("DateCreated");
                    this.OnDateCreatedChanged();
                }
            }
        }

        public System.Nullable<long> UserModified
        {
            get
            {
                return this._UserModified;
            }
            set
            {
                if ((this._UserModified != value))
                {
                    this.OnUserModifiedChanging(value);
                    this.SendPropertyChanging();
                    this._UserModified = value;
                    this.SendPropertyChanged("UserModified");
                    this.OnUserModifiedChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> DateModififed
        {
            get
            {
                return this._DateModififed;
            }
            set
            {
                if ((this._DateModififed != value))
                {
                    this.OnDateModififedChanging(value);
                    this.SendPropertyChanging();
                    this._DateModififed = value;
                    this.SendPropertyChanged("DateModififed");
                    this.OnDateModififedChanged();
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public partial class WebPageRegistry : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private long _ID;

        private string _PageIdentity;

        private string _FullName;

        private string _AssemblyName;

        private string _Description;

        private System.Nullable<bool> _IsActive;

        private System.Nullable<long> _UserCreated;

        private System.Nullable<System.DateTime> _DateCreated;

        private System.Nullable<long> _UserModified;

        private System.Nullable<System.DateTime> _DateModified;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(long value);
        partial void OnIDChanged();
        partial void OnPageIdentityChanging(string value);
        partial void OnPageIdentityChanged();
        partial void OnFullNameChanging(string value);
        partial void OnFullNameChanged();
        partial void OnAssemblyNameChanging(string value);
        partial void OnAssemblyNameChanged();
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        partial void OnIsActiveChanging(System.Nullable<bool> value);
        partial void OnIsActiveChanged();
        partial void OnUserCreatedChanging(System.Nullable<long> value);
        partial void OnUserCreatedChanged();
        partial void OnDateCreatedChanging(System.Nullable<System.DateTime> value);
        partial void OnDateCreatedChanged();
        partial void OnUserModifiedChanging(System.Nullable<long> value);
        partial void OnUserModifiedChanged();
        partial void OnDateModifiedChanging(System.Nullable<System.DateTime> value);
        partial void OnDateModifiedChanged();
        #endregion

        public WebPageRegistry()
        {
            OnCreated();
        }

        public long ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._ID = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        public string PageIdentity
        {
            get
            {
                return this._PageIdentity;
            }
            set
            {
                if ((this._PageIdentity != value))
                {
                    this.OnPageIdentityChanging(value);
                    this.SendPropertyChanging();
                    this._PageIdentity = value;
                    this.SendPropertyChanged("PageIdentity");
                    this.OnPageIdentityChanged();
                }
            }
        }

        public string FullName
        {
            get
            {
                return this._FullName;
            }
            set
            {
                if ((this._FullName != value))
                {
                    this.OnFullNameChanging(value);
                    this.SendPropertyChanging();
                    this._FullName = value;
                    this.SendPropertyChanged("FullName");
                    this.OnFullNameChanged();
                }
            }
        }

        public string AssemblyName
        {
            get
            {
                return this._AssemblyName;
            }
            set
            {
                if ((this._AssemblyName != value))
                {
                    this.OnAssemblyNameChanging(value);
                    this.SendPropertyChanging();
                    this._AssemblyName = value;
                    this.SendPropertyChanged("AssemblyName");
                    this.OnAssemblyNameChanged();
                }
            }
        }

        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                if ((this._Description != value))
                {
                    this.OnDescriptionChanging(value);
                    this.SendPropertyChanging();
                    this._Description = value;
                    this.SendPropertyChanged("Description");
                    this.OnDescriptionChanged();
                }
            }
        }

        public System.Nullable<bool> IsActive
        {
            get
            {
                return this._IsActive;
            }
            set
            {
                if ((this._IsActive != value))
                {
                    this.OnIsActiveChanging(value);
                    this.SendPropertyChanging();
                    this._IsActive = value;
                    this.SendPropertyChanged("IsActive");
                    this.OnIsActiveChanged();
                }
            }
        }

        public System.Nullable<long> UserCreated
        {
            get
            {
                return this._UserCreated;
            }
            set
            {
                if ((this._UserCreated != value))
                {
                    this.OnUserCreatedChanging(value);
                    this.SendPropertyChanging();
                    this._UserCreated = value;
                    this.SendPropertyChanged("UserCreated");
                    this.OnUserCreatedChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> DateCreated
        {
            get
            {
                return this._DateCreated;
            }
            set
            {
                if ((this._DateCreated != value))
                {
                    this.OnDateCreatedChanging(value);
                    this.SendPropertyChanging();
                    this._DateCreated = value;
                    this.SendPropertyChanged("DateCreated");
                    this.OnDateCreatedChanged();
                }
            }
        }

        public System.Nullable<long> UserModified
        {
            get
            {
                return this._UserModified;
            }
            set
            {
                if ((this._UserModified != value))
                {
                    this.OnUserModifiedChanging(value);
                    this.SendPropertyChanging();
                    this._UserModified = value;
                    this.SendPropertyChanged("UserModified");
                    this.OnUserModifiedChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> DateModified
        {
            get
            {
                return this._DateModified;
            }
            set
            {
                if ((this._DateModified != value))
                {
                    this.OnDateModifiedChanging(value);
                    this.SendPropertyChanging();
                    this._DateModified = value;
                    this.SendPropertyChanged("DateModified");
                    this.OnDateModifiedChanged();
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
