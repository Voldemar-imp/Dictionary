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
            Console.WriteLine($"Столица государства {userInput}, это -  {countriesAndCapitals [userInput]}");           
        }

        static void AddToDictionary(Dictionary<string, string> dictionary, string[] kay, string[] value )
        {
            for (int i = 0; i < kay.Length; i++)
            {
                dictionary.Add(kay[i], value[i]);
            }
        }

        static string GetCountryName(Dictionary<string, string> cities)
        {
            string userInput = "";

            Console.WriteLine("Введите назвине страны:");

            while (cities.ContainsKey(userInput) == false)
            {
                userInput = Console.ReadLine();

                if (cities.ContainsKey(userInput))
                {
                    return userInput;
                }
                else
                {
                    Console.WriteLine($"Страны с названием {userInput} в справочнике нет, попробуйте еще раз: ");
                }
            }
            return userInput;
        }
    }
}
