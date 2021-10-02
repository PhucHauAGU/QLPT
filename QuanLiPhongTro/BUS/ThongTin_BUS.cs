using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class ThongTin_BUS
    {
        //Lấy DS nhân viên
        public static List<ThongTin_DTO> LayThongTin()
        {
            return ThongTin_DAO.LayThongTin();
        }

        //Lấy DS nhân viên theo chức vụ
        public static List<ThongTin_DTO> LayThongTinTheoPhong(string maphong)
        {
            return ThongTin_DAO.LayThongTinTheoPhong(maphong);
        }
        public static List<Phong_DTO> LayDSPhongTheoKhu(string makhu)
        {
            return Phong_DAO.LayDSPhongTheoKhu(makhu);
        }

        //Lấy DS nhân viên theo họ và tên
        public static List<ThongTin_DTO> TimTheoHoTen(string hoten)
        {
            return ThongTin_DAO.TimTheoHoTen(hoten);
        }

        
        //Lấy một nhân viên theo mã
        public static ThongTin_DTO TimTheoMa(string maso)
        {
            return ThongTin_DAO.TimTheoMa(maso);
        }
        


        //Thêm 1 nhân viên
        public static bool ThemThongTin(ThongTin_DTO tt)
        {
            return ThongTin_DAO.ThemThongTin(tt);
        }

        //Sửa 1 nhân viên
        public static bool SuaThongTin(ThongTin_DTO tt)
        {
            return ThongTin_DAO.SuaThongTin(tt);
        }

        //Xóa 1 nhân viên
        public static bool XoaThongTin(ThongTin_DTO nv)
        {
            return ThongTin_DAO.XoaThongTin(nv);
        }
        public static bool ChuyenPhong(string maso, string maphongcanchuyen, string makhucanchuyen)
        {
            return ThongTin_DAO.ChuyenPhong(maso, maphongcanchuyen, makhucanchuyen);
        }
        public static bool CongSoLuong(string maphong)
        {
            return ThongTin_DAO.CongSoLuong(maphong);
        }
        public static bool TruSoLuong(string maphong)
        {
            return ThongTin_DAO.TruSoLuong(maphong);
        }
    }
}
