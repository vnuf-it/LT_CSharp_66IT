namespace Core_WebAPI.Models
{
    public abstract class People
    {
        string cccd;
        string hodem;
        string ten;
        string bietdanh;
        string email;
        string dienthoai;
        int tuoi;

        public string Cccd { get => cccd; set => cccd = value; }
        public string Hodem { get => hodem; set => hodem = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Bietdanh { get => bietdanh; set => bietdanh = value; }
        public string Email { get => email; set => email = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }

        public People(string _hodem, string _ten)
        {
            this.Hodem = _hodem;
            this.Ten = _ten;
        }

        public People(string _cccd, string _hodem, string _ten)
        {
            this.Cccd = _cccd;
            this.Hodem = _hodem;
            this.Ten = _ten;
        }
        public People(string _hodem, string _ten, int _tuoi)
        {
            this.Hodem = _hodem;
            this.Ten = _ten;
            this.Tuoi = _tuoi;
        }

        public People(string _hodem, string _ten, string _dienthoai, string _email)
        {
            this.Hodem = _hodem;
            this.Ten = _ten;
            this.Dienthoai = _dienthoai;
            this.Email = _email;
        }

        public abstract string GetHoVaTen();

    }
}
