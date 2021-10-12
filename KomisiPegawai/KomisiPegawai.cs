using System;

namespace KomisiPegawai
{
    public class KomisiPegawai : Object
    {
        public String NamaDepan;
        public String NamaBelakang;
        public String NomorKTP;
        private Decimal penjualanKotor; //Penjualan mingguan kotor
        private Decimal tingkatKomisi; //Persentasi komisi

        public KomisiPegawai(String namaDepan, String namaBelakang, String nomorKTP, Decimal penjualanKotor, Decimal tingkatKomisi)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NomorKTP = nomorKTP;
            PenjualanKotor = penjualanKotor; //Validasi penjualan kotor
            TingkatKomisi = tingkatKomisi; //Validasi tingkat komisi
        }
        public void setNamaDepan(string namaDepan)
        {
            NamaDepan = namaDepan;
        }
        public string getNamaDepan()
        {
            return NamaDepan;
        }
        public void setNamaBelakang(string namaBelakang)
        {
            NamaBelakang = namaBelakang;
        }
        public string getNamaBelakang()
        {
            return NamaBelakang;
        }
        public void setNomorKTP(string nomorKTP)
        {
            NomorKTP = nomorKTP;
        }
        public string getNomorKTP()
        {
            return NomorKTP;
        }
        public Decimal PenjualanKotor
        {
            get
            {
                return penjualanKotor;
            }
            set
            {
                penjualanKotor = (value < 0) ? 0 : value;
            }
        }
        public Decimal TingkatKomisi
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
        //Menghitung uang komisi pegawai
        public Decimal Pendapatan() => tingkatKomisi * penjualanKotor;
        //Mengembalikan representasi string dari objek komisi pegawai
        public override string ToString() =>
            $"komisi pegawai : {NamaDepan} {NamaBelakang}\n" +
            $"nomor KTP : {NomorKTP}\n" +
            $"penjualan kotor : {penjualanKotor:C}\n" +
            $"tingkat komisi : {tingkatKomisi:F2}";
    }
}
