using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisiTambahanPegawai
{
    class TestKomisiTambahanPegawai
    {
        public static void Main(string[] args)
        {
            var pegawai = new KomisiTambahanPegawai("Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Informasi Pegawai di dapatkan dengan properti dan metode :\n");
            Console.WriteLine($"Nama depan : {pegawai.NamaDepan}");
            Console.WriteLine($"Nama belakang : {pegawai.NamaBelakang}");
            Console.WriteLine($"Nomor KTP : {pegawai.NomorKTP}");
            Console.WriteLine($"Penjualan terakhir : {pegawai.PenjualanKotor:C}");
            Console.WriteLine($"Tingkat komisi : {pegawai.TingkatKomisi:F2}");
            Console.WriteLine($"Pendapatan : {pegawai.Pendapatan():C}");
            Console.WriteLine($"Gaji pokok pegawai : {pegawai.GajiPokok:C}");

            pegawai.GajiPokok = 1000.00M; //set gaji pokok

            Console.WriteLine("\nPembaruan informasi pegawai diperoleh dari ToString:\n");
            Console.WriteLine(pegawai);
            Console.WriteLine($"Pendapatan : {pegawai.Pendapatan():C}");
        }
    }
}

