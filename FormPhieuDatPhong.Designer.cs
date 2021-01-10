
namespace QLKS
{
    partial class FormPhieuDatPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("KHÁCH HÀNG", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Mã khách hàng");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Tên khách hàng");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Giới tính");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("CMND/Passport");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Địa chỉ");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Cơ quan");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Điện thoại");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Email");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labMaPD = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.txtSonguoi = new System.Windows.Forms.TextBox();
            this.txtTiencoc = new System.Windows.Forms.TextBox();
            this.dtpNgayden = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaydi = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvTimPhong = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTim = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lsvViewPhong = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSua = new System.Windows.Forms.Button();
            this.lsvChiTiet = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btndatphong = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnHuy = new System.Windows.Forms.Button();
            this.button1_NhanPhong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkfin = new System.Windows.Forms.CheckBox();
            this.chkcan = new System.Windows.Forms.CheckBox();
            this.chksub = new System.Windows.Forms.CheckBox();
            this.chkwait = new System.Windows.Forms.CheckBox();
            this.lsvDSPhieuDatPhong = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loi = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu đặt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số người:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đặt cọc:";
            // 
            // labMaPD
            // 
            this.labMaPD.AutoSize = true;
            this.labMaPD.Location = new System.Drawing.Point(193, 51);
            this.labMaPD.Name = "labMaPD";
            this.labMaPD.Size = new System.Drawing.Size(46, 17);
            this.labMaPD.TabIndex = 5;
            this.labMaPD.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày đi:";
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(199, 108);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(121, 24);
            this.cmbKhachHang.TabIndex = 7;
            this.cmbKhachHang.SelectedIndexChanged += new System.EventHandler(this.cmbKhachHang_SelectedIndexChanged);
            // 
            // txtSonguoi
            // 
            this.txtSonguoi.Location = new System.Drawing.Point(199, 228);
            this.txtSonguoi.Name = "txtSonguoi";
            this.txtSonguoi.Size = new System.Drawing.Size(100, 22);
            this.txtSonguoi.TabIndex = 8;
            this.txtSonguoi.TextChanged += new System.EventHandler(this.txtSonguoi_TextChanged);
            // 
            // txtTiencoc
            // 
            this.txtTiencoc.Location = new System.Drawing.Point(196, 282);
            this.txtTiencoc.Name = "txtTiencoc";
            this.txtTiencoc.Size = new System.Drawing.Size(195, 22);
            this.txtTiencoc.TabIndex = 9;
            this.txtTiencoc.TextChanged += new System.EventHandler(this.txtTiencoc_TextChanged);
            // 
            // dtpNgayden
            // 
            this.dtpNgayden.Location = new System.Drawing.Point(196, 163);
            this.dtpNgayden.Name = "dtpNgayden";
            this.dtpNgayden.Size = new System.Drawing.Size(103, 22);
            this.dtpNgayden.TabIndex = 10;
            this.dtpNgayden.ValueChanged += new System.EventHandler(this.dtpNgayden_ValueChanged);
            // 
            // dtpNgaydi
            // 
            this.dtpNgaydi.Location = new System.Drawing.Point(391, 163);
            this.dtpNgaydi.Name = "dtpNgaydi";
            this.dtpNgaydi.Size = new System.Drawing.Size(140, 22);
            this.dtpNgaydi.TabIndex = 11;
            this.dtpNgaydi.ValueChanged += new System.EventHandler(this.dtpNgaydi_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvTimPhong);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Location = new System.Drawing.Point(12, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 243);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm phòng trống";
            // 
            // lsvTimPhong
            // 
            this.lsvTimPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvTimPhong.HideSelection = false;
            this.lsvTimPhong.Location = new System.Drawing.Point(25, 53);
            this.lsvTimPhong.Name = "lsvTimPhong";
            this.lsvTimPhong.Size = new System.Drawing.Size(473, 172);
            this.lsvTimPhong.TabIndex = 1;
            this.lsvTimPhong.UseCompatibleStateImageBehavior = false;
            this.lsvTimPhong.View = System.Windows.Forms.View.Details;
            this.lsvTimPhong.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lsvTimPhong_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Phòng";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Loại";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số người";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá";
            this.columnHeader4.Width = 114;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(212, 24);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(589, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 561);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lsvViewPhong);
            this.tabPage1.Controls.Add(this.btnSua);
            this.tabPage1.Controls.Add(this.lsvChiTiet);
            this.tabPage1.Controls.Add(this.btndatphong);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chi tiết";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lsvViewPhong
            // 
            this.lsvViewPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lsvViewPhong.HideSelection = false;
            this.lsvViewPhong.Location = new System.Drawing.Point(20, 244);
            this.lsvViewPhong.Name = "lsvViewPhong";
            this.lsvViewPhong.Size = new System.Drawing.Size(516, 194);
            this.lsvViewPhong.TabIndex = 1;
            this.lsvViewPhong.UseCompatibleStateImageBehavior = false;
            this.lsvViewPhong.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phòng";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Loại";
            this.columnHeader6.Width = 133;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số người";
            this.columnHeader7.Width = 131;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Giá";
            this.columnHeader8.Width = 150;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(225, 458);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 41);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lsvChiTiet
            // 
            this.lsvChiTiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            listViewGroup1.Header = "KHÁCH HÀNG";
            listViewGroup1.Name = "listViewGroupKHACHHANG";
            this.lsvChiTiet.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lsvChiTiet.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup1;
            listViewItem4.Group = listViewGroup1;
            listViewItem5.Group = listViewGroup1;
            listViewItem6.Group = listViewGroup1;
            listViewItem7.Group = listViewGroup1;
            listViewItem8.Group = listViewGroup1;
            this.lsvChiTiet.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.lsvChiTiet.Location = new System.Drawing.Point(14, 20);
            this.lsvChiTiet.Name = "lsvChiTiet";
            this.lsvChiTiet.Size = new System.Drawing.Size(522, 203);
            this.lsvChiTiet.TabIndex = 0;
            this.lsvChiTiet.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Thông tin";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Giá trị";
            // 
            // btndatphong
            // 
            this.btndatphong.Location = new System.Drawing.Point(50, 458);
            this.btndatphong.Name = "btndatphong";
            this.btndatphong.Size = new System.Drawing.Size(103, 41);
            this.btndatphong.TabIndex = 14;
            this.btndatphong.Text = "Đặt phòng";
            this.btndatphong.UseVisualStyleBackColor = true;
            this.btndatphong.Click += new System.EventHandler(this.btndatphong_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnHuy);
            this.tabPage2.Controls.Add(this.button1_NhanPhong);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.lsvDSPhieuDatPhong);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(264, 490);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 36);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // button1_NhanPhong
            // 
            this.button1_NhanPhong.Location = new System.Drawing.Point(66, 486);
            this.button1_NhanPhong.Name = "button1_NhanPhong";
            this.button1_NhanPhong.Size = new System.Drawing.Size(126, 40);
            this.button1_NhanPhong.TabIndex = 2;
            this.button1_NhanPhong.Text = "Nhận phòng";
            this.button1_NhanPhong.UseVisualStyleBackColor = true;
            this.button1_NhanPhong.Click += new System.EventHandler(this.button1_NhanPhong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkfin);
            this.groupBox2.Controls.Add(this.chkcan);
            this.groupBox2.Controls.Add(this.chksub);
            this.groupBox2.Controls.Add(this.chkwait);
            this.groupBox2.Location = new System.Drawing.Point(97, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "view";
            // 
            // chkfin
            // 
            this.chkfin.AutoSize = true;
            this.chkfin.Location = new System.Drawing.Point(323, 20);
            this.chkfin.Name = "chkfin";
            this.chkfin.Size = new System.Drawing.Size(63, 21);
            this.chkfin.TabIndex = 3;
            this.chkfin.Text = "finish";
            this.chkfin.UseVisualStyleBackColor = true;
            this.chkfin.CheckedChanged += new System.EventHandler(this.chkfin_CheckedChanged);
            // 
            // chkcan
            // 
            this.chkcan.AutoSize = true;
            this.chkcan.Location = new System.Drawing.Point(213, 22);
            this.chkcan.Name = "chkcan";
            this.chkcan.Size = new System.Drawing.Size(71, 21);
            this.chkcan.TabIndex = 2;
            this.chkcan.Text = "cancel";
            this.chkcan.UseVisualStyleBackColor = true;
            this.chkcan.CheckedChanged += new System.EventHandler(this.chkcan_CheckedChanged);
            // 
            // chksub
            // 
            this.chksub.AutoSize = true;
            this.chksub.Location = new System.Drawing.Point(107, 21);
            this.chksub.Name = "chksub";
            this.chksub.Size = new System.Drawing.Size(87, 21);
            this.chksub.TabIndex = 1;
            this.chksub.Text = "submited";
            this.chksub.UseVisualStyleBackColor = true;
            this.chksub.CheckedChanged += new System.EventHandler(this.chksub_CheckedChanged);
            // 
            // chkwait
            // 
            this.chkwait.AutoSize = true;
            this.chkwait.Location = new System.Drawing.Point(4, 23);
            this.chkwait.Name = "chkwait";
            this.chkwait.Size = new System.Drawing.Size(77, 21);
            this.chkwait.TabIndex = 0;
            this.chkwait.Text = "waitting";
            this.chkwait.UseVisualStyleBackColor = true;
            this.chkwait.CheckedChanged += new System.EventHandler(this.chkwait_CheckedChanged);
            // 
            // lsvDSPhieuDatPhong
            // 
            this.lsvDSPhieuDatPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.lsvDSPhieuDatPhong.HideSelection = false;
            this.lsvDSPhieuDatPhong.Location = new System.Drawing.Point(6, 70);
            this.lsvDSPhieuDatPhong.Name = "lsvDSPhieuDatPhong";
            this.lsvDSPhieuDatPhong.Size = new System.Drawing.Size(530, 395);
            this.lsvDSPhieuDatPhong.TabIndex = 0;
            this.lsvDSPhieuDatPhong.UseCompatibleStateImageBehavior = false;
            this.lsvDSPhieuDatPhong.View = System.Windows.Forms.View.Details;
//            this.lsvDSPhieuDatPhong.SelectedIndexChanged += new System.EventHandler(this.lsvDSPhieuDatPhong_SelectedIndexChanged_1);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Mã phiếu";
            this.columnHeader11.Width = 76;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Khách hàng";
            this.columnHeader12.Width = 84;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Số khách";
            this.columnHeader13.Width = 82;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Ngày đến";
            this.columnHeader14.Width = 72;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Ngày đi";
            this.columnHeader15.Width = 74;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Tình trạng";
            this.columnHeader16.Width = 92;
            // 
            // loi
            // 
            this.loi.ContainerControl = this;
            // 
            // FormPhieuDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1151, 586);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpNgaydi);
            this.Controls.Add(this.dtpNgayden);
            this.Controls.Add(this.txtTiencoc);
            this.Controls.Add(this.txtSonguoi);
            this.Controls.Add(this.cmbKhachHang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labMaPD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPhieuDatPhong";
            this.Text = "FormPhieuDatPhong";
            this.Load += new System.EventHandler(this.FormPhieuDatPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labMaPD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.TextBox txtSonguoi;
        private System.Windows.Forms.TextBox txtTiencoc;
        private System.Windows.Forms.DateTimePicker dtpNgayden;
        private System.Windows.Forms.DateTimePicker dtpNgaydi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvTimPhong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lsvViewPhong;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView lsvChiTiet;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView lsvDSPhieuDatPhong;
        private System.Windows.Forms.Button btndatphong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider loi;
        private System.Windows.Forms.CheckBox chkfin;
        private System.Windows.Forms.CheckBox chkcan;
        private System.Windows.Forms.CheckBox chksub;
        private System.Windows.Forms.CheckBox chkwait;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button button1_NhanPhong;
    }
}