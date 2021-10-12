using System;
using System.Collections.Generic;
using System.Text;

namespace KomisiPegawai
{
    class TestKomisiPegawai
    {
        static void Main()
        {
            var pegawai = new KomisiPegawai("Sue", "Jones", "222-22-2222", 10000.00M, .06M);

            Console.WriteLine("Informasi Pegawai di dapatkan dengan properti dan metode :\n");
            Console.WriteLine($"Nama depan : {pegawai.NamaDepan}");
            Console.WriteLine($"Nama belakang : {pegawai.NamaBelakang}");
            Console.WriteLine($"Nomor KTP : {pegawai.NomorKTP}");
            Console.WriteLine($"Penjualan terakhir : {pegawai.PenjualanKotor:C}");
            Console.WriteLine($"Tingkat komisi : {pegawai.TingkatKomisi:F2}");
            Console.WriteLine($"Pendapatan : {pegawai.Pendapatan():C}");

            pegawai.PenjualanKotor = 5000.00M; //set penjualan kotor
            pegawai.TingkatKomisi = .1M; //set tingkat komisi

            Console.WriteLine("\nPembaruan informasi pegawai diperoleh dari ToString:\n");
            Console.WriteLine(pegawai);
            Console.WriteLine($"Pendapatan : {pegawai.Pendapatan():C}");
        }
    }
}
