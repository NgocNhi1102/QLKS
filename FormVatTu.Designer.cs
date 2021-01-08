
namespace QLKS
{
    partial class FormVatTu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbVattu = new System.Windows.Forms.ComboBox();
            this.cmbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.lsvCTVattu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoaCTVT = new System.Windows.Forms.Button();
            this.btnSuaCTVT = new System.Windows.Forms.Button();
            this.btnThemCTVT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTenVatTu = new System.Windows.Forms.TextBox();
            this.txtMaVatTu = new System.Windows.Forms.TextBox();
            this.lsvQLVattu = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoaVT = new System.Windows.Forms.Button();
            this.btnSuaVT = new System.Windows.Forms.Button();
            this.btnThemVT = new System.Windows.Forms.Button();
            this.loi = new System.Windows.Forms.ErrorProvider(this.components);
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 475);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage1.Controls.Add(this.cmbVattu);
            this.tabPage1.Controls.Add(this.cmbLoaiPhong);
            this.tabPage1.Controls.Add(this.numSL);
            this.tabPage1.Controls.Add(this.lsvCTVattu);
            this.tabPage1.Controls.Add(this.btnXoaCTVT);
            this.tabPage1.Controls.Add(this.btnSuaCTVT);
            this.tabPage1.Controls.Add(this.btnThemCTVT);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bố trí CT";
            // 
            // cmbVattu
            // 
            this.cmbVattu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVattu.FormattingEnabled = true;
            this.cmbVattu.Location = new System.Drawing.Point(145, 106);
            this.cmbVattu.Name = "cmbVattu";
            this.cmbVattu.Size = new System.Drawing.Size(221, 26);
            this.cmbVattu.TabIndex = 9;
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiPhong.FormattingEnabled = true;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(144, 56);
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            this.cmbLoaiPhong.Size = new System.Drawing.Size(222, 26);
            this.cmbLoaiPhong.TabIndex = 8;
            this.cmbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiPhong_SelectedIndexChanged);
            // 
            // numSL
            // 
            this.numSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSL.Location = new System.Drawing.Point(146, 166);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(220, 24);
            this.numSL.TabIndex = 7;
            // 
            // lsvCTVattu
            // 
            this.lsvCTVattu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvCTVattu.HideSelection = false;
            this.lsvCTVattu.Location = new System.Drawing.Point(50, 209);
            this.lsvCTVattu.Name = "lsvCTVattu";
            this.lsvCTVattu.Size = new System.Drawing.Size(739, 218);
            this.lsvCTVattu.TabIndex = 6;
            this.lsvCTVattu.UseCompatibleStateImageBehavior = false;
            this.lsvCTVattu.View = System.Windows.Forms.View.Details;
            this.lsvCTVattu.Click += new System.EventHandler(this.lsvCTVattu_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Vật tư";
            this.columnHeader1.Width = 232;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 432;
            // 
            // btnXoaCTVT
            // 
            this.btnXoaCTVT.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnXoaCTVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCTVT.Location = new System.Drawing.Point(568, 163);
            this.btnXoaCTVT.Name = "btnXoaCTVT";
            this.btnXoaCTVT.Size = new System.Drawing.Size(122, 28);
            this.btnXoaCTVT.TabIndex = 5;
            this.btnXoaCTVT.Text = "Xoá";
            this.btnXoaCTVT.UseVisualStyleBackColor = false;
            this.btnXoaCTVT.Click += new System.EventHandler(this.btnXoaCTVT_Click);
            // 
            // btnSuaCTVT
            // 
            this.btnSuaCTVT.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSuaCTVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCTVT.Location = new System.Drawing.Point(568, 106);
            this.btnSuaCTVT.Name = "btnSuaCTVT";
            this.btnSuaCTVT.Size = new System.Drawing.Size(122, 28);
            this.btnSuaCTVT.TabIndex = 4;
            this.btnSuaCTVT.Text = "Sửa";
            this.btnSuaCTVT.UseVisualStyleBackColor = false;
            this.btnSuaCTVT.Click += new System.EventHandler(this.btnSuaCTVT_Click);
            // 
            // btnThemCTVT
            // 
            this.btnThemCTVT.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThemCTVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCTVT.Location = new System.Drawing.Point(568, 50);
            this.btnThemCTVT.Name = "btnThemCTVT";
            this.btnThemCTVT.Size = new System.Drawing.Size(122, 32);
            this.btnThemCTVT.TabIndex = 3;
            this.btnThemCTVT.Text = "Thêm";
            this.btnThemCTVT.UseVisualStyleBackColor = false;
            this.btnThemCTVT.Click += new System.EventHandler(this.btnThemCTVT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vật tư:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại phòng:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage2.Controls.Add(this.txtTenVatTu);
            this.tabPage2.Controls.Add(this.txtMaVatTu);
            this.tabPage2.Controls.Add(this.lsvQLVattu);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnXoaVT);
            this.tabPage2.Controls.Add(this.btnSuaVT);
            this.tabPage2.Controls.Add(this.btnThemVT);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txtTenVatTu
            // 
            this.txtTenVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVatTu.Location = new System.Drawing.Point(171, 149);
            this.txtTenVatTu.Name = "txtTenVatTu";
            this.txtTenVatTu.Size = new System.Drawing.Size(150, 24);
            this.txtTenVatTu.TabIndex = 8;
            this.txtTenVatTu.TextChanged += new System.EventHandler(this.txtTenVatTu_TextChanged);
            // 
            // txtMaVatTu
            // 
            this.txtMaVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVatTu.Location = new System.Drawing.Point(171, 87);
            this.txtMaVatTu.Name = "txtMaVatTu";
            this.txtMaVatTu.Size = new System.Drawing.Size(150, 24);
            this.txtMaVatTu.TabIndex = 7;
            this.txtMaVatTu.TextChanged += new System.EventHandler(this.txtMaVatTu_TextChanged);
            // 
            // lsvQLVattu
            // 
            this.lsvQLVattu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lsvQLVattu.HideSelection = false;
            this.lsvQLVattu.Location = new System.Drawing.Point(410, 36);
            this.lsvQLVattu.Name = "lsvQLVattu";
            this.lsvQLVattu.Size = new System.Drawing.Size(417, 411);
            this.lsvQLVattu.TabIndex = 6;
            this.lsvQLVattu.UseCompatibleStateImageBehavior = false;
            this.lsvQLVattu.View = System.Windows.Forms.View.Details;
            this.lsvQLVattu.SelectedIndexChanged += new System.EventHandler(this.lsvQLVattu_SelectedIndexChanged);
            this.lsvQLVattu.Click += new System.EventHandler(this.lsvQLVattu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên vật tư:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã vật tư:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(101, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "QUẢN LÝ VẬT TƯ";
            // 
            // btnXoaVT
            // 
            this.btnXoaVT.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnXoaVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaVT.Location = new System.Drawing.Point(317, 271);
            this.btnXoaVT.Name = "btnXoaVT";
            this.btnXoaVT.Size = new System.Drawing.Size(85, 23);
            this.btnXoaVT.TabIndex = 2;
            this.btnXoaVT.Text = "Xoá";
            this.btnXoaVT.UseVisualStyleBackColor = false;
            this.btnXoaVT.Click += new System.EventHandler(this.btnXoaVT_Click);
            // 
            // btnSuaVT
            // 
            this.btnSuaVT.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSuaVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaVT.Location = new System.Drawing.Point(196, 271);
            this.btnSuaVT.Name = "btnSuaVT";
            this.btnSuaVT.Size = new System.Drawing.Size(85, 23);
            this.btnSuaVT.TabIndex = 1;
            this.btnSuaVT.Text = "Sửa";
            this.btnSuaVT.UseVisualStyleBackColor = false;
            this.btnSuaVT.Click += new System.EventHandler(this.btnSuaVT_Click);
            // 
            // btnThemVT
            // 
            this.btnThemVT.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThemVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVT.Location = new System.Drawing.Point(61, 271);
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.Size = new System.Drawing.Size(85, 23);
            this.btnThemVT.TabIndex = 0;
            this.btnThemVT.Text = "Thêm";
            this.btnThemVT.UseVisualStyleBackColor = false;
            this.btnThemVT.Click += new System.EventHandler(this.btnThemVT_Click);
            // 
            // loi
            // 
            this.loi.ContainerControl = this;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã vật tư";
            this.columnHeader3.Width = 168;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên vật tư";
            this.columnHeader4.Width = 180;
            // 
            // FormVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 478);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormVatTu";
            this.Text = "FormVatTu";
            this.Load += new System.EventHandler(this.FormVatTu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbVattu;
        private System.Windows.Forms.ComboBox cmbLoaiPhong;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.ListView lsvCTVattu;
        private System.Windows.Forms.Button btnXoaCTVT;
        private System.Windows.Forms.Button btnSuaCTVT;
        private System.Windows.Forms.Button btnThemCTVT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtTenVatTu;
        private System.Windows.Forms.TextBox txtMaVatTu;
        private System.Windows.Forms.ListView lsvQLVattu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoaVT;
        private System.Windows.Forms.Button btnSuaVT;
        private System.Windows.Forms.Button btnThemVT;
        private System.Windows.Forms.ErrorProvider loi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}