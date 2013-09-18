using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fiuba.Tecnicas.Giledrose
{
    public class Inventory{
    
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

        private Producto esTipoDeProducto(string itemName)
        {
            Producto producto;

            if ((itemName != "Aged Brie") && (itemName != "Backstage passes to a TAFKAL80ETC concert")
                    && (itemName != "Sulfuras, Hand of Ragnaros") && (itemName != "Conjured Mana Cake"))
                return producto = new Tipo1();                

            if (itemName == "Aged Brie")
                return producto = new Tipo2();                

            if (itemName == "Backstage passes to a TAFKAL80ETC concert")
                return producto = new Tipo3();                

            if (itemName == "Conjured Mana Cake")
                return producto = new Tipo4();        

            return producto = new TipoNulo();
        }
        
        public void updateQuality()
        {
            foreach (var item in items)
            {
                Producto producto = this.esTipoDeProducto(item.Name);
                producto.actualizar(item);               
            }
        }
    }
}
