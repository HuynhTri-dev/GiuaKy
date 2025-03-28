using System.ComponentModel.DataAnnotations;

namespace GiuaKy.Models
{
    public class DiemThi
    {
        public int MaSV { get; set; }

        [MaxLength(10)]
        public string MaMH { get; set; }
        public float DiemThi1 { get; set; }
        public float DiemThi2 { get; set; }
        public Sinhvien SinhVien { get; set; }
        public MonHoc MonHoc { get; set; }
    }
}
