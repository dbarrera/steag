using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data.Linq;

namespace Steag.Framework.Model
{
    public partial class BadgeRegistry : INotifyPropertyChanging, INotifyPropertyChanged, IAuditable
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private long _ID;

        private string _BadgeCode;

        private System.Nullable<bool> _IsIssued;

        private System.Nullable<bool> _IsActive;

        private System.Nullable<long> _UserCreated;

        private System.Nullable<System.DateTime> _DateCreated;

        private System.Nullable<long> _UserModified;

        private System.Nullable<System.DateTime> _DateModified;

        private EntitySet<ECDAP> _ECDAP;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(long value);
        partial void OnIDChanged();
        partial void OnBadgeCodeChanging(string value);
        partial void OnBadgeCodeChanged();
        partial void OnIsIssuedChanging(System.Nullable<bool> value);
        partial void OnIsIssuedChanged();
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

        public BadgeRegistry()
        {
            this._ECDAP = new EntitySet<ECDAP>(new Action<ECDAP>(this.attach_ECDAP), new Action<ECDAP>(this.detach_ECDAP));
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

        public string BadgeCode
        {
            get
            {
                return this._BadgeCode;
            }
            set
            {
                if ((this._BadgeCode != value))
                {
                    this.OnBadgeCodeChanging(value);
                    this.SendPropertyChanging();
                    this._BadgeCode = value;
                    this.SendPropertyChanged("BadgeCode");
                    this.OnBadgeCodeChanged();
                }
            }
        }

        public System.Nullable<bool> IsIssued
        {
            get
            {
                return this._IsIssued;
            }
            set
            {
                if ((this._IsIssued != value))
                {
                    this.OnIsIssuedChanging(value);
                    this.SendPropertyChanging();
                    this._IsIssued = value;
                    this.SendPropertyChanged("IsIssued");
                    this.OnIsIssuedChanged();
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

        public EntitySet<ECDAP> ECDAP
        {
            get
            {
                return this._ECDAP;
            }
            set
            {
                this._ECDAP.Assign(value);
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

        private void attach_ECDAP(ECDAP entity)
        {
            this.SendPropertyChanging();
            entity.BadgeRegistry = this;
        }

        private void detach_ECDAP(ECDAP entity)
        {
            this.SendPropertyChanging();
            entity.BadgeRegistry = null;
        }
    }

    public partial class Company : INotifyPropertyChanging, INotifyPropertyChanged, IAuditable
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private long _ID;

        private string _CompanyName;

        private string _Address1;

        private string _Address2;

        private string _State;

        private string _Country;

        private string _PostalCode;

        private string _EmailAddress2;

        private string _EmailAddrses2;

        private System.Nullable<long> _ContactPerson;

        private string _TelNo1;

        private string _TelNo2;

        private System.Nullable<bool> _IsActive;

        private System.Nullable<long> _UserCreated;

        private System.Nullable<System.DateTime> _DateCreated;

        private System.Nullable<long> _UserModified;

        private System.Nullable<System.DateTime> _DateModified;

        private EntitySet<Person> _Person;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(long value);
        partial void OnIDChanged();
        partial void OnCompanyNameChanging(string value);
        partial void OnCompanyNameChanged();
        partial void OnAddress1Changing(string value);
        partial void OnAddress1Changed();
        partial void OnAddress2Changing(string value);
        partial void OnAddress2Changed();
        partial void OnStateChanging(string value);
        partial void OnStateChanged();
        partial void OnCountryChanging(string value);
        partial void OnCountryChanged();
        partial void OnPostalCodeChanging(string value);
        partial void OnPostalCodeChanged();
        partial void OnEmailAddress2Changing(string value);
        partial void OnEmailAddress2Changed();
        partial void OnEmailAddrses2Changing(string value);
        partial void OnEmailAddrses2Changed();
        partial void OnContactPersonChanging(System.Nullable<long> value);
        partial void OnContactPersonChanged();
        partial void OnTelNo1Changing(string value);
        partial void OnTelNo1Changed();
        partial void OnTelNo2Changing(string value);
        partial void OnTelNo2Changed();
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

        public Company()
        {
            this._Person = new EntitySet<Person>(new Action<Person>(this.attach_Person), new Action<Person>(this.detach_Person));
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

        public string CompanyName
        {
            get
            {
                return this._CompanyName;
            }
            set
            {
                if ((this._CompanyName != value))
                {
                    this.OnCompanyNameChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyName = value;
                    this.SendPropertyChanged("CompanyName");
                    this.OnCompanyNameChanged();
                }
            }
        }

        public string Address1
        {
            get
            {
                return this._Address1;
            }
            set
            {
                if ((this._Address1 != value))
                {
                    this.OnAddress1Changing(value);
                    this.SendPropertyChanging();
                    this._Address1 = value;
                    this.SendPropertyChanged("Address1");
                    this.OnAddress1Changed();
                }
            }
        }

        public string Address2
        {
            get
            {
                return this._Address2;
            }
            set
            {
                if ((this._Address2 != value))
                {
                    this.OnAddress2Changing(value);
                    this.SendPropertyChanging();
                    this._Address2 = value;
                    this.SendPropertyChanged("Address2");
                    this.OnAddress2Changed();
                }
            }
        }

        public string State
        {
            get
            {
                return this._State;
            }
            set
            {
                if ((this._State != value))
                {
                    this.OnStateChanging(value);
                    this.SendPropertyChanging();
                    this._State = value;
                    this.SendPropertyChanged("State");
                    this.OnStateChanged();
                }
            }
        }

        public string Country
        {
            get
            {
                return this._Country;
            }
            set
            {
                if ((this._Country != value))
                {
                    this.OnCountryChanging(value);
                    this.SendPropertyChanging();
                    this._Country = value;
                    this.SendPropertyChanged("Country");
                    this.OnCountryChanged();
                }
            }
        }

        public string PostalCode
        {
            get
            {
                return this._PostalCode;
            }
            set
            {
                if ((this._PostalCode != value))
                {
                    this.OnPostalCodeChanging(value);
                    this.SendPropertyChanging();
                    this._PostalCode = value;
                    this.SendPropertyChanged("PostalCode");
                    this.OnPostalCodeChanged();
                }
            }
        }

        public string EmailAddress2
        {
            get
            {
                return this._EmailAddress2;
            }
            set
            {
                if ((this._EmailAddress2 != value))
                {
                    this.OnEmailAddress2Changing(value);
                    this.SendPropertyChanging();
                    this._EmailAddress2 = value;
                    this.SendPropertyChanged("EmailAddress2");
                    this.OnEmailAddress2Changed();
                }
            }
        }

        public string EmailAddrses2
        {
            get
            {
                return this._EmailAddrses2;
            }
            set
            {
                if ((this._EmailAddrses2 != value))
                {
                    this.OnEmailAddrses2Changing(value);
                    this.SendPropertyChanging();
                    this._EmailAddrses2 = value;
                    this.SendPropertyChanged("EmailAddrses2");
                    this.OnEmailAddrses2Changed();
                }
            }
        }

        public System.Nullable<long> ContactPerson
        {
            get
            {
                return this._ContactPerson;
            }
            set
            {
                if ((this._ContactPerson != value))
                {
                    this.OnContactPersonChanging(value);
                    this.SendPropertyChanging();
                    this._ContactPerson = value;
                    this.SendPropertyChanged("ContactPerson");
                    this.OnContactPersonChanged();
                }
            }
        }

        public string TelNo1
        {
            get
            {
                return this._TelNo1;
            }
            set
            {
                if ((this._TelNo1 != value))
                {
                    this.OnTelNo1Changing(value);
                    this.SendPropertyChanging();
                    this._TelNo1 = value;
                    this.SendPropertyChanged("TelNo1");
                    this.OnTelNo1Changed();
                }
            }
        }

        public string TelNo2
        {
            get
            {
                return this._TelNo2;
            }
            set
            {
                if ((this._TelNo2 != value))
                {
                    this.OnTelNo2Changing(value);
                    this.SendPropertyChanging();
                    this._TelNo2 = value;
                    this.SendPropertyChanged("TelNo2");
                    this.OnTelNo2Changed();
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

        public EntitySet<Person> Person
        {
            get
            {
                return this._Person;
            }
            set
            {
                this._Person.Assign(value);
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

        private void attach_Person(Person entity)
        {
            this.SendPropertyChanging();
            entity.Company = this;
        }

        private void detach_Person(Person entity)
        {
            this.SendPropertyChanging();
            entity.Company = null;
        }
    }

    public partial class EACS : INotifyPropertyChanging, INotifyPropertyChanged, IAuditable
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private long _ID;

        private long _SARFID;

        private string _EACSCode;

        private System.Nullable<System.DateTime> _TransactionDate;

        private string _Purpose;

        private System.Nullable<bool> _IsFirstVisit;

        private string _Notes;

        private string _Status;

        private System.Nullable<System.DateTime> _ProcessedDate;

        private System.Nullable<long> _ProcessedBy;

        private System.Nullable<System.DateTime> _VerifiedDate;

        private System.Nullable<long> _VerifiedBy;

        private System.Nullable<System.DateTime> _ClosedDate;

        private System.Nullable<long> _ClosedBy;

        private System.Nullable<bool> _IsActive;

        private System.Nullable<long> _UserCreated;

        private System.Nullable<System.DateTime> _DateCreated;

        private System.Nullable<long> _UserModified;

        private System.Nullable<System.DateTime> _DateModified;

        private EntityRef<UserAccount> _UserAccount;

        private EntityRef<UserAccount> _ProcessedByUserAccount;

        private EntityRef<SARF> _SARF;

        private EntityRef<UserAccount> _VerifiedByUserAccount;

        private EntitySet<EACSPersons> _EACSPersons;

        private EntitySet<EACSVehicles> _EACSVehicles;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(long value);
        partial void OnIDChanged();
        partial void OnSARFIDChanging(long value);
        partial void OnSARFIDChanged();
        partial void OnEACSCodeChanging(string value);
        partial void OnEACSCodeChanged();
        partial void OnTransactionDateChanging(System.Nullable<System.DateTime> value);
        partial void OnTransactionDateChanged();
        partial void OnPurposeChanging(string value);
        partial void OnPurposeChanged();
        partial void OnIsFirstVisitChanging(System.Nullable<bool> value);
        partial void OnIsFirstVisitChanged();
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
        partial void OnStatusChanging(string value);
        partial void OnStatusChanged();
        partial void OnProcessedDateChanging(System.Nullable<System.DateTime> value);
        partial void OnProcessedDateChanged();
        partial void OnProcessedByChanging(System.Nullable<long> value);
        partial void OnProcessedByChanged();
        partial void OnVerifiedDateChanging(System.Nullable<System.DateTime> value);
        partial void OnVerifiedDateChanged();
        partial void OnVerifiedByChanging(System.Nullable<long> value);
        partial void OnVerifiedByChanged();
        partial void OnClosedDateChanging(System.Nullable<System.DateTime> value);
        partial void OnClosedDateChanged();
        partial void OnClosedByChanging(System.Nullable<long> value);
        partial void OnClosedByChanged();
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

        public EACS()
        {
            this._UserAccount = default(EntityRef<UserAccount>);
            this._ProcessedByUserAccount = default(EntityRef<UserAccount>);
            this._SARF = default(EntityRef<SARF>);
            this._VerifiedByUserAccount = default(EntityRef<UserAccount>);
            this._EACSPersons = new EntitySet<EACSPersons>(new Action<EACSPersons>(this.attach_EACSPersons), new Action<EACSPersons>(this.detach_EACSPersons));
            this._EACSVehicles = new EntitySet<EACSVehicles>(new Action<EACSVehicles>(this.attach_EACSVehicles), new Action<EACSVehicles>(this.detach_EACSVehicles));
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

        public long SARFID
        {
            get
            {
                return this._SARFID;
            }
            set
            {
                if ((this._SARFID != value))
                {
                    if (this._SARF.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnSARFIDChanging(value);
                    this.SendPropertyChanging();
                    this._SARFID = value;
                    this.SendPropertyChanged("SARFID");
                    this.OnSARFIDChanged();
                }
            }
        }

        public string EACSCode
        {
            get
            {
                return this._EACSCode;
            }
            set
            {
                if ((this._EACSCode != value))
                {
                    this.OnEACSCodeChanging(value);
                    this.SendPropertyChanging();
                    this._EACSCode = value;
                    this.SendPropertyChanged("EACSCode");
                    this.OnEACSCodeChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> TransactionDate
        {
            get
            {
                return this._TransactionDate;
            }
            set
            {
                if ((this._TransactionDate != value))
                {
                    this.OnTransactionDateChanging(value);
                    this.SendPropertyChanging();
                    this._TransactionDate = value;
                    this.SendPropertyChanged("TransactionDate");
                    this.OnTransactionDateChanged();
                }
            }
        }

        public string Purpose
        {
            get
            {
                return this._Purpose;
            }
            set
            {
                if ((this._Purpose != value))
                {
                    this.OnPurposeChanging(value);
                    this.SendPropertyChanging();
                    this._Purpose = value;
                    this.SendPropertyChanged("Purpose");
                    this.OnPurposeChanged();
                }
            }
        }

        public System.Nullable<bool> IsFirstVisit
        {
            get
            {
                return this._IsFirstVisit;
            }
            set
            {
                if ((this._IsFirstVisit != value))
                {
                    this.OnIsFirstVisitChanging(value);
                    this.SendPropertyChanging();
                    this._IsFirstVisit = value;
                    this.SendPropertyChanged("IsFirstVisit");
                    this.OnIsFirstVisitChanged();
                }
            }
        }

        public string Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                if ((this._Notes != value))
                {
                    this.OnNotesChanging(value);
                    this.SendPropertyChanging();
                    this._Notes = value;
                    this.SendPropertyChanged("Notes");
                    this.OnNotesChanged();
                }
            }
        }

        public string Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                if ((this._Status != value))
                {
                    this.OnStatusChanging(value);
                    this.SendPropertyChanging();
                    this._Status = value;
                    this.SendPropertyChanged("Status");
                    this.OnStatusChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> ProcessedDate
        {
            get
            {
                return this._ProcessedDate;
            }
            set
            {
                if ((this._ProcessedDate != value))
                {
                    this.OnProcessedDateChanging(value);
                    this.SendPropertyChanging();
                    this._ProcessedDate = value;
                    this.SendPropertyChanged("ProcessedDate");
                    this.OnProcessedDateChanged();
                }
            }
        }

        public System.Nullable<long> ProcessedBy
        {
            get
            {
                return this._ProcessedBy;
            }
            set
            {
                if ((this._ProcessedBy != value))
                {
                    if (this._ProcessedByUserAccount.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnProcessedByChanging(value);
                    this.SendPropertyChanging();
                    this._ProcessedBy = value;
                    this.SendPropertyChanged("ProcessedBy");
                    this.OnProcessedByChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> VerifiedDate
        {
            get
            {
                return this._VerifiedDate;
            }
            set
            {
                if ((this._VerifiedDate != value))
                {
                    this.OnVerifiedDateChanging(value);
                    this.SendPropertyChanging();
                    this._VerifiedDate = value;
                    this.SendPropertyChanged("VerifiedDate");
                    this.OnVerifiedDateChanged();
                }
            }
        }

        public System.Nullable<long> VerifiedBy
        {
            get
            {
                return this._VerifiedBy;
            }
            set
            {
                if ((this._VerifiedBy != value))
                {
                    if (this._VerifiedByUserAccount.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnVerifiedByChanging(value);
                    this.SendPropertyChanging();
                    this._VerifiedBy = value;
                    this.SendPropertyChanged("VerifiedBy");
                    this.OnVerifiedByChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> ClosedDate
        {
            get
            {
                return this._ClosedDate;
            }
            set
            {
                if ((this._ClosedDate != value))
                {
                    this.OnClosedDateChanging(value);
                    this.SendPropertyChanging();
                    this._ClosedDate = value;
                    this.SendPropertyChanged("ClosedDate");
                    this.OnClosedDateChanged();
                }
            }
        }

        public System.Nullable<long> ClosedBy
        {
            get
            {
                return this._ClosedBy;
            }
            set
            {
                if ((this._ClosedBy != value))
                {
                    if (this._UserAccount.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnClosedByChanging(value);
                    this.SendPropertyChanging();
                    this._ClosedBy = value;
                    this.SendPropertyChanged("ClosedBy");
                    this.OnClosedByChanged();
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

        public UserAccount UserAccount
        {
            get
            {
                return this._UserAccount.Entity;
            }
            set
            {
                UserAccount previousValue = this._UserAccount.Entity;
                if (((previousValue != value)
                            || (this._UserAccount.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._UserAccount.Entity = null;
                        previousValue.EACS.Remove(this);
                    }
                    this._UserAccount.Entity = value;
                    if ((value != null))
                    {
                        value.EACS.Add(this);
                        this._ClosedBy = value.ID;
                    }
                    else
                    {
                        this._ClosedBy = default(Nullable<long>);
                    }
                    this.SendPropertyChanged("UserAccount");
                }
            }
        }

        public UserAccount ProcessedByUserAccount
        {
            get
            {
                return this._ProcessedByUserAccount.Entity;
            }
            set
            {
                UserAccount previousValue = this._ProcessedByUserAccount.Entity;
                if (((previousValue != value)
                            || (this._ProcessedByUserAccount.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._ProcessedByUserAccount.Entity = null;
                        previousValue.EACS_ProcessedBy.Remove(this);
                    }
                    this._ProcessedByUserAccount.Entity = value;
                    if ((value != null))
                    {
                        value.EACS_ProcessedBy.Add(this);
                        this._ProcessedBy = value.ID;
                    }
                    else
                    {
                        this._ProcessedBy = default(Nullable<long>);
                    }
                    this.SendPropertyChanged("ProcessedByUserAccount");
                }
            }
        }

        public SARF SARF
        {
            get
            {
                return this._SARF.Entity;
            }
            set
            {
                SARF previousValue = this._SARF.Entity;
                if (((previousValue != value)
                            || (this._SARF.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._SARF.Entity = null;
                        previousValue.EACS.Remove(this);
                    }
                    this._SARF.Entity = value;
                    if ((value != null))
                    {
                        value.EACS.Add(this);
                        this._SARFID = value.ID;
                    }
                    else
                    {
                        this._SARFID = default(long);
                    }
                    this.SendPropertyChanged("SARF");
                }
            }
        }

        public UserAccount VerifiedByUserAccount
        {
            get
            {
                return this._VerifiedByUserAccount.Entity;
            }
            set
            {
                UserAccount previousValue = this._VerifiedByUserAccount.Entity;
                if (((previousValue != value)
                            || (this._VerifiedByUserAccount.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._VerifiedByUserAccount.Entity = null;
                        previousValue.EACS_VerifiedBy.Remove(this);
                    }
                    this._VerifiedByUserAccount.Entity = value;
                    if ((value != null))
                    {
                        value.EACS_VerifiedBy.Add(this);
                        this._VerifiedBy = value.ID;
                    }
                    else
                    {
                        this._VerifiedBy = default(Nullable<long>);
                    }
                    this.SendPropertyChanged("VerifiedByUserAccount");
                }
            }
        }

        public EntitySet<EACSPersons> EACSPersons
        {
            get
            {
                return this._EACSPersons;
            }
            set
            {
                this._EACSPersons.Assign(value);
            }
        }

        public EntitySet<EACSVehicles> EACSVehicles
        {
            get
            {
                return this._EACSVehicles;
            }
            set
            {
                this._EACSVehicles.Assign(value);
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

        private void attach_EACSPersons(EACSPersons entity)
        {
            this.SendPropertyChanging();
            entity.EACS = this;
        }

        private void detach_EACSPersons(EACSPersons entity)
        {
            this.SendPropertyChanging();
            entity.EACS = null;
        }

        private void attach_EACSVehicles(EACSVehicles entity)
        {
            this.SendPropertyChanging();
            entity.EACS = this;
        }

        private void detach_EACSVehicles(EACSVehicles entity)
        {
            this.SendPropertyChanging();
            entity.EACS = null;
        }
    }

    public partial class EACSPersons : INotifyPropertyChanging, INotifyPropertyChanged, IAuditable
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private long _ID;

        private long _EACSID;

        private long _PersonID;

        private string _Status;

        private System.Nullable<bool> _IsActive;

        private System.Nullable<long> _UserCreated;

        private System.Nullable<System.DateTime> _DateCreated;

        private System.Nullable<long> _UserModified;

        private System.Nullable<System.DateTime> _DateModified;

        private EntityRef<EACS> _EACS;

        private EntityRef<Person> _Person;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(long value);
        partial void OnIDChanged();
        partial void OnEACSIDChanging(long value);
        partial void OnEACSIDChanged();
        partial void OnPersonIDChanging(long value);
        partial void OnPersonIDChanged();
        partial void OnStatusChanging(string value);
        partial void OnStatusChanged();
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

        public EACSPersons()
        {
            this._EACS = default(EntityRef<EACS>);
            this._Person = default(EntityRef<Person>);
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

        public long EACSID
        {
            get
            {
                return this._EACSID;
            }
            set
            {
                if ((this._EACSID != value))
                {
                    if (this._EACS.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnEACSIDChanging(value);
                    this.SendPropertyChanging();
                    this._EACSID = value;
                    this.SendPropertyChanged("EACSID");
                    this.OnEACSIDChanged();
                }
            }
        }

        public long PersonID
        {
            get
            {
                return this._PersonID;
            }
            set
            {
                if ((this._PersonID != value))
                {
                    if (this._Person.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnPersonIDChanging(value);
                    this.SendPropertyChanging();
                    this._PersonID = value;
                    this.SendPropertyChanged("PersonID");
                    this.OnPersonIDChanged();
                }
            }
        }

        public string Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                if ((this._Status != value))
                {
                    this.OnStatusChanging(value);
                    this.SendPropertyChanging();
                    this._Status = value;
                    this.SendPropertyChanged("Status");
                    this.OnStatusChanged();
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

        public EACS EACS
        {
            get
            {
                return this._EACS.Entity;
            }
            set
            {
                EACS previousValue = this._EACS.Entity;
                if (((previousValue != value)
                            || (this._EACS.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._EACS.Entity = null;
                        previousValue.EACSPersons.Remove(this);
                    }
                    this._EACS.Entity = value;
                    if ((value != null))
                    {
                        value.EACSPersons.Add(this);
                        this._EACSID = value.ID;
                    }
                    else
                    {
                        this._EACSID = default(long);
                    }
                    this.SendPropertyChanged("EACS");
                }
            }
        }

        public Person Person
        {
            get
            {
                return this._Person.Entity;
            }
            set
            {
                Person previousValue = this._Person.Entity;
                if (((previousValue != value)
                            || (this._Person.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Person.Entity = null;
                        previousValue.EACSPersons.Remove(this);
                    }
                    this._Person.Entity = value;
                    if ((value != null))
                    {
                        value.EACSPersons.Add(this);
                        this._PersonID = value.ID;
                    }
                    else
                    {
                        this._PersonID = default(long);
                    }
                    this.SendPropertyChanged("Person");
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

    public partial class EACSVehicles : INotifyPropertyChanging, INotifyPropertyChanged, IAuditable
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private long _ID;

        private long _EACSID;

        private string _RegistrationNumber;

        private string _SequenceNumber;

        private string _VehicleType;

        private string _DriversName;

        private string _DriversLicenseNumber;

        private System.Nullable<bool> _IsInspectionDone;

        private string _IssuedParkingPermit;

        private string _ParkingPermitColor;

        private System.Nullable<short> _NumberOfPassengers;

        private System.Nullable<bool> _HasLiquor;

        private System.Nullable<bool> _HasFireArm;

        private System.Nullable<bool> _HasAmmunition;

        private System.Nullable<bool> _HasDeadlyWeapon;

        private string _Status;

        private System.Nullable<bool> _IsActive;

        private System.Nullable<long> _UserCreated;

        private System.Nullable<System.DateTime> _DateCreated;

        private System.Nullable<long> _UserModified;

        private System.Nullable<System.DateTime> _DateModified;

        private EntityRef<EACS> _EACS;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(long value);
        partial void OnIDChanged();
        partial void OnEACSIDChanging(long value);
        partial void OnEACSIDChanged();
        partial void OnRegistrationNumberChanging(string value);
        partial void OnRegistrationNumberChanged();
        partial void OnSequenceNumberChanging(string value);
        partial void OnSequenceNumberChanged();
        partial void OnVehicleTypeChanging(string value);
        partial void OnVehicleTypeChanged();
        partial void OnDriversNameChanging(string value);
        partial void OnDriversNameChanged();
        partial void OnDriversLicenseNumberChanging(string value);
        partial void OnDriversLicenseNumberChanged();
        partial void OnIsInspectionDoneChanging(System.Nullable<bool> value);
        partial void OnIsInspectionDoneChanged();
        partial void OnIssuedParkingPermitChanging(string value);
        partial void OnIssuedParkingPermitChanged();
        partial void OnParkingPermitColorChanging(string value);
        partial void OnParkingPermitColorChanged();
        partial void OnNumberOfPassengersChanging(System.Nullable<short> value);
        partial void OnNumberOfPassengersChanged();
        partial void OnHasLiquorChanging(System.Nullable<bool> value);
        partial void OnHasLiquorChanged();
        partial void OnHasFireArmChanging(System.Nullable<bool> value);
        partial void OnHasFireArmChanged();
        partial void OnHasAmmunitionChanging(System.Nullable<bool> value);
        partial void OnHasAmmunitionChanged();
        partial void OnHasDeadlyWeaponChanging(System.Nullable<bool> value);
        partial void OnHasDeadlyWeaponChanged();
        partial void OnStatusChanging(string value);
        partial void OnStatusChanged();
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

        public EACSVehicles()
        {
            this._EACS = default(EntityRef<EACS>);
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

        public long EACSID
        {
            get
            {
                return this._EACSID;
            }
            set
            {
                if ((this._EACSID != value))
                {
                    if (this._EACS.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnEACSIDChanging(value);
                    this.SendPropertyChanging();
                    this._EACSID = value;
                    this.SendPropertyChanged("EACSID");
                    this.OnEACSIDChanged();
                }
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this._RegistrationNumber;
            }
            set
            {
                if ((this._RegistrationNumber != value))
                {
                    this.OnRegistrationNumberChanging(value);
                    this.SendPropertyChanging();
                    this._RegistrationNumber = value;
                    this.SendPropertyChanged("RegistrationNumber");
                    this.OnRegistrationNumberChanged();
                }
            }
        }

        public string SequenceNumber
        {
            get
            {
                return this._SequenceNumber;
            }
            set
            {
                if ((this._SequenceNumber != value))
                {
                    this.OnSequenceNumberChanging(value);
                    this.SendPropertyChanging();
                    this._SequenceNumber = value;
                    this.SendPropertyChanged("SequenceNumber");
                    this.OnSequenceNumberChanged();
                }
            }
        }

        public string VehicleType
        {
            get
            {
                return this._VehicleType;
            }
            set
            {
                if ((this._VehicleType != value))
                {
                    this.OnVehicleTypeChanging(value);
                    this.SendPropertyChanging();
                    this._VehicleType = value;
                    this.SendPropertyChanged("VehicleType");
                    this.OnVehicleTypeChanged();
                }
            }
        }

        public string DriversName
        {
            get
            {
                return this._DriversName;
            }
            set
            {
                if ((this._DriversName != value))
                {
                    this.OnDriversNameChanging(value);
                    this.SendPropertyChanging();
                    this._DriversName = value;
                    this.SendPropertyChanged("DriversName");
                    this.OnDriversNameChanged();
                }
            }
        }

        public string DriversLicenseNumber
        {
            get
            {
                return this._DriversLicenseNumber;
            }
            set
            {
                if ((this._DriversLicenseNumber != value))
                {
                    this.OnDriversLicenseNumberChanging(value);
                    this.SendPropertyChanging();
                    this._DriversLicenseNumber = value;
                    this.SendPropertyChanged("DriversLicenseNumber");
                    this.OnDriversLicenseNumberChanged();
                }
            }
        }

        public System.Nullable<bool> IsInspectionDone
        {
            get
            {
                return this._IsInspectionDone;
            }
            set
            {
                if ((this._IsInspectionDone != value))
                {
                    this.OnIsInspectionDoneChanging(value);
                    this.SendPropertyChanging();
                    this._IsInspectionDone = value;
                    this.SendPropertyChanged("IsInspectionDone");
                    this.OnIsInspectionDoneChanged();
                }
            }
        }

        public string IssuedParkingPermit
        {
            get
            {
                return this._IssuedParkingPermit;
            }
            set
            {
                if ((this._IssuedParkingPermit != value))
                {
                    this.OnIssuedParkingPermitChanging(value);
                    this.SendPropertyChanging();
                    this._IssuedParkingPermit = value;
                    this.SendPropertyChanged("IssuedParkingPermit");
                    this.OnIssuedParkingPermitChanged();
                }
            }
        }

        public string ParkingPermitColor
        {
            get
            {
                return this._ParkingPermitColor;
            }
            set
            {
                if ((this._ParkingPermitColor != value))
                {
                    this.OnParkingPermitColorChanging(value);
                    this.SendPropertyChanging();
                    this._ParkingPermitColor = value;
                    this.SendPropertyChanged("ParkingPermitColor");
                    this.OnParkingPermitColorChanged();
                }
            }
        }

        public System.Nullable<short> NumberOfPassengers
        {
            get
            {
                return this._NumberOfPassengers;
            }
            set
            {
                if ((this._NumberOfPassengers != value))
                {
                    this.OnNumberOfPassengersChanging(value);
                    this.SendPropertyChanging();
                    this._NumberOfPassengers = value;
                    this.SendPropertyChanged("NumberOfPassengers");
                    this.OnNumberOfPassengersChanged();
                }
            }
        }

        public System.Nullable<bool> HasLiquor
        {
            get
            {
                return this._HasLiquor;
            }
            set
            {
                if ((this._HasLiquor != value))
                {
                    this.OnHasLiquorChanging(value);
                    this.SendPropertyChanging();
                    this._HasLiquor = value;
                    this.SendPropertyChanged("HasLiquor");
                    this.OnHasLiquorChanged();
                }
            }
        }

        public System.Nullable<bool> HasFireArm
        {
            get
            {
                return this._HasFireArm;
            }
            set
            {
                if ((this._HasFireArm != value))
                {
                    this.OnHasFireArmChanging(value);
                    this.SendPropertyChanging();
                    this._HasFireArm = value;
                    this.SendPropertyChanged("HasFireArm");
                    this.OnHasFireArmChanged();
                }
            }
        }

        public System.Nullable<bool> HasAmmunition
        {
            get
            {
                return this._HasAmmunition;
            }
            set
            {
                if ((this._HasAmmunition != value))
                {
                    this.OnHasAmmunitionChanging(value);
                    this.SendPropertyChanging();
                    this._HasAmmunition = value;
                    this.SendPropertyChanged("HasAmmunition");
                    this.OnHasAmmunitionChanged();
                }
            }
        }

        public System.Nullable<bool> HasDeadlyWeapon
        {
            get
            {
                return this._HasDeadlyWeapon;
            }
            set
            {
                if ((this._HasDeadlyWeapon != value))
                {
                    this.OnHasDeadlyWeaponChanging(value);
                    this.SendPropertyChanging();
                    this._HasDeadlyWeapon = value;
                    this.SendPropertyChanged("HasDeadlyWeapon");
                    this.OnHasDeadlyWeaponChanged();
                }
            }
        }

        public string Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                if ((this._Status != value))
                {
                    this.OnStatusChanging(value);
                    this.SendPropertyChanging();
                    this._Status = value;
                    this.SendPropertyChanged("Status");
                    this.OnStatusChanged();
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

        public EACS EACS
        {
            get
            {
                return this._EACS.Entity;
            }
            set
            {
                EACS previousValue = this._EACS.Entity;
                if (((previousValue != value)
                            || (this._EACS.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._EACS.Entity = null;
                        previousValue.EACSVehicles.Remove(this);
                    }
                    this._EACS.Entity = value;
                    if ((value != null))
                    {
                        value.EACSVehicles.Add(this);
                        this._EACSID = value.ID;
                    }
                    else
                    {
                        this._EACSID = default(long);
                    }
                    this.SendPropertyChanged("EACS");
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

    public partial class ECDAP : INotifyPropertyChanging, INotifyPropertyChanged, IAuditable
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private long _ID;

        private long _EACSID;

        private string _ECDAPCode;

        private long _BadgeID;

        private System.Nullable<System.DateTime> _DateIssued;

        private long _IssuedTo;

        private System.Nullable<long> _IssuedBy;

        private System.Nullable<System.DateTime> _DateReturned;

        private System.Nullable<bool> _IsReturned;

        private System.Nullable<bool> _IsActive;

        private System.Nullable<long> _UserCreated;

        private System.Nullable<System.DateTime> _DateCreated;

        private System.Nullable<long> _UserModified;

        private System.Nullable<System.DateTime> _DateModified;

        private EntityRef<BadgeRegistry> _BadgeRegistry;

        private EntityRef<Person> _Person;

        private EntityRef<UserAccount> _UserAccount;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(long value);
        partial void OnIDChanged();
        partial void OnEACSIDChanging(long value);
        partial void OnEACSIDChanged();
        partial void OnECDAPCodeChanging(string value);
        partial void OnECDAPCodeChanged();
        partial void OnBadgeIDChanging(long value);
        partial void OnBadgeIDChanged();
        partial void OnDateIssuedChanging(System.Nullable<System.DateTime> value);
        partial void OnDateIssuedChanged();
        partial void OnIssuedToChanging(long value);
        partial void OnIssuedToChanged();
        partial void OnIssuedByChanging(System.Nullable<long> value);
        partial void OnIssuedByChanged();
        partial void OnDateReturnedChanging(System.Nullable<System.DateTime> value);
        partial void OnDateReturnedChanged();
        partial void OnIsReturnedChanging(System.Nullable<bool> value);
        partial void OnIsReturnedChanged();
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

        public ECDAP()
        {
            this._BadgeRegistry = default(EntityRef<BadgeRegistry>);
            this._Person = default(EntityRef<Person>);
            this._UserAccount = default(EntityRef<UserAccount>);
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

        public long EACSID
        {
            get
            {
                return this._EACSID;
            }
            set
            {
                if ((this._EACSID != value))
                {
                    this.OnEACSIDChanging(value);
                    this.SendPropertyChanging();
                    this._EACSID = value;
                    this.SendPropertyChanged("EACSID");
                    this.OnEACSIDChanged();
                }
            }
        }

        public string ECDAPCode
        {
            get
            {
                return this._ECDAPCode;
            }
            set
            {
                if ((this._ECDAPCode != value))
                {
                    this.OnECDAPCodeChanging(value);
                    this.SendPropertyChanging();
                    this._ECDAPCode = value;
                    this.SendPropertyChanged("ECDAPCode");
                    this.OnECDAPCodeChanged();
                }
            }
        }

        public long BadgeID
        {
            get
            {
                return this._BadgeID;
            }
            set
            {
                if ((this._BadgeID != value))
                {
                    if (this._BadgeRegistry.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnBadgeIDChanging(value);
                    this.SendPropertyChanging();
                    this._BadgeID = value;
                    this.SendPropertyChanged("BadgeID");
                    this.OnBadgeIDChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> DateIssued
        {
            get
            {
                return this._DateIssued;
            }
            set
            {
                if ((this._DateIssued != value))
                {
                    this.OnDateIssuedChanging(value);
                    this.SendPropertyChanging();
                    this._DateIssued = value;
                    this.SendPropertyChanged("DateIssued");
                    this.OnDateIssuedChanged();
                }
            }
        }

        public long IssuedTo
        {
            get
            {
                return this._IssuedTo;
            }
            set
            {
                if ((this._IssuedTo != value))
                {
                    if (this._Person.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnIssuedToChanging(value);
                    this.SendPropertyChanging();
                    this._IssuedTo = value;
                    this.SendPropertyChanged("IssuedTo");
                    this.OnIssuedToChanged();
                }
            }
        }

        public System.Nullable<long> IssuedBy
        {
            get
            {
                return this._IssuedBy;
            }
            set
            {
                if ((this._IssuedBy != value))
                {
                    if (this._UserAccount.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnIssuedByChanging(value);
                    this.SendPropertyChanging();
                    this._IssuedBy = value;
                    this.SendPropertyChanged("IssuedBy");
                    this.OnIssuedByChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> DateReturned
        {
            get
            {
                return this._DateReturned;
            }
            set
            {
                if ((this._DateReturned != value))
                {
                    this.OnDateReturnedChanging(value);
                    this.SendPropertyChanging();
                    this._DateReturned = value;
                    this.SendPropertyChanged("DateReturned");
                    this.OnDateReturnedChanged();
                }
            }
        }

        public System.Nullable<bool> IsReturned
        {
            get
            {
                return this._IsReturned;
            }
            set
            {
                if ((this._IsReturned != value))
                {
                    this.OnIsReturnedChanging(value);
                    this.SendPropertyChanging();
                    this._IsReturned = value;
                    this.SendPropertyChanged("IsReturned");
                    this.OnIsReturnedChanged();
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

        public BadgeRegistry BadgeRegistry
        {
            get
            {
                return this._BadgeRegistry.Entity;
            }
            set
            {
                BadgeRegistry previousValue = this._BadgeRegistry.Entity;
                if (((previousValue != value)
                            || (this._BadgeRegistry.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._BadgeRegistry.Entity = null;
                        previousValue.ECDAP.Remove(this);
                    }
                    this._BadgeRegistry.Entity = value;
                    if ((value != null))
                    {
                        value.ECDAP.Add(this);
                        this._BadgeID = value.ID;
                    }
                    else
                    {
                        this._BadgeID = default(long);
                    }
                    this.SendPropertyChanged("BadgeRegistry");
                }
            }
        }

        public Person Person
        {
            get
            {
                return this._Person.Entity;
            }
            set
            {
                Person previousValue = this._Person.Entity;
                if (((previousValue != value)
                            || (this._Person.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Person.Entity = null;
                        previousValue.ECDAP.Remove(this);
                    }
                    this._Person.Entity = value;
                    if ((value != null))
                    {
                        value.ECDAP.Add(this);
                        this._IssuedTo = value.ID;
                    }
                    else
                    {
                        this._IssuedTo = default(long);
                    }
                    this.SendPropertyChanged("Person");
                }
            }
        }

        public UserAccount UserAccount
        {
            get
            {
                return this._UserAccount.Entity;
            }
            set
            {
                UserAccount previousValue = this._UserAccount.Entity;
                if (((previousValue != value)
                            || (this._UserAccount.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._UserAccount.Entity = null;
                        previousValue.ECDAP.Remove(this);
                    }
                    this._UserAccount.Entity = value;
                    if ((value != null))
                    {
                        value.ECDAP.Add(this);
                        this._IssuedBy = value.ID;
                    }
                    else
                    {
                        this._IssuedBy = default(Nullable<long>);
                    }
                    this.SendPropertyChanged("UserAccount");
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

    public partial class Person : INotifyPropertyChanging, INotifyPropertyChanged, IAuditable
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private long _ID;

        private string _LastName;

        private string _FirstName;

        private string _MiddleName;

        private System.Nullable<System.DateTime> _Birthday;

        private string _Sex;

        private string _Position;

        private System.Data.Linq.Binary _Photo;

        private System.Nullable<long> _CompanyID;

        private System.Nullable<bool> _HasVisited;

        private System.Nullable<System.DateTime> _DateOfFirstVisit;

        private System.Nullable<System.DateTime> _LastVisited;

        private System.Nullable<bool> _IsActive;

        private System.Nullable<long> _UserCreated;

        private System.Nullable<System.DateTime> _DateCreated;

        private System.Nullable<long> _UserModified;

        private System.Nullable<System.DateTime> _DateModified;

        private EntityRef<Company> _Company;

        private EntitySet<EACSPersons> _EACSPersons;

        private EntitySet<ECDAP> _ECDAP;

        private EntitySet<SARFPersons> _SARFPersons;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(long value);
        partial void OnIDChanged();
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        partial void OnMiddleNameChanging(string value);
        partial void OnMiddleNameChanged();
        partial void OnBirthdayChanging(System.Nullable<System.DateTime> value);
        partial void OnBirthdayChanged();
        partial void OnSexChanging(string value);
        partial void OnSexChanged();
        partial void OnPositionChanging(string value);
        partial void OnPositionChanged();
        partial void OnPhotoChanging(System.Data.Linq.Binary value);
        partial void OnPhotoChanged();
        partial void OnCompanyIDChanging(System.Nullable<long> value);
        partial void OnCompanyIDChanged();
        partial void OnHasVisitedChanging(System.Nullable<bool> value);
        partial void OnHasVisitedChanged();
        partial void OnDateOfFirstVisitChanging(System.Nullable<System.DateTime> value);
        partial void OnDateOfFirstVisitChanged();
        partial void OnLastVisitedChanging(System.Nullable<System.DateTime> value);
        partial void OnLastVisitedChanged();
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

        public Person()
        {
            this._Company = default(EntityRef<Company>);
            this._EACSPersons = new EntitySet<EACSPersons>(new Action<EACSPersons>(this.attach_EACSPersons), new Action<EACSPersons>(this.detach_EACSPersons));
            this._ECDAP = new EntitySet<ECDAP>(new Action<ECDAP>(this.attach_ECDAP), new Action<ECDAP>(this.detach_ECDAP));
            this._SARFPersons = new EntitySet<SARFPersons>(new Action<SARFPersons>(this.attach_SARFPersons), new Action<SARFPersons>(this.detach_SARFPersons));
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

        public System.Nullable<System.DateTime> Birthday
        {
            get
            {
                return this._Birthday;
            }
            set
            {
                if ((this._Birthday != value))
                {
                    this.OnBirthdayChanging(value);
                    this.SendPropertyChanging();
                    this._Birthday = value;
                    this.SendPropertyChanged("Birthday");
                    this.OnBirthdayChanged();
                }
            }
        }

        public string Sex
        {
            get
            {
                return this._Sex;
            }
            set
            {
                if ((this._Sex != value))
                {
                    this.OnSexChanging(value);
                    this.SendPropertyChanging();
                    this._Sex = value;
                    this.SendPropertyChanged("Sex");
                    this.OnSexChanged();
                }
            }
        }

        public string Position
        {
            get
            {
                return this._Position;
            }
            set
            {
                if ((this._Position != value))
                {
                    this.OnPositionChanging(value);
                    this.SendPropertyChanging();
                    this._Position = value;
                    this.SendPropertyChanged("Position");
                    this.OnPositionChanged();
                }
            }
        }

        public System.Data.Linq.Binary Photo
        {
            get
            {
                return this._Photo;
            }
            set
            {
                if ((this._Photo != value))
                {
                    this.OnPhotoChanging(value);
                    this.SendPropertyChanging();
                    this._Photo = value;
                    this.SendPropertyChanged("Photo");
                    this.OnPhotoChanged();
                }
            }
        }

        public System.Nullable<long> CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    if (this._Company.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        public System.Nullable<bool> HasVisited
        {
            get
            {
                return this._HasVisited;
            }
            set
            {
                if ((this._HasVisited != value))
                {
                    this.OnHasVisitedChanging(value);
                    this.SendPropertyChanging();
                    this._HasVisited = value;
                    this.SendPropertyChanged("HasVisited");
                    this.OnHasVisitedChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> DateOfFirstVisit
        {
            get
            {
                return this._DateOfFirstVisit;
            }
            set
            {
                if ((this._DateOfFirstVisit != value))
                {
                    this.OnDateOfFirstVisitChanging(value);
                    this.SendPropertyChanging();
                    this._DateOfFirstVisit = value;
                    this.SendPropertyChanged("DateOfFirstVisit");
                    this.OnDateOfFirstVisitChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> LastVisited
        {
            get
            {
                return this._LastVisited;
            }
            set
            {
                if ((this._LastVisited != value))
                {
                    this.OnLastVisitedChanging(value);
                    this.SendPropertyChanging();
                    this._LastVisited = value;
                    this.SendPropertyChanged("LastVisited");
                    this.OnLastVisitedChanged();
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

        public Company Company
        {
            get
            {
                return this._Company.Entity;
            }
            set
            {
                Company previousValue = this._Company.Entity;
                if (((previousValue != value)
                            || (this._Company.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Company.Entity = null;
                        previousValue.Person.Remove(this);
                    }
                    this._Company.Entity = value;
                    if ((value != null))
                    {
                        value.Person.Add(this);
                        this._CompanyID = value.ID;
                    }
                    else
                    {
                        this._CompanyID = default(Nullable<long>);
                    }
                    this.SendPropertyChanged("Company");
                }
            }
        }

        public EntitySet<EACSPersons> EACSPersons
        {
            get
            {
                return this._EACSPersons;
            }
            set
            {
                this._EACSPersons.Assign(value);
            }
        }

        public EntitySet<ECDAP> ECDAP
        {
            get
            {
                return this._ECDAP;
            }
            set
            {
                this._ECDAP.Assign(value);
            }
        }

        public EntitySet<SARFPersons> SARFPersons
        {
            get
            {
                return this._SARFPersons;
            }
            set
            {
                this._SARFPersons.Assign(value);
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

        private void attach_EACSPersons(EACSPersons entity)
        {
            this.SendPropertyChanging();
            entity.Person = this;
        }

        private void detach_EACSPersons(EACSPersons entity)
        {
            this.SendPropertyChanging();
            entity.Person = null;
        }

        private void attach_ECDAP(ECDAP entity)
        {
            this.SendPropertyChanging();
            entity.Person = this;
        }

        private void detach_ECDAP(ECDAP entity)
        {
            this.SendPropertyChanging();
            entity.Person = null;
        }

        private void attach_SARFPersons(SARFPersons entity)
        {
            this.SendPropertyChanging();
            entity.Person = this;
        }

        private void detach_SARFPersons(SARFPersons entity)
        {
            this.SendPropertyChanging();
            entity.Person = null;
        }
    }

    public partial class SARF : INotifyPropertyChanging, INotifyPropertyChanged, IAuditable
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private long _ID;

        private string _SARFCode;

        private System.Nullable<System.DateTime> _DateFiled;

        private System.Nullable<System.DateTime> _DateOfVisit;

        private long _FiledBy;

        private string _Purpose;

        private string _SourceIP;

        private string _Status;

        private System.Nullable<long> _ApprovedBy;

        private System.Nullable<System.DateTime> _DateVisited;

        private long _VisitVerifiedBy;

        private System.Nullable<bool> _IsActive;

        private System.Nullable<long> _UserCreated;

        private System.Nullable<System.DateTime> _DateCreated;

        private System.Nullable<long> _UserModified;

        private System.Nullable<System.DateTime> _DateModified;

        private EntitySet<EACS> _EACS;

        private EntityRef<UserAccount> _UserAccount;

        private EntityRef<UserAccount> _FiledByUserAccount;

        private EntityRef<UserAccount> _VisitVerifiedByUserAccount;

        private EntitySet<SARFPersons> _SARFPersons;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(long value);
        partial void OnIDChanged();
        partial void OnSARFCodeChanging(string value);
        partial void OnSARFCodeChanged();
        partial void OnDateFiledChanging(System.Nullable<System.DateTime> value);
        partial void OnDateFiledChanged();
        partial void OnDateOfVisitChanging(System.Nullable<System.DateTime> value);
        partial void OnDateOfVisitChanged();
        partial void OnFiledByChanging(long value);
        partial void OnFiledByChanged();
        partial void OnPurposeChanging(string value);
        partial void OnPurposeChanged();
        partial void OnSourceIPChanging(string value);
        partial void OnSourceIPChanged();
        partial void OnStatusChanging(string value);
        partial void OnStatusChanged();
        partial void OnApprovedByChanging(System.Nullable<long> value);
        partial void OnApprovedByChanged();
        partial void OnDateVisitedChanging(System.Nullable<System.DateTime> value);
        partial void OnDateVisitedChanged();
        partial void OnVisitVerifiedByChanging(long value);
        partial void OnVisitVerifiedByChanged();
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

        public SARF()
        {
            this._EACS = new EntitySet<EACS>(new Action<EACS>(this.attach_EACS), new Action<EACS>(this.detach_EACS));
            this._UserAccount = default(EntityRef<UserAccount>);
            this._FiledByUserAccount = default(EntityRef<UserAccount>);
            this._VisitVerifiedByUserAccount = default(EntityRef<UserAccount>);
            this._SARFPersons = new EntitySet<SARFPersons>(new Action<SARFPersons>(this.attach_SARFPersons), new Action<SARFPersons>(this.detach_SARFPersons));
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

        public string SARFCode
        {
            get
            {
                return this._SARFCode;
            }
            set
            {
                if ((this._SARFCode != value))
                {
                    this.OnSARFCodeChanging(value);
                    this.SendPropertyChanging();
                    this._SARFCode = value;
                    this.SendPropertyChanged("SARFCode");
                    this.OnSARFCodeChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> DateFiled
        {
            get
            {
                return this._DateFiled;
            }
            set
            {
                if ((this._DateFiled != value))
                {
                    this.OnDateFiledChanging(value);
                    this.SendPropertyChanging();
                    this._DateFiled = value;
                    this.SendPropertyChanged("DateFiled");
                    this.OnDateFiledChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> DateOfVisit
        {
            get
            {
                return this._DateOfVisit;
            }
            set
            {
                if ((this._DateOfVisit != value))
                {
                    this.OnDateOfVisitChanging(value);
                    this.SendPropertyChanging();
                    this._DateOfVisit = value;
                    this.SendPropertyChanged("DateOfVisit");
                    this.OnDateOfVisitChanged();
                }
            }
        }

        public long FiledBy
        {
            get
            {
                return this._FiledBy;
            }
            set
            {
                if ((this._FiledBy != value))
                {
                    if (this._FiledByUserAccount.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnFiledByChanging(value);
                    this.SendPropertyChanging();
                    this._FiledBy = value;
                    this.SendPropertyChanged("FiledBy");
                    this.OnFiledByChanged();
                }
            }
        }

        public string Purpose
        {
            get
            {
                return this._Purpose;
            }
            set
            {
                if ((this._Purpose != value))
                {
                    this.OnPurposeChanging(value);
                    this.SendPropertyChanging();
                    this._Purpose = value;
                    this.SendPropertyChanged("Purpose");
                    this.OnPurposeChanged();
                }
            }
        }

        public string SourceIP
        {
            get
            {
                return this._SourceIP;
            }
            set
            {
                if ((this._SourceIP != value))
                {
                    this.OnSourceIPChanging(value);
                    this.SendPropertyChanging();
                    this._SourceIP = value;
                    this.SendPropertyChanged("SourceIP");
                    this.OnSourceIPChanged();
                }
            }
        }

        public string Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                if ((this._Status != value))
                {
                    this.OnStatusChanging(value);
                    this.SendPropertyChanging();
                    this._Status = value;
                    this.SendPropertyChanged("Status");
                    this.OnStatusChanged();
                }
            }
        }

        public System.Nullable<long> ApprovedBy
        {
            get
            {
                return this._ApprovedBy;
            }
            set
            {
                if ((this._ApprovedBy != value))
                {
                    if (this._UserAccount.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnApprovedByChanging(value);
                    this.SendPropertyChanging();
                    this._ApprovedBy = value;
                    this.SendPropertyChanged("ApprovedBy");
                    this.OnApprovedByChanged();
                }
            }
        }

        public System.Nullable<System.DateTime> DateVisited
        {
            get
            {
                return this._DateVisited;
            }
            set
            {
                if ((this._DateVisited != value))
                {
                    this.OnDateVisitedChanging(value);
                    this.SendPropertyChanging();
                    this._DateVisited = value;
                    this.SendPropertyChanged("DateVisited");
                    this.OnDateVisitedChanged();
                }
            }
        }

        public long VisitVerifiedBy
        {
            get
            {
                return this._VisitVerifiedBy;
            }
            set
            {
                if ((this._VisitVerifiedBy != value))
                {
                    if (this._VisitVerifiedByUserAccount.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnVisitVerifiedByChanging(value);
                    this.SendPropertyChanging();
                    this._VisitVerifiedBy = value;
                    this.SendPropertyChanged("VisitVerifiedBy");
                    this.OnVisitVerifiedByChanged();
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

        public EntitySet<EACS> EACS
        {
            get
            {
                return this._EACS;
            }
            set
            {
                this._EACS.Assign(value);
            }
        }

        public UserAccount UserAccount
        {
            get
            {
                return this._UserAccount.Entity;
            }
            set
            {
                UserAccount previousValue = this._UserAccount.Entity;
                if (((previousValue != value)
                            || (this._UserAccount.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._UserAccount.Entity = null;
                        previousValue.SARF.Remove(this);
                    }
                    this._UserAccount.Entity = value;
                    if ((value != null))
                    {
                        value.SARF.Add(this);
                        this._ApprovedBy = value.ID;
                    }
                    else
                    {
                        this._ApprovedBy = default(Nullable<long>);
                    }
                    this.SendPropertyChanged("UserAccount");
                }
            }
        }

        public UserAccount FiledByUserAccount
        {
            get
            {
                return this._FiledByUserAccount.Entity;
            }
            set
            {
                UserAccount previousValue = this._FiledByUserAccount.Entity;
                if (((previousValue != value)
                            || (this._FiledByUserAccount.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._FiledByUserAccount.Entity = null;
                        previousValue.SARF_FiledBy.Remove(this);
                    }
                    this._FiledByUserAccount.Entity = value;
                    if ((value != null))
                    {
                        value.SARF_FiledBy.Add(this);
                        this._FiledBy = value.ID;
                    }
                    else
                    {
                        this._FiledBy = default(long);
                    }
                    this.SendPropertyChanged("FiledByUserAccount");
                }
            }
        }

        public UserAccount VisitVerifiedByUserAccount
        {
            get
            {
                return this._VisitVerifiedByUserAccount.Entity;
            }
            set
            {
                UserAccount previousValue = this._VisitVerifiedByUserAccount.Entity;
                if (((previousValue != value)
                            || (this._VisitVerifiedByUserAccount.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._VisitVerifiedByUserAccount.Entity = null;
                        previousValue.SARF_VerifiedBy.Remove(this);
                    }
                    this._VisitVerifiedByUserAccount.Entity = value;
                    if ((value != null))
                    {
                        value.SARF_VerifiedBy.Add(this);
                        this._VisitVerifiedBy = value.ID;
                    }
                    else
                    {
                        this._VisitVerifiedBy = default(long);
                    }
                    this.SendPropertyChanged("VisitVerifiedByUserAccount");
                }
            }
        }

        public EntitySet<SARFPersons> SARFPersons
        {
            get
            {
                return this._SARFPersons;
            }
            set
            {
                this._SARFPersons.Assign(value);
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

        private void attach_EACS(EACS entity)
        {
            this.SendPropertyChanging();
            entity.SARF = this;
        }

        private void detach_EACS(EACS entity)
        {
            this.SendPropertyChanging();
            entity.SARF = null;
        }

        private void attach_SARFPersons(SARFPersons entity)
        {
            this.SendPropertyChanging();
            entity.SARF = this;
        }

        private void detach_SARFPersons(SARFPersons entity)
        {
            this.SendPropertyChanging();
            entity.SARF = null;
        }
    }

    public partial class SARFPersons : INotifyPropertyChanging, INotifyPropertyChanged, IAuditable
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private long _ID;

        private long _SARFID;

        private long _PersonID;

        private string _Status;

        private System.Nullable<bool> _FirstVisit;

        private System.Nullable<bool> _WasInVisit;

        private System.Nullable<bool> _IsActive;

        private System.Nullable<long> _UserCreated;

        private System.Nullable<System.DateTime> _DateCreated;

        private System.Nullable<long> _UserModified;

        private System.Nullable<System.DateTime> _DateModified;

        private EntityRef<Person> _Person;

        private EntityRef<SARF> _SARF;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(long value);
        partial void OnIDChanged();
        partial void OnSARFIDChanging(long value);
        partial void OnSARFIDChanged();
        partial void OnPersonIDChanging(long value);
        partial void OnPersonIDChanged();
        partial void OnStatusChanging(string value);
        partial void OnStatusChanged();
        partial void OnFirstVisitChanging(System.Nullable<bool> value);
        partial void OnFirstVisitChanged();
        partial void OnWasInVisitChanging(System.Nullable<bool> value);
        partial void OnWasInVisitChanged();
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

        public SARFPersons()
        {
            this._Person = default(EntityRef<Person>);
            this._SARF = default(EntityRef<SARF>);
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

        public long SARFID
        {
            get
            {
                return this._SARFID;
            }
            set
            {
                if ((this._SARFID != value))
                {
                    if (this._SARF.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnSARFIDChanging(value);
                    this.SendPropertyChanging();
                    this._SARFID = value;
                    this.SendPropertyChanged("SARFID");
                    this.OnSARFIDChanged();
                }
            }
        }

        public long PersonID
        {
            get
            {
                return this._PersonID;
            }
            set
            {
                if ((this._PersonID != value))
                {
                    if (this._Person.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnPersonIDChanging(value);
                    this.SendPropertyChanging();
                    this._PersonID = value;
                    this.SendPropertyChanged("PersonID");
                    this.OnPersonIDChanged();
                }
            }
        }

        public string Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                if ((this._Status != value))
                {
                    this.OnStatusChanging(value);
                    this.SendPropertyChanging();
                    this._Status = value;
                    this.SendPropertyChanged("Status");
                    this.OnStatusChanged();
                }
            }
        }

        public System.Nullable<bool> FirstVisit
        {
            get
            {
                return this._FirstVisit;
            }
            set
            {
                if ((this._FirstVisit != value))
                {
                    this.OnFirstVisitChanging(value);
                    this.SendPropertyChanging();
                    this._FirstVisit = value;
                    this.SendPropertyChanged("FirstVisit");
                    this.OnFirstVisitChanged();
                }
            }
        }

        public System.Nullable<bool> WasInVisit
        {
            get
            {
                return this._WasInVisit;
            }
            set
            {
                if ((this._WasInVisit != value))
                {
                    this.OnWasInVisitChanging(value);
                    this.SendPropertyChanging();
                    this._WasInVisit = value;
                    this.SendPropertyChanged("WasInVisit");
                    this.OnWasInVisitChanged();
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

        public Person Person
        {
            get
            {
                return this._Person.Entity;
            }
            set
            {
                Person previousValue = this._Person.Entity;
                if (((previousValue != value)
                            || (this._Person.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Person.Entity = null;
                        previousValue.SARFPersons.Remove(this);
                    }
                    this._Person.Entity = value;
                    if ((value != null))
                    {
                        value.SARFPersons.Add(this);
                        this._PersonID = value.ID;
                    }
                    else
                    {
                        this._PersonID = default(long);
                    }
                    this.SendPropertyChanged("Person");
                }
            }
        }

        public SARF SARF
        {
            get
            {
                return this._SARF.Entity;
            }
            set
            {
                SARF previousValue = this._SARF.Entity;
                if (((previousValue != value)
                            || (this._SARF.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._SARF.Entity = null;
                        previousValue.SARFPersons.Remove(this);
                    }
                    this._SARF.Entity = value;
                    if ((value != null))
                    {
                        value.SARFPersons.Add(this);
                        this._SARFID = value.ID;
                    }
                    else
                    {
                        this._SARFID = default(long);
                    }
                    this.SendPropertyChanged("SARF");
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

    public partial class SystemSettings : INotifyPropertyChanging, INotifyPropertyChanged, IAuditable
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private long _ID;

        private string _CompanyName;

        private string _Address1;

        private string _Address2;

        private string _Country;

        private string _State;

        private string _PostalCode;

        private System.Nullable<int> _FiscalYear;

        private System.Nullable<long> _LastSARFID;

        private System.Nullable<long> _LastEACSID;

        private System.Nullable<long> _LastECDAPID;

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
        partial void OnCompanyNameChanging(string value);
        partial void OnCompanyNameChanged();
        partial void OnAddress1Changing(string value);
        partial void OnAddress1Changed();
        partial void OnAddress2Changing(string value);
        partial void OnAddress2Changed();
        partial void OnCountryChanging(string value);
        partial void OnCountryChanged();
        partial void OnStateChanging(string value);
        partial void OnStateChanged();
        partial void OnPostalCodeChanging(string value);
        partial void OnPostalCodeChanged();
        partial void OnFiscalYearChanging(System.Nullable<int> value);
        partial void OnFiscalYearChanged();
        partial void OnLastSARFIDChanging(System.Nullable<long> value);
        partial void OnLastSARFIDChanged();
        partial void OnLastEACSIDChanging(System.Nullable<long> value);
        partial void OnLastEACSIDChanged();
        partial void OnLastECDAPIDChanging(System.Nullable<long> value);
        partial void OnLastECDAPIDChanged();
        partial void OnUserCreatedChanging(System.Nullable<long> value);
        partial void OnUserCreatedChanged();
        partial void OnDateCreatedChanging(System.Nullable<System.DateTime> value);
        partial void OnDateCreatedChanged();
        partial void OnUserModifiedChanging(System.Nullable<long> value);
        partial void OnUserModifiedChanged();
        partial void OnDateModifiedChanging(System.Nullable<System.DateTime> value);
        partial void OnDateModifiedChanged();
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

        public string CompanyName
        {
            get
            {
                return this._CompanyName;
            }
            set
            {
                if ((this._CompanyName != value))
                {
                    this.OnCompanyNameChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyName = value;
                    this.SendPropertyChanged("CompanyName");
                    this.OnCompanyNameChanged();
                }
            }
        }

        public string Address1
        {
            get
            {
                return this._Address1;
            }
            set
            {
                if ((this._Address1 != value))
                {
                    this.OnAddress1Changing(value);
                    this.SendPropertyChanging();
                    this._Address1 = value;
                    this.SendPropertyChanged("Address1");
                    this.OnAddress1Changed();
                }
            }
        }

        public string Address2
        {
            get
            {
                return this._Address2;
            }
            set
            {
                if ((this._Address2 != value))
                {
                    this.OnAddress2Changing(value);
                    this.SendPropertyChanging();
                    this._Address2 = value;
                    this.SendPropertyChanged("Address2");
                    this.OnAddress2Changed();
                }
            }
        }

        public string Country
        {
            get
            {
                return this._Country;
            }
            set
            {
                if ((this._Country != value))
                {
                    this.OnCountryChanging(value);
                    this.SendPropertyChanging();
                    this._Country = value;
                    this.SendPropertyChanged("Country");
                    this.OnCountryChanged();
                }
            }
        }

        public string State
        {
            get
            {
                return this._State;
            }
            set
            {
                if ((this._State != value))
                {
                    this.OnStateChanging(value);
                    this.SendPropertyChanging();
                    this._State = value;
                    this.SendPropertyChanged("State");
                    this.OnStateChanged();
                }
            }
        }

        public string PostalCode
        {
            get
            {
                return this._PostalCode;
            }
            set
            {
                if ((this._PostalCode != value))
                {
                    this.OnPostalCodeChanging(value);
                    this.SendPropertyChanging();
                    this._PostalCode = value;
                    this.SendPropertyChanged("PostalCode");
                    this.OnPostalCodeChanged();
                }
            }
        }

        public System.Nullable<int> FiscalYear
        {
            get
            {
                return this._FiscalYear;
            }
            set
            {
                if ((this._FiscalYear != value))
                {
                    this.OnFiscalYearChanging(value);
                    this.SendPropertyChanging();
                    this._FiscalYear = value;
                    this.SendPropertyChanged("FiscalYear");
                    this.OnFiscalYearChanged();
                }
            }
        }

        public System.Nullable<long> LastSARFID
        {
            get
            {
                return this._LastSARFID;
            }
            set
            {
                if ((this._LastSARFID != value))
                {
                    this.OnLastSARFIDChanging(value);
                    this.SendPropertyChanging();
                    this._LastSARFID = value;
                    this.SendPropertyChanged("LastSARFID");
                    this.OnLastSARFIDChanged();
                }
            }
        }

        public System.Nullable<long> LastEACSID
        {
            get
            {
                return this._LastEACSID;
            }
            set
            {
                if ((this._LastEACSID != value))
                {
                    this.OnLastEACSIDChanging(value);
                    this.SendPropertyChanging();
                    this._LastEACSID = value;
                    this.SendPropertyChanged("LastEACSID");
                    this.OnLastEACSIDChanged();
                }
            }
        }

        public System.Nullable<long> LastECDAPID
        {
            get
            {
                return this._LastECDAPID;
            }
            set
            {
                if ((this._LastECDAPID != value))
                {
                    this.OnLastECDAPIDChanging(value);
                    this.SendPropertyChanging();
                    this._LastECDAPID = value;
                    this.SendPropertyChanged("LastECDAPID");
                    this.OnLastECDAPIDChanged();
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

    public partial class UserAccount : INotifyPropertyChanging, INotifyPropertyChanged, IAuditable
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

        private string _EmailAddress;

        private System.Nullable<bool> _IsActive;

        private System.Nullable<long> _UserCreated;

        private System.Nullable<System.DateTime> _DateCreated;

        private System.Nullable<long> _UserModified;

        private System.Nullable<System.DateTime> _DateModified;

        private EntitySet<EACS> _EACS;

        private EntitySet<EACS> _EACS_ProcessedBy;

        private EntitySet<EACS> _EACS_VerifiedBy;

        private EntitySet<ECDAP> _ECDAP;

        private EntitySet<SARF> _SARF;

        private EntitySet<SARF> _SARF_FiledBy;

        private EntitySet<SARF> _SARF_VerifiedBy;

        private EntityRef<UserRole> _UserRole;

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
        partial void OnUserRoleIDChanging(long value);
        partial void OnUserRoleIDChanged();
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        partial void OnMiddleNameChanging(string value);
        partial void OnMiddleNameChanged();
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
        partial void OnEmailAddressChanging(string value);
        partial void OnEmailAddressChanged();
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
            this._EACS = new EntitySet<EACS>(new Action<EACS>(this.attach_EACS), new Action<EACS>(this.detach_EACS));
            this._EACS_ProcessedBy = new EntitySet<EACS>(new Action<EACS>(this.attach_EACS_ProcessedBy), new Action<EACS>(this.detach_EACS_ProcessedBy));
            this._EACS_VerifiedBy = new EntitySet<EACS>(new Action<EACS>(this.attach_EACS_VerifiedBy), new Action<EACS>(this.detach_EACS_VerifiedBy));
            this._ECDAP = new EntitySet<ECDAP>(new Action<ECDAP>(this.attach_ECDAP), new Action<ECDAP>(this.detach_ECDAP));
            this._SARF = new EntitySet<SARF>(new Action<SARF>(this.attach_SARF), new Action<SARF>(this.detach_SARF));
            this._SARF_FiledBy = new EntitySet<SARF>(new Action<SARF>(this.attach_SARF_FiledBy), new Action<SARF>(this.detach_SARF_FiledBy));
            this._SARF_VerifiedBy = new EntitySet<SARF>(new Action<SARF>(this.attach_SARF_VerifiedBy), new Action<SARF>(this.detach_SARF_VerifiedBy));
            this._UserRole = default(EntityRef<UserRole>);
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
                    if (this._UserRole.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
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

        public string EmailAddress
        {
            get
            {
                return this._EmailAddress;
            }
            set
            {
                if ((this._EmailAddress != value))
                {
                    this.OnEmailAddressChanging(value);
                    this.SendPropertyChanging();
                    this._EmailAddress = value;
                    this.SendPropertyChanged("EmailAddress");
                    this.OnEmailAddressChanged();
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

        public EntitySet<EACS> EACS
        {
            get
            {
                return this._EACS;
            }
            set
            {
                this._EACS.Assign(value);
            }
        }

        public EntitySet<EACS> EACS_ProcessedBy
        {
            get
            {
                return this._EACS_ProcessedBy;
            }
            set
            {
                this._EACS_ProcessedBy.Assign(value);
            }
        }

        public EntitySet<EACS> EACS_VerifiedBy
        {
            get
            {
                return this._EACS_VerifiedBy;
            }
            set
            {
                this._EACS_VerifiedBy.Assign(value);
            }
        }

        public EntitySet<ECDAP> ECDAP
        {
            get
            {
                return this._ECDAP;
            }
            set
            {
                this._ECDAP.Assign(value);
            }
        }

        public EntitySet<SARF> SARF
        {
            get
            {
                return this._SARF;
            }
            set
            {
                this._SARF.Assign(value);
            }
        }

        public EntitySet<SARF> SARF_FiledBy
        {
            get
            {
                return this._SARF_FiledBy;
            }
            set
            {
                this._SARF_FiledBy.Assign(value);
            }
        }

        public EntitySet<SARF> SARF_VerifiedBy
        {
            get
            {
                return this._SARF_VerifiedBy;
            }
            set
            {
                this._SARF_VerifiedBy.Assign(value);
            }
        }

        public UserRole UserRole
        {
            get
            {
                return this._UserRole.Entity;
            }
            set
            {
                UserRole previousValue = this._UserRole.Entity;
                if (((previousValue != value)
                            || (this._UserRole.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._UserRole.Entity = null;
                        previousValue.UserAccount.Remove(this);
                    }
                    this._UserRole.Entity = value;
                    if ((value != null))
                    {
                        value.UserAccount.Add(this);
                        this._UserRoleID = value.ID;
                    }
                    else
                    {
                        this._UserRoleID = default(long);
                    }
                    this.SendPropertyChanged("UserRole");
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

        private void attach_EACS(EACS entity)
        {
            this.SendPropertyChanging();
            entity.UserAccount = this;
        }

        private void detach_EACS(EACS entity)
        {
            this.SendPropertyChanging();
            entity.UserAccount = null;
        }

        private void attach_EACS_ProcessedBy(EACS entity)
        {
            this.SendPropertyChanging();
            entity.ProcessedByUserAccount = this;
        }

        private void detach_EACS_ProcessedBy(EACS entity)
        {
            this.SendPropertyChanging();
            entity.ProcessedByUserAccount = null;
        }

        private void attach_EACS_VerifiedBy(EACS entity)
        {
            this.SendPropertyChanging();
            entity.VerifiedByUserAccount = this;
        }

        private void detach_EACS_VerifiedBy(EACS entity)
        {
            this.SendPropertyChanging();
            entity.VerifiedByUserAccount = null;
        }

        private void attach_ECDAP(ECDAP entity)
        {
            this.SendPropertyChanging();
            entity.UserAccount = this;
        }

        private void detach_ECDAP(ECDAP entity)
        {
            this.SendPropertyChanging();
            entity.UserAccount = null;
        }

        private void attach_SARF(SARF entity)
        {
            this.SendPropertyChanging();
            entity.UserAccount = this;
        }

        private void detach_SARF(SARF entity)
        {
            this.SendPropertyChanging();
            entity.UserAccount = null;
        }

        private void attach_SARF_FiledBy(SARF entity)
        {
            this.SendPropertyChanging();
            entity.FiledByUserAccount = this;
        }

        private void detach_SARF_FiledBy(SARF entity)
        {
            this.SendPropertyChanging();
            entity.FiledByUserAccount = null;
        }

        private void attach_SARF_VerifiedBy(SARF entity)
        {
            this.SendPropertyChanging();
            entity.VisitVerifiedByUserAccount = this;
        }

        private void detach_SARF_VerifiedBy(SARF entity)
        {
            this.SendPropertyChanging();
            entity.VisitVerifiedByUserAccount = null;
        }
    }

    public partial class UserRole : INotifyPropertyChanging, INotifyPropertyChanged, IAuditable
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

        private EntitySet<UserAccount> _UserAccount;

        private EntitySet<UserRoleWebPage> _UserRoleWebPage;

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
            this._UserAccount = new EntitySet<UserAccount>(new Action<UserAccount>(this.attach_UserAccount), new Action<UserAccount>(this.detach_UserAccount));
            this._UserRoleWebPage = new EntitySet<UserRoleWebPage>(new Action<UserRoleWebPage>(this.attach_UserRoleWebPage), new Action<UserRoleWebPage>(this.detach_UserRoleWebPage));
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

        public EntitySet<UserAccount> UserAccount
        {
            get
            {
                return this._UserAccount;
            }
            set
            {
                this._UserAccount.Assign(value);
            }
        }

        public EntitySet<UserRoleWebPage> UserRoleWebPage
        {
            get
            {
                return this._UserRoleWebPage;
            }
            set
            {
                this._UserRoleWebPage.Assign(value);
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

        private void attach_UserAccount(UserAccount entity)
        {
            this.SendPropertyChanging();
            entity.UserRole = this;
        }

        private void detach_UserAccount(UserAccount entity)
        {
            this.SendPropertyChanging();
            entity.UserRole = null;
        }

        private void attach_UserRoleWebPage(UserRoleWebPage entity)
        {
            this.SendPropertyChanging();
            entity.UserRole = this;
        }

        private void detach_UserRoleWebPage(UserRoleWebPage entity)
        {
            this.SendPropertyChanging();
            entity.UserRole = null;
        }
    }

    public partial class UserRoleWebPage : INotifyPropertyChanging, INotifyPropertyChanged, IAuditable
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private long _ID;

        private long _UserRoleID;

        private long _WebPageID;

        private System.Nullable<bool> _IsActive;

        private System.Nullable<long> _UserCreated;

        private System.Nullable<System.DateTime> _DateCreated;

        private System.Nullable<long> _UserModified;

        private System.Nullable<System.DateTime> _DateModified;

        private EntityRef<UserRole> _UserRole;

        private EntityRef<WebPageRegistry> _WebPageRegistry;

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
            this._UserRole = default(EntityRef<UserRole>);
            this._WebPageRegistry = default(EntityRef<WebPageRegistry>);
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
                    if (this._UserRole.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
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
                    if (this._WebPageRegistry.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
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
                    this.OnDateModififedChanging(value);
                    this.SendPropertyChanging();
                    this._DateModified = value;
                    this.SendPropertyChanged("DateModififed");
                    this.OnDateModififedChanged();
                }
            }
        }

        public UserRole UserRole
        {
            get
            {
                return this._UserRole.Entity;
            }
            set
            {
                UserRole previousValue = this._UserRole.Entity;
                if (((previousValue != value)
                            || (this._UserRole.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._UserRole.Entity = null;
                        previousValue.UserRoleWebPage.Remove(this);
                    }
                    this._UserRole.Entity = value;
                    if ((value != null))
                    {
                        value.UserRoleWebPage.Add(this);
                        this._UserRoleID = value.ID;
                    }
                    else
                    {
                        this._UserRoleID = default(long);
                    }
                    this.SendPropertyChanged("UserRole");
                }
            }
        }

        public WebPageRegistry WebPageRegistry
        {
            get
            {
                return this._WebPageRegistry.Entity;
            }
            set
            {
                WebPageRegistry previousValue = this._WebPageRegistry.Entity;
                if (((previousValue != value)
                            || (this._WebPageRegistry.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._WebPageRegistry.Entity = null;
                        previousValue.UserRoleWebPage.Remove(this);
                    }
                    this._WebPageRegistry.Entity = value;
                    if ((value != null))
                    {
                        value.UserRoleWebPage.Add(this);
                        this._WebPageID = value.ID;
                    }
                    else
                    {
                        this._WebPageID = default(long);
                    }
                    this.SendPropertyChanged("WebPageRegistry");
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

    public partial class WatchList : INotifyPropertyChanging, INotifyPropertyChanged, IAuditable
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private long _ID;

        private string _LastName;

        private string _FirstName;

        private string _MiddleName;

        private string _Description;

        private string _Notes;

        private System.Data.Linq.Binary _Photo;

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
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        partial void OnMiddleNameChanging(string value);
        partial void OnMiddleNameChanged();
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
        partial void OnPhotoChanging(System.Data.Linq.Binary value);
        partial void OnPhotoChanged();
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

        public WatchList()
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

        public string Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                if ((this._Notes != value))
                {
                    this.OnNotesChanging(value);
                    this.SendPropertyChanging();
                    this._Notes = value;
                    this.SendPropertyChanged("Notes");
                    this.OnNotesChanged();
                }
            }
        }

        public System.Data.Linq.Binary Photo
        {
            get
            {
                return this._Photo;
            }
            set
            {
                if ((this._Photo != value))
                {
                    this.OnPhotoChanging(value);
                    this.SendPropertyChanging();
                    this._Photo = value;
                    this.SendPropertyChanged("Photo");
                    this.OnPhotoChanged();
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

    public partial class WebPageRegistry : INotifyPropertyChanging, INotifyPropertyChanged, IAuditable
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

        private EntitySet<UserRoleWebPage> _UserRoleWebPage;

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
            this._UserRoleWebPage = new EntitySet<UserRoleWebPage>(new Action<UserRoleWebPage>(this.attach_UserRoleWebPage), new Action<UserRoleWebPage>(this.detach_UserRoleWebPage));
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

        public EntitySet<UserRoleWebPage> UserRoleWebPage
        {
            get
            {
                return this._UserRoleWebPage;
            }
            set
            {
                this._UserRoleWebPage.Assign(value);
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

        private void attach_UserRoleWebPage(UserRoleWebPage entity)
        {
            this.SendPropertyChanging();
            entity.WebPageRegistry = this;
        }

        private void detach_UserRoleWebPage(UserRoleWebPage entity)
        {
            this.SendPropertyChanging();
            entity.WebPageRegistry = null;
        }
    }
}
