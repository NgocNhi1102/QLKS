using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using DTO;
using BUS;


namespace QLKS
{
    public partial class FormMain : Form
    {
        public FormLogin frmLogin;
        public FormPhong frmPhong;
        public FormDoiMatKhau frmDoimatkhau;
        public FormNhanVien frmNhanVien;


        public int CountList = 5;
        public string m_chucvu = "";
        public string m_username = "";
        public string m_maNV = "";

        PhongBUS pBUS;
        ChiTietDatPhongBUS ctdpBUS;
        PhieuDatPhongBUS pdpBUS;
        PhieuThuePhongBUS ptpBUS;

        private bool num;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            MainNoEnabled();
            frmLogin = new FormLogin();
            frmLogin.frmMain = this;
            frmLogin.ShowDialog();
            if (m_username == "")
            {
                Application.Exit();
            }
            if (m_chucvu == "admin")
            {
                MainEnabled();
            }
            else if (m_chucvu == "Quản lý")
            {
                MainEnQuanLy();
            }
            else
            {
                MainEnNhanVien();
            }
            labUser.Text = "Hi! " + m_username;
            capnhatphong();
        }

        private void DOIMATKHAUtoolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmDoimatkhau = new FormDoiMatKhau();
            frmDoimatkhau.frmMain = this;
            frmDoimatkhau.ShowDialog();
        }

        private void HETHONGtoolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void DANGNHAPtoolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmLogin = new FormLogin();
            frmLogin.frmMain = this;
            frmLogin.ShowDialog();
            if (m_chucvu == "admin")
            {
                MainEnabled();
            }
            else if (m_chucvu == "Quản lý")
            {
                MainEnQuanLy();
            }
            else
            {
                MainEnNhanVien();
            }
        }
        private void MainEnNhanVien()
        {
            QUANLYtoolStripMenuItem2.Enabled = false;
            DOIMATKHAUtoolStripMenuItem8.Enabled = true;
            KHACHHANGgtoolStripMenuItem3.Enabled = true;
            THUEPHONGtoolStripMenuItem4.Enabled = true;
            BAOCAOtoolStripMenuItem5.Enabled = false;
            DANGXUATtoolStripMenuItem7.Enabled = true;
        }

        private void MainEnQuanLy()
        {
            QUANLYtoolStripMenuItem2.Enabled = true;
            DOIMATKHAUtoolStripMenuItem8.Enabled = true;
            KHACHHANGgtoolStripMenuItem3.Enabled = true;
            THUEPHONGtoolStripMenuItem4.Enabled = true;
            BAOCAOtoolStripMenuItem5.Enabled = true;
            DANGXUATtoolStripMenuItem7.Enabled = true;
        }

        private void MainEnabled()
        {
            QUANLYtoolStripMenuItem2.Enabled = true;
            DOIMATKHAUtoolStripMenuItem8.Enabled = true;
            KHACHHANGgtoolStripMenuItem3.Enabled = true;
            THUEPHONGtoolStripMenuItem4.Enabled = true;
           // BAOCAOtoolStripMenuItem5.Enabled = true;
            DANGXUATtoolStripMenuItem7.Enabled = true;
        }
        private void MainNoEnabled()
        {
            QUANLYtoolStripMenuItem2.Enabled = false;
            DOIMATKHAUtoolStripMenuItem8.Enabled = false;
            KHACHHANGgtoolStripMenuItem3.Enabled = false;
            THUEPHONGtoolStripMenuItem4.Enabled = false;
            BAOCAOtoolStripMenuItem5.Enabled = false;
            DANGXUATtoolStripMenuItem7.Enabled = false;
        }

        private void MainNoEnQuanLy(Button bt)
        {
            bt.Enabled = false;
        }

        private void MainNoEnNhanVien()
        {
            QUANLYtoolStripMenuItem2.Enabled = false;
            BAOCAOtoolStripMenuItem5.Enabled = false;
        }
        public string MaHoa(string inputString)
        {
            UnicodeEncoding u = new UnicodeEncoding();
            byte[] bytes = u.GetBytes(inputString); //get original string
            MD5 md = new MD5CryptoServiceProvider(); // using md5 algorithm
            byte[] result = md.ComputeHash(bytes); // encrypted input bytes into encrypted bytes
            return Convert.ToBase64String(result); //return encrypted string
        }

        private void THOATtoolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DANGXUATtoolStripMenuItem7_Click(object sender, EventArgs e)
        {
            MainNoEnabled();
            MessageBox.Show("Bạn vừa đăng xuất thành công!");
        }
        public void KTChiChu(object o, KeyEventArgs e, TextBox txt, ErrorProvider loi)
        {
            if ((e.KeyCode < Keys.A || e.KeyCode > Keys.Z) && (e.KeyCode != Keys.Back) && (e.KeyCode != Keys.Delete) && (e.KeyCode != Keys.ShiftKey) && (e.KeyCode != Keys.Space) && (e.KeyCode != Keys.Enter) && (e.KeyCode != Keys.Control))
            {
                if (e.KeyCode < Keys.A || e.KeyCode > Keys.Z)
                {
                    loi.SetError(txt, "Tên không được nhập số!");
                    num = true;
                }
                else
                {
                    loi.SetError(txt, "");
                }
            }
            else
            {
                loi.SetError(txt, "");
            }
        }
        public void KoNhapSo(object o, KeyPressEventArgs e)
        {
            if (num == true)
                e.Handled = true;
            num = false;
        }
        public void KTChiSo(object o, KeyEventArgs e, TextBox txt, ErrorProvider loi)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad0) && (e.KeyCode != Keys.Back) && (e.KeyCode != Keys.Delete) && (e.KeyCode != Keys.Enter) && (e.KeyCode != Keys.Control))
            {
                if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad0))
                {
                    loi.SetError(txt, "Không được nhập chữ!");
                    num = false;
                }
                else
                {
                    loi.SetError(txt, "");
                }
            }
            else
            {
                loi.SetError(txt, "");
            }
        }
        public void KoNhapChu(object o, KeyPressEventArgs e)
        {
            if (num == false)
                e.Handled = true;
            num = true;
        }

        private void PHONGtoolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmPhong = new FormPhong();
            frmPhong.frmMain = this;
            frmPhong.ShowDialog();
        }

        private void VATTUtoolStripMenuItem11_Click(object sender, EventArgs e)
        {
            FormVatTu frmVT = new FormVatTu();
            frmVT.frmMain = this;
            frmVT.ShowDialog();
        }

        private void NHANVIENtoolStripMenuItem13_Click(object sender, EventArgs e)
        {

            frmNhanVien = new FormNhanVien();
            frmNhanVien.frmMain = this;
            frmNhanVien.ShowDialog();
        }

        private void DICHVUtoolStripMenuItem12_Click(object sender, EventArgs e)
        {
            FormDichVu frmDichVu = new FormDichVu();
            frmDichVu.frmMain = this;
            frmDichVu.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void TTKHACHHANGtoolStripMenuItem15_Click(object sender, EventArgs e)
        {
            FormKhachHang frmKH = new FormKhachHang();
            frmKH.frmMain = this;
            frmKH.ShowDialog();
        }

        private void PHIEUDATPHONGtoolStripMenuItem16_Click(object sender, EventArgs e)
        {

            FormPhieuDatPhong frmPhieuDatPhong = new FormPhieuDatPhong();
            frmPhieuDatPhong.frmMain = this;
            frmPhieuDatPhong.ShowDialog();
        }
        public void capnhatphong()
        {
             lsvMain.Items.Clear();

              pdpBUS = new PhieuDatPhongBUS();
              IList<PhieuDatPhongDTO> listpdp = pdpBUS.getListPhieuDatPhongAll();
              if (listpdp != null)
              {
                  foreach (PhieuDatPhongDTO pdp in listpdp)
                  {
                      if (pdp.Tinhtrang == "waitting")
                      {
                          ctdpBUS = new ChiTietDatPhongBUS();
                          IList<ChiTietDatPhongDTO> listctdp = ctdpBUS.getChiTietDatPhongByID(pdp.Maphieudat);
                          foreach (ChiTietDatPhongDTO ctdp in listctdp)
                          {
                              pBUS = new PhongBUS();
                              PhongDTO p = pBUS.getPhongByID(ctdp.Maphong);
                              if (p.Dadat == false && p.Danhan == false)
                              {
                                  PhongDTO pDTO = new PhongDTO();
                                  pDTO.Maphong = p.Maphong;
                                  pDTO.Maloai = p.Maloai;
                                  pDTO.Dadat = true;
                                  pDTO.Danhan = false;
                                  pBUS.updatePhong(pDTO);
                              }
                          }
                      }
                  }
              }

              pBUS = new PhongBUS();
              IList<PhongDTO> listp = pBUS.getListPhongAll();
              foreach (PhongDTO dread in listp)
              {
                  int i = lsvMain.Items.Count;
                  lsvMain.Items.Add(dread.Maphong);
                  string dat = "", nhan = "";
                  int imgidx = 0;
                  dat = dread.Dadat.ToString();
                  nhan = dread.Danhan.ToString();
                  if (dat == "False" && nhan == "False")
                      imgidx = 0;
                  else if (dat == "True" && nhan == "False")
                      imgidx = 1;
                  else if (dat == "False" && nhan == "True")
                      imgidx = 2;
                  else if (dat == "True" && nhan == "True")
                      imgidx = 3;
                  lsvMain.Items[i].ImageIndex = imgidx;

              }
            
        }

        private void PHIEUTHUEPHONGtoolStripMenuItem17_Click(object sender, EventArgs e)
        {
            FormPhieuThuePhong frmPhieuThuePhong = new FormPhieuThuePhong();
            frmPhieuThuePhong.frmMain = this;
            frmPhieuThuePhong.ShowDialog();
        }

        private void HOADONtoolStripMenuItem18_Click(object sender, EventArgs e)
        {
            FormhHoaDon frmhHoaDon = new FormhHoaDon();
            frmhHoaDon.frmMain = this;
            frmhHoaDon.ShowDialog();
        }
    }
}
