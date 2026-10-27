using Game_giữa_kì.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Game_giữa_kì
{
    public partial class frmThanhTich : Form
    {
        private List<cThanhTich> _danhSachGoc = new List<cThanhTich>();
        public frmThanhTich() {
            InitializeComponent();
        }
        private void frmThanhTich_Load(object sender, EventArgs e)
        {
            try {
                KhoiTaoCotDataGridView();
                TaiVaHienThiDuLieu();
                cboLocCapDo.SelectedIndex = 0;
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi khi khởi tạo bảng thành tích: " + ex.Message,
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void KhoiTaoCotDataGridView() {
            dgvThanhTich.ColumnCount = 5;
            dgvThanhTich.Columns[0].Name = "Hạng";
            dgvThanhTich.Columns[1].Name = "Tên Người Chơi";
            dgvThanhTich.Columns[2].Name = "Cấp Độ";
            dgvThanhTich.Columns[3].Name = "Thời Gian";
            dgvThanhTich.Columns[4].Name = "Ngày Chơi";

            dgvThanhTich.Columns[0].FillWeight = 14;
            dgvThanhTich.Columns[1].FillWeight = 30;
            dgvThanhTich.Columns[2].FillWeight = 18;
            dgvThanhTich.Columns[3].FillWeight = 16;
            dgvThanhTich.Columns[4].FillWeight = 22;

            foreach (DataGridViewColumn col in dgvThanhTich.Columns) {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void TaiVaHienThiDuLieu() {
            try {
                _danhSachGoc = cThanhTich.DocDanhSachThanhTich();
                cThanhTich.SapXepDanhSach(_danhSachGoc);
                HienThiLenBang(_danhSachGoc);
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi khi tải dữ liệu thành tích: " + ex.Message,
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void HienThiLenBang(List<cThanhTich> danhSachHienThi)
        {
            try
            {
                dgvThanhTich.Rows.Clear();

                for (int i = 0; i < danhSachHienThi.Count; i++)
                {
                    cThanhTich tt = danhSachHienThi[i];

                    int phut = tt.ThoiGian / 60;
                    int giay = tt.ThoiGian % 60;
                    string thoiGianHienThi = $"{phut:D2}:{giay:D2}";
                    string ngayHienThi = tt.NgayChoi.ToString("dd/MM/yyyy HH:mm");

                    string hangHienThi;
                    if (i == 0) hangHienThi = "🥇 #1";
                    else if (i == 1) hangHienThi = "🥈 #2";
                    else if (i == 2) hangHienThi = "🥉 #3";
                    else hangHienThi = "#" + (i + 1);

                    int rowIndex = dgvThanhTich.Rows.Add(
                        hangHienThi,
                        tt.Ten,
                        tt.CapDo,
                        thoiGianHienThi,
                        ngayHienThi
                    );

                    DataGridViewRow row = dgvThanhTich.Rows[rowIndex];
                    if (i == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(254, 249, 195);
                        row.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    }
                    else if (i == 1)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(226, 232, 240);
                        row.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    }
                    else if (i == 2)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(254, 215, 170);
                        row.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    }
                }

                lblTongSo.Text = $"Tổng số kỷ lục: {danhSachHienThi.Count}";
                dgvThanhTich.ClearSelection();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hiển thị bảng: " + ex.Message);
            }
        }
        private void cboLocCapDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboLocCapDo.SelectedItem == null) return;

                string luaChon = cboLocCapDo.SelectedItem.ToString().ToLower().Trim();
                if (luaChon == "tất cả")
                {
                    HienThiLenBang(_danhSachGoc);
                }
                else
                {
                    var dsLoc = _danhSachGoc
                        .Where(x => x.CapDo != null && x.CapDo.ToLower().Trim().Contains(luaChon))
                        .ToList();
                    HienThiLenBang(dsLoc);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lọc cấp độ: " + ex.Message);
            }
        }
        private void btnXoaLichSu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa toàn bộ lịch sử thành tích không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (File.Exists("thanhtichs.txt"))
                    {
                        File.Delete("thanhtichs.txt");
                    }
                    _danhSachGoc.Clear();
                    HienThiLenBang(_danhSachGoc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa file thành tích: " + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}