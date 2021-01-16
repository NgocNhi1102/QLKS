using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class InHoaDonDichVuBUS
    {

        InHoaDonDichVuDAO ihddv = new InHoaDonDichVuDAO();
        public ArrayList InHoaDonDivhVu(string mahoadon)
        {
            return ihddv.inhoadondv(mahoadon);
        }
    }
}
