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

namespace Web_CHVLXD.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QL_VATLIEU")]
	public partial class QL_VLXDDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCTHOADON(CTHOADON instance);
    partial void UpdateCTHOADON(CTHOADON instance);
    partial void DeleteCTHOADON(CTHOADON instance);
    partial void InsertVATLIEU(VATLIEU instance);
    partial void UpdateVATLIEU(VATLIEU instance);
    partial void DeleteVATLIEU(VATLIEU instance);
    partial void InsertCTVATLIEU(CTVATLIEU instance);
    partial void UpdateCTVATLIEU(CTVATLIEU instance);
    partial void DeleteCTVATLIEU(CTVATLIEU instance);
    partial void InsertHOADON(HOADON instance);
    partial void UpdateHOADON(HOADON instance);
    partial void DeleteHOADON(HOADON instance);
    partial void InsertIMFOR_USERACCOUNT(IMFOR_USERACCOUNT instance);
    partial void UpdateIMFOR_USERACCOUNT(IMFOR_USERACCOUNT instance);
    partial void DeleteIMFOR_USERACCOUNT(IMFOR_USERACCOUNT instance);
    partial void InsertKHO(KHO instance);
    partial void UpdateKHO(KHO instance);
    partial void DeleteKHO(KHO instance);
    partial void InsertUSERACCOUNT(USERACCOUNT instance);
    partial void UpdateUSERACCOUNT(USERACCOUNT instance);
    partial void DeleteUSERACCOUNT(USERACCOUNT instance);
    #endregion
		
		public QL_VLXDDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QL_VATLIEUConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QL_VLXDDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QL_VLXDDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QL_VLXDDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QL_VLXDDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CTHOADON> CTHOADONs
		{
			get
			{
				return this.GetTable<CTHOADON>();
			}
		}
		
		public System.Data.Linq.Table<VATLIEU> VATLIEUs
		{
			get
			{
				return this.GetTable<VATLIEU>();
			}
		}
		
		public System.Data.Linq.Table<CTVATLIEU> CTVATLIEUs
		{
			get
			{
				return this.GetTable<CTVATLIEU>();
			}
		}
		
		public System.Data.Linq.Table<HOADON> HOADONs
		{
			get
			{
				return this.GetTable<HOADON>();
			}
		}
		
		public System.Data.Linq.Table<IMFOR_USERACCOUNT> IMFOR_USERACCOUNTs
		{
			get
			{
				return this.GetTable<IMFOR_USERACCOUNT>();
			}
		}
		
		public System.Data.Linq.Table<KHO> KHOs
		{
			get
			{
				return this.GetTable<KHO>();
			}
		}
		
		public System.Data.Linq.Table<QLKHO> QLKHOs
		{
			get
			{
				return this.GetTable<QLKHO>();
			}
		}
		
		public System.Data.Linq.Table<USERACCOUNT> USERACCOUNTs
		{
			get
			{
				return this.GetTable<USERACCOUNT>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CTHOADON")]
	public partial class CTHOADON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _IDHOADON;
		
		private string _IDKHO;
		
		private string _MAVALIEU;
		
		private string _TENVATLIEU;
		
		private System.Nullable<int> _SOLUONG;
		
		private System.Nullable<int> _THANHTIEN;
		
		private EntityRef<HOADON> _HOADON;
		
		private EntityRef<KHO> _KHO;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnIDHOADONChanging(string value);
    partial void OnIDHOADONChanged();
    partial void OnIDKHOChanging(string value);
    partial void OnIDKHOChanged();
    partial void OnMAVALIEUChanging(string value);
    partial void OnMAVALIEUChanged();
    partial void OnTENVATLIEUChanging(string value);
    partial void OnTENVATLIEUChanged();
    partial void OnSOLUONGChanging(System.Nullable<int> value);
    partial void OnSOLUONGChanged();
    partial void OnTHANHTIENChanging(System.Nullable<int> value);
    partial void OnTHANHTIENChanged();
    #endregion
		
		public CTHOADON()
		{
			this._HOADON = default(EntityRef<HOADON>);
			this._KHO = default(EntityRef<KHO>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDHOADON", DbType="Char(5)")]
		public string IDHOADON
		{
			get
			{
				return this._IDHOADON;
			}
			set
			{
				if ((this._IDHOADON != value))
				{
					if (this._HOADON.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDHOADONChanging(value);
					this.SendPropertyChanging();
					this._IDHOADON = value;
					this.SendPropertyChanged("IDHOADON");
					this.OnIDHOADONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDKHO", DbType="Char(5)")]
		public string IDKHO
		{
			get
			{
				return this._IDKHO;
			}
			set
			{
				if ((this._IDKHO != value))
				{
					if (this._KHO.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDKHOChanging(value);
					this.SendPropertyChanging();
					this._IDKHO = value;
					this.SendPropertyChanged("IDKHO");
					this.OnIDKHOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAVALIEU", DbType="Char(5)")]
		public string MAVALIEU
		{
			get
			{
				return this._MAVALIEU;
			}
			set
			{
				if ((this._MAVALIEU != value))
				{
					this.OnMAVALIEUChanging(value);
					this.SendPropertyChanging();
					this._MAVALIEU = value;
					this.SendPropertyChanged("MAVALIEU");
					this.OnMAVALIEUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENVATLIEU", DbType="NVarChar(30)")]
		public string TENVATLIEU
		{
			get
			{
				return this._TENVATLIEU;
			}
			set
			{
				if ((this._TENVATLIEU != value))
				{
					this.OnTENVATLIEUChanging(value);
					this.SendPropertyChanging();
					this._TENVATLIEU = value;
					this.SendPropertyChanged("TENVATLIEU");
					this.OnTENVATLIEUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOLUONG", DbType="Int")]
		public System.Nullable<int> SOLUONG
		{
			get
			{
				return this._SOLUONG;
			}
			set
			{
				if ((this._SOLUONG != value))
				{
					this.OnSOLUONGChanging(value);
					this.SendPropertyChanging();
					this._SOLUONG = value;
					this.SendPropertyChanged("SOLUONG");
					this.OnSOLUONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_THANHTIEN", DbType="Int")]
		public System.Nullable<int> THANHTIEN
		{
			get
			{
				return this._THANHTIEN;
			}
			set
			{
				if ((this._THANHTIEN != value))
				{
					this.OnTHANHTIENChanging(value);
					this.SendPropertyChanging();
					this._THANHTIEN = value;
					this.SendPropertyChanged("THANHTIEN");
					this.OnTHANHTIENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HOADON_CTHOADON", Storage="_HOADON", ThisKey="IDHOADON", OtherKey="IDHOADON", IsForeignKey=true, DeleteRule="CASCADE")]
		public HOADON HOADON
		{
			get
			{
				return this._HOADON.Entity;
			}
			set
			{
				HOADON previousValue = this._HOADON.Entity;
				if (((previousValue != value) 
							|| (this._HOADON.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HOADON.Entity = null;
						previousValue.CTHOADONs.Remove(this);
					}
					this._HOADON.Entity = value;
					if ((value != null))
					{
						value.CTHOADONs.Add(this);
						this._IDHOADON = value.IDHOADON;
					}
					else
					{
						this._IDHOADON = default(string);
					}
					this.SendPropertyChanged("HOADON");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHO_CTHOADON", Storage="_KHO", ThisKey="IDKHO", OtherKey="IDKHO", IsForeignKey=true)]
		public KHO KHO
		{
			get
			{
				return this._KHO.Entity;
			}
			set
			{
				KHO previousValue = this._KHO.Entity;
				if (((previousValue != value) 
							|| (this._KHO.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHO.Entity = null;
						previousValue.CTHOADONs.Remove(this);
					}
					this._KHO.Entity = value;
					if ((value != null))
					{
						value.CTHOADONs.Add(this);
						this._IDKHO = value.IDKHO;
					}
					else
					{
						this._IDKHO = default(string);
					}
					this.SendPropertyChanged("KHO");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VATLIEU")]
	public partial class VATLIEU : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IDVATLIEU;
		
		private string _TENVATLIEU;
		
		private EntitySet<CTVATLIEU> _CTVATLIEUs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDVATLIEUChanging(string value);
    partial void OnIDVATLIEUChanged();
    partial void OnTENVATLIEUChanging(string value);
    partial void OnTENVATLIEUChanged();
    #endregion
		
		public VATLIEU()
		{
			this._CTVATLIEUs = new EntitySet<CTVATLIEU>(new Action<CTVATLIEU>(this.attach_CTVATLIEUs), new Action<CTVATLIEU>(this.detach_CTVATLIEUs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDVATLIEU", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDVATLIEU
		{
			get
			{
				return this._IDVATLIEU;
			}
			set
			{
				if ((this._IDVATLIEU != value))
				{
					this.OnIDVATLIEUChanging(value);
					this.SendPropertyChanging();
					this._IDVATLIEU = value;
					this.SendPropertyChanged("IDVATLIEU");
					this.OnIDVATLIEUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENVATLIEU", DbType="NVarChar(30)")]
		public string TENVATLIEU
		{
			get
			{
				return this._TENVATLIEU;
			}
			set
			{
				if ((this._TENVATLIEU != value))
				{
					this.OnTENVATLIEUChanging(value);
					this.SendPropertyChanging();
					this._TENVATLIEU = value;
					this.SendPropertyChanged("TENVATLIEU");
					this.OnTENVATLIEUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="VATLIEU_CTVATLIEU", Storage="_CTVATLIEUs", ThisKey="IDVATLIEU", OtherKey="IDVATLIEU")]
		public EntitySet<CTVATLIEU> CTVATLIEUs
		{
			get
			{
				return this._CTVATLIEUs;
			}
			set
			{
				this._CTVATLIEUs.Assign(value);
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
		
		private void attach_CTVATLIEUs(CTVATLIEU entity)
		{
			this.SendPropertyChanging();
			entity.VATLIEU = this;
		}
		
		private void detach_CTVATLIEUs(CTVATLIEU entity)
		{
			this.SendPropertyChanging();
			entity.VATLIEU = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CTVATLIEU")]
	public partial class CTVATLIEU : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAVATLIEU;
		
		private string _IDVATLIEU;
		
		private string _TENVATLIEU;
		
		private string _DONVI;
		
		private System.Nullable<int> _GIA;
		
		private EntityRef<VATLIEU> _VATLIEU;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAVATLIEUChanging(string value);
    partial void OnMAVATLIEUChanged();
    partial void OnIDVATLIEUChanging(string value);
    partial void OnIDVATLIEUChanged();
    partial void OnTENVATLIEUChanging(string value);
    partial void OnTENVATLIEUChanged();
    partial void OnDONVIChanging(string value);
    partial void OnDONVIChanged();
    partial void OnGIAChanging(System.Nullable<int> value);
    partial void OnGIAChanged();
    #endregion
		
		public CTVATLIEU()
		{
			this._VATLIEU = default(EntityRef<VATLIEU>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAVATLIEU", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAVATLIEU
		{
			get
			{
				return this._MAVATLIEU;
			}
			set
			{
				if ((this._MAVATLIEU != value))
				{
					this.OnMAVATLIEUChanging(value);
					this.SendPropertyChanging();
					this._MAVATLIEU = value;
					this.SendPropertyChanged("MAVATLIEU");
					this.OnMAVATLIEUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDVATLIEU", DbType="Char(5)")]
		public string IDVATLIEU
		{
			get
			{
				return this._IDVATLIEU;
			}
			set
			{
				if ((this._IDVATLIEU != value))
				{
					if (this._VATLIEU.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDVATLIEUChanging(value);
					this.SendPropertyChanging();
					this._IDVATLIEU = value;
					this.SendPropertyChanged("IDVATLIEU");
					this.OnIDVATLIEUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENVATLIEU", DbType="NVarChar(30)")]
		public string TENVATLIEU
		{
			get
			{
				return this._TENVATLIEU;
			}
			set
			{
				if ((this._TENVATLIEU != value))
				{
					this.OnTENVATLIEUChanging(value);
					this.SendPropertyChanging();
					this._TENVATLIEU = value;
					this.SendPropertyChanged("TENVATLIEU");
					this.OnTENVATLIEUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DONVI", DbType="NVarChar(20)")]
		public string DONVI
		{
			get
			{
				return this._DONVI;
			}
			set
			{
				if ((this._DONVI != value))
				{
					this.OnDONVIChanging(value);
					this.SendPropertyChanging();
					this._DONVI = value;
					this.SendPropertyChanged("DONVI");
					this.OnDONVIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GIA", DbType="Int")]
		public System.Nullable<int> GIA
		{
			get
			{
				return this._GIA;
			}
			set
			{
				if ((this._GIA != value))
				{
					this.OnGIAChanging(value);
					this.SendPropertyChanging();
					this._GIA = value;
					this.SendPropertyChanged("GIA");
					this.OnGIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="VATLIEU_CTVATLIEU", Storage="_VATLIEU", ThisKey="IDVATLIEU", OtherKey="IDVATLIEU", IsForeignKey=true)]
		public VATLIEU VATLIEU
		{
			get
			{
				return this._VATLIEU.Entity;
			}
			set
			{
				VATLIEU previousValue = this._VATLIEU.Entity;
				if (((previousValue != value) 
							|| (this._VATLIEU.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._VATLIEU.Entity = null;
						previousValue.CTVATLIEUs.Remove(this);
					}
					this._VATLIEU.Entity = value;
					if ((value != null))
					{
						value.CTVATLIEUs.Add(this);
						this._IDVATLIEU = value.IDVATLIEU;
					}
					else
					{
						this._IDVATLIEU = default(string);
					}
					this.SendPropertyChanged("VATLIEU");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HOADON")]
	public partial class HOADON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IDHOADON;
		
		private System.Nullable<bool> _LOAIHOADON;
		
		private System.Nullable<System.DateTime> _NGAYTAO;
		
		private System.Nullable<int> _TONGTIEN;
		
		private EntitySet<CTHOADON> _CTHOADONs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDHOADONChanging(string value);
    partial void OnIDHOADONChanged();
    partial void OnLOAIHOADONChanging(System.Nullable<bool> value);
    partial void OnLOAIHOADONChanged();
    partial void OnNGAYTAOChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYTAOChanged();
    partial void OnTONGTIENChanging(System.Nullable<int> value);
    partial void OnTONGTIENChanged();
    #endregion
		
		public HOADON()
		{
			this._CTHOADONs = new EntitySet<CTHOADON>(new Action<CTHOADON>(this.attach_CTHOADONs), new Action<CTHOADON>(this.detach_CTHOADONs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDHOADON", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDHOADON
		{
			get
			{
				return this._IDHOADON;
			}
			set
			{
				if ((this._IDHOADON != value))
				{
					this.OnIDHOADONChanging(value);
					this.SendPropertyChanging();
					this._IDHOADON = value;
					this.SendPropertyChanged("IDHOADON");
					this.OnIDHOADONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOAIHOADON", DbType="Bit")]
		public System.Nullable<bool> LOAIHOADON
		{
			get
			{
				return this._LOAIHOADON;
			}
			set
			{
				if ((this._LOAIHOADON != value))
				{
					this.OnLOAIHOADONChanging(value);
					this.SendPropertyChanging();
					this._LOAIHOADON = value;
					this.SendPropertyChanged("LOAIHOADON");
					this.OnLOAIHOADONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYTAO", DbType="Date")]
		public System.Nullable<System.DateTime> NGAYTAO
		{
			get
			{
				return this._NGAYTAO;
			}
			set
			{
				if ((this._NGAYTAO != value))
				{
					this.OnNGAYTAOChanging(value);
					this.SendPropertyChanging();
					this._NGAYTAO = value;
					this.SendPropertyChanged("NGAYTAO");
					this.OnNGAYTAOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TONGTIEN", DbType="Int")]
		public System.Nullable<int> TONGTIEN
		{
			get
			{
				return this._TONGTIEN;
			}
			set
			{
				if ((this._TONGTIEN != value))
				{
					this.OnTONGTIENChanging(value);
					this.SendPropertyChanging();
					this._TONGTIEN = value;
					this.SendPropertyChanged("TONGTIEN");
					this.OnTONGTIENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HOADON_CTHOADON", Storage="_CTHOADONs", ThisKey="IDHOADON", OtherKey="IDHOADON")]
		public EntitySet<CTHOADON> CTHOADONs
		{
			get
			{
				return this._CTHOADONs;
			}
			set
			{
				this._CTHOADONs.Assign(value);
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
		
		private void attach_CTHOADONs(CTHOADON entity)
		{
			this.SendPropertyChanging();
			entity.HOADON = this;
		}
		
		private void detach_CTHOADONs(CTHOADON entity)
		{
			this.SendPropertyChanging();
			entity.HOADON = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.IMFOR_USERACCOUNT")]
	public partial class IMFOR_USERACCOUNT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MANGUOIQL;
		
		private System.Nullable<int> _IDUSER;
		
		private string _TENNGUOIQL;
		
		private System.Nullable<System.DateTime> _NAMSINH;
		
		private string _GENDER;
		
		private string _SDT;
		
		private string _EMAIL;
		
		private EntitySet<KHO> _KHOs;
		
		private EntityRef<USERACCOUNT> _USERACCOUNT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMANGUOIQLChanging(string value);
    partial void OnMANGUOIQLChanged();
    partial void OnIDUSERChanging(System.Nullable<int> value);
    partial void OnIDUSERChanged();
    partial void OnTENNGUOIQLChanging(string value);
    partial void OnTENNGUOIQLChanged();
    partial void OnNAMSINHChanging(System.Nullable<System.DateTime> value);
    partial void OnNAMSINHChanged();
    partial void OnGENDERChanging(string value);
    partial void OnGENDERChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnEMAILChanging(string value);
    partial void OnEMAILChanged();
    #endregion
		
		public IMFOR_USERACCOUNT()
		{
			this._KHOs = new EntitySet<KHO>(new Action<KHO>(this.attach_KHOs), new Action<KHO>(this.detach_KHOs));
			this._USERACCOUNT = default(EntityRef<USERACCOUNT>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANGUOIQL", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MANGUOIQL
		{
			get
			{
				return this._MANGUOIQL;
			}
			set
			{
				if ((this._MANGUOIQL != value))
				{
					this.OnMANGUOIQLChanging(value);
					this.SendPropertyChanging();
					this._MANGUOIQL = value;
					this.SendPropertyChanged("MANGUOIQL");
					this.OnMANGUOIQLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUSER", DbType="Int")]
		public System.Nullable<int> IDUSER
		{
			get
			{
				return this._IDUSER;
			}
			set
			{
				if ((this._IDUSER != value))
				{
					if (this._USERACCOUNT.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDUSERChanging(value);
					this.SendPropertyChanging();
					this._IDUSER = value;
					this.SendPropertyChanged("IDUSER");
					this.OnIDUSERChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENNGUOIQL", DbType="NVarChar(50)")]
		public string TENNGUOIQL
		{
			get
			{
				return this._TENNGUOIQL;
			}
			set
			{
				if ((this._TENNGUOIQL != value))
				{
					this.OnTENNGUOIQLChanging(value);
					this.SendPropertyChanging();
					this._TENNGUOIQL = value;
					this.SendPropertyChanged("TENNGUOIQL");
					this.OnTENNGUOIQLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAMSINH", DbType="Date")]
		public System.Nullable<System.DateTime> NAMSINH
		{
			get
			{
				return this._NAMSINH;
			}
			set
			{
				if ((this._NAMSINH != value))
				{
					this.OnNAMSINHChanging(value);
					this.SendPropertyChanging();
					this._NAMSINH = value;
					this.SendPropertyChanged("NAMSINH");
					this.OnNAMSINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GENDER", DbType="NVarChar(5)")]
		public string GENDER
		{
			get
			{
				return this._GENDER;
			}
			set
			{
				if ((this._GENDER != value))
				{
					this.OnGENDERChanging(value);
					this.SendPropertyChanging();
					this._GENDER = value;
					this.SendPropertyChanged("GENDER");
					this.OnGENDERChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="NVarChar(11)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMAIL", DbType="NVarChar(50)")]
		public string EMAIL
		{
			get
			{
				return this._EMAIL;
			}
			set
			{
				if ((this._EMAIL != value))
				{
					this.OnEMAILChanging(value);
					this.SendPropertyChanging();
					this._EMAIL = value;
					this.SendPropertyChanged("EMAIL");
					this.OnEMAILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="IMFOR_USERACCOUNT_KHO", Storage="_KHOs", ThisKey="MANGUOIQL", OtherKey="MANGUOIQL")]
		public EntitySet<KHO> KHOs
		{
			get
			{
				return this._KHOs;
			}
			set
			{
				this._KHOs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="USERACCOUNT_IMFOR_USERACCOUNT", Storage="_USERACCOUNT", ThisKey="IDUSER", OtherKey="IDUSER", IsForeignKey=true)]
		public USERACCOUNT USERACCOUNT
		{
			get
			{
				return this._USERACCOUNT.Entity;
			}
			set
			{
				USERACCOUNT previousValue = this._USERACCOUNT.Entity;
				if (((previousValue != value) 
							|| (this._USERACCOUNT.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._USERACCOUNT.Entity = null;
						previousValue.IMFOR_USERACCOUNTs.Remove(this);
					}
					this._USERACCOUNT.Entity = value;
					if ((value != null))
					{
						value.IMFOR_USERACCOUNTs.Add(this);
						this._IDUSER = value.IDUSER;
					}
					else
					{
						this._IDUSER = default(Nullable<int>);
					}
					this.SendPropertyChanged("USERACCOUNT");
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
		
		private void attach_KHOs(KHO entity)
		{
			this.SendPropertyChanging();
			entity.IMFOR_USERACCOUNT = this;
		}
		
		private void detach_KHOs(KHO entity)
		{
			this.SendPropertyChanging();
			entity.IMFOR_USERACCOUNT = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHO")]
	public partial class KHO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IDKHO;
		
		private string _TENKHO;
		
		private string _DIACHI;
		
		private string _MANGUOIQL;
		
		private EntitySet<CTHOADON> _CTHOADONs;
		
		private EntityRef<IMFOR_USERACCOUNT> _IMFOR_USERACCOUNT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDKHOChanging(string value);
    partial void OnIDKHOChanged();
    partial void OnTENKHOChanging(string value);
    partial void OnTENKHOChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnMANGUOIQLChanging(string value);
    partial void OnMANGUOIQLChanged();
    #endregion
		
		public KHO()
		{
			this._CTHOADONs = new EntitySet<CTHOADON>(new Action<CTHOADON>(this.attach_CTHOADONs), new Action<CTHOADON>(this.detach_CTHOADONs));
			this._IMFOR_USERACCOUNT = default(EntityRef<IMFOR_USERACCOUNT>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDKHO", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDKHO
		{
			get
			{
				return this._IDKHO;
			}
			set
			{
				if ((this._IDKHO != value))
				{
					this.OnIDKHOChanging(value);
					this.SendPropertyChanging();
					this._IDKHO = value;
					this.SendPropertyChanged("IDKHO");
					this.OnIDKHOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENKHO", DbType="NVarChar(50)")]
		public string TENKHO
		{
			get
			{
				return this._TENKHO;
			}
			set
			{
				if ((this._TENKHO != value))
				{
					this.OnTENKHOChanging(value);
					this.SendPropertyChanging();
					this._TENKHO = value;
					this.SendPropertyChanged("TENKHO");
					this.OnTENKHOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(100)")]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANGUOIQL", DbType="Char(5)")]
		public string MANGUOIQL
		{
			get
			{
				return this._MANGUOIQL;
			}
			set
			{
				if ((this._MANGUOIQL != value))
				{
					if (this._IMFOR_USERACCOUNT.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMANGUOIQLChanging(value);
					this.SendPropertyChanging();
					this._MANGUOIQL = value;
					this.SendPropertyChanged("MANGUOIQL");
					this.OnMANGUOIQLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHO_CTHOADON", Storage="_CTHOADONs", ThisKey="IDKHO", OtherKey="IDKHO")]
		public EntitySet<CTHOADON> CTHOADONs
		{
			get
			{
				return this._CTHOADONs;
			}
			set
			{
				this._CTHOADONs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="IMFOR_USERACCOUNT_KHO", Storage="_IMFOR_USERACCOUNT", ThisKey="MANGUOIQL", OtherKey="MANGUOIQL", IsForeignKey=true)]
		public IMFOR_USERACCOUNT IMFOR_USERACCOUNT
		{
			get
			{
				return this._IMFOR_USERACCOUNT.Entity;
			}
			set
			{
				IMFOR_USERACCOUNT previousValue = this._IMFOR_USERACCOUNT.Entity;
				if (((previousValue != value) 
							|| (this._IMFOR_USERACCOUNT.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._IMFOR_USERACCOUNT.Entity = null;
						previousValue.KHOs.Remove(this);
					}
					this._IMFOR_USERACCOUNT.Entity = value;
					if ((value != null))
					{
						value.KHOs.Add(this);
						this._MANGUOIQL = value.MANGUOIQL;
					}
					else
					{
						this._MANGUOIQL = default(string);
					}
					this.SendPropertyChanged("IMFOR_USERACCOUNT");
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
		
		private void attach_CTHOADONs(CTHOADON entity)
		{
			this.SendPropertyChanging();
			entity.KHO = this;
		}
		
		private void detach_CTHOADONs(CTHOADON entity)
		{
			this.SendPropertyChanging();
			entity.KHO = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QLKHO")]
	public partial class QLKHO
	{
		
		private string _IDKHO;
		
		private string _MAVALIEU;
		
		private string _TENVATLIEU;
		
		private System.Nullable<int> _SOLUONG;
		
		private string _DONVI;
		
		public QLKHO()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDKHO", DbType="Char(5)")]
		public string IDKHO
		{
			get
			{
				return this._IDKHO;
			}
			set
			{
				if ((this._IDKHO != value))
				{
					this._IDKHO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAVALIEU", DbType="Char(5)")]
		public string MAVALIEU
		{
			get
			{
				return this._MAVALIEU;
			}
			set
			{
				if ((this._MAVALIEU != value))
				{
					this._MAVALIEU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENVATLIEU", DbType="NVarChar(30)")]
		public string TENVATLIEU
		{
			get
			{
				return this._TENVATLIEU;
			}
			set
			{
				if ((this._TENVATLIEU != value))
				{
					this._TENVATLIEU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOLUONG", DbType="Int")]
		public System.Nullable<int> SOLUONG
		{
			get
			{
				return this._SOLUONG;
			}
			set
			{
				if ((this._SOLUONG != value))
				{
					this._SOLUONG = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DONVI", DbType="NVarChar(20)")]
		public string DONVI
		{
			get
			{
				return this._DONVI;
			}
			set
			{
				if ((this._DONVI != value))
				{
					this._DONVI = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.USERACCOUNT")]
	public partial class USERACCOUNT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDUSER;
		
		private string _USERNAME;
		
		private string _USERPASSWORD;
		
		private EntitySet<IMFOR_USERACCOUNT> _IMFOR_USERACCOUNTs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDUSERChanging(int value);
    partial void OnIDUSERChanged();
    partial void OnUSERNAMEChanging(string value);
    partial void OnUSERNAMEChanged();
    partial void OnUSERPASSWORDChanging(string value);
    partial void OnUSERPASSWORDChanged();
    #endregion
		
		public USERACCOUNT()
		{
			this._IMFOR_USERACCOUNTs = new EntitySet<IMFOR_USERACCOUNT>(new Action<IMFOR_USERACCOUNT>(this.attach_IMFOR_USERACCOUNTs), new Action<IMFOR_USERACCOUNT>(this.detach_IMFOR_USERACCOUNTs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUSER", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDUSER
		{
			get
			{
				return this._IDUSER;
			}
			set
			{
				if ((this._IDUSER != value))
				{
					this.OnIDUSERChanging(value);
					this.SendPropertyChanging();
					this._IDUSER = value;
					this.SendPropertyChanged("IDUSER");
					this.OnIDUSERChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USERNAME", DbType="NVarChar(14)")]
		public string USERNAME
		{
			get
			{
				return this._USERNAME;
			}
			set
			{
				if ((this._USERNAME != value))
				{
					this.OnUSERNAMEChanging(value);
					this.SendPropertyChanging();
					this._USERNAME = value;
					this.SendPropertyChanged("USERNAME");
					this.OnUSERNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USERPASSWORD", DbType="NVarChar(14)")]
		public string USERPASSWORD
		{
			get
			{
				return this._USERPASSWORD;
			}
			set
			{
				if ((this._USERPASSWORD != value))
				{
					this.OnUSERPASSWORDChanging(value);
					this.SendPropertyChanging();
					this._USERPASSWORD = value;
					this.SendPropertyChanged("USERPASSWORD");
					this.OnUSERPASSWORDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="USERACCOUNT_IMFOR_USERACCOUNT", Storage="_IMFOR_USERACCOUNTs", ThisKey="IDUSER", OtherKey="IDUSER")]
		public EntitySet<IMFOR_USERACCOUNT> IMFOR_USERACCOUNTs
		{
			get
			{
				return this._IMFOR_USERACCOUNTs;
			}
			set
			{
				this._IMFOR_USERACCOUNTs.Assign(value);
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
		
		private void attach_IMFOR_USERACCOUNTs(IMFOR_USERACCOUNT entity)
		{
			this.SendPropertyChanging();
			entity.USERACCOUNT = this;
		}
		
		private void detach_IMFOR_USERACCOUNTs(IMFOR_USERACCOUNT entity)
		{
			this.SendPropertyChanging();
			entity.USERACCOUNT = null;
		}
	}
}
#pragma warning restore 1591
