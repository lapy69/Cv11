﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Vyuka")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertHodnoceni(Hodnoceni instance);
    partial void UpdateHodnoceni(Hodnoceni instance);
    partial void DeleteHodnoceni(Hodnoceni instance);
    partial void InsertPredmety(Predmety instance);
    partial void UpdatePredmety(Predmety instance);
    partial void DeletePredmety(Predmety instance);
    partial void InsertStudenti(Studenti instance);
    partial void UpdateStudenti(Studenti instance);
    partial void DeleteStudenti(Studenti instance);
    partial void InsertSpojovaciTabulka(SpojovaciTabulka instance);
    partial void UpdateSpojovaciTabulka(SpojovaciTabulka instance);
    partial void DeleteSpojovaciTabulka(SpojovaciTabulka instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ConsoleApp1.Properties.Settings.Default.VyukaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Hodnoceni> Hodnoceni
		{
			get
			{
				return this.GetTable<Hodnoceni>();
			}
		}
		
		public System.Data.Linq.Table<Predmety> Predmety
		{
			get
			{
				return this.GetTable<Predmety>();
			}
		}
		
		public System.Data.Linq.Table<Studenti> Studenti
		{
			get
			{
				return this.GetTable<Studenti>();
			}
		}
		
		public System.Data.Linq.Table<SpojovaciTabulka> SpojovaciTabulka
		{
			get
			{
				return this.GetTable<SpojovaciTabulka>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Hodnoceni")]
	public partial class Hodnoceni : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Zkratka;
		
		private int _ID;
		
		private System.DateTime _datum_hodnoceni;
		
		private double _hodnoceni1;
		
		private EntityRef<Predmety> _Predmety;
		
		private EntityRef<Studenti> _Studenti;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnZkratkaChanging(string value);
    partial void OnZkratkaChanged();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void Ondatum_hodnoceniChanging(System.DateTime value);
    partial void Ondatum_hodnoceniChanged();
    partial void Onhodnoceni1Changing(double value);
    partial void Onhodnoceni1Changed();
    #endregion
		
		public Hodnoceni()
		{
			this._Predmety = default(EntityRef<Predmety>);
			this._Studenti = default(EntityRef<Studenti>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zkratka", DbType="VarChar(3) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Zkratka
		{
			get
			{
				return this._Zkratka;
			}
			set
			{
				if ((this._Zkratka != value))
				{
					if (this._Predmety.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnZkratkaChanging(value);
					this.SendPropertyChanging();
					this._Zkratka = value;
					this.SendPropertyChanged("Zkratka");
					this.OnZkratkaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					if (this._Studenti.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datum_hodnoceni", DbType="Date NOT NULL")]
		public System.DateTime datum_hodnoceni
		{
			get
			{
				return this._datum_hodnoceni;
			}
			set
			{
				if ((this._datum_hodnoceni != value))
				{
					this.Ondatum_hodnoceniChanging(value);
					this.SendPropertyChanging();
					this._datum_hodnoceni = value;
					this.SendPropertyChanged("datum_hodnoceni");
					this.Ondatum_hodnoceniChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="hodnoceni", Storage="_hodnoceni1", DbType="Float NOT NULL")]
		public double hodnoceni1
		{
			get
			{
				return this._hodnoceni1;
			}
			set
			{
				if ((this._hodnoceni1 != value))
				{
					this.Onhodnoceni1Changing(value);
					this.SendPropertyChanging();
					this._hodnoceni1 = value;
					this.SendPropertyChanged("hodnoceni1");
					this.Onhodnoceni1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Predmety_Hodnoceni", Storage="_Predmety", ThisKey="Zkratka", OtherKey="Zkratka", IsForeignKey=true)]
		public Predmety Predmety
		{
			get
			{
				return this._Predmety.Entity;
			}
			set
			{
				Predmety previousValue = this._Predmety.Entity;
				if (((previousValue != value) 
							|| (this._Predmety.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Predmety.Entity = null;
						previousValue.Hodnoceni.Remove(this);
					}
					this._Predmety.Entity = value;
					if ((value != null))
					{
						value.Hodnoceni.Add(this);
						this._Zkratka = value.Zkratka;
					}
					else
					{
						this._Zkratka = default(string);
					}
					this.SendPropertyChanged("Predmety");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Studenti_Hodnoceni", Storage="_Studenti", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
		public Studenti Studenti
		{
			get
			{
				return this._Studenti.Entity;
			}
			set
			{
				Studenti previousValue = this._Studenti.Entity;
				if (((previousValue != value) 
							|| (this._Studenti.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Studenti.Entity = null;
						previousValue.Hodnoceni.Remove(this);
					}
					this._Studenti.Entity = value;
					if ((value != null))
					{
						value.Hodnoceni.Add(this);
						this._ID = value.ID;
					}
					else
					{
						this._ID = default(int);
					}
					this.SendPropertyChanged("Studenti");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Predmety")]
	public partial class Predmety : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Zkratka;
		
		private string _Nazev;
		
		private EntitySet<Hodnoceni> _Hodnoceni;
		
		private EntitySet<SpojovaciTabulka> _SpojovaciTabulka;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnZkratkaChanging(string value);
    partial void OnZkratkaChanged();
    partial void OnNazevChanging(string value);
    partial void OnNazevChanged();
    #endregion
		
		public Predmety()
		{
			this._Hodnoceni = new EntitySet<Hodnoceni>(new Action<Hodnoceni>(this.attach_Hodnoceni), new Action<Hodnoceni>(this.detach_Hodnoceni));
			this._SpojovaciTabulka = new EntitySet<SpojovaciTabulka>(new Action<SpojovaciTabulka>(this.attach_SpojovaciTabulka), new Action<SpojovaciTabulka>(this.detach_SpojovaciTabulka));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zkratka", DbType="VarChar(3) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Zkratka
		{
			get
			{
				return this._Zkratka;
			}
			set
			{
				if ((this._Zkratka != value))
				{
					this.OnZkratkaChanging(value);
					this.SendPropertyChanging();
					this._Zkratka = value;
					this.SendPropertyChanged("Zkratka");
					this.OnZkratkaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nazev", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nazev
		{
			get
			{
				return this._Nazev;
			}
			set
			{
				if ((this._Nazev != value))
				{
					this.OnNazevChanging(value);
					this.SendPropertyChanging();
					this._Nazev = value;
					this.SendPropertyChanged("Nazev");
					this.OnNazevChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Predmety_Hodnoceni", Storage="_Hodnoceni", ThisKey="Zkratka", OtherKey="Zkratka")]
		public EntitySet<Hodnoceni> Hodnoceni
		{
			get
			{
				return this._Hodnoceni;
			}
			set
			{
				this._Hodnoceni.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Predmety_SpojovaciTabulka", Storage="_SpojovaciTabulka", ThisKey="Zkratka", OtherKey="Zkratka")]
		public EntitySet<SpojovaciTabulka> SpojovaciTabulka
		{
			get
			{
				return this._SpojovaciTabulka;
			}
			set
			{
				this._SpojovaciTabulka.Assign(value);
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
		
		private void attach_Hodnoceni(Hodnoceni entity)
		{
			this.SendPropertyChanging();
			entity.Predmety = this;
		}
		
		private void detach_Hodnoceni(Hodnoceni entity)
		{
			this.SendPropertyChanging();
			entity.Predmety = null;
		}
		
		private void attach_SpojovaciTabulka(SpojovaciTabulka entity)
		{
			this.SendPropertyChanging();
			entity.Predmety = this;
		}
		
		private void detach_SpojovaciTabulka(SpojovaciTabulka entity)
		{
			this.SendPropertyChanging();
			entity.Predmety = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Studenti")]
	public partial class Studenti : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Jmeno;
		
		private string _Prijmeni;
		
		private System.DateTime _Datum_narozeni;
		
		private int _ID;
		
		private EntitySet<Hodnoceni> _Hodnoceni;
		
		private EntitySet<SpojovaciTabulka> _SpojovaciTabulka;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnJmenoChanging(string value);
    partial void OnJmenoChanged();
    partial void OnPrijmeniChanging(string value);
    partial void OnPrijmeniChanged();
    partial void OnDatum_narozeniChanging(System.DateTime value);
    partial void OnDatum_narozeniChanged();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    #endregion
		
		public Studenti()
		{
			this._Hodnoceni = new EntitySet<Hodnoceni>(new Action<Hodnoceni>(this.attach_Hodnoceni), new Action<Hodnoceni>(this.detach_Hodnoceni));
			this._SpojovaciTabulka = new EntitySet<SpojovaciTabulka>(new Action<SpojovaciTabulka>(this.attach_SpojovaciTabulka), new Action<SpojovaciTabulka>(this.detach_SpojovaciTabulka));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Jmeno", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Jmeno
		{
			get
			{
				return this._Jmeno;
			}
			set
			{
				if ((this._Jmeno != value))
				{
					this.OnJmenoChanging(value);
					this.SendPropertyChanging();
					this._Jmeno = value;
					this.SendPropertyChanged("Jmeno");
					this.OnJmenoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prijmeni", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Prijmeni
		{
			get
			{
				return this._Prijmeni;
			}
			set
			{
				if ((this._Prijmeni != value))
				{
					this.OnPrijmeniChanging(value);
					this.SendPropertyChanging();
					this._Prijmeni = value;
					this.SendPropertyChanged("Prijmeni");
					this.OnPrijmeniChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Datum_narozeni", DbType="Date NOT NULL")]
		public System.DateTime Datum_narozeni
		{
			get
			{
				return this._Datum_narozeni;
			}
			set
			{
				if ((this._Datum_narozeni != value))
				{
					this.OnDatum_narozeniChanging(value);
					this.SendPropertyChanging();
					this._Datum_narozeni = value;
					this.SendPropertyChanged("Datum_narozeni");
					this.OnDatum_narozeniChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Studenti_Hodnoceni", Storage="_Hodnoceni", ThisKey="ID", OtherKey="ID")]
		public EntitySet<Hodnoceni> Hodnoceni
		{
			get
			{
				return this._Hodnoceni;
			}
			set
			{
				this._Hodnoceni.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Studenti_SpojovaciTabulka", Storage="_SpojovaciTabulka", ThisKey="ID", OtherKey="ID")]
		public EntitySet<SpojovaciTabulka> SpojovaciTabulka
		{
			get
			{
				return this._SpojovaciTabulka;
			}
			set
			{
				this._SpojovaciTabulka.Assign(value);
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
		
		private void attach_Hodnoceni(Hodnoceni entity)
		{
			this.SendPropertyChanging();
			entity.Studenti = this;
		}
		
		private void detach_Hodnoceni(Hodnoceni entity)
		{
			this.SendPropertyChanging();
			entity.Studenti = null;
		}
		
		private void attach_SpojovaciTabulka(SpojovaciTabulka entity)
		{
			this.SendPropertyChanging();
			entity.Studenti = this;
		}
		
		private void detach_SpojovaciTabulka(SpojovaciTabulka entity)
		{
			this.SendPropertyChanging();
			entity.Studenti = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SpojovaciTabulka")]
	public partial class SpojovaciTabulka : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Zkratka;
		
		private int _ID;
		
		private EntityRef<Predmety> _Predmety;
		
		private EntityRef<Studenti> _Studenti;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnZkratkaChanging(string value);
    partial void OnZkratkaChanged();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    #endregion
		
		public SpojovaciTabulka()
		{
			this._Predmety = default(EntityRef<Predmety>);
			this._Studenti = default(EntityRef<Studenti>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zkratka", DbType="VarChar(3) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Zkratka
		{
			get
			{
				return this._Zkratka;
			}
			set
			{
				if ((this._Zkratka != value))
				{
					if (this._Predmety.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnZkratkaChanging(value);
					this.SendPropertyChanging();
					this._Zkratka = value;
					this.SendPropertyChanged("Zkratka");
					this.OnZkratkaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					if (this._Studenti.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Predmety_SpojovaciTabulka", Storage="_Predmety", ThisKey="Zkratka", OtherKey="Zkratka", IsForeignKey=true)]
		public Predmety Predmety
		{
			get
			{
				return this._Predmety.Entity;
			}
			set
			{
				Predmety previousValue = this._Predmety.Entity;
				if (((previousValue != value) 
							|| (this._Predmety.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Predmety.Entity = null;
						previousValue.SpojovaciTabulka.Remove(this);
					}
					this._Predmety.Entity = value;
					if ((value != null))
					{
						value.SpojovaciTabulka.Add(this);
						this._Zkratka = value.Zkratka;
					}
					else
					{
						this._Zkratka = default(string);
					}
					this.SendPropertyChanged("Predmety");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Studenti_SpojovaciTabulka", Storage="_Studenti", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
		public Studenti Studenti
		{
			get
			{
				return this._Studenti.Entity;
			}
			set
			{
				Studenti previousValue = this._Studenti.Entity;
				if (((previousValue != value) 
							|| (this._Studenti.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Studenti.Entity = null;
						previousValue.SpojovaciTabulka.Remove(this);
					}
					this._Studenti.Entity = value;
					if ((value != null))
					{
						value.SpojovaciTabulka.Add(this);
						this._ID = value.ID;
					}
					else
					{
						this._ID = default(int);
					}
					this.SendPropertyChanged("Studenti");
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
#pragma warning restore 1591