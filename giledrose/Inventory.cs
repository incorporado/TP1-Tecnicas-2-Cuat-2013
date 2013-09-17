using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fiuba.Tecnicas.Giledrose
{
    public class Inventory
    {
        private readonly IEnumerable<Item> items;

        public Inventory(IEnumerable<Item> items) 
        {
            this.items = items;
        }

        public Inventory() 
        {
            items = new List<Item>
            {
                new Item("+5 Dexterity Vest", 10, 20),
                new Item("Aged Brie", 2, 0),
                new Item("Elixir of the Mongoose", 5, 7),
                new Item("Sulfuras, Hand of Ragnaros", 0, 80),
                new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                new Item("Conjured Mana Cake", 3, 6),
            };
        }

        public void updateQuality()
        {
            foreach (var item in items)
            {
                if ( (item.Name != "Aged Brie") && (item.Name != "Backstage passes to a TAFKAL80ETC concert") 
                    && (item.Name != "Sulfuras, Hand of Ragnaros") )
                {
                    item.SellIn -= 1;

                    if ( (item.SellIn < 0) && (item.Quality - 1 > 0) )
                    {
                        item.Quality -= 2;
                        
                    }
                    else if (item.Quality > 0)
                    {
                        item.Quality -= 1;                        
                    }
                }               

                if ( (item.Name == "Aged Brie") )
                {
                    item.SellIn -= 1;   

                    if ( (item.Quality + 1 < 50) && (item.SellIn < 0) )
                    {
                        item.Quality += 2;                                         
                    }
                    else if (item.Quality < 50)
                    {
                        item.Quality += 1;
                    }
                }

                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {                    

                    if (item.SellIn - 1 < 0)
                    {
                        item.Quality = 0;                        
                    }
                    else
                    {                        
                        if (item.Quality + 1 > 50 - 1)
                        {
                            item.Quality += 1;
                        }
                        else if ( (item.Quality + 1 < 50) && (item.SellIn < 6) ) 
                        {                            
                            item.Quality += 3;                            
                        }
                        else if ( (item.Quality + 1 < 50) && (item.SellIn < 11) ) 
                        {
                            item.Quality += 2;
                        }                        
                    }

                    item.SellIn -= 1;
                }               
            }
        }
    }
}
