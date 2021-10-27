using System;

namespace Home
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task-1
            // 1. Verilmis string deyerinde verilmis charin hansi indexde yerlesdiyini tapib qaytaran metod.Misalcun metodu call edib "salam" ve 'l' deyerleri gondersek geriye 2 qaytarmalidir amma char hemin stringde olmasa -1 qaytarmalidir.
            int value = stringChar("elektrik", 'i');
            if (value != -1)
            {
                Console.WriteLine($"Tapilan index: {value}");
            }
            else
            {
                Console.WriteLine($"Tapilan index: {value}");
            }
            #endregion

            #region Task
            //2. Verilmis ededin en yaxin asagi kokaltisini tapib qaytaran
            int square = squareRoot(102);
            if (square > 0)
            {
                Console.WriteLine($"Verilmis ededin kokaltisi = { square}");
            }
            else
            {
                Console.WriteLine("Menfi eded");
            }
            #endregion

            #region Task-3
            //3. Verilmis ededin reqemleri cemini tapib qaytaran metod.
            int sumresult = sumDigit(5622);
            if (sumresult > 0)
            {
                Console.WriteLine($"Ededin reqemlerinin cemi {sumresult}");
            }

            #endregion

            #region Task-4
            //4. Verilmis indeger arrayinin icindeki en boyuk deyeri tapan metod
            int[] numbers = { 122, 399, 45, 603, 13, 34, 621, 43, 27670 };

            int arrayMax = numbersMax(numbers);
            if (numbers.Length > 0)
            {
                Console.WriteLine($"Verilmis arraydeki en boyuk eded = {arrayMax}");
            }
            else
            {
                Console.WriteLine("İci bosdur!");
            }
            #endregion

            #region Task-5
            //5.Verilmis integer arrayindeki butun elementleri musbet sekilder qaytaran metod.Misalcun parametr olaraq {1,-4,9,-8} deyerleri olan array daxil edilse arqument kimi metod bize {1,4,9,8} deyerleri olan array qaytarmalidir
            int[] values = { 521, -7, -1, -1031, 300, -2692, -2002 };

            int[] valuePositive = aryValues(values);
            Console.WriteLine("Ededler:");
            foreach (int item in valuePositive)
            {
                Console.WriteLine(item);
            }
            #endregion
        }

        #region Task-1

        static int stringChar(string mainString, char chr)
        {
            int resultFind = -1;
            for (int i = 0; i < mainString.Length; i++)
            {
                if (mainString[i] == chr)
                {
                    resultFind = i;
                    break;
                }
            }
            return resultFind;
        }
        #endregion

        #region Task-2
        static int squareRoot(int value)
        {
            int a = 0;
            int squareResult = 0;
            while (a * a <= value)
            {
                a++;
            }
            squareResult = a - 1;
            return squareResult;

        }
        #endregion

        #region Task-3

        static int sumDigit(int value)
        {
            int sum = 0;
            int digit = 0;
            int M = value;

            while (M > 0)
            {
                digit = M % 10;
                sum += digit;
                M = (M - digit) / 10;

            }
            return sum;

        }

        #endregion

        #region Task-4
        static int numbersMax(int[] numbers)
        {
            int i = 0;
            int max = numbers[0];
            while (i < numbers.Length - 1)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                i++;
            }
            return max;
        }
        #endregion

        #region Task-5

        static int[] aryValues(int[] values)
        {
            for (int a = 0; a < values.Length; a++)
            {
                if (values[a] < 0)
                {
                    values[a] = values[a] * (-1);
                }
                else
                {
                    continue;
                }
            }
            return values;
        }

        #endregion

    }



}
