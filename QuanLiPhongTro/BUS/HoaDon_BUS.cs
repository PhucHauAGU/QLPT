using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class HoaDon_BUS
    {
        //Lấy DS nhân viên
        public static List<HoaDon_DTO> LayHoaDon()
        {
            return HoaDon_DAO.LayHoaDon();
        }

        //Lấy DS nhân viên theo chức vụ
        public static List<HoaDon_DTO> LayHoaDonTheoPhong(string maphong)
        {
            return HoaDon_DAO.LayDSHoaDonTheoPhong(maphong);
        }
        

        //Lấy DS nhân viên theo họ và tên
        public static List<HoaDon_DTO> TimKiemTheoMa(string ma)
        {
            return HoaDon_DAO.TimKiemTheoMa(ma);
        }


        //Lấy một nhân viên theo mã
        public static HoaDon_DTO TimTheoMa(string maso)
        {
            return HoaDon_DAO.TimTheoMa(maso);
        }



        //Thêm 1 nhân viên
        public static bool ThemHoaDon(HoaDon_DTO tt)
        {
            return HoaDon_DAO.ThemHoaDon(tt);
        }

        //Sửa 1 nhân viên
        public static bool SuaHoaDon(HoaDon_DTO tt)
        {
            return HoaDon_DAO.SuaHoaDon(tt);
        }

        //Xóa 1 nhân viên
        public static bool XoaHoaDon(HoaDon_DTO nv)
        {
            return HoaDon_DAO.XoaHoaDon(nv);
        }
        
    }
}
