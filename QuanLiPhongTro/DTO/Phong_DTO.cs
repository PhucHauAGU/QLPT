using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Phong_DTO
    {
        private string sMaPhong;

        public string SMaPhong
        {
            get { return sMaPhong; }
            set { sMaPhong = value; }
        }
        private string sMaKhu;

        public string SMaKhu
        {
            get { return sMaKhu; }
            set { sMaKhu = value; }
        }
        private int iSoLuong;

        public int ISoLuong
        {
            get { return iSoLuong; }
            set { iSoLuong = value; }
        }
        private int iSoLuongToiDa;

        public int ISoLuongToiDa
        {
            get { return iSoLuongToiDa; }
            set { iSoLuongToiDa = value; }
        }
    }
}
