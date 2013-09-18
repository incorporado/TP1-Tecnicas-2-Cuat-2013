using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Fiuba.Tecnicas.Giledrose
{    
    public class Inventory{
        
        private ArrayList productType1 =  new ArrayList();
        private ArrayList productType2 =  new ArrayList();
        private ArrayList productType3 =  new ArrayList();
        private ArrayList productType4 =  new ArrayList();
    
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

        private void addProducts () 
        {
            this.productType1.Add("+5 Dexterity Vest");
            this.productType1.Add("Elixir of the Mongoose");
            this.productType2.Add("Aged Brie");
            this.productType3.Add("Backstage passes to a TAFKAL80ETC concert");
            this.productType4.Add("Conjured Mana Cake");
        }

        private Product isTypeProduct(string itemName)
        {
            Product product;

            if (this.productType1.Contains(itemName))
            {
                return product = new Type1();
            }
            if (this.productType2.Contains(itemName))
            {
                return product = new Type2();
            }
            if (this.productType3.Contains(itemName))
            {
                return product = new Type3();
            }
            if (this.productType4.Contains(itemName))
            {
                return product = new Type4();
            }
            
            return product = new NullType();
        }
        
        public void updateQuality()
        {
            this.addProducts();

            foreach (var item in items)
            {
                Product product = this.isTypeProduct(item.Name);
                product.update(item);               
            }
        }
    }
}
