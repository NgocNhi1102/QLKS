using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ChiTietDatPhongDAO
    {
        HotelDataContext htDataContext = new HotelDataContext();

        //Đếm tất cả các phần tử có trong bảng
        public int CountListctdp()
        {
            var query = (from ctdp in htDataContext.chitietdatphongs select ctdp).Count();
            return query;
        }

        //Lấy danh sách tất cả các CTDP
        public IList<ChiTietDatPhongDTO> getListChiTietDatPhongAll()
        {
            var query = (from ctdp in htDataContext.chitietdatphongs
                         orderby ctdp.maphieudat descending

                         select new ChiTietDatPhongDTO
                         {
                             Maphieudat = ctdp.maphieudat,
                             Maphong = ctdp.maphong,
                         }).Distinct<ChiTietDatPhongDTO>();
            return query.ToList<ChiTietDatPhongDTO>();
        }

        //Lấy danh sách tất cả CTDP lần lấy 10 phần tử
        public IList<ChiTietDatPhongDTO> getListChiTietDatPhongLMAll(int a)
        {
            var query = (from ctdp in htDataContext.chitietdatphongs
                         orderby ctdp.maphieudat descending

                         select new ChiTietDatPhongDTO
                         {
                             Maphieudat = ctdp.maphieudat,
                             Maphong = ctdp.maphong,
                         }).Distinct<ChiTietDatPhongDTO>();

            query = query.Skip(a).Take(LoginDAO.limitList);
            return query.ToList<ChiTietDatPhongDTO>();
        }

        //Danh sách các CTDP có mã phiếu đặt được nhập vào
        public IList<ChiTietDatPhongDTO> getChiTietDatPhongByID(string id)
        {
            var querry = (from ctdp in htDataContext.chitietdatphongs
                          where ctdp.maphieudat == id
                          select new ChiTietDatPhongDTO
                          {
                              Maphieudat = ctdp.maphieudat,
                              Maphong = ctdp.maphong,
                          }).Distinct<ChiTietDatPhongDTO>();
            return querry.ToList<ChiTietDatPhongDTO>();
        }

        //Lấy danh sách tất cả các CTDP có tên được nhập vào
        public IList<ChiTietDatPhongDTO> getListChiTietDatPhongByName(string name)
        {
            var querry = (from ctdp in htDataContext.chitietdatphongs
                          where ctdp.maphong == name
                          select new ChiTietDatPhongDTO
                          {
                              Maphieudat = ctdp.maphieudat,
                              Maphong = ctdp.maphong,
                          }).Distinct<ChiTietDatPhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<ChiTietDatPhongDTO>();
            }
        }

        //Danh sách gần đúng các CTDP  có mã được nhập vào
        public IList<ChiTietDatPhongDTO> getLikeChiTietDatPhongByID(string id)
        {
            var querry = (from ctdp in htDataContext.chitietdatphongs
                          where SqlMethods.Like(ctdp.maphieudat, "%" + id + "%")
                          select new ChiTietDatPhongDTO
                          {
                              Maphieudat = ctdp.maphieudat,
                              Maphong = ctdp.maphong,
                          }).Distinct<ChiTietDatPhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<ChiTietDatPhongDTO>();
            }
        }

        //Lấy danh sách gần đúng tất cả CTDP có tên được nhập vào
        public IList<ChiTietDatPhongDTO> getListLikeChiTietDatPhongByName(string name)
        {
            var querry = (from ctdp in htDataContext.chitietdatphongs
                          where SqlMethods.Like(ctdp.maphong, "%" + name + "%")
                          select new ChiTietDatPhongDTO
                          {
                              Maphieudat = ctdp.maphieudat,
                              Maphong = ctdp.maphong,
                          }).Distinct<ChiTietDatPhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<ChiTietDatPhongDTO>();
            }
        }

        //Thêm 
        public void insertChiTietDatPhong(ChiTietDatPhongDTO ctdpDTO)
        {
            chitietdatphong ctdp = new chitietdatphong();
            ctdp.maphieudat = ctdpDTO.Maphieudat;
            ctdp.maphong = ctdpDTO.Maphong;
            htDataContext.chitietdatphongs.InsertOnSubmit(ctdp);
            htDataContext.SubmitChanges();
        }

        //Xóa
        public void deleteChiTietDatPhong(string IDChiTietDatPhong)
        {
            IEnumerable<chitietdatphong> querry = from ctdp in htDataContext.chitietdatphongs
                                                  where ctdp.maphieudat == IDChiTietDatPhong
                                                  select ctdp;
            foreach (chitietdatphong ct in querry)
            {
                htDataContext.chitietdatphongs.DeleteOnSubmit(ct);
            }
            htDataContext.SubmitChanges();
        }

        //Sửa 
        public void updateChiTietDatPhong(ChiTietDatPhongDTO ctdpDTO)
        {
            var querry = (from ctdp in htDataContext.chitietdatphongs
                          where ctdp.maphieudat == ctdpDTO.Maphieudat
                          select ctdp).FirstOrDefault<chitietdatphong>();
            querry.maphieudat = ctdpDTO.Maphieudat;
            querry.maphong = ctdpDTO.Maphong;
            htDataContext.SubmitChanges();
        }
    }
}
