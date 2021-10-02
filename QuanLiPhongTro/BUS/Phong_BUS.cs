using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class Phong_BUS
    {
        public static List<Phong_DTO> LayDSPhong()
        {
            return Phong_DAO.LayDSPhong();
        }
        public static List<Phong_DTO> LayDSPhongTrong()
        {
            return Phong_DAO.LaySoLuongPhongTrong();
        }

        //Lấy DS nhân viên theo chức vụ
        public static List<Phong_DTO> LayDSPhongTheoKhu(string makhu)
        {
            return Phong_DAO.LayDSPhongTheoKhu(makhu);
        }
        public static List<Phong_DTO> LayDSPhongChuaFullTheoKhu(string makhu)
        {
            return Phong_DAO.LayDSPhongChuaFullTheoKhu(makhu);
        }

       

        //Lấy một nhân viên theo mã
        public static Phong_DTO TimPhongTheoMa(string ma)
        {
            return Phong_DAO.TimPhongTheoMa(ma);
        }

        //Thêm 1 nhân viên
        public static bool ThemPhong(Phong_DTO p)
        {
            return Phong_DAO.ThemPhong(p);
        }

     

        //Xóa 1 nhân viên
        public static bool XoaPhong(Phong_DTO p)
        {
            return Phong_DAO.XoaPhong(p);
        }
    }
}
