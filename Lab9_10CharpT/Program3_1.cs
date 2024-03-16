//"C:\\Users\\Христина\\source\\repos\\lab9\\input.txt";
using System;
using System.IO;
using System.Collections;

class Program3_1
{
    static void Main3()
    {
        // Шлях до вхідного файлу
        string inputFilePath = "C:\\Users\\Христина\\source\\repos\\lab9\\input3_1.txt";
        // Шлях до вихідного файлу
        string outputFilePath = "C:\\Users\\Христина\\source\\repos\\lab9\\output3_1.txt";

        // Створюємо ArrayList для зберігання цифр у зворотньому порядку
        ArrayList numbersList = new ArrayList();

        // Читаємо цифри з вхідного файлу та додаємо їх у numbersList
        using (StreamReader sr = new StreamReader(inputFilePath))
        {
            string inputDigits = sr.ReadLine();
            foreach (char digitChar in inputDigits)
            {
                if (char.IsDigit(digitChar))
                {
                    int digit = digitChar - '0'; // Конвертуємо символ у цифру
                    numbersList.Insert(0, digit); // Додаємо цифру у початок ArrayList, щоб зберегти зворотній порядок
                }
            }
        }

        // Відкриваємо файл для запису
        using (StreamWriter sw = new StreamWriter(outputFilePath))
        {
            // Записуємо цифри з numbersList у файл(IEnumerable)
            foreach (int digit in numbersList)
            {
                sw.Write(digit);
            }
        }

        Console.WriteLine("Операція завершена. Результат записано у файл output3_1.txt.");
    }
}


