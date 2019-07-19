using PokeApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi
{
    public class ItemParser
    {
        public static List<Item> ParseItems()
        {
            List<Item> items = new List<Item>();

            using (StreamReader streamreader = new StreamReader("items.txt"))
            {
                string line;
                streamreader.ReadLine();
                while ((line = streamreader.ReadLine()) != null)
                {
                    try
                    {
                        List<string> itemcharacteristics = line.Split(',').ToList<string>();

                        if(Int32.Parse(itemcharacteristics[3]) == 0)
                        {
                            continue;
                        }
                        Item item = new Item
                        {
                            Id = Int32.Parse(itemcharacteristics[0]),
                            Name = itemcharacteristics[1],
                            Price = Int32.Parse(itemcharacteristics[3])
                        };
                        items.Add(item);
                    }
                    catch
                    {
                        Console.WriteLine("blad");
                    }
                }

            }
            return items;
        }
    }
}
