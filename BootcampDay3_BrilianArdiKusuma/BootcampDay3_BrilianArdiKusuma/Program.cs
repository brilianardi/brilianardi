using System;

namespace BootcampDay3_BrilianArdiKusuma
{
    internal class Soal11Sampai15
    {
        static void Main()
        {
            string ulang = "";
            do
            {
                Console.WriteLine("\n==List Soal==");
                Console.Write("Pilih no.soal : 11 - 16 : ");
                int pilihSoal = int.Parse(Console.ReadLine());

                switch (pilihSoal)
                {
                    case 11:
                        Soal11();
                        break;
                    case 12:
                        Soal12();
                        break;
                    case 13:
                        Soal13();
                        break;
                    case 14:
                        Soal14();
                        break;
                    case 15:
                        Soal15();
                        break;
                    case 16:
                        Soal16();
                        break;
                    default:
                        break;

                }
                Console.Write("\nPilih soal lagi? (y/n) : ");
                ulang = Console.ReadLine();
            }
            while (ulang.ToLower() == "y");
        }

        static void Soal11()
        {
            Console.Write("\nMasukan angka : ");
            int inputAngka = int.Parse(Console.ReadLine());
            int bilanganPembagi = 2;

            while (inputAngka != 1)
            {
                while (inputAngka % bilanganPembagi == 0)
                {
                    Console.Write("{0} / {1} = ", inputAngka, bilanganPembagi);
                    inputAngka = inputAngka / bilanganPembagi;
                    Console.WriteLine("{0}", inputAngka);
                }
                bilanganPembagi++;
            }
        }
        static void Soal12()
        {
            int i, j;
            int angka1 = 1;

            Console.Write("\nInput jumlah kolom dan baris : ");
            int kolomDanBaris = int.Parse(Console.ReadLine());
            int angka2 = kolomDanBaris;

            for (i = 0; i < kolomDanBaris; i++)
            {
                for (j = 0; j < kolomDanBaris; j++)
                {
                    if (i == 0)
                    {
                        Console.Write(angka1);
                        angka1++;
                    }
                    else if (i == (kolomDanBaris - 1))
                    {
                        Console.Write(angka2);
                        angka2--;

                    }
                    else if (j == 0 || j == (kolomDanBaris - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Soal13()
        {
            int x;
            int angka = 3;
            Console.Write("\nInput jumlah kolom : ");
            int jumlahKolom = int.Parse(Console.ReadLine());

            for (x = 1; x <= jumlahKolom; x++)
            {
                if (x % 2 == 0)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write(angka + " ");
                }
                angka *= 3;
            }
        }
        static void Soal14()
        {
            int x;
            int angka = -5;
            int angka2 = 10;
            Console.Write("\nMasukan jumlah kolom : ");
            int jumlahKolom = int.Parse(Console.ReadLine());

            for (x = 1; x <= jumlahKolom; x++)
            {
                if (x % 2 != 0)
                {
                    Console.Write(angka + " ");
                    angka -= 10;
                }
                else
                {
                    Console.Write(angka2 + " ");
                    angka2 += 10;
                }
            }
        }
        static void Soal15()
        {
            //output 1 = 1,1,2,3,5,8,13

            int x, pertama = 1, kedua = 1, ketiga;

            Console.Write("\nMasukan jumlah kolom Fibonacci 2: ");  //pertama : 2 kedua = 3 
            int input = int.Parse(Console.ReadLine());

            Console.Write("{0} {1} ", pertama, kedua);

            for (x = 3; x <= input; x++)
            {
                ketiga = pertama + kedua;
                Console.Write("{0} ", ketiga);
                pertama = kedua;
                kedua = ketiga;
            }

            //Output : 1,1,1,3,5,9,17

            Console.Write("\nMasukan jumlah kolom Fibonacci 3 : ");
            int inputKolom = int.Parse(Console.ReadLine());
            int y, satu = 1, dua = 1, tiga = 1, empat = 0;

            Console.Write("{0} {1} {2} ", satu, dua, tiga);

            for (y = 4; y <= inputKolom; y++)
            {
                empat = satu + dua + tiga;
                Console.Write("{0} ", empat);
                satu = dua;
                dua = tiga;
                tiga = empat;

            }
        }

        static void Soal16()
        {
            //Output : 1,1,2,3,5,8,13

            Console.Write("Masukan batas baris Fibonacci 2 : ");
            int batasFibonacci2 = int.Parse(Console.ReadLine());

            int x, satu = 1, dua = 1, tiga;

            for (x = 1; x <= batasFibonacci2; x++)
            {
                if (x < 3)
                {
                    Console.Write(1+" ");
                }
                else
                {
                    tiga = satu + dua;
                    Console.Write("{0} ",tiga);
                    satu = dua;
                    dua = tiga;
                }
            }
            Console.ReadLine();
        }
    }
}
