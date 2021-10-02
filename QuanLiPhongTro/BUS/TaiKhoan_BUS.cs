using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Security.Cryptography;

namespace BUS
{
   public class TaiKhoan_BUS
    {
        public static TaiKhoan_DTO LayTaiKhoan(string ten, string matkhau)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = TaiKhoan_BUS.GetMd5Hash(md5Hash, matkhau);
            return TaiKhoan_DAO.LayTaiKhoan(ten, matkhauMH);
        }


        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();

        }
        public static bool DoiMatKhau(TaiKhoan_DTO tk, string matkhaumoi)
        {
            MD5 md5Hash = MD5.Create();
            string matkhau_mahoa = GetMd5Hash(md5Hash, matkhaumoi);
            tk.SMatKhau = matkhau_mahoa;
            return TaiKhoan_DAO.CapNhatNguoiDung(tk);
        }
    }
}
