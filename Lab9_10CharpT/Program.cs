//"C:\\Users\\Христина\\source\\repos\\lab9\\input.txt";
using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main1()
    {
        // Шлях до вхідного файлу
        string inputFilePath = "C:\\Users\\Христина\\source\\repos\\lab9\\input.txt";
        // Шлях до вихідного файлу
        string outputFilePath = "C:\\Users\\Христина\\source\\repos\\lab9\\output.txt";

        // Створюємо новий стек для зберігання цифр
        Stack<int> numbersStack = new Stack<int>();

        // Читаємо цифри з вхідного файлу та додаємо їх у стек
        using (StreamReader sr = new StreamReader(inputFilePath))
        {
            string inputDigits = sr.ReadLine();
            foreach (char digitChar in inputDigits)
            {
                if (char.IsDigit(digitChar))
                {
                    int digit = digitChar - '0'; // Конвертуємо символ у цифру
                    numbersStack.Push(digit);
                }
            }
        }

        // Відкриваємо файл для запису у зворотньому порядку
        using (StreamWriter sw = new StreamWriter(outputFilePath))
        {
            // Записуємо цифри зі стеку у файл у зворотньому порядку
            while (numbersStack.Count > 0)
            {
                int digit = numbersStack.Pop();
                sw.Write(digit);
            }
        }

        Console.WriteLine("Операція завершена. Результат записано у файл output.txt.");
    }
}

