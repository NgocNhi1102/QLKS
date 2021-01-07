using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class KiemTraPhongDAO
    {
        HotelDataContext htDataContext = new HotelDataContext();
        ArrayList a = new ArrayList();
        public ArrayList KiemTraPhong(DateTime ngayden, DateTime ngaydi)
        {
            var listd = htDataContext.kiemtraphong(ngayden, ngaydi);
            a.Clear();
            foreach (kiemtraphongResult kt in listd)
            {

                KiemTraPhongDTO ktp = new KiemTraPhongDTO();
                ktp.Maphieudat = kt.maphieudat;
                ktp.Maphong = kt.maphong;
                ktp.Ngayden = kt.ngayden.Value;
                ktp.Ngaydi = kt.ngaydi.Value;
                ktp.Tinhtrang = kt.tinhtrang;
                a.Add(ktp);
            }
            return a;
        }
    }
}
