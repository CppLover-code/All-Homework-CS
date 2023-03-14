﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_09._03._2023_Массивы_и_строки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(" Задание 1. Работа с 1d и 2d массивами");

            //double[] A = new double[5];                         // 1d массив вещественных чисел
            //double[,] B = new double[3,4];                      // 2d масиив вещественных чисел

            //Console.WriteLine("\n Введите 5 чисел для заполнения 1d массива:");

            //for (int i = 0; i < A.Length; i++)                  // заполнение 1d массива с клавы
            //    A[i] = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("\n 1d массив: ");                  // вывод 1d массива

            //foreach (double i in A)
            //    Console.Write(i + "\t");
            //Console.WriteLine();

            //Random rnd = new Random();                                  // создаем объект для генерации чисел

            //for (int i = 0; i < 3; i++)                                 // заполнение 2d массива рандомом
            //    for (int j = 0; j < 4; j++)
            //        B[i, j] = i + j + 1 + Math.Round(rnd.NextDouble(), 1);  // записываем в массив случайное число

            //Console.WriteLine("\n 2d массив: ");                  

            //for (int i = 0; i < 3; i++)                         // вывод 2d массива в виде матрицы
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(B[i,j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //double sum = A.Sum();   // общая сумма всех элементов 1d и 2d (ниже суммируем еще и эл. 2d массива) 
            //double product = 1;     // общее произведение всех элементов 1d и 2d

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            //double maxA = A.Max();  // максимальный элемент 1d массива
            //double minA = A.Min();  // минимальный элемент 1d массива
            //double sumEvenA = 0;    // сумма чётных элементов 1d массива

            //for (int i = 0; i < A.Length; i++)
            //{
            //    product *= A[i];        // умножаем эл. массива
            //    if (A[i] % 2 == 0)      // суммируем чётные эл.
            //        sumEvenA += A[i];
            //}

            /////////////////////////////////////////////////////////////////////////////////////////////////////
            //double maxB = B[0,0];   // максимальный элемент 2d массива
            //double minB = B[0,0];   // минимальный элемент 2d массива
            //double sumOddB = 0;     // сумма нечётных столбцов 2d массива

            //for (int i = 0; i < 3; i++)                         
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if(maxB < B[i,j]) maxB = B[i,j];            // поиск макс. элемента 2d массива
            //        if(minB > B[i,j]) minB = B[i,j];            // поиск мин. элемента 2d массива
            //        sum += B[i, j];                             // суммируем эл. массива
            //        product *= B[i,j];                          // умножаем эл. массива
            //        if(j % 2 != 0) sumOddB += B[i,j];           // сумма эл. нечётных столбцов
            //    }
            //}

            /////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine();
            //if(maxA == maxB)
            //{
            //    Console.WriteLine(" Общий максимальный элемент двух массивов: " + maxA);
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkRed;
            //    Console.WriteLine(" Общего максимального элемента двух массивов не найдено!");
            //    Console.ResetColor();
            //}

            //if (minA == minB)
            //{
            //    Console.WriteLine(" Общий минимальный элемент двух массивов: " + minA);
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkRed;
            //    Console.WriteLine(" Общего минимального элемента двух массивов не найдено!");
            //    Console.ResetColor();
            //}

            //Console.WriteLine(" Общая сумма всех элементов: " + sum);
            //Console.WriteLine(" Общее произведение всех элементов: " + Math.Round(product,2));
            //Console.WriteLine(" Сумма чётных элементов 1d массива A: " + sumEvenA);
            //Console.WriteLine(" Сумма нечётных столбцов 2d массива B: " + sumOddB);


            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine(" Задание 2. Работа с 2d массивом\n");

            //int s = 5;
            //int[,] arrInt = new int[s, s];

            //Random rndInt = new Random();                  // объект для генерации случайных чисел

            //for (int i = 0; i < s; i++)
            //{
            //    for (int j = 0; j < s; j++)
            //    {
            //        arrInt[i, j] = rndInt.Next(-100, 101);   // заполнение массива случайными числами
            //    }
            //}

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(" 2D массив 5х5");
            //Console.ResetColor();
            //for (int i = 0; i < s; i++)
            //{
            //    for (int j = 0; j < s; j++)
            //    {
            //        Console.Write(arrInt[i, j] + "\t");    // выводим массив 
            //    }
            //    Console.WriteLine();
            //}


            //int size = s * s;               // размер 1d массива
            //int[] arrCopy = new int[size];  // создаем и выделяем память для 1d массива
            //int w = 0;                      // переменная для индексации массива

            //    for (int k = 0; k < s; k++)
            //    {
            //        for (int j = 0; j < s; j++)
            //        {
            //            arrCopy[w] = arrInt[k, j];
            //            w++;
            //        }
            //    }

            //int minC = arrCopy.Min();
            //int maxC = arrCopy.Max();

            //int minI = 0; 
            //int maxI = 0;

            //int rangeSum = 0;

            //for (int i = 0; i < arrCopy.Length; i++)
            //{
            //    if (arrCopy[i] == minC) minI = i;         // находим индексы мин и макс элементов
            //    else if (arrCopy[i] == maxC) maxI = i;
            //}

            //if (minI > maxI)                              // если индекс минимального элемента
            //{                                             // больше индекса макс элемента,
            //    int temp = minI;                          // то меняем значения индексов местами
            //    minI = maxI;
            //    maxI = temp;
            //}

            //for (int i = minI + 1; i < maxI; i++)
            //{
            //    rangeSum += arrCopy[i];                   // суммируем элементы в диапазоне от мин. до макс.
            //}

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("\n Сумма элементов массива в диапазоне от мин. до макс.: " + rangeSum);
            //Console.ResetColor();


            Console.WriteLine("----------------------------------------");

            Console.WriteLine(" Задание 3. Шифр Цезаря для кириллицы");

            Console.WriteLine(" Введите строку, которую необходимо зашифровать: ");

            StringBuilder str = new StringBuilder(Console.ReadLine());               // для ввода строки

            int key = 0;                                                             // цифра-ключ для сдвига
            while (true)                                                             // цикл работает, пока не введут 
            {                                                                        // цифру в диапазоне от 1 до 10
                Console.WriteLine(" Введите цифру-ключ для шифрования от 1 до 10:");

                while (!int.TryParse(Console.ReadLine(), out key))                   // пока вводимый символ не является цифрой
                {
                    Console.WriteLine(" Ошибочный ввод! Введите целое число:");      // выводим сообщение, иначе в key запишется цифра
                }
                if (key >= 1 && key <= 10) break;                                    // если цифра входит в диапазон - стоп цикл,           
                else Console.WriteLine(" Ошибочный ввод! ");                         // иначе выводим сообщение об ошибке

            }

            int side;                                                                // сторона сдвига
            while (true)                                                             
            {
                Console.WriteLine(" Выберите сторону сдвига: \n 1 - вправо \n 2 - влево");

                while (!int.TryParse(Console.ReadLine(), out side))
                {
                    Console.WriteLine(" Ошибочный ввод! Введите целое число:");
                }
                if (side == 1 || side == 2) break;
                else Console.WriteLine(" Ошибочный ввод! ");
            }

            if (side == 1)                                  // если сдвиг вправо
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= 1040 && str[i] <= 1103)  // если символ является кириллицей
                    {                                      // temp(хранит код символа-шифра)
                        int temp = str[i] + key;           // временная переменная равна сумме кода текущего символа и ключа
                        if (temp > 1103)                   // если temp символ больше буквы 'я'
                        {
                            temp -= 1103;                  // находим разницу temp и буквы 'я'
                            temp += 1040 - 1;              // эту разницу суммируем к коду 'А' - 1
                        }
                        str[i] = (char)temp;               // "заменяем" настоящую букву полученным шифром 
                    }
                    else continue;                         // иначе, если текущий символ не является буквой кириллицы,
                }                                          // пропускаем обработку данного символа
            }
            else if (side == 2)                            // если сдвиг влево
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= 1040 && str[i] <= 1103)
                    {
                        int temp = str[i] - key;
                        if (temp < 1040)
                        {
                            temp = 1040 - temp;
                            temp = 1103 - temp + 1;
                        }
                        str[i] = (char)temp;
                    }
                    else continue;

                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n Зашифрованное сообщение " + (char)9660);
            Console.ResetColor();
            Console.WriteLine(str);
            

            //Console.WriteLine(" Дешифратор для кириллицы");
            // Дешифратор работает аналогично шифровке, только наоборот.
            // Если шифровка была вправо, то расшифровывать нужно справа налево.
            // Если влево - то слева направо. Все действия с учётом цифры-ключа!

            if (side == 1)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= 1040 && str[i] <= 1103)
                    {
                        int temp = str[i] - key;
                        if (temp < 1040)
                        {
                            temp = 1040 - temp;
                            temp = 1103 - temp + 1;
                        }
                        str[i] = (char)temp;
                    }
                    else continue;
                }   
            }
            else if (side == 2)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= 1040 && str[i] <= 1103)
                    {
                        int temp = str[i] + key;
                        if (temp > 1103)
                        {
                            temp -= 1103;
                            temp += 1040 - 1;
                        }
                        str[i] = (char)temp;
                    }
                    else continue;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Расшифрованное сообщение " + (char)9660);
            Console.ResetColor();
            Console.WriteLine(str);




            //Console.WriteLine("----------------------------------------");

            //Console.WriteLine(" Задание 4. Операции над матрицами");
            //Console.WriteLine("----------------------------------------");

            //Console.WriteLine(" Задание 5. Арифметическое выражение");
            //Console.WriteLine("----------------------------------------");

            //Console.WriteLine(" Задание 6. Изменение регистра первой буквы каждого предложения");
            //Console.WriteLine("----------------------------------------");

            //Console.WriteLine(" Задание 7. Проверка текста на недопустимые слова");
            //Console.WriteLine("----------------------------------------");

        }
    }
}
