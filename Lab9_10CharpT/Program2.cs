using System;
using System.IO;
using System.Collections.Generic;


class Program2
{
    static void Main2()
    {
        // Шлях до вхідного файлу
        string inputFilePath = "C:\\Users\\Христина\\source\\repos\\lab9\\input2.txt";
        // Шлях до вихідного файлу
        string outputFilePath = "C:\\Users\\Христина\\source\\repos\\lab9\\output2.txt";

        // Створюємо чергу для зберігання символів, які не є цифрами
        Queue<char> nonDigitsQueue = new Queue<char>();
        // Створюємо чергу для зберігання цифр
        Queue<char> digitsQueue = new Queue<char>();

        // Читаємо символи з вхідного файлу та додаємо їх у відповідні черги
        using (StreamReader sr = new StreamReader(inputFilePath))
        {
            while (!sr.EndOfStream)
            {
                char ch = (char)sr.Read();
                if (char.IsDigit(ch))
                {
                    digitsQueue.Enqueue(ch);
                }
                else
                {
                    nonDigitsQueue.Enqueue(ch);
                }
            }
        }

        // Записуємо символи з черги nonDigitsQueue у вихідний файл
        using (StreamWriter sw = new StreamWriter(outputFilePath))
        {
            while (nonDigitsQueue.Count > 0)
            {
                char ch = nonDigitsQueue.Dequeue();
                sw.Write(ch);
            }

            // Записуємо цифри з черги digitsQueue у вихідний файл
            while (digitsQueue.Count > 0)
            {
                char ch = digitsQueue.Dequeue();
                sw.Write(ch);
            }
        }

        Console.WriteLine("Операція завершена. Результат записано у файл output2.txt.");
    }
}

