using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            //правим си две хранилища, едното за легендарните предмети е едно за джънковете
            //добавяйки количество към легендарен предмет трябва да следим дали не сме достигнали кол. 250, 
            //ако сме го достигнали или сме ги надхвърлили тези 250, махаме 250 от събраното количество и отпечатваме
            //само оставащите, отпечатваме и за какво оръжие сме събрали количество и програмата приключва - не печатаме
            //оставащите количества и предмети от inputa

            //можем да си задаваме начални стойности на речника, изтриваме облите скоби и отваряме къдрави,
            //след това в тези скоби отваряме нови къдрави и вътре описваме двойка ключ-стойност {"", 0} - 
            //ключа стринг с дефолтна стойност 0
            Dictionary<string, int> legendaryItems = new Dictionary<string, int>
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0},
            };

            Dictionary<string, int> junkItems = new Dictionary<string, int>();

            string winnerItem = " ";

            bool isRunning = true;

            while (isRunning)
            {
                string[] parts = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //3 Motes 5 stones 5 Shards


                //обхождайки реда с този цикъл ще можем да си извадим стойностите на i = quantiti
                //i + 1 = item-а
                for (int i = 0; i < parts.Length; i += 2)
                {
                    int quantity = int.Parse(parts[i]);
                    
                    //тук си правим item-ите на ToLower(), защото легендарните предмети са ни дадени с малки букви
                    string item = parts[i + 1].ToLower();

                    //проверяваме дали item-а ние от легендарните, т.е. дали се съдържа в речника на легендарните
                    if (legendaryItems.ContainsKey(item))
                    {
                        //щом е от специалните към него(key item) добавяме количеството
                        legendaryItems[item] += quantity;

                        //сега проверяваме дали сме достигнали 250 от този item, ако сме ние реално сме приключили
                        //с обработката, приключваме с while цикъла и трябва да извадим от този item 250 и трябва да
                        //приключим както обработването на предметите(for-a) така и while-а. Правим си една bool IsRunning
                        //която в началото ще е true, и while-a ще върти докато IsRunning е true. За да стане false - правим я 
                        //false, когато легендарен предмет достигне или надхвърли 250 и след като извадим от itema-a 250;
                        if (legendaryItems[item] >= 250)
                        {
                            //за да разберем, кой от трите специални предмета сме събрали
                            //създаваме си извън whil-а променлива winnerItem с начална стойност string.Empty, който
                            //тук, след като сме събрали или надхвърлили 250 от накой от item-ите, му присвояваме 
                            //стойността на айтъма, от който сме събрали 250
                            winnerItem = item;
                            legendaryItems[item] -= 250;
                            isRunning = false;
                            break;
                        }
                    }



                    // втората част: ако от входа получим junk, проверяваме дали този junk се съдържа в речника 
                    //с junk-овете, ако се съдържа увеличаваме количеството му с количеството от входните данни,
                    //ако не го добавяме в речника, с количеството от входните данни
                    else
                    {
                        if (junkItems.ContainsKey(item))
                        {
                            junkItems[item] += quantity;

                        }
                        else
                        {
                            junkItems.Add(item, quantity);
                        }
                    }
                }
            }

            if (winnerItem == "shards")
            {
                Console.WriteLine($"Shadowmourne obtained!");
            }
            else if (winnerItem == "fragments")
            {
                Console.WriteLine($"Valanyr obtained!");
            }
            else
            {
                Console.WriteLine($"Dragonwrath obtained!");
            }

            Dictionary<string, int> sortedLegendaryItem = legendaryItems
                .OrderByDescending(i => i.Value)
                .ThenBy(i => i.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedLegendaryItem)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            Dictionary<string, int> sortedJunkItems = junkItems
                .OrderBy(i => i.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedJunkItems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
