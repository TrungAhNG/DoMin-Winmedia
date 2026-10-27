using Game_giữa_kì;
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

namespace Game_giữa_kì {
    public partial class frmMainMenu : Form {
        public frmMainMenu() {
            InitializeComponent();
            InitializeComponentProgrammatic();
        }
        private Label lblTitle;
        private Label lblNamePrompt;
        private TextBox txtPlayerName;
        private Button btnPlay;
        private Button btnGuide;
        private Button btnThanhTich;
        private Button btnAbout;
        private Button btnExit;
        private CheckBox chkSound;
        private PictureBox picBomb;
        private bool amThanhBat = true;

        private void InitializeComponentProgrammatic()
        {
            this.Text = "Minesweeper - Trang Chủ";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(620, 820);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.White;

            lblTitle = new Label();
            lblTitle.Text = "Minesweeper";
            lblTitle.Font = new Font("Arial", 26, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(190, 30);

            picBomb = new PictureBox();
            picBomb.Size = new Size(160, 160);
            picBomb.Location = new Point(230, 85);
            picBomb.SizeMode = PictureBoxSizeMode.Zoom;
            picBomb.BackColor = Color.Transparent;

            string duongDanAnh = Path.Combine(Application.StartupPath, "Image", "Boom(mainmenu).png");
            if (File.Exists(duongDanAnh))
            {
                picBomb.Image = Image.FromFile(duongDanAnh);
            }

            lblNamePrompt = new Label();
            lblNamePrompt.Text = "Tên người chơi:";
            lblNamePrompt.Font = new Font("Arial", 12, FontStyle.Bold);
            lblNamePrompt.Location = new Point(155, 260);
            lblNamePrompt.AutoSize = true;

            txtPlayerName = new TextBox();
            txtPlayerName.Text = "Người chơi 1";
            txtPlayerName.Font = new Font("Arial", 12);
            txtPlayerName.Size = new Size(310, 30);
            txtPlayerName.Location = new Point(155, 290);

            btnPlay = CreateButton("Chơi", 340);
            btnGuide = CreateButton("Hướng dẫn", 420);
            btnThanhTich = CreateButton("Thành tích", 500);
            btnAbout = CreateButton("Thông tin", 580);
            btnExit = CreateButton("Thoát", 660);

            chkSound = new CheckBox();
            chkSound.Text = "Âm thanh";
            chkSound.Font = new Font("Arial", 14);
            chkSound.AutoSize = true;
            chkSound.Location = new Point(25, 760);
            chkSound.Checked = true;
            chkSound.CheckedChanged += (s, e) => amThanhBat = chkSound.Checked;

            btnPlay.Click += BtnPlay_Click;
            btnGuide.Click += BtnGuide_Click;
            btnThanhTich.Click += BtnThanhTich_Click;
            btnAbout.Click += BtnAbout_Click;
            btnExit.Click += BtnExit_Click;

            this.Controls.Add(lblTitle);
            this.Controls.Add(picBomb);
            this.Controls.Add(lblNamePrompt);
            this.Controls.Add(txtPlayerName);
            this.Controls.Add(btnPlay);
            this.Controls.Add(btnGuide);
            this.Controls.Add(btnThanhTich);
            this.Controls.Add(btnAbout);
            this.Controls.Add(btnExit);
            this.Controls.Add(chkSound);
        }

        private Button CreateButton(string text, int topPosition)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Font = new Font("Arial", 16, FontStyle.Bold);
            btn.Size = new Size(220, 60);
            btn.Location = new Point(200, topPosition);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 2;
            btn.Cursor = Cursors.Hand;
            return btn;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            PhatAmThanh("click.wav");
            string name = txtPlayerName.Text.Trim();
            frmGame gameForm = new frmGame(name);
            this.Hide();
            gameForm.ShowDialog();
            this.Show();
        }

        private void BtnGuide_Click(object sender, EventArgs e)
        {
            PhatAmThanh("click.wav");
            frmHuongDan formHuongDan = new frmHuongDan();
            formHuongDan.ShowDialog();
        }

        private void BtnThanhTich_Click(object sender, EventArgs e)
        {
            PhatAmThanh("click.wav");
            frmThanhTich formThanhTich = new frmThanhTich();
            formThanhTich.ShowDialog();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            PhatAmThanh("click.wav");
            frmAbout formAbout = new frmAbout();
            formAbout.ShowDialog();
        }

        private void PhatAmThanh(string tenFile)
        {
            if (!amThanhBat) return;
            string duongDan = Path.Combine(Application.StartupPath, "Sound", tenFile);
            cTienTich.PhatAmThanhAnToan(duongDan);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            PhatAmThanh("click.wav");
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát game không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmMainMenu_Load(object sender, EventArgs e) {
        }
    }
}