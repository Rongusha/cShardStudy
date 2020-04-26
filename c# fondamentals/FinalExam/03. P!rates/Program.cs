using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _03._P_rates
{

    class City
    {
       
        public int population { get; set; }
        public int gold { get; set; }

        public City( int population, int gold)
        {
           
            this.population = population;
            this.gold = gold;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var command = string.Empty;
            var cities = new Dictionary<string, City>();

            while ((command= Console.ReadLine())!= "Sail")
            {
                var splitted = command.Split("||").ToArray();
                var currentCity = splitted[0];
                var population = int.Parse(splitted[1]);
                var gold =int.Parse(splitted[2]);

                if (!cities.ContainsKey(currentCity))
                {
                    cities[currentCity] = new City(population, gold);
                }
                else
                {
                    cities[currentCity].population += population;
                    cities[currentCity].gold += gold;
                }
            }
            while ((command = Console.ReadLine()) != "End")
            {
                var splitted = command.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();
                var action = splitted[0];
                var currentCity = splitted[1];
                var killedPopilation = int.Parse(splitted[2]);
                

                switch (action)
                {
                    case "Plunder":
                        var stealedGold = int.Parse(splitted[3]);
                        cities[currentCity].population -= killedPopilation;
                        cities[currentCity].gold -= stealedGold;

                        Console.WriteLine($"{currentCity} plundered! {stealedGold} gold stolen, {killedPopilation} citizens killed.");

                        if (cities[currentCity].population == 0 || cities[currentCity].gold == 0)
                        {
                            cities.Remove(currentCity);
                            Console.WriteLine($"{currentCity} has been wiped off the map!");
                        }
                        break;

                    case "Prosper":

                        if (killedPopilation>0)
                        {
                            cities[currentCity].gold += killedPopilation;

                            Console.WriteLine($"{killedPopilation} gold added to the city treasury. {currentCity} now has {cities[currentCity].gold} gold.");
                        }
                        else
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        break;
                }
            }

            if (cities.Keys.Count>0)
            {
                cities= cities.OrderByDescending(x=>x.Value.gold).ThenBy(x=>x.Key).ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine($"Ahoy, Captain! There are {cities.Keys.Count} wealthy settlements to go to:");

                foreach (var (key,value) in cities)
                {
                    
                        Console.WriteLine($"{key} -> Population: {value.population} citizens, Gold: {value.gold} kg");
                    
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

           
        }
    }
}
