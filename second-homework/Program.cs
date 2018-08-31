using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace second_homework
{
    class Program
    {
        public static int FirstThreeNumbersEquals { get; private set; }
        public static int SecondThreeNumbersEquals { get; private set; }

        static void Main(string[] args)
        {
            WriteLine("Первое задание...");
            Write("Пожалуйста, введите какой-нибудь текст...");
            string strng = ReadLine();
            int pointPosition = strng.IndexOf(".");

            int nmbrfspces = 0;
            if (pointPosition != 1)
            {
                for (int m = 0; m < pointPosition; m++)
                {
                    if (strng[m] == ' ')
                    {
                        nmbrfspces++;
                    }
                }
            }

            Write("Сумма пробелов до первой точки:");
            WriteLine(nmbrfspces);
            ReadLine();
            Clear();

            WriteLine("Второе задание...");
            Write("Пожалуйста, введите номер билета: ");
            int numeric;
            bool isParsed = int.TryParse(ReadLine(), out numeric);
            if (isParsed)
            {
                if (numeric >= 0 && numeric <= 9)
                {
                    if (numeric < 3)
                    {

                        FirstThreeNumbersEquals += numeric;
                    }
                    else
                    {
                        SecondThreeNumbersEquals += numeric;
                    }
                    numeric++;
                }
                else
                {
                    WriteLine("Ошибка. Может быть, вы ввели неправильный номер. Попробуйте еще раз.");
                    ReadLine();
                }
            }
            else
            {
                WriteLine("Ошибка. Может быть, вы ввели неправильный номер. Попробуйте еще раз.");
                ReadLine();
            }
            Clear();

            if (FirstThreeNumbersEquals == SecondThreeNumbersEquals)
            {
                WriteLine("Да. Ваш номер билета счастливый.");
            }
            else
            {
                WriteLine("Нет. Ваш номер билета несчастливый.");
            }

            WriteLine("Третье задание...");
            WriteLine("Пожалуйста, напишите какой-нибудь текст:");
            string strg = ReadLine();

            StringBuilder builderMan = new StringBuilder();
            foreach (char m in strg)
            {
                builderMan.Append(ToUp(m));
            }
            strg = builderMan.ToString();
            Write("Строка только в выскомрегистра.");
            WriteLine(strg);
            builderMan.Clear();

            WriteLine("Пожалуйста, напишите какой-нибудь текст:");
            strg = ReadLine();
            foreach (char m in strg)
            {
                builderMan.Append(ToLow(m));
            }
            strg = builderMan.ToString();
            Write("Строка только в низком регистре.");
            WriteLine(strg);

            WriteLine("Четвертое задание...");
            WriteLine("Пожалуйста, введите первое число...");
            int numericFirst;
            int numericSecond;
            bool isparsed = int.TryParse(ReadLine(), out numericFirst);
            while (!isparsed)
            {
                Write("Ошибка. Попробуйте еще раз.");
                isparsed = int.TryParse(ReadLine(), out numericFirst);
                Clear();
            }

            WriteLine("Пожалуйста, введите второе число.");
            isparsed = int.TryParse(ReadLine(), out numericSecond);
            while (!isparsed)
            {
                Write("Ошибка. Попробуйте еще раз.");
                isparsed = int.TryParse(ReadLine(), out numericSecond);
                Clear();
            }

            for (int m = numericFirst; m <= numericSecond; m++)
            {
                for (int n = 0; n < m; n++)
                {
                    Write(m);
                }
                WriteLine();
                Clear();
            }

            WriteLine("Пятое задание...");
            const int Ten = 10;
            int tale;
            bool p4rsed = int.TryParse(ReadLine(), out tale);
            while (!p4rsed)
            {
                Write("Ошбка. Попробуйте еще раз... ");
                p4rsed = int.TryParse(ReadLine(), out tale);
                Clear();
            }
            int TaleRank = tale.ToString().Length;
            int[] TaleSolid = new int[TaleRank];
            for (int m = 0; m < TaleRank; m++)
            {
                TaleSolid[m] = tale / Ten;
            }
            Write("Конвертированное число: ");
            foreach (int m in TaleSolid)
            {
                Write(m);
            }
            ReadLine();
            Clear();
        }

        private static char ToLow(char m)
        {
            throw new NotImplementedException();
        }
        private static char ToUp(char m)
        {
            throw new NotImplementedException();
        }
    }
}
