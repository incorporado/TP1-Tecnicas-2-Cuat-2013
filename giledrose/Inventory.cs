using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fiuba.Tecnicas.Giledrose
{
    public class Inventory{
    
        public const int TIPO_DE_PRODUCTO_1 = 1;
        public const int TIPO_DE_PRODUCTO_2 = 2;
        public const int TIPO_DE_PRODUCTO_3 = 3;
        public const int TIPO_DE_PRODUCTO_4 = 4;
        public const int TIPO_DE_PRODUCTO_NO_IDENTIFICADO = 5;
        public const int MAXIMA_CALIDAD = 50;
        public const int A_DIEZ_DIAS_DEL_VENCIMIENTO = 11;
        public const int A_CINCO_DIAS_DEL_VENCIMIENTO = 6;

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

        private int esTipoDeProducto(string itemName)
        {
            if ((itemName != "Aged Brie") && (itemName != "Backstage passes to a TAFKAL80ETC concert")
                    && (itemName != "Sulfuras, Hand of Ragnaros") && (itemName != "Conjured Mana Cake"))
                return TIPO_DE_PRODUCTO_1;

            if (itemName == "Aged Brie")
                return TIPO_DE_PRODUCTO_2;

            if (itemName == "Backstage passes to a TAFKAL80ETC concert")                    
                return TIPO_DE_PRODUCTO_3;

            if (itemName == "Conjured Mana Cake")
                return TIPO_DE_PRODUCTO_4;

            return TIPO_DE_PRODUCTO_NO_IDENTIFICADO;

        }

        private void actualizarProductoTipo1(Item item)
        {
            item.SellIn -= 1;

            if ((item.SellIn < 0) && (item.Quality - 1 > 0))
            {
                item.Quality -= 2;

            }
            else if (item.Quality > 0)
            {
                item.Quality -= 1;
            }
        }

        private void actualizarProductoTipo2(Item item)
        {
            item.SellIn -= 1;

            if ((item.Quality + 1 < MAXIMA_CALIDAD) && (item.SellIn < 0))
            {
                item.Quality += 2;
            }
            else if (item.Quality < MAXIMA_CALIDAD)
            {
                item.Quality += 1;
            }
        }

        private void actualizarProductoTipo3(Item item)
        {
            if (item.SellIn - 1 < 0)
            {
                item.Quality = 0;
            }
            else
            {
                if (item.Quality + 1 > MAXIMA_CALIDAD - 1)
                {
                    item.Quality += 1;
                }
                else if ((item.Quality + 2 < MAXIMA_CALIDAD) && (item.SellIn < A_CINCO_DIAS_DEL_VENCIMIENTO))
                {
                    item.Quality += 3;
                }
                else if ((item.Quality + 1 < MAXIMA_CALIDAD) && (item.SellIn < A_DIEZ_DIAS_DEL_VENCIMIENTO))
                {
                    item.Quality += 2;
                }
            }

            item.SellIn -= 1;
        }

        private void actualizarProductoTipo4(Item item)
        {
            item.SellIn -= 1;

            if ( (item.SellIn > 0) && (item.Quality > 0) )
            {
                item.Quality -= 2;
            }
            else if (item.Quality > 0)
            {
                item.Quality -= 4;
            }
            if (item.Quality < 0) item.Quality = 0;
        }

        public void updateQuality()
        {
            foreach (var item in items)
            {
                if ( esTipoDeProducto (item.Name) == TIPO_DE_PRODUCTO_1 )
                {
                    this.actualizarProductoTipo1(item);
                }               

                if ( esTipoDeProducto (item.Name) == TIPO_DE_PRODUCTO_2 )
                {
                    actualizarProductoTipo2(item);
                }

                if ( esTipoDeProducto (item.Name) == TIPO_DE_PRODUCTO_3 )
                {
                    this.actualizarProductoTipo3(item);
                }

                if (esTipoDeProducto(item.Name) == TIPO_DE_PRODUCTO_4 )
                {
                    this.actualizarProductoTipo4(item);
                }
            }
        }
    }
}
