using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class InHoaDonPhongBUS
    {
        InHoaDonPhongDAO hdDAO = new InHoaDonPhongDAO();
        public ArrayList InHoaDonPhong(string mahoadon)
        {
            return hdDAO.InHoaDonPhong(mahoadon);
        }
    }
}
