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
   public class TaiKhoan_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả nhân viên
        public static TaiKhoan_DTO LayTaiKhoan(string ten, string matkhau)
        {
            string sTruyVan = string.Format(@"select * from taikhoan where ten = '{0}' and matkhau ='{1}'", ten, matkhau);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.STen = dt.Rows[0]["ten"].ToString();
            tk.SMatKhau = dt.Rows[0]["matkhau"].ToString();
            tk.IQuyen = int.Parse(dt.Rows[0]["quyen"].ToString());

            Dataprovider.DongKetNoi(con);
            return tk;

        }
        public static bool CapNhatNguoiDung(TaiKhoan_DTO tk)
        {
            string sql = string.Format(@"update taikhoan set matkhau='{0}' where ten='{1}'", tk.SMatKhau, tk.STen);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(sql, con);
            return kq;
        }
    }
}
