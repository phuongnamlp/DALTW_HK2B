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

namespace Project_Travel.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TourDB")]
	public partial class MyDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTour(Tour instance);
    partial void UpdateTour(Tour instance);
    partial void DeleteTour(Tour instance);
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertDonHangDetail(DonHangDetail instance);
    partial void UpdateDonHangDetail(DonHangDetail instance);
    partial void DeleteDonHangDetail(DonHangDetail instance);
    #endregion
		
		public MyDataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TourDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Tour> Tours
		{
			get
			{
				return this.GetTable<Tour>();
			}
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<DonHangDetail> DonHangDetails
		{
			get
			{
				return this.GetTable<DonHangDetail>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tour")]
	public partial class Tour : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaTour;
		
		private string _TenTour;
		
		private string _Hinh;
		
		private System.Nullable<decimal> _Gia;
		
		private string _NgayKhoiHanh;
		
		private string _PhuongTien;
		
		private string _SoNgayDi;
		
		private System.Nullable<int> _Hotel_TieuChuan;
		
		private System.Nullable<decimal> _GiaNguoiLon;
		
		private System.Nullable<decimal> _GiaTreEm;
		
		private string _GhiChu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTourChanging(int value);
    partial void OnMaTourChanged();
    partial void OnTenTourChanging(string value);
    partial void OnTenTourChanged();
    partial void OnHinhChanging(string value);
    partial void OnHinhChanged();
    partial void OnGiaChanging(System.Nullable<decimal> value);
    partial void OnGiaChanged();
    partial void OnNgayKhoiHanhChanging(string value);
    partial void OnNgayKhoiHanhChanged();
    partial void OnPhuongTienChanging(string value);
    partial void OnPhuongTienChanged();
    partial void OnSoNgayDiChanging(string value);
    partial void OnSoNgayDiChanged();
    partial void OnHotel_TieuChuanChanging(System.Nullable<int> value);
    partial void OnHotel_TieuChuanChanged();
    partial void OnGiaNguoiLonChanging(System.Nullable<decimal> value);
    partial void OnGiaNguoiLonChanged();
    partial void OnGiaTreEmChanging(System.Nullable<decimal> value);
    partial void OnGiaTreEmChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    #endregion
		
		public Tour()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTour", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaTour
		{
			get
			{
				return this._MaTour;
			}
			set
			{
				if ((this._MaTour != value))
				{
					this.OnMaTourChanging(value);
					this.SendPropertyChanging();
					this._MaTour = value;
					this.SendPropertyChanged("MaTour");
					this.OnMaTourChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTour", DbType="NVarChar(50)")]
		public string TenTour
		{
			get
			{
				return this._TenTour;
			}
			set
			{
				if ((this._TenTour != value))
				{
					this.OnTenTourChanging(value);
					this.SendPropertyChanging();
					this._TenTour = value;
					this.SendPropertyChanged("TenTour");
					this.OnTenTourChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hinh", DbType="NVarChar(50)")]
		public string Hinh
		{
			get
			{
				return this._Hinh;
			}
			set
			{
				if ((this._Hinh != value))
				{
					this.OnHinhChanging(value);
					this.SendPropertyChanging();
					this._Hinh = value;
					this.SendPropertyChanged("Hinh");
					this.OnHinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this.OnGiaChanging(value);
					this.SendPropertyChanging();
					this._Gia = value;
					this.SendPropertyChanged("Gia");
					this.OnGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayKhoiHanh", DbType="NVarChar(50)")]
		public string NgayKhoiHanh
		{
			get
			{
				return this._NgayKhoiHanh;
			}
			set
			{
				if ((this._NgayKhoiHanh != value))
				{
					this.OnNgayKhoiHanhChanging(value);
					this.SendPropertyChanging();
					this._NgayKhoiHanh = value;
					this.SendPropertyChanged("NgayKhoiHanh");
					this.OnNgayKhoiHanhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhuongTien", DbType="NVarChar(50)")]
		public string PhuongTien
		{
			get
			{
				return this._PhuongTien;
			}
			set
			{
				if ((this._PhuongTien != value))
				{
					this.OnPhuongTienChanging(value);
					this.SendPropertyChanging();
					this._PhuongTien = value;
					this.SendPropertyChanged("PhuongTien");
					this.OnPhuongTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoNgayDi", DbType="NVarChar(50)")]
		public string SoNgayDi
		{
			get
			{
				return this._SoNgayDi;
			}
			set
			{
				if ((this._SoNgayDi != value))
				{
					this.OnSoNgayDiChanging(value);
					this.SendPropertyChanging();
					this._SoNgayDi = value;
					this.SendPropertyChanged("SoNgayDi");
					this.OnSoNgayDiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hotel_TieuChuan", DbType="Int")]
		public System.Nullable<int> Hotel_TieuChuan
		{
			get
			{
				return this._Hotel_TieuChuan;
			}
			set
			{
				if ((this._Hotel_TieuChuan != value))
				{
					this.OnHotel_TieuChuanChanging(value);
					this.SendPropertyChanging();
					this._Hotel_TieuChuan = value;
					this.SendPropertyChanged("Hotel_TieuChuan");
					this.OnHotel_TieuChuanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaNguoiLon", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> GiaNguoiLon
		{
			get
			{
				return this._GiaNguoiLon;
			}
			set
			{
				if ((this._GiaNguoiLon != value))
				{
					this.OnGiaNguoiLonChanging(value);
					this.SendPropertyChanging();
					this._GiaNguoiLon = value;
					this.SendPropertyChanged("GiaNguoiLon");
					this.OnGiaNguoiLonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaTreEm", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> GiaTreEm
		{
			get
			{
				return this._GiaTreEm;
			}
			set
			{
				if ((this._GiaTreEm != value))
				{
					this.OnGiaTreEmChanging(value);
					this.SendPropertyChanging();
					this._GiaTreEm = value;
					this.SendPropertyChanged("GiaTreEm");
					this.OnGiaTreEmChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(50)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this.OnGhiChuChanging(value);
					this.SendPropertyChanging();
					this._GhiChu = value;
					this.SendPropertyChanged("GhiChu");
					this.OnGhiChuChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKH;
		
		private string _HoTen;
		
		private string _Email;
		
		private string _DiaChi;
		
		private string _SDT;
		
		private string _TenDangNhap;
		
		private string _MatKhau;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnTenDangNhapChanging(string value);
    partial void OnTenDangNhapChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    #endregion
		
		public KhachHang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(100)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDangNhap", DbType="NVarChar(50)")]
		public string TenDangNhap
		{
			get
			{
				return this._TenDangNhap;
			}
			set
			{
				if ((this._TenDangNhap != value))
				{
					this.OnTenDangNhapChanging(value);
					this.SendPropertyChanging();
					this._TenDangNhap = value;
					this.SendPropertyChanged("TenDangNhap");
					this.OnTenDangNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="VarChar(50)")]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DonHangDetail")]
	public partial class DonHangDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDon;
		
		private int _MaTour;
		
		private System.Nullable<decimal> _TongGia;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDonChanging(int value);
    partial void OnMaDonChanged();
    partial void OnMaTourChanging(int value);
    partial void OnMaTourChanged();
    partial void OnTongGiaChanging(System.Nullable<decimal> value);
    partial void OnTongGiaChanged();
    #endregion
		
		public DonHangDetail()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDon", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaDon
		{
			get
			{
				return this._MaDon;
			}
			set
			{
				if ((this._MaDon != value))
				{
					this.OnMaDonChanging(value);
					this.SendPropertyChanging();
					this._MaDon = value;
					this.SendPropertyChanged("MaDon");
					this.OnMaDonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTour", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaTour
		{
			get
			{
				return this._MaTour;
			}
			set
			{
				if ((this._MaTour != value))
				{
					this.OnMaTourChanging(value);
					this.SendPropertyChanging();
					this._MaTour = value;
					this.SendPropertyChanged("MaTour");
					this.OnMaTourChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongGia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> TongGia
		{
			get
			{
				return this._TongGia;
			}
			set
			{
				if ((this._TongGia != value))
				{
					this.OnTongGiaChanging(value);
					this.SendPropertyChanging();
					this._TongGia = value;
					this.SendPropertyChanged("TongGia");
					this.OnTongGiaChanged();
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
