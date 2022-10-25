using System;

namespace uts_pemograman
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            string username;
            string type;
            string merk;
            double diskon;
            double total_diskon;
            double total;
            Console.WriteLine("www.kelompok7.com");
            Console.Write("masukan username anda = ");
            username = Console.ReadLine();

            if (username == "aman345") {
                Console.Write("Masukan Password Anda = ");
                password = Console.ReadLine();
                if (password =="22421073") {
                    Console.WriteLine("Selamat Datang Aman");
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Pilih beragam Merk Handphone");
                    Console.WriteLine("1. OPPO");
                    Console.WriteLine("2. VIVO");
                    merk = Console.ReadLine();
                    if (merk == "1") {
                        Console.WriteLine("Pilih type Handphone OPPO");
                        Console.WriteLine("1. OPPO F1  1.000.000");
                        Console.WriteLine("2. Reno 6  1.500.000");
                        Console.Write("Masukan Pilihan type Handphone yang akan di beli : ");
                        type = Console.ReadLine();
                        if (type == "1"){
                            Console.WriteLine("***********************");
                            Console.WriteLine("Anda telah memelih OPPO F1");
                            Console.WriteLine("RAM : 2 GB");
                            Console.WriteLine("ROM : 16 GB");
                            Console.WriteLine("***********************");
                            Console.WriteLine("****Pembelian****");
                            Console.Write("Masukan Diskon : ");
                            diskon = double.Parse(Console.ReadLine());
                            total_diskon = 1200000 * diskon;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1000000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                        else if (type == "2") {
                            Console.WriteLine("***********************");
                            Console.WriteLine("Anda telah memilih OPPO RENO 6");
                            Console.WriteLine("RAM : 6 GB");
                            Console.WriteLine("ROM : 128 GB");
                            Console.WriteLine("***********************");
                            Console.WriteLine("****Pembelian****");
                            Console.Write("Masukan Diskon : ");
                            diskon = double.Parse(Console.ReadLine());
                            total_diskon = 1500000 * diskon;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1500000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                    }
                    else if (merk == "2") {
                        Console.WriteLine("Pilih type Handphone Vivo");
                        Console.WriteLine("1. Vivo Y9   1.800.000");
                        Console.WriteLine("2. Vivo Y12  1.500.000");
                        Console.WriteLine("Masukan Pilihan type Handphone yang akan di Beli");
                        type = Console.ReadLine();
                        if (type == "1") {
                            Console.WriteLine("***********************");
                            Console.WriteLine("Anda telah memilih Vivo Y9");
                            Console.WriteLine("RAM : 3 GB");
                            Console.WriteLine("ROM : 32 GB");
                            Console.WriteLine("***********************");
                            Console.WriteLine("****Pembelian****");
                            Console.Write("Masukan Diskon : ");
                            diskon = double.Parse(Console.ReadLine());
                            total_diskon = 1800000 * diskon;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1800000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                        else if (type == "2") {
                            Console.WriteLine("***********************");
                            Console.WriteLine("Anda telah memilih Vivo Y12");
                            Console.WriteLine("RAM : 2 GB");
                            Console.WriteLine("ROM : 16 GB");
                            Console.WriteLine("***********************");
                            Console.WriteLine("****Pembelian****");
                            Console.Write("Masukan Diskon : ");
                            diskon = double.Parse(Console.ReadLine());
                            total_diskon = 1500000 * diskon;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1500000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                    }
                }
                else if (password =="22421077") {
                    Console.WriteLine("Selamat Datang Aman Aja");
                    Console.WriteLine("***********************");
                    Console.WriteLine("Pilih beragam Merk Handphone");
                    Console.WriteLine("1. OPPO");
                    Console.WriteLine("2. Vivo");
                    merk = Console.ReadLine();
                    if (merk == "1") {
                        Console.WriteLine("Pilih type Handphone OPPO");
                        Console.WriteLine("1. OPPO F1  1.000.000");
                        Console.WriteLine("2. RENO 6  1.500.000");
                        Console.Write("Masukan Pilihan type Handphone yang akan di beli : ");
                        type = Console.ReadLine();
                        if (type == "1"){
                            Console.WriteLine("***********************");
                            Console.WriteLine("Anda telah memilih OPPO F1");
                            Console.WriteLine("RAM : 2 GB");
                            Console.WriteLine("ROM : 16 GB");
                            Console.WriteLine("***********************");
                            Console.WriteLine("****Pembelian****");
                            Console.Write("Masukan Diskon : ");
                            diskon = double.Parse(Console.ReadLine());
                            total_diskon = 1200000 * diskon;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1200000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                        else if (type == "2") {
                            Console.WriteLine("***********************");
                            Console.WriteLine("Anda telah memilih RENO 6");
                            Console.WriteLine("RAM : 6 GB");
                            Console.WriteLine("ROM : 128 GB");
                            Console.WriteLine("***********************");
                            Console.WriteLine("****Pembelian****");
                            Console.Write("Masukan Diskon : ");
                            diskon = double.Parse(Console.ReadLine());
                            total_diskon = 1500000 * diskon;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1500000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                    }
                    else if (merk == "2") {
                        Console.WriteLine("Pilih type Handphone Vivo");
                        Console.WriteLine("1. Vivo Y9 1.800.000");
                        Console.WriteLine("2. Vivo Y12  1.500.000");
                        Console.WriteLine("Masukan Pilihan type Handphone yang akan di Beli");
                        type = Console.ReadLine();
                        if (type == "1") {
                            Console.WriteLine("***********************");
                            Console.WriteLine("Anda telah memilih Vivo Y9");
                            Console.WriteLine("RAM : 3 GB");
                            Console.WriteLine("ROM : 32 GB");
                            Console.WriteLine("***********************");
                            Console.WriteLine("****Pembelian****");
                            Console.Write("Masukan Diskon : ");
                            diskon = double.Parse(Console.ReadLine());
                            total_diskon = 1800000 * diskon;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1800000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                        else if (type == "2") {
                            Console.WriteLine("***********************");
                            Console.WriteLine("Anda telah memilih Vivo Y12");
                            Console.WriteLine("RAM : 2 GB");
                            Console.WriteLine("ROM : 16 GB");
                            Console.WriteLine("***********************");
                            Console.WriteLine("****Pembelian****");
                            Console.Write("Masukan Diskon : ");
                            diskon = double.Parse(Console.ReadLine());
                            total_diskon = 1500000 * diskon;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1500000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                    }
                }
                else {
                    Console.WriteLine("Password yang anda Masukan Salah");
                }
            }
            else if (username =="ardan123") {
                Console.Write("Masukan Password Anda = ");
                password = Console.ReadLine();
                if (password =="22421076") {
                    Console.WriteLine("Selamat Datang Ardan");
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Pilih beragam Merk Handphone");
                    Console.WriteLine("1. OPPO");
                    Console.WriteLine("2. Vivo");
                    merk = Console.ReadLine();
                    if (merk == "1") {
                        Console.WriteLine("Pilih type Handphone OPPO");
                        Console.WriteLine("1. Oppo F1  1.000.000");
                        Console.WriteLine("2. Reno 6  1.500.000");
                        Console.Write("Masukan Pilihan type Handphone yang akan di beli : ");
                        type = Console.ReadLine();
                        if (type == "1"){
                            Console.WriteLine("*******************");
                            Console.WriteLine("Anda telah memilih OPPO F1");
                            Console.WriteLine("1. RAM : 2 GB");
                            Console.WriteLine("1. ROM : 16 GB");
                            Console.WriteLine("*******************");
                            total_diskon = 1200000 * 0.20;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1200000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                        else if (type == "2") {
                            Console.WriteLine("*******************");
                            Console.WriteLine("Anda telah memilih RENO 6");
                            Console.WriteLine("1. RAM : 6 GB");
                            Console.WriteLine("1. ROM : 128 GB");
                            Console.WriteLine("*******************");
                            total_diskon = 1500000 * 0.20;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1500000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                    }
                    else if (merk == "2") {
                        Console.WriteLine("Pilih type Handphone Vivo");
                        Console.WriteLine("1. Vivo Y9   1.800.000");
                        Console.WriteLine("2. Vivo Y12   1.500.000");
                        Console.WriteLine("Masukan Pilihan type Handphone yang akan di Beli");
                        type = Console.ReadLine();
                        if (type == "1") {
                            Console.WriteLine("*******************");
                            Console.WriteLine("Anda telah memilih Vivo Y9");
                            Console.WriteLine("1. RAM : 3 GB");
                            Console.WriteLine("1. ROM : 32 GB");
                            Console.WriteLine("*******************");
                            total_diskon = 1800000 * 0.20;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1800000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                        else if (type == "2") {
                            Console.WriteLine("*******************");
                            Console.WriteLine("Anda telah memilih Vivo Y12");
                            Console.WriteLine("1. RAM : 2 GB");
                            Console.WriteLine("1. ROM : 16 GB");
                            Console.WriteLine("*******************");
                            total_diskon = 1500000 * 0.20;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1500000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                    }
                }
                else if (password =="22421078") {
                    Console.WriteLine("Selamat Datang Pak uki");
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Pilih beragam Merk Handphone");
                    Console.WriteLine("1. OPPO");
                    Console.WriteLine("2. Vivo");
                    merk = Console.ReadLine();
                    if (merk == "1") {
                        Console.WriteLine("Pilih type Handphone OPPO");
                        Console.WriteLine("1. OPPO F1  1.000.000");
                        Console.WriteLine("2. RENO  1.500.000");
                        Console.Write("Masukan Pilihan type Handphone yang akan di beli : ");
                        type = Console.ReadLine();
                        if (type == "1"){
                            Console.WriteLine("*******************");
                            Console.WriteLine("Anda telah memilih OPPO F1");
                            Console.WriteLine("1. RAM : 2 GB");
                            Console.WriteLine("1. ROM : 16 GB");
                            Console.WriteLine("*******************");
                            total_diskon = 1200000 * 0.30;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1200000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                        else if (type == "2") {
                            Console.WriteLine("*******************");
                            Console.WriteLine("Anda telah memilih RENO 6");
                            Console.WriteLine("1. RAM : 6 GB");
                            Console.WriteLine("1. ROM : 128 GB");
                            Console.WriteLine("*******************");
                            total_diskon = 1500000 * 0.30;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1500000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                    }
                    else if (merk == "2") {
                        Console.WriteLine("Pilih type Handphone Vivo");
                        Console.WriteLine("1. Vivo Y9  1.800.000");
                        Console.WriteLine("2. Vivo Y12  1.500.000");
                        Console.WriteLine("Masukan Pilihan type Handphone yang akan di Beli");
                        type = Console.ReadLine();
                        if (type == "1") {
                            Console.WriteLine("*******************");
                            Console.WriteLine("Anda telah memilih Vivo Y9");
                            Console.WriteLine("1. RAM : 3 GB");
                            Console.WriteLine("1. ROM : 32 GB");
                            Console.WriteLine("*******************");
                            total_diskon = 1800000 * 0.30;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1800000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                        else if (type == "2") {
                            Console.WriteLine("*******************");
                            Console.WriteLine("Anda telah memilih Vivo Y12");
                            Console.WriteLine("1. RAM : 2 GB");
                            Console.WriteLine("1. ROM : 16 GB");
                            Console.WriteLine("*******************");
                            total_diskon = 1500000 * 0.30;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1500000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                    }
                }
                else {
                    Console.WriteLine("Password yang anda Masukan Salah");
                }
            }
            else {
                Console.WriteLine("Username yang anda Masukan Salah");
            }
        }
    }
}