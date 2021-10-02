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
     public class Phong_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả nhân viên
        public static List<Phong_DTO> LayDSPhong()
        {
            string sTruyVan = "select * from phong";
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
        public static List<Phong_DTO> LayDSPhongChuaFullTheoKhu(string makhu)
        {
            string sTruyVan = "select * from phong where makhu='" + makhu + "' and soluong < soluongtoida";
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
       
      
       
        // Lấy thông tin nhân viên có mã ma, trả về null nếu không thấy
        public static Phong_DTO TimPhongTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from phong where maphong=N'{0}'", ma);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Phong_DTO p = new Phong_DTO();
            p.SMaPhong = dt.Rows[0]["maphong"].ToString();
            p.SMaKhu = dt.Rows[0]["makhu"].ToString();
            p.ISoLuong = Int32.Parse(dt.Rows[0]["soluong"].ToString());
            p.ISoLuongToiDa = Int32.Parse(dt.Rows[0]["soluongtoida"].ToString());
       
            Dataprovider.DongKetNoi(con);
            return p;
        }

        // Thêm nhân viên
        public static bool ThemPhong(Phong_DTO p)
        {
            string sTruyVan = string.Format(@"insert into phong values(N'{0}',N'{1}',N'{2}',N'{3}')", p.SMaPhong, p.SMaKhu, p.ISoLuong, p.ISoLuongToiDa);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
         

        }

        // Xóa nhân viên
        public static bool XoaPhong(Phong_DTO nv)
        {
            string sTruyVan = string.Format(@"delete from phong where maphong=N'{0}'", nv.SMaPhong);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
        public static List<Phong_DTO> LaySoLuongPhongTrong()
        {
            string sTruyVan = "select * from phong where soluong=0";
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
     
    }
}
