﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class CSDL_BUS
    {
        public static bool SaoLuu()
        {
            return CSDL_DAO.SaoLuuDuLieu();
        }
        public static  bool PhucHoiDuLieu()
        {
            return CSDL_DAO.PhucHoiDuLieu();
        }
    }
}
