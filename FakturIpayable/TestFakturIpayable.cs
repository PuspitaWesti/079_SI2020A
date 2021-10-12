using System;
using System.Collections.Generic;
using System.Text;

namespace FakturIpayable
{
    class TestFakturIpayable
    {
        static void Main(string[] args)
        {
            IPayable[] payableObjects = new IPayable[4];

            payableObjects[0] = new Faktur("01234", "seat", 2, 375.00M);
            payableObjects[1] = new Faktur("56789", "tire", 4, 79.95M);
            payableObjects[2] = new GajiKaryawan("John", "Smith", "111-11-1111", 800.00M);
            payableObjects[3] = new GajiKaryawan("Lisa", "Barnes", "888-88-8888", 1200.00M);

            Console.WriteLine("Faktur dan Karyawan akan diproses secara polymorphisme");

            foreach (IPayable currentPayable in payableObjects)
            {
                Console.WriteLine("{0} \n{1}: {2:C}\n", currentPayable, "tanggal jatuh tempo", currentPayable.DapatkanJumlahPembayaran());
            }
            Console.ReadLine();
        }
    }
}
