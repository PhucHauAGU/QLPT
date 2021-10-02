using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Khu_DTO
    {
        private string sMaKhu;

        public string SMaKhu
        {
            get { return sMaKhu; }
            set { sMaKhu = value; }
        }
        private string sTenKhu;

        public string STenKhu
        {
            get { return sTenKhu; }
            set { sTenKhu = value; }
        }
        private int iSoPhong;

        public int ISoPhong
        {
            get { return iSoPhong; }
            set { iSoPhong = value; }
        }
    }
}
