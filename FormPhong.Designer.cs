
namespace QLKS
{
    partial class FormPhong
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
            this.tabctrPhong = new System.Windows.Forms.TabControl();
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.cmbTenLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lsvPhong = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.tabLoaiphong = new System.Windows.Forms.TabPage();
            this.txtSonguoi = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtMaloai = new System.Windows.Forms.TextBox();
            this.lsvLoaiPhong = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSuaLoaiPhong = new System.Windows.Forms.Button();
            this.btnXoaLoaiPhong = new System.Windows.Forms.Button();
            this.btnThemLoaiPhong = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loi = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnQLVT = new System.Windows.Forms.Button();
            this.tabctrPhong.SuspendLayout();
            this.tabPhong.SuspendLayout();
            this.tabLoaiphong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrPhong
            // 
            this.tabctrPhong.Controls.Add(this.tabPhong);
            this.tabctrPhong.Controls.Add(this.tabLoaiphong);
            this.tabctrPhong.Location = new System.Drawing.Point(2, 1);
            this.tabctrPhong.Name = "tabctrPhong";
            this.tabctrPhong.SelectedIndex = 0;
            this.tabctrPhong.Size = new System.Drawing.Size(991, 527);
            this.tabctrPhong.TabIndex = 0;
            this.tabctrPhong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabctrPhong_MouseClick);
            // 
            // tabPhong
            // 
            this.tabPhong.BackColor = System.Drawing.Color.LightCyan;
            this.tabPhong.Controls.Add(this.btnQLVT);
            this.tabPhong.Controls.Add(this.txtPhong);
            this.tabPhong.Controls.Add(this.cmbTenLoaiPhong);
            this.tabPhong.Controls.Add(this.lsvPhong);
            this.tabPhong.Controls.Add(this.label3);
            this.tabPhong.Controls.Add(this.label2);
            this.tabPhong.Controls.Add(this.label1);
            this.tabPhong.Controls.Add(this.btnSuaPhong);
            this.tabPhong.Controls.Add(this.btnXoaPhong);
            this.tabPhong.Controls.Add(this.btnThemPhong);
            this.tabPhong.Location = new System.Drawing.Point(4, 25);
            this.tabPhong.Name = "tabPhong";
            this.tabPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhong.Size = new System.Drawing.Size(983, 498);
            this.tabPhong.TabIndex = 0;
            this.tabPhong.Text = "Quản lý phòng";
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(185, 97);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(121, 22);
            this.txtPhong.TabIndex = 8;
            // 
            // cmbTenLoaiPhong
            // 
            this.cmbTenLoaiPhong.FormattingEnabled = true;
            this.cmbTenLoaiPhong.Location = new System.Drawing.Point(185, 179);
            this.cmbTenLoaiPhong.Name = "cmbTenLoaiPhong";
            this.cmbTenLoaiPhong.Size = new System.Drawing.Size(121, 24);
            this.cmbTenLoaiPhong.TabIndex = 7;
            // 
            // lsvPhong
            // 
            this.lsvPhong.BackColor = System.Drawing.Color.Azure;
            this.lsvPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvPhong.HideSelection = false;
            this.lsvPhong.Location = new System.Drawing.Point(500, 42);
            this.lsvPhong.Name = "lsvPhong";
            this.lsvPhong.Size = new System.Drawing.Size(483, 456);
            this.lsvPhong.TabIndex = 6;
            this.lsvPhong.UseCompatibleStateImageBehavior = false;
            this.lsvPhong.View = System.Windows.Forms.View.Details;
            this.lsvPhong.SelectedIndexChanged += new System.EventHandler(this.lsvPhong_SelectedIndexChanged);
            this.lsvPhong.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvPhong_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Phòng";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Loại phòng";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số người";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá";
            this.columnHeader4.Width = 146;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(54, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(54, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(90, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ PHÒNG";
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSuaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhong.Location = new System.Drawing.Point(319, 306);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(111, 47);
            this.btnSuaPhong.TabIndex = 2;
            this.btnSuaPhong.Text = "Sửa";
            this.btnSuaPhong.UseVisualStyleBackColor = false;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnXoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhong.Location = new System.Drawing.Point(185, 403);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(102, 45);
            this.btnXoaPhong.TabIndex = 1;
            this.btnXoaPhong.Text = "Xoá";
            this.btnXoaPhong.UseVisualStyleBackColor = false;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhong.Location = new System.Drawing.Point(34, 306);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(102, 47);
            this.btnThemPhong.TabIndex = 0;
            this.btnThemPhong.Text = "Thêm";
            this.btnThemPhong.UseVisualStyleBackColor = false;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // tabLoaiphong
            // 
            this.tabLoaiphong.BackColor = System.Drawing.Color.LightCyan;
            this.tabLoaiphong.Controls.Add(this.txtSonguoi);
            this.tabLoaiphong.Controls.Add(this.txtGia);
            this.tabLoaiphong.Controls.Add(this.txtMaloai);
            this.tabLoaiphong.Controls.Add(this.lsvLoaiPhong);
            this.tabLoaiphong.Controls.Add(this.btnSuaLoaiPhong);
            this.tabLoaiphong.Controls.Add(this.btnXoaLoaiPhong);
            this.tabLoaiphong.Controls.Add(this.btnThemLoaiPhong);
            this.tabLoaiphong.Controls.Add(this.label10);
            this.tabLoaiphong.Controls.Add(this.label9);
            this.tabLoaiphong.Controls.Add(this.label8);
            this.tabLoaiphong.Controls.Add(this.label4);
            this.tabLoaiphong.Location = new System.Drawing.Point(4, 25);
            this.tabLoaiphong.Name = "tabLoaiphong";
            this.tabLoaiphong.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoaiphong.Size = new System.Drawing.Size(983, 498);
            this.tabLoaiphong.TabIndex = 1;
            this.tabLoaiphong.Text = "Loại phòng";
            this.tabLoaiphong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabLoaiphong_MouseClick);
            // 
            // txtSonguoi
            // 
            this.txtSonguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSonguoi.Location = new System.Drawing.Point(189, 231);
            this.txtSonguoi.Name = "txtSonguoi";
            this.txtSonguoi.Size = new System.Drawing.Size(193, 28);
            this.txtSonguoi.TabIndex = 10;
            this.txtSonguoi.TextChanged += new System.EventHandler(this.txtSonguoi_TextChanged);
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(189, 164);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(193, 28);
            this.txtGia.TabIndex = 9;
            this.txtGia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGia_KeyDown);
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // txtMaloai
            // 
            this.txtMaloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaloai.Location = new System.Drawing.Point(189, 93);
            this.txtMaloai.Name = "txtMaloai";
            this.txtMaloai.Size = new System.Drawing.Size(193, 28);
            this.txtMaloai.TabIndex = 8;
            // 
            // lsvLoaiPhong
            // 
            this.lsvLoaiPhong.BackColor = System.Drawing.Color.Azure;
            this.lsvLoaiPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lsvLoaiPhong.HideSelection = false;
            this.lsvLoaiPhong.Location = new System.Drawing.Point(528, 18);
            this.lsvLoaiPhong.Name = "lsvLoaiPhong";
            this.lsvLoaiPhong.Size = new System.Drawing.Size(449, 465);
            this.lsvLoaiPhong.TabIndex = 7;
            this.lsvLoaiPhong.UseCompatibleStateImageBehavior = false;
            this.lsvLoaiPhong.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã loại";
            this.columnHeader5.Width = 84;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giá";
            this.columnHeader6.Width = 76;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số người";
            this.columnHeader7.Width = 125;
            // 
            // btnSuaLoaiPhong
            // 
            this.btnSuaLoaiPhong.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSuaLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoaiPhong.Location = new System.Drawing.Point(386, 331);
            this.btnSuaLoaiPhong.Name = "btnSuaLoaiPhong";
            this.btnSuaLoaiPhong.Size = new System.Drawing.Size(106, 48);
            this.btnSuaLoaiPhong.TabIndex = 6;
            this.btnSuaLoaiPhong.Text = "Sửa";
            this.btnSuaLoaiPhong.UseVisualStyleBackColor = false;
            this.btnSuaLoaiPhong.Click += new System.EventHandler(this.btnSuaLoaiPhong_Click);
            // 
            // btnXoaLoaiPhong
            // 
            this.btnXoaLoaiPhong.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnXoaLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiPhong.Location = new System.Drawing.Point(243, 410);
            this.btnXoaLoaiPhong.Name = "btnXoaLoaiPhong";
            this.btnXoaLoaiPhong.Size = new System.Drawing.Size(106, 48);
            this.btnXoaLoaiPhong.TabIndex = 5;
            this.btnXoaLoaiPhong.Text = "Xoá";
            this.btnXoaLoaiPhong.UseVisualStyleBackColor = false;
            this.btnXoaLoaiPhong.Click += new System.EventHandler(this.btnXoaLoaiPhong_Click);
            // 
            // btnThemLoaiPhong
            // 
            this.btnThemLoaiPhong.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThemLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiPhong.Location = new System.Drawing.Point(76, 331);
            this.btnThemLoaiPhong.Name = "btnThemLoaiPhong";
            this.btnThemLoaiPhong.Size = new System.Drawing.Size(106, 48);
            this.btnThemLoaiPhong.TabIndex = 4;
            this.btnThemLoaiPhong.Text = "Thêm";
            this.btnThemLoaiPhong.UseVisualStyleBackColor = false;
            this.btnThemLoaiPhong.Click += new System.EventHandler(this.btnThemLoaiPhong_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(72, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Số người:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "Giá:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã loại:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(145, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 44);
            this.label4.TabIndex = 0;
            this.label4.Text = "LOẠI PHÒNG";
            // 
            // loi
            // 
            this.loi.ContainerControl = this;
            // 
            // btnQLVT
            // 
            this.btnQLVT.BackColor = System.Drawing.Color.Azure;
            this.btnQLVT.Location = new System.Drawing.Point(360, 458);
            this.btnQLVT.Name = "btnQLVT";
            this.btnQLVT.Size = new System.Drawing.Size(134, 34);
            this.btnQLVT.TabIndex = 9;
            this.btnQLVT.Text = "QLVT";
            this.btnQLVT.UseVisualStyleBackColor = false;
            this.btnQLVT.Click += new System.EventHandler(this.btnQLVT_Click_1);
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 532);
            this.Controls.Add(this.tabctrPhong);
            this.Name = "FormPhong";
            this.Text = "FormPhong";
            this.Load += new System.EventHandler(this.FormPhong_Load);
            this.tabctrPhong.ResumeLayout(false);
            this.tabPhong.ResumeLayout(false);
            this.tabPhong.PerformLayout();
            this.tabLoaiphong.ResumeLayout(false);
            this.tabLoaiphong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrPhong;
        private System.Windows.Forms.TabPage tabPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.ComboBox cmbTenLoaiPhong;
        private System.Windows.Forms.ListView lsvPhong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.TabPage tabLoaiphong;
        private System.Windows.Forms.TextBox txtSonguoi;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMaloai;
        private System.Windows.Forms.ListView lsvLoaiPhong;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnSuaLoaiPhong;
        private System.Windows.Forms.Button btnXoaLoaiPhong;
        private System.Windows.Forms.Button btnThemLoaiPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider loi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnQLVT;
    }
}