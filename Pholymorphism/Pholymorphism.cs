using System;

namespace Pholymorphism
{
    public abstract class Karyawan
    {
        private string NamaDepan;
        private string NamaBelakang;
        private string SSN;
        public Karyawan(string Depan, string Belakang, string ssn)
        {
            NamaDepan = Depan;
            NamaBelakang = Belakang;
            SSN = ssn;
        }
        public string namaDepan
        {
            get
            {
                return NamaDepan;
            }
        }
        public string namaBelakang
        {
            get
            {
                return NamaBelakang;
            }
        }
        public string Ssn
        {
            get
            {
                return SSN;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}\nSSN : {2}", namaDepan, namaBelakang, Ssn);
        }
        public abstract decimal Pendapatan();
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
        public override decimal Pendapatan()
        {
            return GajiMingguan;
        }
        public override string ToString()
        {
            return string.Format("Nama Karyawan : {0}\n{1}: {2:C}", base.ToString(), "Gaji Mingguan", GajiMingguan);
        }
    }
    public class KaryawanPerjam : Karyawan
    {
        private decimal upah;
        private decimal jam;

        public KaryawanPerjam(string Depan, string Belakang, string ssn, decimal upahPerjam, decimal jamKerja)
            : base(Depan, Belakang, ssn)
        {
            Upah = upahPerjam;
            Jam = jamKerja;
        }
        public decimal Upah
        {
            get
            {
                return upah;
            }
            set
            {
                upah = (value >= 0) ? value : 0;
            }
        }
        public decimal Jam
        {
            get
            {
                return jam;
            }
            set
            {
                jam = ((value >= 0) && (value <= 168)) ? value : 0;
            }
        }
        public override decimal Pendapatan()
        {
            if (Jam <= 40)
                return Upah * Jam;
            else
                return (40 * Upah) + ((Jam - 40) * 1.5M);
        }
        public override string ToString()
        {
            return string.Format("Karyawan per jam : {0}\n{1}: {2:C}; {3}: {4:F2}", base.ToString(), "Upah/jam", Upah, "\nBanyak Jam Kerja", Jam);
        }
    }
    public class KomisiKaryawan : Karyawan
    {
        private decimal penjualanKotor;
        private decimal tingkatKomisi;

        public KomisiKaryawan(string Depan, string Belakang, string ssn, decimal penjualan, decimal tingkat)
            : base(Depan, Belakang, ssn)
        {
            PenjualanKotor = penjualan;
            TingkatKomisi = tingkat;
        }
        public decimal PenjualanKotor
        {
            get
            {
                return penjualanKotor;
            }
            set
            {
                penjualanKotor = (value >= 0) ? value : 0;
            }
        }
        public decimal TingkatKomisi
        {
            get
            {
                return tingkatKomisi;
            }
            set
            {
                tingkatKomisi = (value > 0 && value < 1) ? value : 0;
            }
        }
        public override decimal Pendapatan()
        {
            return TingkatKomisi * PenjualanKotor;
        }
        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}", "\nKomisi Karyawan", base.ToString(), "Penjualan Kotor", PenjualanKotor, "Tingkat Komisi", TingkatKomisi);
        }
    }
    public class KomisiTambahanKaryawan : KomisiKaryawan
    {
        private decimal gajiPokok;

        public KomisiTambahanKaryawan(string Depan, string Belakang, string ssn, decimal penjualan, decimal tingkat, decimal gaji)
            : base(Depan, Belakang, ssn, penjualan, tingkat)
        {
            GajiPokok = gaji;
        }
        public decimal GajiPokok
        {
            get
            {
                return gajiPokok;
            }
            set
            {
                gajiPokok = (value >= 0) ? value : 0;
            }
        }
        public override decimal Pendapatan()
        {
            return GajiPokok * base.Pendapatan();
        }
        public override string ToString()
        {
            return string.Format("{0} {1}; {2}: {3:C}", "Gaji-Pokok", base.ToString(), "\nGaji Pokok", GajiPokok);
        }
    }
}