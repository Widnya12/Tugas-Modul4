using System;

namespace Tugas_Modul4_Kelompok40
{
    public class Weapon
    {
        public static void Pistol()
        {
            Console.WriteLine("USP, Desert Eagle, dan Dual Berettas");
            Console.WriteLine("Total Harga : 1550");
        }
        public static void Shotgun()
        {
            Console.WriteLine("M3 dan XM1014");
            Console.WriteLine("Total Harga : 3700");
        }
        public static void SMG()
        {
            Console.WriteLine("MP7, UMP-45, P90, dan PP-Bizon");
            Console.WriteLine("Total Harga : 7150");
        }
        public static void Rifle()
        {
            Console.WriteLine("FAMAS, M4A1, dan AUG");
            Console.WriteLine("Total Harga : 8650");
        }
        public static void Sniper()
        {
            Console.WriteLine("Schmidt Scout dan AWP");
            Console.WriteLine("Total Harga : 7500");
        }
        public static void MG()
        {
            Console.WriteLine("M249 dan Negev");
            Console.WriteLine("Total Harga : 11450");
        }
    }
    public class Ahmad
    {
        static void Main(string[] args)
        {
            {
                string Nama, Beli, Pilihan, Metode, Rekening, Transaksi;
                int a, b, c, exit = 0;
                Console.WriteLine("\t\tWeapon Shop\n");
            awal:
                Console.WriteLine("Silahkan Masukkan Nama Anda :");
                Nama = Console.ReadLine();
                Console.WriteLine("Selamat Datang {0} di Weapon Shop, Selamat berbelanja", Nama);
                do
                {
                    Console.WriteLine("Apakah Anda akan Membeli Senjata Kami? Ya/Tidak :");
                    Beli = Console.ReadLine();
                    if (Beli == "Ya")
                    {
                        Console.WriteLine("Pilih Menu Anda, senjata hanya dapat dibeli per kelasnya, tidak bisa dibeli secara eceran :");
                        Console.WriteLine("1. Pistol");
                        Console.WriteLine("2. Shotgun");
                        Console.WriteLine("3. Sub-Machine Gun");
                        Console.WriteLine("4. Rifle");
                        Console.WriteLine("5. Sniper Rifle");
                        Console.WriteLine("6. Machine Gun");
                        Console.WriteLine("Silahkan Masukan Pilihan Anda :");
                        Pilihan = Console.ReadLine();
                        int.TryParse(Pilihan, out a);
                        switch (Pilihan)
                        {
                            case "1":
                                Weapon.Pistol();
                                break;
                            case "2":
                                Weapon.Shotgun();
                                break;
                            case "3":
                                Weapon.SMG();
                                break;
                            case "4":
                                Weapon.Rifle();
                                break;
                            case "5":
                                Weapon.Sniper();
                                break;
                            case "6":
                                Weapon.MG();
                                break;
                        }
                        Console.WriteLine("Pilih Metode Pembayaran :");
                        Console.WriteLine("1. Mandiri");
                        Console.WriteLine("2. BNI");
                        Console.WriteLine("3. BCA");
                        Console.WriteLine("Pilihan Anda :");
                        Metode = Console.ReadLine();
                        int.TryParse(Metode, out b);
                        Console.WriteLine("Masukkan No Rekening Anda :");
                        Rekening = Console.ReadLine();
                        int.TryParse(Rekening, out c);
                        Console.WriteLine("Pembelian senjata dari {0} dengan nomer rekening {1} telah berhasil", Nama, Rekening);
                    }
                    else if (Beli == "Tidak")
                    {
                        Console.WriteLine("Terimakasih telah datang ke Weapon Shop");
                        Console.ReadLine();
                        return;

                    }
                    Console.WriteLine("Apakah anda ingin membeli senjata lagi ? Ya/Tidak : ");
                    Transaksi = Console.ReadLine();
                    if (Transaksi == "Ya")
                    {
                        goto awal;
                    }
                    else if (Transaksi == "Tidak")
                    {
                        Console.WriteLine("Terimakasih sudah berbelanja di Weapon Shop");
                        Console.ReadLine();
                        return;
                    }
                } while (exit == 0);
            }
        }
    }
}