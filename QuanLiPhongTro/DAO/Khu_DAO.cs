using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class Khu_DAO
    {
        static SqlConnection con;
        public static List<Khu_DTO> LayKhu()
        {
            string sTruyVan = "select * from khu";
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Khu_DTO> lstKhu = new List<Khu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Khu_DTO k = new Khu_DTO();
                k.SMaKhu = dt.Rows[i]["makhu"].ToString();
                k.STenKhu = dt.Rows[i]["tenkhu"].ToString();
                k.ISoPhong = Int32.Parse(dt.Rows[i]["sophong"].ToString());
                lstKhu.Add(k);
            }
            Dataprovider.DongKetNoi(con);
            return lstKhu;
        }

        // lấy tên chức vụ theo mã
        public static string LayTenKhuTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select tenkhu from khu where makhu=N'{0}'", ma);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                Dataprovider.DongKetNoi(con);
                return null;
            }

            Dataprovider.DongKetNoi(con);
            return dt.Rows[0]["tenkhu"].ToString();
        }

        public static Khu_DTO TimKhuTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from khu where makhu=N'{0}'", ma);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Khu_DTO k = new Khu_DTO();
            k.SMaKhu = dt.Rows[0]["makhu"].ToString();
            k.STenKhu = dt.Rows[0]["tenkhu"].ToString();
            k.ISoPhong = Int32.Parse(dt.Rows[0]["sophong"].ToString());
            

            Dataprovider.DongKetNoi(con);
            return k;
        }
        // Thêm Khu
        public static bool ThemKhu(Khu_DTO k)
        {
            string sTruyVan = string.Format(@"insert into khu values(N'{0}',N'{1}',N'{2}')", k.SMaKhu, k.STenKhu, k.ISoPhong);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
            

        }

        // Sửa nhân viên
        public static bool SuaKhu(Khu_DTO k)
        {
            string sTruyVan = string.Format(@"update khu set tenkhu=N'{0}',sophong=N'{1}' where makhu=N'{2}'", k.STenKhu, k.ISoPhong, k.SMaKhu);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;

        }

        // Xóa nhân viên
        public static bool XoaKhu(Khu_DTO k)
        {
            string sTruyVan = string.Format(@"delete from khu where makhu=N'{0}'", k.SMaKhu);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
    }
}
