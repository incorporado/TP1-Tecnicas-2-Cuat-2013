﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Fiuba.Tecnicas.Giledrose
{    
    public class Inventory{
        
        private ArrayList productosTipo1;
        private ArrayList productosTipo2;
        private ArrayList productosTipo3;
        private ArrayList productosTipo4;
    
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

        private void agregarProductos () 
        {
            productosTipo1 = new ArrayList();
            productosTipo2 = new ArrayList();
            productosTipo3 = new ArrayList();
            productosTipo4 = new ArrayList();
            this.productosTipo1.Add("+5 Dexterity Vest");
            this.productosTipo1.Add("Elixir of the Mongoose");
            this.productosTipo2.Add("Aged Brie");
            this.productosTipo3.Add("Backstage passes to a TAFKAL80ETC concert");
            this.productosTipo4.Add("Conjured Mana Cake");
        }

        public void agregarProductos(string nombre, int tipo)
        {
            if (tipo == 1)
            {
                this.productosTipo1.Add(nombre);
                return;
            }
            if (tipo == 2)
            {
                this.productosTipo2.Add(nombre);
                return;
            }
            if (tipo == 3)
            {
                this.productosTipo3.Add(nombre);
                return;
            }
            if (tipo == 4)
            {
                this.productosTipo4.Add(nombre);
                return;
            }
        }

        private Producto esTipoDeProducto(string itemName)
        {
            Producto producto;

            if (this.productosTipo1.Contains(itemName))
            {
                return producto = new Tipo1();
            }
            if (this.productosTipo2.Contains(itemName))
            {
                return producto = new Tipo2();
            }
            if (this.productosTipo3.Contains(itemName))
            {
                return producto = new Tipo3();
            }
            if (this.productosTipo4.Contains(itemName))
            {
                return producto = new Tipo4();
            }
            
            return producto = new TipoNulo();
        }
        
        public void updateQuality()
        {
            this.agregarProductos();

            foreach (var item in items)
            {
                Producto producto = this.esTipoDeProducto(item.Name);
                producto.actualizar(item);               
            }
        }
    }
}
