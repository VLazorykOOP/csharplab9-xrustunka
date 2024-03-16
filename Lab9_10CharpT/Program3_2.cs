using System;
using System.IO;
using System.Collections;

class Program3_2
{
    static void Main3()
    {
        // Шлях до вхідного файлу
        string inputFilePath = "C:\\Users\\Христина\\source\\repos\\lab9\\input3_2.txt";
        // Шлях до вихідного файлу
        string outputFilePath = "C:\\Users\\Христина\\source\\repos\\lab9\\output3_2.txt";

        // Створюємо ArrayList для зберігання символів, які не є цифрами
        ArrayList nonDigitsList = new ArrayList();
        // Створюємо ArrayList для зберігання цифр
        ArrayList digitsList = new ArrayList();

        // Читаємо символи з вхідного файлу та додаємо їх у відповідні ArrayList
        using (StreamReader sr = new StreamReader(inputFilePath))
        {
            while (!sr.EndOfStream)
            {
                char ch = (char)sr.Read();
                if (char.IsDigit(ch))
                {
                    digitsList.Add(ch);
                }
                else
                {
                    nonDigitsList.Add(ch);
                }
            }
        }

        // Записуємо символи з nonDigitsList у вихідний файл
        using (StreamWriter sw = new StreamWriter(outputFilePath))
        {
            //IEnumerable використовується тут для перебору символів у ArrayList
            foreach (char ch in nonDigitsList)
            {
                sw.Write(ch);
            }

            // Записуємо символи з digitsList у вихідний файл
            foreach (char ch in digitsList)
            {
                sw.Write(ch);
            }
        }

        Console.WriteLine("Операція завершена. Результат записано у файл output3_2.txt.");
    }
}


