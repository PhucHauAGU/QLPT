using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class HoaDon_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả thoong tin
        public static List<HoaDon_DTO> LayHoaDon()
        {
            string sTruyVan = "select * from hoadon";
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lstHoaDon = new List<DTO.HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO tt = new HoaDon_DTO();
                tt.SMaHoaDon = dt.Rows[i]["mahoadon"].ToString();
                tt.SMaPhong = dt.Rows[i]["maphong"].ToString();
                tt.ITienDien = Int32.Parse(dt.Rows[i]["tiendien"].ToString());
                tt.ITienNuoc = Int32.Parse(dt.Rows[i]["tiennuoc"].ToString());
                tt.ITienPhong = Int32.Parse(dt.Rows[i]["tienphong"].ToString());
                tt.IThanhTien = Int32.Parse(dt.Rows[i]["thanhtien"].ToString());
                tt.STrangThai = dt.Rows[i]["trangthai"].ToString();
                lstHoaDon.Add(tt);
            }
            Dataprovider.DongKetNoi(con);
            return lstHoaDon;
        }
        public static List<HoaDon_DTO> LayDSHoaDonTheoPhong(string maphong)
        {
            string sTruyVan = "select * from hoadon where maphong='" + maphong + "'";
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lstHoaDon = new List<DTO.HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO tt = new HoaDon_DTO();
                tt.SMaHoaDon = dt.Rows[i]["mahoadon"].ToString();
                tt.SMaPhong = dt.Rows[i]["maphong"].ToString();
                tt.ITienDien = Int32.Parse(dt.Rows[i]["tiendien"].ToString());
                tt.ITienNuoc = Int32.Parse(dt.Rows[i]["tiennuoc"].ToString());
                tt.ITienPhong = Int32.Parse(dt.Rows[i]["tienphong"].ToString());
                tt.IThanhTien = Int32.Parse(dt.Rows[i]["thanhtien"].ToString());
                tt.STrangThai = dt.Rows[i]["trangthai"].ToString();
                lstHoaDon.Add(tt);
            }
            Dataprovider.DongKetNoi(con);
            return lstHoaDon;
        }


       
        // Tìm ds nhân viên theo họ và tên, trả về null nếu không thấy
        public static List<HoaDon_DTO> TimKiemTheoMa(string maso)
        {
            string sTruyVan = string.Format(@"select * from hoadon where mahoadon like '%{0}%'", maso);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<HoaDon_DTO> lstHoaDon = new List<DTO.HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO tt = new HoaDon_DTO();
                tt.SMaHoaDon = dt.Rows[i]["mahoadon"].ToString();
                tt.SMaPhong = dt.Rows[i]["maphong"].ToString();
                tt.ITienDien = Int32.Parse(dt.Rows[i]["tiendien"].ToString());
                tt.ITienNuoc = Int32.Parse(dt.Rows[i]["tiennuoc"].ToString());
                tt.ITienPhong = Int32.Parse(dt.Rows[i]["tienphong"].ToString());
                tt.IThanhTien = Int32.Parse(dt.Rows[i]["thanhtien"].ToString());
                tt.STrangThai = dt.Rows[i]["trangthai"].ToString();
                lstHoaDon.Add(tt);
            }
            Dataprovider.DongKetNoi(con);
            return lstHoaDon;
        }

        // Lấy thông tin nhân viên có mã ma, trả về null nếu không thấy
        public static HoaDon_DTO TimTheoMa(string maso)
        {
            string sTruyVan = string.Format(@"select * from hoadon where mahoadon=N'{0}'", maso);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            HoaDon_DTO tt = new HoaDon_DTO();
            tt.SMaHoaDon = dt.Rows[0]["mahoadon"].ToString();
            tt.SMaPhong = dt.Rows[0]["maphong"].ToString();
            tt.ITienDien = Int32.Parse(dt.Rows[0]["tiendien"].ToString());
            tt.ITienNuoc = Int32.Parse(dt.Rows[0]["tiennuoc"].ToString());
            tt.ITienPhong = Int32.Parse(dt.Rows[0]["tienphong"].ToString());
            tt.IThanhTien = Int32.Parse(dt.Rows[0]["thanhtien"].ToString());
            tt.STrangThai = dt.Rows[0]["trangthai"].ToString();

            Dataprovider.DongKetNoi(con);
            return tt;
        }


        // Thêm nhân viên
        public static bool ThemHoaDon(HoaDon_DTO tt)
        {
            string sTruyVan = string.Format(@"insert into hoadon values(N'{0}',N'{1}',N'{2}',N'{3}','{4}',N'{5}',N'{6}')", tt.SMaHoaDon, tt.SMaPhong, tt.ITienDien, tt.ITienNuoc, tt.ITienPhong, tt.IThanhTien, tt.STrangThai);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;


        }

        // Sửa nhân viên
        public static bool SuaHoaDon(HoaDon_DTO tt)
        {
            string sTruyVan = string.Format(@"update hoadon set maphong=N'{0}',tiendien=N'{1}',tiennuoc=N'{2}',tienphong='{3}',thanhtien=N'{4}',trangthai=N'{5}' where mahoadon=N'{6}'", tt.SMaPhong, tt.ITienDien, tt.ITienNuoc, tt.ITienPhong, tt.IThanhTien, tt.STrangThai,  tt.SMaHoaDon);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;

        }

        // Xóa nhân viên
        public static bool XoaHoaDon(HoaDon_DTO tt)
        {
            string sTruyVan = string.Format(@"delete from hoadon where mahoadon=N'{0}'", tt.SMaHoaDon);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
       
    }
}
