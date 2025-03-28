namespace GiuaKy.Models
{
    public class Sinhvien
    {
        public int MaSV { get; set; }
        public string Hodem { get; set; }
        public string Ten { get; set; }
        public string Ngaysinh { get; set; }
        public string Noisinh { get; set; }
        public int Gioitinh { get; set; }
        public string HinhSV { get; set; }
        public ICollection<DiemThi> DiemThis { get; set; }

    }
}
