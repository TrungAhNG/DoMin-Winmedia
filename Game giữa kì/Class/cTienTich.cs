using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_giữa_kì.Class {
    internal class cTienTich {
        public static void LoadAnhAnToan(PictureBox picBox, string duongDanAnh) {
            if (picBox == null) return;

            try
            {
                if (string.IsNullOrWhiteSpace(duongDanAnh) || !File.Exists(duongDanAnh))
                {
                    picBox.Image = TaoAnhMacDinh(picBox.Width, picBox.Height);
                    return;
                }

                if (picBox.Image != null)
                {
                    picBox.Image.Dispose();
                    picBox.Image = null;
                }

                using (FileStream fs = new FileStream(duongDanAnh, FileMode.Open, FileAccess.Read))
                {
                    picBox.Image = Image.FromStream(fs);
                }
            }
            catch
            {
                picBox.Image = TaoAnhMacDinh(picBox.Width, picBox.Height);
            }
        }

        public static void PhatAmThanhAnToan(string duongDanAmThanh) {
            try
            {
                if (string.IsNullOrWhiteSpace(duongDanAmThanh) || !File.Exists(duongDanAmThanh)) return;

                using (SoundPlayer player = new SoundPlayer(duongDanAmThanh))
                {
                    player.Play();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi phát âm thanh: " + ex.Message);
            }
        }

        private static Image TaoAnhMacDinh(int width, int height) {
            try {
                int w = Math.Max(width, 60);
                int h = Math.Max(height, 60);
                Bitmap bmp = new Bitmap(w, h);
                using (Graphics g = Graphics.FromImage(bmp)) {
                    g.Clear(Color.FromArgb(226, 232, 240));
                    using (Pen pen = new Pen(Color.FromArgb(148, 163, 184), 2)) {
                        g.DrawRectangle(pen, 1, 1, w - 2, h - 2);
                    }
                    using (Font font = new Font("Segoe UI", 9F, FontStyle.Bold))
                    using (Brush brush = new SolidBrush(Color.FromArgb(100, 116, 139))) {
                        StringFormat sf = new StringFormat {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        };
                        g.DrawString("No Image", font, brush, new RectangleF(0, 0, w, h), sf);
                    }
                }
                return bmp;
            }
            catch {
                return null;
            }
        }
    }
}