using System;

namespace JohnTravolta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bagaimana kami akan memanggilmu? ");
            String nama = Console.ReadLine();
            
            Start(nama);
        }


        static void Start(String nama){
            Console.Clear();
            Console.WriteLine("Selamat datang, {0}", nama);
            Console.WriteLine("Jabatan : ");
            System.Console.WriteLine("1. Direktur");
            System.Console.WriteLine("2. Manajer");
            System.Console.WriteLine("3. Karyawan");

            System.Console.Write("Silahkan pilih nomor jabatan anda: ");
            int jabatan = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Silahkan masukkan total jam kerja anda minggu ini: ");
            int jamKerja = Convert.ToInt32(Console.ReadLine());

            hitungGaji(jabatan,jamKerja);
        }

        static void hitungGaji (int jabatan, int jamKerja){
            int jamLembur = 0;
            double gajiPerJam = 0.2f;
            double totalGaji = 0.2f;

            switch (jabatan)
            {
                case 1 : 
                    gajiPerJam = 30_000;
                    if (jamKerja > 40)
                    {
                        jamLembur = jamKerja - 40;
                        jamKerja = 40;
                    }
                    totalGaji = (gajiPerJam * jamKerja) + ((gajiPerJam * 1.5) * jamLembur);
                    break;

                case 2 : 
                    gajiPerJam = 20_000;
                    if (jamKerja > 40)
                    {
                        jamLembur = jamKerja - 40;
                        jamKerja = 40;
                    }
                    totalGaji = (gajiPerJam * jamKerja) + ((gajiPerJam * 1.5) * jamLembur);
                    break;

                case 3 : 
                    gajiPerJam = 15_000;
                    if (jamKerja > 40)
                    {
                        jamLembur = jamKerja - 40;
                        jamKerja = 40;
                    }
                    totalGaji = (gajiPerJam * jamKerja) + ((gajiPerJam * 1.5) * jamLembur);
                    break;

                default : break;
            }
            
            System.Console.WriteLine("Anda mendapatkan gaji sebesar Rp.{0} minggu ini.", totalGaji);
            System.Console.Write("Apakah anda ingin melihat detail gaji anda? (y/n) ");
            char yn = Convert.ToChar(Console.ReadLine());

            if (yn.Equals('y') || yn.Equals('Y')){
                Details(jamKerja, jamLembur, gajiPerJam, totalGaji);
            }
            else
            {
                Menabung(totalGaji);       
            }        
        }

        static void Details(int jamKerja, int jamLembur, double gajiPerJam, double totalGaji){
            Console.Clear();
            System.Console.WriteLine("\t\t\t DETAIL GAJI\n\n");
            System.Console.WriteLine("Gaji anda perjamnya adalah Rp.{0}. Dengan tambahan 150% untuk setiap jam lembur", gajiPerJam);
            System.Console.WriteLine("Setiap jam anda kerja di atas 40 jam akan dihitung sebagai jam lembur.");
            System.Console.WriteLine("Anda kerja {0} jam minggu ini, dengan jam lembur sebanyak {1} jam.", (jamKerja + jamLembur), jamLembur);
            System.Console.WriteLine("Gaji anda berdasarkan jam kerja adalah Rp.{0}", (gajiPerJam * jamKerja));
            System.Console.WriteLine("Gaji anda berdasarkan jam lembur adalah Rp.{0}", ((gajiPerJam * 1.5) * jamLembur));
            System.Console.WriteLine("Sehingga total gaji anda adalah Rp.{0}", totalGaji);

            System.Console.WriteLine("\n\n");
            System.Console.Write("Silahkan pencet tombol apapun untuk melanjutkan");
            Console.ReadKey();

            Menabung(totalGaji);
        }
        static void Menabung(double totalGaji){
            Console.Clear();
            System.Console.WriteLine("\t\t\t PROGRAM MENABUNG\n\n");
            System.Console.WriteLine("Anda telah menghasilkan Rp.{0} mingggu ini.", totalGaji);
            System.Console.Write("Silahkan masukkan pengeluaran anda minggu ini: ");
            double pengeluaran = Convert.ToDouble(Console.ReadLine());

            if (totalGaji > pengeluaran){
                System.Console.WriteLine("Anda bisa menabung setidaknya Rp.{0} minggu ini", (totalGaji-pengeluaran));
            }
            else if (totalGaji <= pengeluaran){
                System.Console.WriteLine("Anda tidak bisa menabung");
                if (totalGaji < pengeluaran){
                    System.Console.WriteLine("Kami sarankan agar anda mencari masukan tambahan, atau mengurangi pengeluaran anda.");
                }
            }

            Exit();
        }
        

        static void Exit(){
            System.Console.WriteLine("Terimakasih sudah menggunakan aplikasi kami");
            Console.ReadKey();
        }
    }
}
