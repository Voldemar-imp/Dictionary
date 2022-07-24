using System;
using System.Collections.Generic;

namespace collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] countries = { "Россия", "Англия","Китай", "Германия", "США" };
            string[] capitals = { "Москва", "Лондон", "Пекин", "Берлин", "Вашингтон" };
            Dictionary<string, string> countriesAndCapitals = new Dictionary<string, string>();

            AddToDictionary(countriesAndCapitals, countries, capitals);
            string userInput = GetCountryName(countriesAndCapitals);
            Console.WriteLine($"Столица страны {userInput}, это -  {countriesAndCapitals [userInput]}");           
        }

        static void AddToDictionary(Dictionary<string, string> dictionary, string[] key, string[] value )
        {
            for (int i = 0; i < key.Length; i++)
            {
                dictionary.Add(key[i], value[i]);
            }
        }
        
        static string GetCountryName(Dictionary<string, string> dictionary)
        {
            string userInput = "";
            bool isCorrect = false; 

            Console.WriteLine("Введите назвине страны:");

            while (isCorrect == false)
            {
                userInput = Console.ReadLine();
                isCorrect = dictionary.ContainsKey(userInput);

                if (isCorrect == false)
                {
                    Console.WriteLine($"Страны с названием {userInput} в справочнике нет, попробуйте еще раз: ");
                }
            }

            return userInput;
        }
    }
}
