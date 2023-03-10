using System;
using System.Collections.Generic;

namespace MyCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MyCollections, where we have fun with C# collections!");
            Console.WriteLine();
            Console.WriteLine("We'll use gemstones to demonstrate the functionality of different collections.");
            Console.WriteLine();
            Console.WriteLine("Let's start with Queue! Press any key to continue, and again after each part.");
            Console.ReadKey();
            Console.Clear();

            Queue<string> gemQueue = new Queue<string>();
            gemQueue.Enqueue("Emerald");
            gemQueue.Enqueue("Amethyst");
            gemQueue.Enqueue("Diamond");
            gemQueue.Enqueue("Sapphire");
            gemQueue.Enqueue("Ruby");

            Console.WriteLine("I've made a queue with 5 items. Check it out:");
            foreach (string gem in gemQueue)
            {
                Console.WriteLine(gem);
            }
            Console.ReadKey();
            Console.WriteLine("Now let's see whether sapphire is on the list:");
            if (gemQueue.Contains("Sapphire"))
            {
                Console.WriteLine("Yes, it is! Cool.");
            }
            else
            {
                Console.WriteLine("Oops! I did it wrong.");
            }
            Console.ReadKey();

            gemQueue.Dequeue();
            Console.WriteLine("I've removed an item.");
            Console.WriteLine($"The queue now contains {gemQueue.Count} items.");
            Console.WriteLine("Here's the new list:");
            foreach (string gem in gemQueue)
            {
                Console.WriteLine(gem);
            }
            Console.ReadKey();
            Console.Clear();

            PriorityQueue<string, int> gemPQueue = new PriorityQueue<string, int>();
            gemPQueue.Enqueue("Amethyst", 5);
            gemPQueue.Enqueue("Emerald", 4);
            gemPQueue.Enqueue("Sapphire", 3);
            gemPQueue.Enqueue("Ruby", 2);
            gemPQueue.Enqueue("Diamond", 1);

            Console.WriteLine("Next, we'll check out PriorityQueue.");
            Console.WriteLine("I've prepared a prioritized queue.");
            Console.WriteLine($"It contains {gemPQueue.Count} items.");
            Console.ReadKey();
            Console.WriteLine($"The highest priority element is {gemPQueue.Peek()}.");
            gemPQueue.Dequeue();
            Console.WriteLine($"I've removed it now. The prioritized queue now has {gemPQueue.Count} items.");
            Console.WriteLine("I'll remove the rest now...");
            Console.ReadKey();
            while(gemPQueue.TryDequeue(out string item, out int priority))
            {
                Console.WriteLine($"{item} has been removed. It was priority {priority}.");
            }
            Console.WriteLine("All done with prioritized queues! Let's move on...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Time for Stacks!");
            Stack<string> gemStack= new Stack<string>();
            gemStack.Push("Amethyst");
            gemStack.Push("Ruby");
            gemStack.Push("Diamond");
            gemStack.Push("Sapphire");
            gemStack.Push("Emerald");

            Console.WriteLine("I've made a stack of 5 gems. Let's check to see if the stack contains Ruby...");
            Console.ReadKey();
            if (gemStack.Contains("Ruby"))
            {
                Console.WriteLine("It does! Great.");
            }
            else
            {
                Console.WriteLine("Oops! I did it wrong.");
            }
            Console.WriteLine();
            Console.WriteLine("Now let's remove an item...");
            Console.ReadKey();
            gemStack.Pop();
            Console.WriteLine($"Done! The stack now contains {gemStack.Count} items.");
            Console.WriteLine("Here's what's left:");
            foreach (string item in gemStack)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Linked lists! What fun!");
            string[] gems = { "Emerald", "Diamond", "Amethyst", "Sapphire", "Ruby" };
            LinkedList<string> gemlink = new LinkedList<string>(gems);
            Console.WriteLine($"I've created a linked list of gems.");
            Console.WriteLine($"It has {gemlink.Count} nodes. The first node is {gemlink.First.Value} and the last is {gemlink.Last.Value}.");
            Console.ReadKey();
            LinkedListNode<string> loca1 = gemlink.Find("Amethyst");
            gemlink.AddBefore(loca1, "Topaz");
            Console.WriteLine("Now I've added a new gem, Topaz, to the middle of the list...");
            Console.ReadKey();
            gemlink.RemoveLast();
            Console.WriteLine("And removed the last value, Ruby.");
            Console.WriteLine($"The list now has {gemlink.Count} nodes. Here are the values:");
            foreach (string item in gemlink)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Onward!");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("How about some Dictionary action?");
            Console.WriteLine();
            Dictionary<string,string>gemDict= new Dictionary<string,string>();
            gemDict.Add("Diamond", "C");
            gemDict.Add("Ruby", "Al2O3");
            gemDict.Add("Emerald", "Be3Al2(SiO3)6");
            gemDict.Add("Sapphire", "a-Al2O3");
            gemDict.Add("Amethyst", "SiO2");
            Console.WriteLine("Dictionaries let us create values in pairs. I've made a list of gemstones paired with their elemental compositions.");
            Console.WriteLine("Here are the keys:");
            Dictionary<string,string>.KeyCollection keys = gemDict.Keys;
            foreach (string key in keys) Console.WriteLine(key);
            Console.ReadKey();
            Console.WriteLine("And here are the values:");
            Dictionary<string,string>.ValueCollection values = gemDict.Values;
            foreach (string value in values) Console.WriteLine(value);
            Console.ReadKey();
            Console.WriteLine("And all together now:");
            foreach (KeyValuePair<string,string>kvp in gemDict) Console.WriteLine($"{kvp.Key},{kvp.Value}");
            Console.ReadKey();
            Console.WriteLine("Now I'll take one out...");
            gemDict.Remove("Ruby");
            Console.WriteLine($"And I'm left with {gemDict.Count} objects.");
            Console.WriteLine("Ready to move on?");
            Console.ReadKey();
            Console.Clear();

            SortedList<int, string> gemSort = new SortedList<int, string>()
            {
                {2300,"Diamond"},
                {4000,"Ruby"},
                {380,"Sapphire"},
                {15,"Amethyst"},
                {1600,"Emerald"}
            };
            Console.WriteLine("For my sorted list, I've made a list of gems and their market value per carat.");
            Console.WriteLine("Check it out:");
            foreach (KeyValuePair<int,string>kvp in gemSort) Console.WriteLine($"Price: {kvp.Key} Gem: {kvp.Value}");
            bool valid = false;
            while (!valid) {
                Console.WriteLine("How about adding one to the list? Go ahead... type in a new price value. Just make one up.");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("And now the name of your new gem. (i.e. Topaz, Aquamarine, Jet, etc)");
                string gem = Console.ReadLine();
                if (gemSort.ContainsKey(price) || gemSort.ContainsValue(gem) || price <= 0 || gem == string.Empty)
                {
                    Console.WriteLine("Whoops! That doesn't work. Enter a valid key/value pair not on the list.");
                }
                else {
                    gemSort.Add(price, gem);
                    valid = true; }
            }
            Console.WriteLine("Okay! That's added to the list. Here's what we have after I've removed one of the other values:");
            gemSort.Remove(2300);
            foreach (KeyValuePair<int, string> kvp in gemSort) Console.WriteLine($"Price: {kvp.Key} Gem: {kvp.Value}");
            Console.WriteLine("Done! Next is...");
            Console.ReadKey();
            Console.Clear();

            HashSet<string> gemHash= new HashSet<string> {"Diamond","Ruby","Sapphire","Emerald","Amethyst" };
            HashSet<string> rockHash = new HashSet<string> { "Granite", "Limestone", "Slate", "Marble","Basalt"};

            Console.WriteLine("A HashSet performs better than a List, and stores data in a hash table.");
            Console.WriteLine("Here's a HashSet with the familiar gems:");
            foreach (string key in gemHash) Console.WriteLine(key);
            Console.WriteLine("And here's another list of common rocks:");
            foreach (string key in rockHash) Console.WriteLine(key);
            Console.ReadKey();
            Console.WriteLine("I can combine them like this into one HashSet:");
            gemHash.UnionWith(rockHash);
            foreach (string key in gemHash) Console.WriteLine(key);
            Console.ReadKey();
            Console.WriteLine("Now here's a third hashset of random minerals:");
            HashSet<string> minHash = new HashSet<string> { "Quartz", "Calcite", "Amethyst", "Ruby", "Dolomite"};
            foreach (string key in minHash) Console.WriteLine(key);
            Console.WriteLine("Now I'll make a new HashSet composed of the duplicates:");
            HashSet<string> duplicates = new HashSet<string>();
            duplicates = gemHash;
            duplicates.IntersectWith(minHash);
            foreach (string key in duplicates) Console.WriteLine(key);
            Console.WriteLine("There we go!");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Whew! Last one.");
            Console.WriteLine("Ironically, we're going to end with the easiest: plain old Lists.");
            List<string> gemList = new List<string> { "Diamond","Ruby","Sapphire","Emerald","Amethyst"};
            Console.WriteLine("Here's the familiar five in plain List form:");
            foreach(string key in gemList) Console.WriteLine(key);
            Console.ReadKey();
            Console.WriteLine("Now I'll add 3 more items, sort and print the list:");
            string[] gemListAdd = new string[] { "Aquamarine", "Citrine", "Topaz" };
            gemList.AddRange(gemListAdd);
            gemList.Sort();
            foreach (string key in gemList) Console.WriteLine(key);
            Console.ReadKey();
            Console.WriteLine("And finally, I'll remove an item (Emerald), reverse-sort, and print again:");
            gemList.Remove("Emerald");
            gemList.Reverse();
            foreach (string key in gemList) Console.WriteLine(key);
            Console.WriteLine();
            Console.WriteLine("That's all for the seven collection types! Thanks so much for checking it out.");


        }
    }
}
