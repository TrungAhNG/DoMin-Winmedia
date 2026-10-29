using Game_giữa_kì.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_giữa_kì
{
    public partial class frmHuongDan : Form
    {
    public frmHuongDan() {
        InitializeComponent();
        TaoGiaoDien();
    }
    private void TaoGiaoDien()
    {
        this.Text = "Hướng dẫn Minesweeper";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.ClientSize = new Size(620, 800);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.BackColor = Color.White;

        Label lblTieuDe = new Label();
        lblTieuDe.Text = "Hướng dẫn Minesweeper";
        lblTieuDe.Font = new Font("Arial", 22, FontStyle.Bold);
        lblTieuDe.AutoSize = true;
        lblTieuDe.Location = new Point(95, 25);
        this.Controls.Add(lblTieuDe);

        TableLayoutPanel pnlHuongDan = new TableLayoutPanel();
        pnlHuongDan.Location = new Point(15, 90);
        pnlHuongDan.Size = new Size(590, 620);
        pnlHuongDan.ColumnCount = 2;
        pnlHuongDan.RowCount = 4;
        pnlHuongDan.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

        pnlHuongDan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
        pnlHuongDan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

        for (int i = 0; i < 4; i++)
        {
            pnlHuongDan.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
        }

        for (int i = 1; i <= 8; i++)
        {
            Panel pnlViDu = TaoKhuVuc(i);
            int cot = (i - 1) % 2;
            int hang = (i - 1) / 2;
            pnlHuongDan.Controls.Add(pnlViDu, cot, hang);
        }

        this.Controls.Add(pnlHuongDan);

        Button btnQuayLai = new Button();
        btnQuayLai.Text = "Quay lại";
        btnQuayLai.Font = new Font("Arial", 12, FontStyle.Bold);
        btnQuayLai.Size = new Size(130, 40);
        btnQuayLai.Location = new Point(245, 730);
        btnQuayLai.Click += (sender, e) => this.Close();
        this.Controls.Add(btnQuayLai);
    }
        private Panel TaoKhuVuc(int soThuTu)
        {
            Panel pnlViDu = new Panel();
            pnlViDu.Dock = DockStyle.Fill;
            pnlViDu.BackColor = Color.White;

            Label lblTieuDe = new Label();
            lblTieuDe.Text = "Ví dụ " + soThuTu;
            lblTieuDe.Font = new Font("Arial", 11, FontStyle.Bold);
            lblTieuDe.Location = new Point(8, 5);
            lblTieuDe.AutoSize = true;
            pnlViDu.Controls.Add(lblTieuDe);

            PictureBox picViDu = new PictureBox();
            picViDu.Location = new Point(8, 28);
            picViDu.Size = new Size(125, 95);
            picViDu.SizeMode = PictureBoxSizeMode.Zoom;
            picViDu.BorderStyle = BorderStyle.FixedSingle;
            picViDu.BackColor = Color.WhiteSmoke;

            string duongDanAnh = Path.Combine(Application.StartupPath, "Image", "vidu" + soThuTu + ".jpg");
            cTienTich.LoadAnhAnToan(picViDu, duongDanAnh);

            pnlViDu.Controls.Add(picViDu);

            Label lblGhiChu = new Label();
            lblGhiChu.Text = LayGhiChu(soThuTu);
            lblGhiChu.Font = new Font("Arial", 9);
            lblGhiChu.Location = new Point(8, 128);
            lblGhiChu.AutoSize = true;
            pnlViDu.Controls.Add(lblGhiChu);

            return pnlViDu;
        }
        private string LayGhiChu(int soThuTu)
    {
        switch (soThuTu)
        {
            case 1: return "Số 1: Có 1 quả mìn trong 8 ô xung quanh.";
            case 2: return "Số 2: Có 2 quả mìn trong 8 ô xung quanh.";
            case 3: return "Số 3: Có 3 quả mìn trong 8 ô xung quanh.";
            case 4: return "Số 4: Có 4 quả mìn trong 8 ô xung quanh.";
            case 5: return "Số 5: Có 5 quả mìn trong 8 ô xung quanh.";
            case 6: return "Số 6: Có 6 quả mìn trong 8 ô xung quanh.";
            case 7: return "Số 7: Có 7 quả mìn trong 8 ô xung quanh.";
            case 8: return "Số 8: Cả 8 ô xung quanh đều có mìn.";
            default: return "";
        }
    }
    private void frmHuongDan_Load(object sender, EventArgs e) { }
    }
}