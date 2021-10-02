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
    public class ThongTin_DAO
    {
         static SqlConnection con;

        // Lấy danh sách tất cả thoong tin
        public static List<ThongTin_DTO>  LayThongTin() {
            string sTruyVan = "select * from thongtin";
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ThongTin_DTO> lstThongTin = new List<DTO.ThongTin_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThongTin_DTO tt = new ThongTin_DTO();
                tt.SMaSo  = dt.Rows[i]["maso"].ToString();
                tt.SHoTen  = dt.Rows[i]["hoten"].ToString();
                tt.INamSinh = Int32.Parse(dt.Rows[i]["namsinh"].ToString());
                tt.SGioiTinh = dt.Rows[i]["gioitinh"].ToString();
                tt.SCMND = dt.Rows[i]["cmnd"].ToString();
                tt.SNguyenQuan = dt.Rows[i]["nguyenquan"].ToString();
                tt.SDienThoai = dt.Rows[i]["dienthoai"].ToString();
                tt.SMaKhu = dt.Rows[i]["makhu"].ToString();
                tt.SMaPhong = dt.Rows[i]["maphong"].ToString();
                lstThongTin.Add(tt);
            }
            Dataprovider.DongKetNoi(con);
            return lstThongTin;
        }
        public static List<Phong_DTO> LayDSPhongTheoKhu(string makhu)
        {
            string sTruyVan = "select * from phong where makhu='" + makhu + "'";
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> lstPhong = new List<DTO.Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO p = new Phong_DTO();
                p.SMaPhong = dt.Rows[i]["maphong"].ToString();
                p.SMaKhu = dt.Rows[i]["makhu"].ToString();
                p.ISoLuong = Int32.Parse(dt.Rows[i]["soluong"].ToString());
                p.ISoLuongToiDa = Int32.Parse(dt.Rows[i]["soluongtoida"].ToString());

                lstPhong.Add(p);
            }
            Dataprovider.DongKetNoi(con);
            return lstPhong;
        }


        // Lấy danh sách tất cả nhân viên theo chức vụ
        public static List<ThongTin_DTO> LayThongTinTheoPhong(string maphong)
        {
            string sTruyVan = "select * from thongtin where maphong ='" + maphong + "'";
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ThongTin_DTO> lstThongTin = new List<DTO.ThongTin_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThongTin_DTO tt = new ThongTin_DTO();
                tt.SMaSo = dt.Rows[i]["maso"].ToString();
                tt.SHoTen = dt.Rows[i]["hoten"].ToString();
                tt.INamSinh = Int32.Parse(dt.Rows[i]["namsinh"].ToString());
                tt.SGioiTinh = dt.Rows[i]["gioitinh"].ToString();
                tt.SCMND = dt.Rows[i]["cmnd"].ToString();
                tt.SNguyenQuan = dt.Rows[i]["nguyenquan"].ToString();
                tt.SDienThoai = dt.Rows[i]["dienthoai"].ToString();
                tt.SMaKhu = dt.Rows[i]["makhu"].ToString();
                tt.SMaPhong = dt.Rows[i]["maphong"].ToString();
                lstThongTin.Add(tt);
            }
            Dataprovider.DongKetNoi(con);
            return lstThongTin;
        }
        // Tìm ds nhân viên theo họ và tên, trả về null nếu không thấy
        public static List<ThongTin_DTO> TimTheoHoTen(string maso)
        {
            string sTruyVan = string.Format(@"select * from thongtin where maso like '%{0}%'", maso);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<ThongTin_DTO> lstThongTin = new List<DTO.ThongTin_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThongTin_DTO tt = new ThongTin_DTO();
                tt.SMaSo = dt.Rows[i]["maso"].ToString();
                tt.SHoTen = dt.Rows[i]["hoten"].ToString();
                tt.INamSinh = Int32.Parse(dt.Rows[i]["namsinh"].ToString());
                tt.SGioiTinh = dt.Rows[i]["gioitinh"].ToString();
                tt.SCMND = dt.Rows[i]["cmnd"].ToString();
                tt.SNguyenQuan = dt.Rows[i]["nguyenquan"].ToString();
                tt.SDienThoai = dt.Rows[i]["dienthoai"].ToString();
                tt.SMaKhu = dt.Rows[i]["makhu"].ToString();
                tt.SMaPhong = dt.Rows[i]["maphong"].ToString();
                lstThongTin.Add(tt);
            }
            Dataprovider.DongKetNoi(con);
            return lstThongTin;
        }
      
        // Lấy thông tin nhân viên có mã ma, trả về null nếu không thấy
        public static ThongTin_DTO TimTheoMa(string maso)
        {
            string sTruyVan = string.Format(@"select * from thongtin where maso=N'{0}'", maso);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            ThongTin_DTO tt = new ThongTin_DTO();
            tt.SMaSo = dt.Rows[0]["maso"].ToString();
            tt.SHoTen = dt.Rows[0]["hoten"].ToString();
            tt.INamSinh = Int32.Parse(dt.Rows[0]["namsinh"].ToString());
            tt.SGioiTinh = dt.Rows[0]["gioitinh"].ToString();
            tt.SCMND = dt.Rows[0]["cmnd"].ToString();
            tt.SNguyenQuan = dt.Rows[0]["nguyenquan"].ToString();
            tt.SDienThoai = dt.Rows[0]["dienthoai"].ToString();
            tt.SMaKhu = dt.Rows[0]["makhu"].ToString();
            tt.SMaPhong = dt.Rows[0]["maphong"].ToString();

            Dataprovider.DongKetNoi(con);
            return tt;
        }
        

        // Thêm nhân viên
        public static bool ThemThongTin(ThongTin_DTO tt)
        {
            string sTruyVan = string.Format(@"insert into thongtin values(N'{0}',N'{1}',N'{2}',N'{3}','{4}',N'{5}',N'{6}',N'{7}',N'{8}')", tt.SMaSo, tt.SHoTen, tt.INamSinh, tt.SGioiTinh, tt.SCMND, tt.SNguyenQuan, tt.SDienThoai, tt.SMaKhu, tt.SMaPhong);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
          

        }

        // Sửa nhân viên
        public static bool SuaThongTin(ThongTin_DTO tt)
        {
            string sTruyVan = string.Format(@"update thongtin set hoten=N'{0}',namsinh=N'{1}',gioitinh=N'{2}',cmnd='{3}',nguyenquan=N'{4}',dienthoai=N'{5}',makhu=N'{6}',maphong=N'{7}' where maso=N'{8}'", tt.SHoTen, tt.INamSinh, tt.SGioiTinh, tt.SCMND, tt.SNguyenQuan, tt.SDienThoai, tt.SMaKhu, tt.SMaPhong, tt.SMaSo);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;

        }

        // Xóa nhân viên
        public static bool XoaThongTin(ThongTin_DTO tt)
        {
            string sTruyVan = string.Format(@"delete from thongtin where maso=N'{0}'", tt.SMaSo);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
        public static bool ChuyenPhong(string maso, string maphongcanchuyen, string makhucanchuyen)
        {
            string sTruyVan = string.Format(@"update thongtin set maphong=N'{0}',makhu=N'{1}' where maso=N'{2}'", maphongcanchuyen, makhucanchuyen,maso);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
        public static bool CongSoLuong(string maphong)
        {
            string sTruyVan = string.Format(@"update phong set soluong=soluong+1 where maphong=N'{0}'",  maphong);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
        public static bool TruSoLuong(string maphong)
        {
            string sTruyVan = string.Format(@"update phong set soluong=soluong-1 where maphong=N'{0}'", maphong);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
       
    }
}
