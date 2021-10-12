using System;

namespace FakturIpayable
{
    public interface IPayable
    {
        decimal DapatkanJumlahPembayaran();
    }
    public class Faktur : IPayable
    {
        private string bagianNomor;
        private string bagianDeskripsi;
        private int kuantitas;
        private decimal hargaPeritem;

        public Faktur(string bagian, string deskripsi, int menghitung, decimal harga)
        {
            BagianNomor = bagian;
            BagianDeskripsi = deskripsi;
            Kuantitas = menghitung;
            HargaPeritem = harga;
        }
        public string BagianNomor
        {
            get
            {
                return bagianNomor;
            }
            set
            {
                bagianNomor = value;
            }
        }
        public string BagianDeskripsi
        {
            get
            {
                return bagianDeskripsi;
            }
            set
            {
                bagianDeskripsi = value;
            }
        }
        public int Kuantitas
        {
            get
            {
                return kuantitas;
            }
            set
            {
                kuantitas = (value < 0) ? 0 : value;
            }
        }
        public decimal HargaPeritem
        {
            get
            {
                return hargaPeritem;
            }
            set
            {
                hargaPeritem = (value < 0) ? 0 : value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}: \n{1}: {2} ({3}) \n{4}: {5} \n{6}: {7:C}", "faktur", "Bagian Nomor", BagianNomor, BagianDeskripsi, "Kuantitas", Kuantitas, "Harga per item", HargaPeritem);
        }
        public decimal DapatkanJumlahPembayaran()
        {
            return Kuantitas * HargaPeritem;
        }
    }
    public abstract class Karyawan : IPayable
    {
        private string namaDepan;
        private string namaBelakang;
        private string socialSecurityNumber;
        public Karyawan(string Depan, string Belakang, string ssn)
        {
            namaDepan = Depan;
            namaBelakang = Belakang;
            socialSecurityNumber = ssn;
        }
        public string NamaDepan
        {
            get
            {
                return namaDepan;
            }
        }
        public string NamaBelakang
        {
            get
            {
                return namaBelakang;
            }
        }
        public string SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}\nSocial Security Number : {2}", NamaDepan, NamaBelakang, SocialSecurityNumber);
        }
        public abstract decimal DapatkanJumlahPembayaran();
    }
    public class GajiKaryawan : Karyawan
    {
        private decimal gajiMingguan;

        public GajiKaryawan(string Depan, string Belakang, string ssn, decimal gaji)
            : base(Depan, Belakang, ssn)
        {
            GajiMingguan = gaji;
        }
        public decimal GajiMingguan
        {
            get
            {
                return gajiMingguan;
            }
            set
            {
                gajiMingguan = ((value >= 0) ? value : 0);
            }
        }
        public override decimal DapatkanJumlahPembayaran()
        {
            return GajiMingguan;
        }
        public override string ToString()
        {
            return string.Format("Gaji karyawan : {0}\n{1}: {2:C}", base.ToString(), "gaji mingguan", GajiMingguan);
        }
    }
}
