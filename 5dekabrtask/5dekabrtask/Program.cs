using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace _5dekabrtask
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Task1 
            Console.WriteLine("Task1");

            Console.WriteLine("4 reqemli eded daxil edin");
        //l1: int a = (Convert.ToInt32(Console.ReadLine()));
        //    if (!(a > 999 && a < 10000))
        //    {
        //        Console.WriteLine("4 reqemli eded yalnis daxil edilib,yeniden cehd edin");
        //        goto l1;
        //    }

        //    else
        //    {
        //        int sum = 0;
        //        while (a > 0)
        //        {
        //            sum += a % 10;
        //            a /= 10;
        //        }
        //        Console.WriteLine($"sum:{sum}");

        //   }
        //  Console.WriteLine(" ");
        l1:
            string aStr = Console.ReadLine();
            if (int.TryParse(aStr, out int a) && aStr.Length == 4)
            {
                int sum = 0;

                while (a > 0)
                {
                    sum += a % 10;
                    a /= 10;
                }
                Console.WriteLine($"ededin reqemleri cemi:{sum}");
            }
            else
            {
                Console.WriteLine("Eded 4 reqemli deyil");
                goto l1;
            }

            Console.WriteLine(" ");


            //Task2
            Console.WriteLine("Task2");
            Console.WriteLine("6 reqemli eded daxil edin ");
        l3:
            string bStr = Console.ReadLine();

            if (int.TryParse(bStr, out int b) && bStr.Length == 6)
            {
                int bninilk3reqemi = b / 1000;
                int sum277 = 0;
                while (bninilk3reqemi > 0)
                {
                    sum277 += bninilk3reqemi % 10;
                    bninilk3reqemi /= 10;

                }
                Console.WriteLine($"Ilk 3 reqemin cemi: {sum277}");
            }

            else
            {
                Console.WriteLine("Eded 6 reqemli deyil!");
                goto l3;
            }

            Console.WriteLine(" ");

            //Task3*
            Console.WriteLine("Task3");
            Console.WriteLine("9 reqemli eded daxil edin");
        l4:
            string cStr = Console.ReadLine();
            if (int.TryParse(cStr, out int c) & cStr.Length == 9)
            {
                int sum278 = 0;
                int cninortasindaki3reqem = c / 1000;
                int c3 = 0;

                while (cninortasindaki3reqem > 0 && c3 < 3)
                {
                    sum278 += cninortasindaki3reqem % 10;
                    cninortasindaki3reqem /= 10;
                    c3++;
                }
                Console.WriteLine($"9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi:{sum278}");
            }

            else
            {
                Console.WriteLine("eded 9 reqemli deyil ");
                goto l4;
            }

            Console.WriteLine(" ");


            //Task4
            Console.WriteLine("Task4");
            Console.WriteLine("5 reqemli eded daxil edin");
        l5:
            string mStr = Console.ReadLine();
            if (int.TryParse(mStr, out int m) && mStr.Length == 5)
            {
                int m1 = m % 10;
                int m2 = m / 10000;
                int m3 = (m1 + m2) * (m1 + m2);
                Console.WriteLine($"5 reqemli ededin ilk ve son reqemlerinin ceminin kvadrati:{m3} ");
                Console.WriteLine($"{m1}");
                Console.WriteLine($"{m2}");

            }
            else
            {
                Console.WriteLine("XETA...Daxil etdiyiniz eded 5 reqemli deyil !");
                goto l5;
            }

            Console.WriteLine(" ");
            //Task5
            Console.WriteLine("Task5");
            Console.WriteLine("6 reqemli eded daxil edin");
        l7:
            string nStrr = Console.ReadLine();
            if (int.TryParse(nStrr, out int n) && nStrr.Length == 6)
            {
                int n1 = n / 100000;
                int n2 = n * 10 + n1;
                Console.WriteLine($" 6 reqemli ededin 1 ci reqemini hemin ededin axirina atiriq: {n1}");


            }
            else
            {
                Console.WriteLine("XETA...Daxil etdiyiniz eded 6 reqemli deyil!");
                goto l7;
            }

            Console.WriteLine(" ");
            //Task6
            Console.WriteLine("Task6");
            Console.WriteLine("8 reqemli eded daxil edin");
        l8:
            string pStr = Console.ReadLine();
            if (int.TryParse(pStr, out int p) && pStr.Length == 8)
            {
                int p1 = p % 10000000;
                int p2 = p1 / 10;
                //Console.WriteLine("8 reqemli ededin birinci ve axirinci reqemini legv edirik"  + p2);
                Console.WriteLine($"8 reqemli ededin birinci ve axirinci reqemini legv edirik: {p2}");

            }

            else
            {
                Console.WriteLine("XETA...Daxil etdiyiniz eded 8 reqemli deyil!");
                goto l8;
            }
            Console.WriteLine(" ");
            //Task7*
            Console.WriteLine("Task7");
            Console.WriteLine("4 reqemli eded daxil edin");
        l9:
            string qStr = Console.ReadLine();
            if (int.TryParse(qStr, out int q) && qStr.Length == 4)
            {
                Console.WriteLine("4 reqemli reqemin tersini duzmek ve evvel ve axirina 8 elave etmek");
                int q10 = q % 10;
                int q1 = q / 10;

                int q11 = q1 % 10;
                int q2 = q / 100;

                int q12 = q2 % 10;
                int q3 = q / 1000;

                int sum = (q10 * 1000) + (q11 * 100) + (q12 * 10) + q3;
                int sum1 = 800008 + sum * 10;

                Console.WriteLine(sum1);

            }
            else
            {
                Console.WriteLine("XETA...Daxil etdiyiniz eded 6 reqemli deyil!");
                goto l9;
            }
            Console.WriteLine(" ");

            //Task8*
            Console.WriteLine("Task8");
            Console.WriteLine("100 den boyuk eded daxil et");
        l10:
            string sStr = Console.ReadLine();
            if (int.TryParse(sStr, out int s) && sStr.Length >= 3)
            {
                int s1 = s % 10;
                int s2 = s / 100;
                int s21 = s2 % 10;

                Console.WriteLine($"Axirdan 3cu reqemin ve sonuncu reqemin cemi: {s1 + s21}");

            }
            else
            {
                Console.WriteLine("XETA...Daxil etdiyiniz eded 3 reqemli deyil!");
                goto l10;
            }

            Console.WriteLine(" ");
            //Task9
            Console.WriteLine("Task9");
        l11: Console.WriteLine("9 reqemli eded daxil et");

            string kStr = Console.ReadLine();
            if (int.TryParse(kStr, out int k) && kStr.Length == 9)
            {
                int k1 = k % 10;
                int k2 = k / 100; int k12 = k2 % 10;
                int k3 = k / 10000; int k13 = k3 % 10;
                int k4 = k / 1000000; int k14 = k4 % 10;
                int k5 = k / 100000000; int k15 = k5 % 10;
                int sum111 = (k15 * 10000) + (k14 * 1000) + (k13 * 100) + (k12 * 10) + k1;
                Console.WriteLine($"9 reqemli ededdin tek yerde dayananlardan bir eded duzletdik: {sum111}");
            }
            else
            {
                Console.WriteLine("eded 9 reqemli deyil");
                goto l11;
            }

            Console.WriteLine(" ");

            //task9.1

            //static int ReadInt(string caption, string errorMessage)
            //{
            //    var backupColor = Console.ForegroundColor;

            //l145:
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.Write(caption);
            //    Console.ForegroundColor = backupColor;

            //    string aStr = Console.ReadLine();

            //    bool state = int.TryParse(aStr, out int a);

            //    if (!state)
            //    {
            //        if (!string.IsNullOrWhiteSpace(errorMessage))
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine(errorMessage);
            //            Console.ForegroundColor = backupColor;
            //        }

            //        goto l145;
            //    }

            //    return a;
            //}

            //Task10
            Console.WriteLine("Task10");
            Console.WriteLine("9 reqemli eded daxil et");
        l12:
            string wStr = Console.ReadLine();
            if (int.TryParse(wStr, out int w) && wStr.Length == 9)
            {
                int a110 = w % 10;
                int b110 = w / 100; int b1100 = b110 % 10;
                int c110 = w / 10000; int c1100 = c110 % 10;
                int d110 = w / 1000000; int d1100 = d110 % 10;
                int e110 = w / 100000000; int e1100 = e110 % 10;
                int sum110 = (e1100 * 10000) + (d1100 * 100) + (c1100 * 100) + (b1100 * 10) + a110;
                Console.WriteLine($"Ededin tek yerinde duran reqemlerden yaranan eded: {sum110}");
                int a666 = w / 10; int a667 = a666 % 10;

                int a111 = w / 1000; int a112 = a111 % 10;
                int b111 = w / 100000; int b112 = b111 % 10;
                int c111 = w / 10000000; int c112 = c111 % 10;
                int sum111 = (c112 * 1000) + (b112 * 100) + (a112 * 10) + a667;
                Console.WriteLine($"Ededin cut yerinde duran reqemlerden yaranan eded:{sum111}");
                int sum112 = sum111 + sum110;
                Console.WriteLine($"Tek yerde duran ededler ile cut yerde duran ededleri topladiq: {sum112}");
            }
            else
            {
                Console.WriteLine("xeta var! ps:eded 9 reqemli deyil yeniden cehd edin");
                goto l12;
            }

            Console.WriteLine(" ");

            //Task11
            Console.WriteLine("Task 11");
            Console.WriteLine("8 reqemli eded daxil edin");
        l13:
            string jstr = Console.ReadLine();

            if (int.TryParse(jstr, out int j) && jstr.Length == 8)
            {
                int a55 = j / 1000000;
                int b55 = j % 100;
                int c55 = (j / 100) % 100;
                int d55 = (j / 10000) % 100;
                Console.WriteLine($"Bu ededin reqemleri iki iki qruplasdirildi: {a55}, {d55}, {c55} ve {b55}");
                int cem55 = a55 + b55 + c55 + d55;
                Console.WriteLine($"Bu qrupdaki ededlerin cemi tapilir: {cem55}");
                int cem99 = cem55 * 100 + 99;
                Console.WriteLine($"Alinan cavabina axirina 99 artiriq: {cem99}");
                int cem551 = cem99 - (cem99 * 18) / 100;
                Console.WriteLine($"Bu ededden ozunun 18 faizini cixiriq: {cem551} ");
            }

            else
            {
                Console.WriteLine("Eded 8 reqemli deyil");
                goto l13;
            }
            Console.WriteLine(" ");

            //task12*
            Console.WriteLine("Task12");
            Console.WriteLine("Birinci 5 reqemli ededi daxil edin");
        l14:
            string hStr = Console.ReadLine();
            Console.Write("Ikinci 5 reqemli ededi daxil edin: ");
            string h1Str = Console.ReadLine();
            if (int.TryParse(hStr, out int h) && int.TryParse(h1Str, out int h1) && hStr.Length == 5 && h1Str.Length == 5)
            {
                int hinsonuncureqemi = h % 10;
                int sum89 = 0;
                while (h > 0)
                {
                    sum89 += h % 10;
                    h /= 10;
                }
                int sum90 = 1;
                while (h1 > 0)
                {
                    sum90 *= h1 % 10;
                    h1 /= 10;
                }
                Console.WriteLine($"Ilk ededin reqemli cemi: {sum89}");
                Console.WriteLine($"Ikinci ededin reqemleri cemi: {sum90}");
                int sum91 = sum89 + sum90;
                Console.WriteLine($"Birinci ededin cemi ile ikinci ededin hasilinin cemi: {sum91}");
                int sum92 = sum91 * 10 + hinsonuncureqemi;
                Console.WriteLine($"Son aldigimiz ededin axirina ilk daxil etdiyimiz ededin son reqemini gelirik: {sum92}");
            }

            else
            {
                Console.WriteLine("Xeta...Ededlerin her ikisi 5 reqemli olmalidir");
                goto l14;
            }

            Console.WriteLine(" ");

            //task13
            Console.WriteLine("Task 13");
            Console.Write("Ilk 5 reqemli ededi daxil edin: ");
        l16:
            string dStr = Console.ReadLine();
            Console.Write("Ikinci 5 reqemli ededi daxil edin: ");
            string oStr = Console.ReadLine();
            Console.Write("Ucuncu 5 reqemli ededi daxil edin: ");
            string iStr = Console.ReadLine();
            if (int.TryParse(dStr, out int d) && int.TryParse(oStr, out int o) && int.TryParse(iStr, out int i) && dStr.Length == 5 && oStr.Length == 5 && iStr.Length == 5)
            {
                int d88 = d % 10;
                int d1 = d / 10000;
                int b88 = o % 10;
                int z1 = o / 10000;
                int c88 = i % 10;
                int v1 = i / 10000;
                int aa = d1 * 10 + d88;
                int bb = z1 * 10 + b88;
                int cc = v1 * 10 + c88;
                Console.WriteLine($"Bu ededlerin her birinin ilk ve son reqeminden ededler duzeldilir: {aa} ve {bb} ve {cc}");
                int cem555 = aa + bb + cc;
                Console.WriteLine($"Bu ededlerin cemi tapilir: {cem555}");
                int cem5551 = cem555 / 2 + cem555;
                Console.WriteLine($"Bu cemin uzerine oz 50 faizini gelirik: {cem5551}");
            }
            else
            {
                Console.WriteLine("Ededlerin hamisi 5 reqemli olmalidir! ");
                goto l16;


            }
            Console.WriteLine(" ");

            // task14
            static void Main()
            {
                int sayi1 = 123456;
                int sayi2 = 654321;
                int sayi3 = 1234567;

                int toplam = ((sayi1 / 1000) % 1000 + (sayi2 / 1000) % 1000);

                int sonDortBasamak = sayi3 % 10000;

                int sonuc1 = toplam - (sayi3 / 1000000);

                double yuzdeAltmis = sonuc1 + 60;

                double axirinci = yuzdeAltmis - (0.18);// neticeden 18 % cixart.

                Console.WriteLine("axirinci + netice");



            }


        }
        private static void Exercise15()
        {


            int number1, number2,
                number3, number4,
                number5;

        l1:
            number1 = ReadInt("3 reqemli eded daxil ed", null);
            if (number1 < 100 || number1 >= 1000)
            {

                goto l1;
            }
            number2 = ReadInt("3 reqemli eded daxil ed", null);
            if (number2 < 100 || number2 >= 1000)
            {

                goto l1;
            }
            number3 = ReadInt("6 reqemli eded daxil ed", null);
            if (number3 < 100000 || number3 >= 1000000)
            {

                goto l1;
            }
            number4 = ReadInt("6 reqemli eded daxil ed", null);
            if (number4 < 100000 || number4 >= 1000000)
            {

                goto l1;
            }

            number5 = ReadInt("7 reqemli eded daxil ed", null);
            if (number5 < 1000000 || number5 >= 10000000)
            {

                goto l1;
            }
            long sumofnum1num2 = number1 + number2;
            sumofnum1num2 %= 100;
            sumofnum1num2 = Convert.ToInt32(Math.Pow(sumofnum1num2, 2));

            long joinNum1Num2 = number1 * 1000 + number2 + sumofnum1num2;

            joinNum1Num2 -= (number5 % 100000);
            long sumofnum3num4 = number3 + number4;

            sumofnum3num4 %= 1000;

            joinNum1Num2 += sumofnum3num4;

            long sumofdigitfornum5 = Reversedigit(SumDigits(number5));

            joinNum1Num2 += sumofdigitfornum5;

            joinNum1Num2 = joinNum1Num2 * 100 + 11;

            long oddplacenumber = GetNumberFromOdd(number5) - joinNum1Num2;

            oddplacenumber = ((oddplacenumber / 100) * 100 + 88) * 10 + oddplacenumber % 10;

            Console.WriteLine(oddplacenumber);
        }

        private static int SumDigits(int number5)
        {
            throw new NotImplementedException();
        }

        static long SumofDigit(int value)
        {

            int sum = 0;

            while (value > 0)
            {

                sum += value % 10;
                value /= 10;

            }
            return sum;
        }

        static long Reversedigit(int value)
        {

            int reverse = 0;

            while (value > 0)
            {

                reverse = reverse * 10 + (value % 10);
                value /= 10;

            }
            return reverse;
        }
        static long GetNumberFromOdd(int value)
        {

            int newNumber = 0;
            int position = 1;
            while (value > 0)
            {
                int digit = (value % 10);

                if (position % 2 != 0)
                {
                    newNumber = digit * (int)Math.Pow(10, position / 2) + newNumber;
                }

                value /= 10;
                position++;
            }
            return newNumber;
        }
        static int ReadInt(string caption, string errorMessage)
        {
            var backupColor = Console.ForegroundColor;
        l1:

            string aStr = Console.ReadLine();
            bool state = int.TryParse(aStr, out int a);
            if (!state)
            {
                if (!string.IsNullOrWhiteSpace(errorMessage))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errorMessage);
                    Console.ForegroundColor = backupColor;
                }
                goto l1;
            }
            return a;
        }
    }

}
