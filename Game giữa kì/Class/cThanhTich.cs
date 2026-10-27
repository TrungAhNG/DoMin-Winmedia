using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_giữa_kì.Class {
    internal class cThanhTich {
        public string Ten { get; set; }
        public string CapDo { get; set; }
        public int ThoiGian { get; set; }
        public DateTime NgayChoi { get; set; }
        private static readonly string FilePath = "thanhtichs.txt";
        private static readonly string DateFormat = "dd/MM/yyyy HH:mm";
        public cThanhTich(string ten, string capDo, int thoiGian, DateTime ngayChoi) {
            this.Ten = ten;
            this.CapDo = capDo;
            this.ThoiGian = thoiGian;
            this.NgayChoi = ngayChoi;
        }
        public cThanhTich() { 
        }
        public string ToSaveString() {
            string tenAnToan = string.IsNullOrWhiteSpace(Ten) ? "Người chơi" : Ten.Replace("|", "-").Trim();
            string capDoAnToan = string.IsNullOrWhiteSpace(CapDo) ? "Dễ" : CapDo.Replace("|", "-").Trim();
            return $"{tenAnToan}|{capDoAnToan}|{ThoiGian}|{NgayChoi.ToString(DateFormat, CultureInfo.InvariantCulture)}";
        }
        public static void GhiThanhTich(cThanhTich nguoiChoiMoi) {
            try {
                if (nguoiChoiMoi == null) return;
                using (StreamWriter sw = new StreamWriter(FilePath, true, Encoding.UTF8)) {
                    sw.WriteLine(nguoiChoiMoi.ToSaveString());
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Lỗi ghi file thành tích: " + ex.Message);
            }
        }
        public static List<cThanhTich> DocDanhSachThanhTich() {
            List<cThanhTich> danhSach = new List<cThanhTich>();
            try {
                if (!File.Exists(FilePath)) return danhSach;
                using (StreamReader sr = new StreamReader(FilePath, Encoding.UTF8)) {
                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        string[] parts = line.Split('|');
                        if (parts.Length == 4) {
                            bool isTimeValid = int.TryParse(parts[2].Trim(), out int thoiGian);
                            bool isDateValid = DateTime.TryParseExact (
                                parts[3].Trim(),
                                new[] { "dd/MM/yyyy HH:mm", "dd/MM/yyyy", "d/M/yyyy HH:mm", "d/M/yyyy" },
                                CultureInfo.InvariantCulture,
                                DateTimeStyles.None,
                                out DateTime ngayChoi
                            );
                            if (!isDateValid) {
                                isDateValid = DateTime.TryParse(parts[3].Trim(), out ngayChoi);
                            }
                            if (isTimeValid && isDateValid) {
                                cThanhTich tt = new cThanhTich(parts[0].Trim(), parts[1].Trim(), thoiGian, ngayChoi);
                                danhSach.Add(tt);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Lỗi đọc file thành tích: " + ex.Message);
            }
            return danhSach;
        }
        private static int LayTrongSoCapDo(string capDo) {
            if (string.IsNullOrWhiteSpace(capDo)) return 4;
            string cd = capDo.ToLower().Trim();
            if (cd.Contains("khó") || cd.Contains("kho") || cd.Contains("hard")) return 1;
            if (cd.Contains("trung bình") || cd.Contains("trung binh") || cd.Contains("vừa") || cd.Contains("medium")) return 2;
            if (cd.Contains("dễ") || cd.Contains("de") || cd.Contains("easy")) return 3;
            return 4;
        }
        public static void SapXepDanhSach(List<cThanhTich> danhSach) {
            try {
                if (danhSach == null || danhSach.Count <= 1) return;
                danhSach.Sort((a, b) => {
                    int uuTienA = LayTrongSoCapDo(a.CapDo);
                    int uuTienB = LayTrongSoCapDo(b.CapDo);
                    if (uuTienA != uuTienB)
                        return uuTienA.CompareTo(uuTienB);
                    else
                        return a.ThoiGian.CompareTo(b.ThoiGian);
                });
            }
            catch (Exception ex) {
                Console.WriteLine("Lỗi sắp xếp danh sách: " + ex.Message);
            }
        }
    }
}