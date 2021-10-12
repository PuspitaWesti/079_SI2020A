using System;
using System.Collections.Generic;
using System.Text;

namespace Pholymorphism
{
    class TestPholymorphism
    {
        static void Main(string[] args)
        {
            GajiKaryawan gajiKaryawan = new GajiKaryawan("John", "Smith", "111-11-1111", 800.00M);
            KaryawanPerjam karyawanPerjam = new KaryawanPerjam("Karen", "Price", "222-22-2222", 16.75M, 40.0M);
            KomisiKaryawan komisiKaryawan = new KomisiKaryawan("Sue", "Jones", "333-33-3333", 10000.00M, .06M);
            KomisiTambahanKaryawan komisiTambahanKaryawan = new KomisiTambahanKaryawan("Bob", "Lewis", "444-44-4444", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Karyawan diproses secara Individual :\n");
            Console.WriteLine("{0}\n{1}: {2:C}\n", gajiKaryawan, "Diperoleh", gajiKaryawan.Pendapatan());
            Console.WriteLine("{0}\n{1}: {2:C}\n", karyawanPerjam, "Diperoleh", karyawanPerjam.Pendapatan());
            Console.WriteLine("{0}\n{1}: {2:C}\n", komisiKaryawan, "Diperoleh", komisiKaryawan.Pendapatan());
            Console.WriteLine("{0}\n{1}: {2:C}\n", komisiTambahanKaryawan, "Diperoleh", komisiTambahanKaryawan.Pendapatan());

            Karyawan[] karyawan = new Karyawan[4];

            karyawan[0] = gajiKaryawan;
            karyawan[1] = karyawanPerjam;
            karyawan[2] = komisiKaryawan;
            karyawan[3] = komisiTambahanKaryawan;

            Console.WriteLine("Karyawan diproses secara Polimorfisme:\n");

            foreach (Karyawan karyawanSekarang in karyawan)
            {
                Console.WriteLine(karyawanSekarang);
                if (karyawanSekarang is KomisiTambahanKaryawan)
                {
                    KomisiTambahanKaryawan pegawai = (KomisiTambahanKaryawan)karyawanSekarang;

                    pegawai.GajiPokok *= 1.10M;
                    Console.WriteLine("Gaji pokok baru dengan kenaikan 10% adalah : {0:C}", pegawai.GajiPokok);
                }
                Console.WriteLine("Diperoleh {0:C}\n", karyawanSekarang.Pendapatan());
            }
            for (int j = 0; j < karyawan.Length; j++)
                Console.WriteLine("Pegawai {0} is a {1}", j, karyawan[j].GetType());
            Console.ReadLine();
        }
    }
}
