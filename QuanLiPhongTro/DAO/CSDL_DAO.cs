using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class CSDL_DAO
    {
        static SqlConnection con;
        // Backup
        public static bool SaoLuuDuLieu()
        {
            
            string sql = @"backup database QLPT to disk = 'F:\SaoLuu\QLPTbakup.bak' with init,stats = 10";
            con = Dataprovider.MoKetNoi();

            bool kq = Dataprovider.TruyVanKhongLayDuLieu(sql, con);
            return kq;
            
        }

        public static bool PhucHoiDuLieu()
        {
            
            string sql = @"use master restore database QLPT from disk ='F:\SaoLuu\QLPTbakup.bak' with replace";
            con = Dataprovider.MoKetNoi();
            
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(sql, con);
            return kq;
        }
    }
}
