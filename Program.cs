using System;

namespace HomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bosluq olmayan yazi duzeltmek
            //string sentence = "Salam her kese";
            //string newSentence = "";

            //for(int i = 0; i < sentence.Length; i++)
            //{
            //    if(sentence[i] != ' ')
            //    {
            //        newSentence += sentence[i];
            //    }
            //}
            //Console.WriteLine(newSentence);
            #endregion

            #region Verilmis herfden nece eded oldugunu tapmaq
            //string word = "saalaamm";
            //char letter = 'a';
            //int count = 0;

            //for(int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] == letter) count++;
            //}
            //Console.WriteLine(count);
            #endregion

            #region Verilmis yazidaki artiq bosluqlari silmek
            //string word = "   salam her kese    ";
            //int left = 0;
            //int right = 0;
            //string newWord = "";
            //for(int i = 0; i < word.Length; i++)
            //{
            //    if(word[i] == ' ')
            //    {
            //        left++;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //for (int i = word.Length-1; i >= 0; i--)
            //{
            //    if (word[i] == ' ')
            //    {
            //        right++;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //for(int i = left; i < word.Length-right; i++)
            //{
            //    newWord += word[i];
            //}
            //Console.WriteLine(newWord);
            #endregion

            #region Verilmis 2 eded arasinda emeliyyat 
            //Console.Write("Birinci ededi daxil edin : ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Ikinci ededi daxil edin : ");
            //int num2 = int.Parse(Console.ReadLine());
            //Start:
            //Console.Write("Etmek istediyiniz emeliyyati secin (+,-,*,/) : ");
            //char operation = char.Parse(Console.ReadLine());

            //if (operation == '+') Console.WriteLine(num1 + num2);
            //else if (operation == '-') Console.WriteLine(num1 - num2);
            //else if (operation == '*') Console.WriteLine(num1 * num2);
            //else if (operation == '/') Console.WriteLine(num1 / num2);
            //else
            //{ 
            //    Console.WriteLine("Duzgun emeliyyat daxil edin.");
            //    goto Start;
            //}
            #endregion

            #region Verilmis herfin olub olmadigini tapmaq
            //Console.Write("Sozu daxil edin : ");
            //string word = Console.ReadLine();
            //char letter = 'A';
            //bool isExist = false;

            //for(int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] == letter)
            //    {
            //        isExist = true;
            //    }
            //}
            //Console.WriteLine(isExist);
            #endregion

            #region Verilmis sozde nece A herfinin oldugunu tapmaq
            //string word = "sAalAamm";
            //char letter = 'A';
            //int count = 0;

            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] == letter) count++;
            //}
            //Console.WriteLine(count);
            #endregion

            #region Verilmis musbet cut ededin kvadratini tapmaq 
            //Start:
            //Console.Write("Ededi daxil edin : ");
            //int num = int.Parse(Console.ReadLine());
            //if (num > 0 && num % 2 == 0) Console.WriteLine(num * num);
            //else
            //{
            //    Console.WriteLine("Musbet ve cut eded daxil edin");
            //    goto Start;
            //}
            #endregion

            #region Verilmis tehsile gore saat gostermek
            Console.WriteLine("programming");
            Console.WriteLine("design");
            Console.WriteLine("system");
            Console.Write("Secmek istediyiniz tehsili secin : ");
            string education = Console.ReadLine();

            switch (education)
            {
                case "programming":
                    Console.WriteLine("400 saat");
                    break;
                case "design":
                    Console.WriteLine("250 saat");
                    break;
                case "system":
                    Console.WriteLine("200 saat");
                    break;
                default:
                    Console.WriteLine("Girilen tehsil movcud deyil");
                    break;
            }
            #endregion
        }
    }
}
