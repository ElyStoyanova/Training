using System;
using System.Collections.Generic;
using System.Linq;

namespace Exerciise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = new Dictionary<string, List<string>>();
            groups.Add("Beatles",new List<string>());
            groups["Beatles"].Add("Jonh");
            groups["Beatles"].Add("Poul");
            groups["Beatles"].Add("Ringo");
            groups["Beatles"].Add("Pesho");

            groups.Add("Signal", new List<string>());
            groups["Signal"].Add("Ivan");
            groups["Signal"].Add("Todor");
            groups["Signal"].Add("Viktor");

            groups.Add("Impuls", new List<string>());
            groups["Impuls"].Add("Didi");
            groups["Impuls"].Add("Niki");
            groups["Impuls"].Add("Pepi");

            var newGroups = new Dictionary<string, List<string>>();
            newGroups = groups.Take(1).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in newGroups)
            {
                Console.WriteLine($"{item.Key}");
                Console.Write("-- ");
                Console.WriteLine(string.Join("\n-- ", item.Value));
            }
                
            
            
        }
    }
}
