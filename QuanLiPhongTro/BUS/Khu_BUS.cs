using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class Khu_BUS
    {
        public static List<Khu_DTO> LayKhu()
        {
            return Khu_DAO.LayKhu();
        }
        public static string LayTenKhuTheoMa(string ma)
        {
            return Khu_DAO.LayTenKhuTheoMa(ma);
        }
        public static bool ThemKhu(Khu_DTO k)
        {
            return Khu_DAO.ThemKhu(k);
        }

        //Sửa 1 nhân viên
        public static bool SuaKhu(Khu_DTO k)
        {
            return Khu_DAO.SuaKhu(k);
        }

        //Xóa 1 nhân viên
        public static bool XoaKhu(Khu_DTO k)
        {
            return Khu_DAO.XoaKhu(k);
        }
        public static Khu_DTO TimKhuTheoMa(string ma)
        {
            return Khu_DAO.TimKhuTheoMa(ma);
        }
    }
}
