namespace Game_giữa_kì
{
    partial class frmThanhTich
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.cboLocCapDo = new System.Windows.Forms.ComboBox();
            this.lblLocCapDo = new System.Windows.Forms.Label();
            this.dgvThanhTich = new System.Windows.Forms.DataGridView();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnXoaLichSu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhTich)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(850, 85);
            // lblSubTitle
            this.lblSubTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubTitle.ForeColor = System.Drawing.Color.White;
            this.lblSubTitle.Location = new System.Drawing.Point(0, 52);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(850, 33);
            this.lblSubTitle.Text = "Ưu tiên xếp hạng: Cấp độ Khó -> Trung bình -> Dễ";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // label1
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 52);
            this.label1.Text = "BẢNG XẾP HẠNG THÀNH TÍCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // pnlFilter
            this.pnlFilter.Controls.Add(this.lblTongSo);
            this.pnlFilter.Controls.Add(this.cboLocCapDo);
            this.pnlFilter.Controls.Add(this.lblLocCapDo);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 85);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(850, 48);
            // lblTongSo
            this.lblTongSo.Location = new System.Drawing.Point(550, 13);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(280, 23);
            this.lblTongSo.Text = "Tổng số kỷ lục: 0";
            // cboLocCapDo
            this.cboLocCapDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocCapDo.Items.AddRange(new object[] { "Tất cả", "Khó", "Trung bình", "Dễ" });
            this.cboLocCapDo.Location = new System.Drawing.Point(140, 10);
            this.cboLocCapDo.Name = "cboLocCapDo";
            this.cboLocCapDo.Size = new System.Drawing.Size(160, 24);
            this.cboLocCapDo.SelectedIndexChanged += new System.EventHandler(this.cboLocCapDo_SelectedIndexChanged);
            // lblLocCapDo
            this.lblLocCapDo.Location = new System.Drawing.Point(20, 13);
            this.lblLocCapDo.Name = "lblLocCapDo";
            this.lblLocCapDo.Size = new System.Drawing.Size(100, 23);
            this.lblLocCapDo.Text = "Lọc theo cấp:";
            // dgvThanhTich
            this.dgvThanhTich.AllowUserToAddRows = false;
            this.dgvThanhTich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhTich.Location = new System.Drawing.Point(20, 145);
            this.dgvThanhTich.Name = "dgvThanhTich";
            this.dgvThanhTich.ReadOnly = true;
            this.dgvThanhTich.RowHeadersVisible = false;
            this.dgvThanhTich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThanhTich.Size = new System.Drawing.Size(810, 250);
            // pnlFooter
            this.pnlFooter.Controls.Add(this.btnXoaLichSu);
            this.pnlFooter.Controls.Add(this.btnDong);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 410);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(850, 58);
            // btnXoaLichSu
            this.btnXoaLichSu.Location = new System.Drawing.Point(20, 11);
            this.btnXoaLichSu.Name = "btnXoaLichSu";
            this.btnXoaLichSu.Size = new System.Drawing.Size(150, 36);
            this.btnXoaLichSu.Text = "Xóa lịch sử";
            this.btnXoaLichSu.Click += new System.EventHandler(this.btnXoaLichSu_Click);
            // btnDong
            this.btnDong.Location = new System.Drawing.Point(700, 11);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(130, 36);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // frmThanhTich
            this.ClientSize = new System.Drawing.Size(850, 468);
            this.Controls.Add(this.dgvThanhTich);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmThanhTich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmThanhTich_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhTich)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.ComboBox cboLocCapDo;
        private System.Windows.Forms.Label lblLocCapDo;
        private System.Windows.Forms.DataGridView dgvThanhTich;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnXoaLichSu;
        private System.Windows.Forms.Button btnDong;
    }
}