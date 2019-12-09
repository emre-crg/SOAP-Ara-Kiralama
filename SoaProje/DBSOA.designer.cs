﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoaProje
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SOA_ARACKIRALAMA")]
	public partial class DBSOADataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertArac(Arac instance);
    partial void UpdateArac(Arac instance);
    partial void DeleteArac(Arac instance);
    partial void InsertKiralamaBilgisi(KiralamaBilgisi instance);
    partial void UpdateKiralamaBilgisi(KiralamaBilgisi instance);
    partial void DeleteKiralamaBilgisi(KiralamaBilgisi instance);
    partial void InsertMüsteri(Müsteri instance);
    partial void UpdateMüsteri(Müsteri instance);
    partial void DeleteMüsteri(Müsteri instance);
    partial void InsertOturum(Oturum instance);
    partial void UpdateOturum(Oturum instance);
    partial void DeleteOturum(Oturum instance);
    partial void InsertSirket(Sirket instance);
    partial void UpdateSirket(Sirket instance);
    partial void DeleteSirket(Sirket instance);
    #endregion
		
		public DBSOADataContext() : 
				base(global::SoaProje.Properties.Settings.Default.SOA_ARACKIRALAMAConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBSOADataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBSOADataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBSOADataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBSOADataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Arac> Aracs
		{
			get
			{
				return this.GetTable<Arac>();
			}
		}
		
		public System.Data.Linq.Table<KiralamaBilgisi> KiralamaBilgisis
		{
			get
			{
				return this.GetTable<KiralamaBilgisi>();
			}
		}
		
		public System.Data.Linq.Table<Müsteri> Müsteris
		{
			get
			{
				return this.GetTable<Müsteri>();
			}
		}
		
		public System.Data.Linq.Table<Oturum> Oturums
		{
			get
			{
				return this.GetTable<Oturum>();
			}
		}
		
		public System.Data.Linq.Table<Sirket> Sirkets
		{
			get
			{
				return this.GetTable<Sirket>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Arac")]
	public partial class Arac : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AracID;
		
		private string _Marka;
		
		private string _Model;
		
		private System.Nullable<int> _Yasi;
		
		private System.Nullable<int> _BagajHacmi;
		
		private System.Nullable<int> _KoltukSayisi;
		
		private System.Nullable<decimal> _GunlukFiyat;
		
		private System.Nullable<int> _SirketID;
		
		private System.Nullable<bool> _KiralanmaDurumu;
		
		private System.Nullable<bool> _airbag;
		
		private EntitySet<KiralamaBilgisi> _KiralamaBilgisis;
		
		private EntityRef<Sirket> _Sirket;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAracIDChanging(int value);
    partial void OnAracIDChanged();
    partial void OnMarkaChanging(string value);
    partial void OnMarkaChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnYasiChanging(System.Nullable<int> value);
    partial void OnYasiChanged();
    partial void OnBagajHacmiChanging(System.Nullable<int> value);
    partial void OnBagajHacmiChanged();
    partial void OnKoltukSayisiChanging(System.Nullable<int> value);
    partial void OnKoltukSayisiChanged();
    partial void OnGunlukFiyatChanging(System.Nullable<decimal> value);
    partial void OnGunlukFiyatChanged();
    partial void OnSirketIDChanging(System.Nullable<int> value);
    partial void OnSirketIDChanged();
    partial void OnKiralanmaDurumuChanging(System.Nullable<bool> value);
    partial void OnKiralanmaDurumuChanged();
    partial void OnairbagChanging(System.Nullable<bool> value);
    partial void OnairbagChanged();
    #endregion
		
		public Arac()
		{
			this._KiralamaBilgisis = new EntitySet<KiralamaBilgisi>(new Action<KiralamaBilgisi>(this.attach_KiralamaBilgisis), new Action<KiralamaBilgisi>(this.detach_KiralamaBilgisis));
			this._Sirket = default(EntityRef<Sirket>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AracID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AracID
		{
			get
			{
				return this._AracID;
			}
			set
			{
				if ((this._AracID != value))
				{
					this.OnAracIDChanging(value);
					this.SendPropertyChanging();
					this._AracID = value;
					this.SendPropertyChanged("AracID");
					this.OnAracIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Marka", DbType="NChar(25)")]
		public string Marka
		{
			get
			{
				return this._Marka;
			}
			set
			{
				if ((this._Marka != value))
				{
					this.OnMarkaChanging(value);
					this.SendPropertyChanging();
					this._Marka = value;
					this.SendPropertyChanged("Marka");
					this.OnMarkaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="NChar(25)")]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				if ((this._Model != value))
				{
					this.OnModelChanging(value);
					this.SendPropertyChanging();
					this._Model = value;
					this.SendPropertyChanged("Model");
					this.OnModelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Yasi", DbType="Int")]
		public System.Nullable<int> Yasi
		{
			get
			{
				return this._Yasi;
			}
			set
			{
				if ((this._Yasi != value))
				{
					this.OnYasiChanging(value);
					this.SendPropertyChanging();
					this._Yasi = value;
					this.SendPropertyChanged("Yasi");
					this.OnYasiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BagajHacmi", DbType="Int")]
		public System.Nullable<int> BagajHacmi
		{
			get
			{
				return this._BagajHacmi;
			}
			set
			{
				if ((this._BagajHacmi != value))
				{
					this.OnBagajHacmiChanging(value);
					this.SendPropertyChanging();
					this._BagajHacmi = value;
					this.SendPropertyChanged("BagajHacmi");
					this.OnBagajHacmiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KoltukSayisi", DbType="Int")]
		public System.Nullable<int> KoltukSayisi
		{
			get
			{
				return this._KoltukSayisi;
			}
			set
			{
				if ((this._KoltukSayisi != value))
				{
					this.OnKoltukSayisiChanging(value);
					this.SendPropertyChanging();
					this._KoltukSayisi = value;
					this.SendPropertyChanged("KoltukSayisi");
					this.OnKoltukSayisiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GunlukFiyat", DbType="Money")]
		public System.Nullable<decimal> GunlukFiyat
		{
			get
			{
				return this._GunlukFiyat;
			}
			set
			{
				if ((this._GunlukFiyat != value))
				{
					this.OnGunlukFiyatChanging(value);
					this.SendPropertyChanging();
					this._GunlukFiyat = value;
					this.SendPropertyChanged("GunlukFiyat");
					this.OnGunlukFiyatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SirketID", DbType="Int")]
		public System.Nullable<int> SirketID
		{
			get
			{
				return this._SirketID;
			}
			set
			{
				if ((this._SirketID != value))
				{
					if (this._Sirket.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSirketIDChanging(value);
					this.SendPropertyChanging();
					this._SirketID = value;
					this.SendPropertyChanged("SirketID");
					this.OnSirketIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KiralanmaDurumu", DbType="Bit")]
		public System.Nullable<bool> KiralanmaDurumu
		{
			get
			{
				return this._KiralanmaDurumu;
			}
			set
			{
				if ((this._KiralanmaDurumu != value))
				{
					this.OnKiralanmaDurumuChanging(value);
					this.SendPropertyChanging();
					this._KiralanmaDurumu = value;
					this.SendPropertyChanged("KiralanmaDurumu");
					this.OnKiralanmaDurumuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_airbag", DbType="Bit")]
		public System.Nullable<bool> airbag
		{
			get
			{
				return this._airbag;
			}
			set
			{
				if ((this._airbag != value))
				{
					this.OnairbagChanging(value);
					this.SendPropertyChanging();
					this._airbag = value;
					this.SendPropertyChanged("airbag");
					this.OnairbagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Arac_KiralamaBilgisi", Storage="_KiralamaBilgisis", ThisKey="AracID", OtherKey="AracID")]
		public EntitySet<KiralamaBilgisi> KiralamaBilgisis
		{
			get
			{
				return this._KiralamaBilgisis;
			}
			set
			{
				this._KiralamaBilgisis.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sirket_Arac", Storage="_Sirket", ThisKey="SirketID", OtherKey="SirketID", IsForeignKey=true)]
		public Sirket Sirket
		{
			get
			{
				return this._Sirket.Entity;
			}
			set
			{
				Sirket previousValue = this._Sirket.Entity;
				if (((previousValue != value) 
							|| (this._Sirket.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sirket.Entity = null;
						previousValue.Aracs.Remove(this);
					}
					this._Sirket.Entity = value;
					if ((value != null))
					{
						value.Aracs.Add(this);
						this._SirketID = value.SirketID;
					}
					else
					{
						this._SirketID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Sirket");
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
		
		private void attach_KiralamaBilgisis(KiralamaBilgisi entity)
		{
			this.SendPropertyChanging();
			entity.Arac = this;
		}
		
		private void detach_KiralamaBilgisis(KiralamaBilgisi entity)
		{
			this.SendPropertyChanging();
			entity.Arac = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KiralamaBilgisi")]
	public partial class KiralamaBilgisi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _KiralamaID;
		
		private System.Nullable<int> _MüsteriID;
		
		private System.Nullable<System.DateTime> _VerilisTarihi;
		
		private string _AlışTarihi;
		
		private System.Nullable<int> _AracID;
		
		private System.Nullable<int> _SonKM;
		
		private System.Nullable<int> _SirketId;
		
		private System.Nullable<int> _AlınacakUcret;
		
		private EntityRef<Arac> _Arac;
		
		private EntityRef<Müsteri> _Müsteri;
		
		private EntityRef<Sirket> _Sirket;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnKiralamaIDChanging(int value);
    partial void OnKiralamaIDChanged();
    partial void OnMüsteriIDChanging(System.Nullable<int> value);
    partial void OnMüsteriIDChanged();
    partial void OnVerilisTarihiChanging(System.Nullable<System.DateTime> value);
    partial void OnVerilisTarihiChanged();
    partial void OnAlışTarihiChanging(string value);
    partial void OnAlışTarihiChanged();
    partial void OnAracIDChanging(System.Nullable<int> value);
    partial void OnAracIDChanged();
    partial void OnSonKMChanging(System.Nullable<int> value);
    partial void OnSonKMChanged();
    partial void OnSirketIdChanging(System.Nullable<int> value);
    partial void OnSirketIdChanged();
    partial void OnAlınacakUcretChanging(System.Nullable<int> value);
    partial void OnAlınacakUcretChanged();
    #endregion
		
		public KiralamaBilgisi()
		{
			this._Arac = default(EntityRef<Arac>);
			this._Müsteri = default(EntityRef<Müsteri>);
			this._Sirket = default(EntityRef<Sirket>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KiralamaID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int KiralamaID
		{
			get
			{
				return this._KiralamaID;
			}
			set
			{
				if ((this._KiralamaID != value))
				{
					this.OnKiralamaIDChanging(value);
					this.SendPropertyChanging();
					this._KiralamaID = value;
					this.SendPropertyChanged("KiralamaID");
					this.OnKiralamaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MüsteriID", DbType="Int")]
		public System.Nullable<int> MüsteriID
		{
			get
			{
				return this._MüsteriID;
			}
			set
			{
				if ((this._MüsteriID != value))
				{
					if (this._Müsteri.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMüsteriIDChanging(value);
					this.SendPropertyChanging();
					this._MüsteriID = value;
					this.SendPropertyChanged("MüsteriID");
					this.OnMüsteriIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VerilisTarihi", DbType="Date")]
		public System.Nullable<System.DateTime> VerilisTarihi
		{
			get
			{
				return this._VerilisTarihi;
			}
			set
			{
				if ((this._VerilisTarihi != value))
				{
					this.OnVerilisTarihiChanging(value);
					this.SendPropertyChanging();
					this._VerilisTarihi = value;
					this.SendPropertyChanged("VerilisTarihi");
					this.OnVerilisTarihiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AlışTarihi", DbType="NChar(10)")]
		public string AlışTarihi
		{
			get
			{
				return this._AlışTarihi;
			}
			set
			{
				if ((this._AlışTarihi != value))
				{
					this.OnAlışTarihiChanging(value);
					this.SendPropertyChanging();
					this._AlışTarihi = value;
					this.SendPropertyChanged("AlışTarihi");
					this.OnAlışTarihiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AracID", DbType="Int")]
		public System.Nullable<int> AracID
		{
			get
			{
				return this._AracID;
			}
			set
			{
				if ((this._AracID != value))
				{
					if (this._Arac.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAracIDChanging(value);
					this.SendPropertyChanging();
					this._AracID = value;
					this.SendPropertyChanged("AracID");
					this.OnAracIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SonKM", DbType="Int")]
		public System.Nullable<int> SonKM
		{
			get
			{
				return this._SonKM;
			}
			set
			{
				if ((this._SonKM != value))
				{
					this.OnSonKMChanging(value);
					this.SendPropertyChanging();
					this._SonKM = value;
					this.SendPropertyChanged("SonKM");
					this.OnSonKMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SirketId", DbType="Int")]
		public System.Nullable<int> SirketId
		{
			get
			{
				return this._SirketId;
			}
			set
			{
				if ((this._SirketId != value))
				{
					if (this._Sirket.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSirketIdChanging(value);
					this.SendPropertyChanging();
					this._SirketId = value;
					this.SendPropertyChanged("SirketId");
					this.OnSirketIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AlınacakUcret", DbType="Int")]
		public System.Nullable<int> AlınacakUcret
		{
			get
			{
				return this._AlınacakUcret;
			}
			set
			{
				if ((this._AlınacakUcret != value))
				{
					this.OnAlınacakUcretChanging(value);
					this.SendPropertyChanging();
					this._AlınacakUcret = value;
					this.SendPropertyChanged("AlınacakUcret");
					this.OnAlınacakUcretChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Arac_KiralamaBilgisi", Storage="_Arac", ThisKey="AracID", OtherKey="AracID", IsForeignKey=true)]
		public Arac Arac
		{
			get
			{
				return this._Arac.Entity;
			}
			set
			{
				Arac previousValue = this._Arac.Entity;
				if (((previousValue != value) 
							|| (this._Arac.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Arac.Entity = null;
						previousValue.KiralamaBilgisis.Remove(this);
					}
					this._Arac.Entity = value;
					if ((value != null))
					{
						value.KiralamaBilgisis.Add(this);
						this._AracID = value.AracID;
					}
					else
					{
						this._AracID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Arac");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Müsteri_KiralamaBilgisi", Storage="_Müsteri", ThisKey="MüsteriID", OtherKey="MüsteriID", IsForeignKey=true)]
		public Müsteri Müsteri
		{
			get
			{
				return this._Müsteri.Entity;
			}
			set
			{
				Müsteri previousValue = this._Müsteri.Entity;
				if (((previousValue != value) 
							|| (this._Müsteri.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Müsteri.Entity = null;
						previousValue.KiralamaBilgisis.Remove(this);
					}
					this._Müsteri.Entity = value;
					if ((value != null))
					{
						value.KiralamaBilgisis.Add(this);
						this._MüsteriID = value.MüsteriID;
					}
					else
					{
						this._MüsteriID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Müsteri");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sirket_KiralamaBilgisi", Storage="_Sirket", ThisKey="SirketId", OtherKey="SirketID", IsForeignKey=true)]
		public Sirket Sirket
		{
			get
			{
				return this._Sirket.Entity;
			}
			set
			{
				Sirket previousValue = this._Sirket.Entity;
				if (((previousValue != value) 
							|| (this._Sirket.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sirket.Entity = null;
						previousValue.KiralamaBilgisis.Remove(this);
					}
					this._Sirket.Entity = value;
					if ((value != null))
					{
						value.KiralamaBilgisis.Add(this);
						this._SirketId = value.SirketID;
					}
					else
					{
						this._SirketId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Sirket");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Müsteri")]
	public partial class Müsteri : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MüsteriID;
		
		private string _İsim;
		
		private string _Soyisim;
		
		private string _TCNo;
		
		private System.Nullable<int> _OturumID;
		
		private string _Adres;
		
		private EntitySet<KiralamaBilgisi> _KiralamaBilgisis;
		
		private EntityRef<Oturum> _Oturum;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMüsteriIDChanging(int value);
    partial void OnMüsteriIDChanged();
    partial void OnİsimChanging(string value);
    partial void OnİsimChanged();
    partial void OnSoyisimChanging(string value);
    partial void OnSoyisimChanged();
    partial void OnTCNoChanging(string value);
    partial void OnTCNoChanged();
    partial void OnOturumIDChanging(System.Nullable<int> value);
    partial void OnOturumIDChanged();
    partial void OnAdresChanging(string value);
    partial void OnAdresChanged();
    #endregion
		
		public Müsteri()
		{
			this._KiralamaBilgisis = new EntitySet<KiralamaBilgisi>(new Action<KiralamaBilgisi>(this.attach_KiralamaBilgisis), new Action<KiralamaBilgisi>(this.detach_KiralamaBilgisis));
			this._Oturum = default(EntityRef<Oturum>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MüsteriID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MüsteriID
		{
			get
			{
				return this._MüsteriID;
			}
			set
			{
				if ((this._MüsteriID != value))
				{
					this.OnMüsteriIDChanging(value);
					this.SendPropertyChanging();
					this._MüsteriID = value;
					this.SendPropertyChanged("MüsteriID");
					this.OnMüsteriIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_İsim", DbType="NChar(20)")]
		public string İsim
		{
			get
			{
				return this._İsim;
			}
			set
			{
				if ((this._İsim != value))
				{
					this.OnİsimChanging(value);
					this.SendPropertyChanging();
					this._İsim = value;
					this.SendPropertyChanged("İsim");
					this.OnİsimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soyisim", DbType="NChar(20)")]
		public string Soyisim
		{
			get
			{
				return this._Soyisim;
			}
			set
			{
				if ((this._Soyisim != value))
				{
					this.OnSoyisimChanging(value);
					this.SendPropertyChanging();
					this._Soyisim = value;
					this.SendPropertyChanged("Soyisim");
					this.OnSoyisimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TCNo", DbType="Char(11)")]
		public string TCNo
		{
			get
			{
				return this._TCNo;
			}
			set
			{
				if ((this._TCNo != value))
				{
					this.OnTCNoChanging(value);
					this.SendPropertyChanging();
					this._TCNo = value;
					this.SendPropertyChanged("TCNo");
					this.OnTCNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OturumID", DbType="Int")]
		public System.Nullable<int> OturumID
		{
			get
			{
				return this._OturumID;
			}
			set
			{
				if ((this._OturumID != value))
				{
					if (this._Oturum.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOturumIDChanging(value);
					this.SendPropertyChanging();
					this._OturumID = value;
					this.SendPropertyChanged("OturumID");
					this.OnOturumIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adres", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Adres
		{
			get
			{
				return this._Adres;
			}
			set
			{
				if ((this._Adres != value))
				{
					this.OnAdresChanging(value);
					this.SendPropertyChanging();
					this._Adres = value;
					this.SendPropertyChanged("Adres");
					this.OnAdresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Müsteri_KiralamaBilgisi", Storage="_KiralamaBilgisis", ThisKey="MüsteriID", OtherKey="MüsteriID")]
		public EntitySet<KiralamaBilgisi> KiralamaBilgisis
		{
			get
			{
				return this._KiralamaBilgisis;
			}
			set
			{
				this._KiralamaBilgisis.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Oturum_Müsteri", Storage="_Oturum", ThisKey="OturumID", OtherKey="ID", IsForeignKey=true)]
		public Oturum Oturum
		{
			get
			{
				return this._Oturum.Entity;
			}
			set
			{
				Oturum previousValue = this._Oturum.Entity;
				if (((previousValue != value) 
							|| (this._Oturum.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Oturum.Entity = null;
						previousValue.Müsteris.Remove(this);
					}
					this._Oturum.Entity = value;
					if ((value != null))
					{
						value.Müsteris.Add(this);
						this._OturumID = value.ID;
					}
					else
					{
						this._OturumID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Oturum");
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
		
		private void attach_KiralamaBilgisis(KiralamaBilgisi entity)
		{
			this.SendPropertyChanging();
			entity.Müsteri = this;
		}
		
		private void detach_KiralamaBilgisis(KiralamaBilgisi entity)
		{
			this.SendPropertyChanging();
			entity.Müsteri = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Oturum")]
	public partial class Oturum : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _KullanıcıAdı;
		
		private string _Sifre;
		
		private EntitySet<Müsteri> _Müsteris;
		
		private EntitySet<Sirket> _Sirkets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnKullanıcıAdıChanging(string value);
    partial void OnKullanıcıAdıChanged();
    partial void OnSifreChanging(string value);
    partial void OnSifreChanged();
    #endregion
		
		public Oturum()
		{
			this._Müsteris = new EntitySet<Müsteri>(new Action<Müsteri>(this.attach_Müsteris), new Action<Müsteri>(this.detach_Müsteris));
			this._Sirkets = new EntitySet<Sirket>(new Action<Sirket>(this.attach_Sirkets), new Action<Sirket>(this.detach_Sirkets));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KullanıcıAdı", DbType="NChar(50)")]
		public string KullanıcıAdı
		{
			get
			{
				return this._KullanıcıAdı;
			}
			set
			{
				if ((this._KullanıcıAdı != value))
				{
					this.OnKullanıcıAdıChanging(value);
					this.SendPropertyChanging();
					this._KullanıcıAdı = value;
					this.SendPropertyChanged("KullanıcıAdı");
					this.OnKullanıcıAdıChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sifre", DbType="NChar(50)")]
		public string Sifre
		{
			get
			{
				return this._Sifre;
			}
			set
			{
				if ((this._Sifre != value))
				{
					this.OnSifreChanging(value);
					this.SendPropertyChanging();
					this._Sifre = value;
					this.SendPropertyChanged("Sifre");
					this.OnSifreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Oturum_Müsteri", Storage="_Müsteris", ThisKey="ID", OtherKey="OturumID")]
		public EntitySet<Müsteri> Müsteris
		{
			get
			{
				return this._Müsteris;
			}
			set
			{
				this._Müsteris.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Oturum_Sirket", Storage="_Sirkets", ThisKey="ID", OtherKey="OturumID")]
		public EntitySet<Sirket> Sirkets
		{
			get
			{
				return this._Sirkets;
			}
			set
			{
				this._Sirkets.Assign(value);
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
		
		private void attach_Müsteris(Müsteri entity)
		{
			this.SendPropertyChanging();
			entity.Oturum = this;
		}
		
		private void detach_Müsteris(Müsteri entity)
		{
			this.SendPropertyChanging();
			entity.Oturum = null;
		}
		
		private void attach_Sirkets(Sirket entity)
		{
			this.SendPropertyChanging();
			entity.Oturum = this;
		}
		
		private void detach_Sirkets(Sirket entity)
		{
			this.SendPropertyChanging();
			entity.Oturum = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sirket")]
	public partial class Sirket : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SirketID;
		
		private string _ŞirketAdi;
		
		private string _Adres;
		
		private System.Nullable<int> _AracSayisi;
		
		private System.Nullable<int> _OturumID;
		
		private System.Nullable<double> _SirketPuani;
		
		private EntitySet<Arac> _Aracs;
		
		private EntitySet<KiralamaBilgisi> _KiralamaBilgisis;
		
		private EntityRef<Oturum> _Oturum;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSirketIDChanging(int value);
    partial void OnSirketIDChanged();
    partial void OnŞirketAdiChanging(string value);
    partial void OnŞirketAdiChanged();
    partial void OnAdresChanging(string value);
    partial void OnAdresChanged();
    partial void OnAracSayisiChanging(System.Nullable<int> value);
    partial void OnAracSayisiChanged();
    partial void OnOturumIDChanging(System.Nullable<int> value);
    partial void OnOturumIDChanged();
    partial void OnSirketPuaniChanging(System.Nullable<double> value);
    partial void OnSirketPuaniChanged();
    #endregion
		
		public Sirket()
		{
			this._Aracs = new EntitySet<Arac>(new Action<Arac>(this.attach_Aracs), new Action<Arac>(this.detach_Aracs));
			this._KiralamaBilgisis = new EntitySet<KiralamaBilgisi>(new Action<KiralamaBilgisi>(this.attach_KiralamaBilgisis), new Action<KiralamaBilgisi>(this.detach_KiralamaBilgisis));
			this._Oturum = default(EntityRef<Oturum>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SirketID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SirketID
		{
			get
			{
				return this._SirketID;
			}
			set
			{
				if ((this._SirketID != value))
				{
					this.OnSirketIDChanging(value);
					this.SendPropertyChanging();
					this._SirketID = value;
					this.SendPropertyChanged("SirketID");
					this.OnSirketIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ŞirketAdi", DbType="NChar(30)")]
		public string ŞirketAdi
		{
			get
			{
				return this._ŞirketAdi;
			}
			set
			{
				if ((this._ŞirketAdi != value))
				{
					this.OnŞirketAdiChanging(value);
					this.SendPropertyChanging();
					this._ŞirketAdi = value;
					this.SendPropertyChanged("ŞirketAdi");
					this.OnŞirketAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adres", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Adres
		{
			get
			{
				return this._Adres;
			}
			set
			{
				if ((this._Adres != value))
				{
					this.OnAdresChanging(value);
					this.SendPropertyChanging();
					this._Adres = value;
					this.SendPropertyChanged("Adres");
					this.OnAdresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AracSayisi", DbType="Int")]
		public System.Nullable<int> AracSayisi
		{
			get
			{
				return this._AracSayisi;
			}
			set
			{
				if ((this._AracSayisi != value))
				{
					this.OnAracSayisiChanging(value);
					this.SendPropertyChanging();
					this._AracSayisi = value;
					this.SendPropertyChanged("AracSayisi");
					this.OnAracSayisiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OturumID", DbType="Int")]
		public System.Nullable<int> OturumID
		{
			get
			{
				return this._OturumID;
			}
			set
			{
				if ((this._OturumID != value))
				{
					if (this._Oturum.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOturumIDChanging(value);
					this.SendPropertyChanging();
					this._OturumID = value;
					this.SendPropertyChanged("OturumID");
					this.OnOturumIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SirketPuani", DbType="Float")]
		public System.Nullable<double> SirketPuani
		{
			get
			{
				return this._SirketPuani;
			}
			set
			{
				if ((this._SirketPuani != value))
				{
					this.OnSirketPuaniChanging(value);
					this.SendPropertyChanging();
					this._SirketPuani = value;
					this.SendPropertyChanged("SirketPuani");
					this.OnSirketPuaniChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sirket_Arac", Storage="_Aracs", ThisKey="SirketID", OtherKey="SirketID")]
		public EntitySet<Arac> Aracs
		{
			get
			{
				return this._Aracs;
			}
			set
			{
				this._Aracs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sirket_KiralamaBilgisi", Storage="_KiralamaBilgisis", ThisKey="SirketID", OtherKey="SirketId")]
		public EntitySet<KiralamaBilgisi> KiralamaBilgisis
		{
			get
			{
				return this._KiralamaBilgisis;
			}
			set
			{
				this._KiralamaBilgisis.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Oturum_Sirket", Storage="_Oturum", ThisKey="OturumID", OtherKey="ID", IsForeignKey=true)]
		public Oturum Oturum
		{
			get
			{
				return this._Oturum.Entity;
			}
			set
			{
				Oturum previousValue = this._Oturum.Entity;
				if (((previousValue != value) 
							|| (this._Oturum.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Oturum.Entity = null;
						previousValue.Sirkets.Remove(this);
					}
					this._Oturum.Entity = value;
					if ((value != null))
					{
						value.Sirkets.Add(this);
						this._OturumID = value.ID;
					}
					else
					{
						this._OturumID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Oturum");
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
		
		private void attach_Aracs(Arac entity)
		{
			this.SendPropertyChanging();
			entity.Sirket = this;
		}
		
		private void detach_Aracs(Arac entity)
		{
			this.SendPropertyChanging();
			entity.Sirket = null;
		}
		
		private void attach_KiralamaBilgisis(KiralamaBilgisi entity)
		{
			this.SendPropertyChanging();
			entity.Sirket = this;
		}
		
		private void detach_KiralamaBilgisis(KiralamaBilgisi entity)
		{
			this.SendPropertyChanging();
			entity.Sirket = null;
		}
	}
}
#pragma warning restore 1591
