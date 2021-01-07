using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class KiemTraPhongBUS
    {
     
            KiemTraPhongDAO ktpDAO = new KiemTraPhongDAO();
            public ArrayList KiemTraPhong(DateTime ngayden, DateTime ngaydi)
            {
                return ktpDAO.KiemTraPhong(ngayden, ngaydi);
            }
        
    }
}
