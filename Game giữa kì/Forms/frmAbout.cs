using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Game_giữa_kì {
    public partial class frmAbout : Form {
        public frmAbout() {
            InitializeComponent();
            InitializeComponentProgrammatic();
        }

        private void frmAbout_Load(object sender, EventArgs e) {
        }
        private void InitializeComponentProgrammatic()
        {
            this.Text = "Thông Tin Nhóm Phát Triển Game";
            this.Size = new Size(500, 420);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(248, 250, 252);

            Label lblTitle = new Label
            {
                Text = "🎮 ĐỒ ÁN GAME DÒ MÌN (MINESWEEPER)",
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Location = new Point(10, 20),
                Size = new Size(465, 35),
                TextAlign = ContentAlignment.MiddleCenter
            };

            TextBox txtMembers = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Location = new Point(25, 70),
                Size = new Size(435, 230),
                Font = new Font("Segoe UI", 10),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Text = "📌 PHÂN CÔNG NHIỆM VỤ NHÓM WINMEDIA :\r\n\r\n" +
                       "👨‍💻 1. Bạn Nguyễn Thanh Phước.Mssv(51.01.104.078) : Thuật toán lõi, Flood Fill, First-click safe, Chording (frmGame.cs)\r\n\r\n" +
                       "🎨 2. Bạn Nguyễn Trần Trung Kiên.Mssv(51.01.104.052) : Giao diện Main Menu & Hướng dẫn (frmMainMenu.cs, frmHuongDan.cs)\r\n\r\n" +
                       "📊 3. Bạn Nguyễn Bách.Mssv(51.01.104.005) Bảng thành tích, Đọc/Ghi file & Utility (cThanhTich.cs, frmThanhTich.cs)\r\n\r\n" +
                       "🎬 4. Bạn Nguyễn Trung Anh.Mssv(51.01.104.002) : Kiểm thử (QA), Tích hợp Source Code, GitHub, (frmAbout.cs)"
            };

            Button btnClose = new Button
            {
                Text = "Đóng",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Size = new Size(120, 35),
                Location = new Point(180, 320),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(37, 99, 235),
                ForeColor = Color.White,
                Cursor = Cursors.Hand
            };
            btnClose.Click += (s, e) => this.Close();

            this.Controls.Add(lblTitle);
            this.Controls.Add(txtMembers);
            this.Controls.Add(btnClose);
        }

    }
}