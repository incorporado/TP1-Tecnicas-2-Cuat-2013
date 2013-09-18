using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fiuba.Tecnicas.Giledrose;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Giledrose.Test
{
    [TestClass]
    public class GiledroseTest
    {
        List<Item> itemsNuevos;
        List<Item> itemsSinCambios;
        
        Inventory inventario;

        //public GiledroseTest()
        [TestInitialize()]
        public void setUp()
        {
            this.itemsNuevos = new List<Item>
            {
                new Item("Sulfuras, Hand of Ragnaros", 0, 0), //1
                new Item("Sulfuras, Hand of Ragnaros", -1, 0), //2
                new Item("Sulfuras, Hand of Ragnaros", -1, 50),//3
                new Item("Aged Brie", 50, 50),//4
                new Item("Aged Brie", 0, 48),//5
                new Item("Backstage passes to a TAFKAL80ETC concert", 0, 50),//6
                new Item("Backstage passes to a TAFKAL80ETC concert", 12, 49),//7
                new Item("Backstage passes to a TAFKAL80ETC concert", 10, 49),//8
                new Item("Backstage passes to a TAFKAL80ETC concert", 10, 48),//9
                new Item("Backstage passes to a TAFKAL80ETC concert", 5, 47),//10
                new Item("Backstage passes to a TAFKAL80ETC concert", -1, 46),//11
                new Item("Backstage passes to a TAFKAL80ETC concert", -1, -10),//12
                new Item("+5 Dexterity Vest", 1, 1),//13
                new Item("+5 Dexterity Vest", 0, 1),//14
                new Item("+5 Dexterity Vest", 0, 2),//15
                new Item("Conjured Mana Cake", 0, 2),//16
                new Item("Elixir of the Mongoose", 0, 10),//17
                new Item("Sulfuras, Hand of Ragnaros", 0, 80),//18
                new Item("Conjured Mana Cake", 10, 5),//19
                new Item("Conjured Mana Cake", 0, 20),//20
            };

            this.itemsSinCambios = new List<Item>
            {
                new Item("Sulfuras, Hand of Ragnaros", 0, 0), //1
                new Item("Sulfuras, Hand of Ragnaros", -1, 0), //2
                new Item("Sulfuras, Hand of Ragnaros", -1, 50),//3
                new Item("Aged Brie", 50, 50),//4
                new Item("Aged Brie", 0, 48),//5
                new Item("Backstage passes to a TAFKAL80ETC concert", 0, 50),//6
                new Item("Backstage passes to a TAFKAL80ETC concert", 12, 49),//7
                new Item("Backstage passes to a TAFKAL80ETC concert", 10, 49),//8
                new Item("Backstage passes to a TAFKAL80ETC concert", 10, 48),//9
                new Item("Backstage passes to a TAFKAL80ETC concert", 5, 47),//10
                new Item("Backstage passes to a TAFKAL80ETC concert", -1, 46),//11
                new Item("Backstage passes to a TAFKAL80ETC concert", -1, -10),//12
                new Item("+5 Dexterity Vest", 1, 1),//13
                new Item("+5 Dexterity Vest", 0, 1),//14
                new Item("+5 Dexterity Vest", 0, 2),//15
                new Item("Conjured Mana Cake", 0, 2),//16
                new Item("Elixir of the Mongoose", 0, 10),//17
                new Item("Sulfuras, Hand of Ragnaros", 0, 80),//18
                new Item("Conjured Mana Cake", 10, 5),//19
                new Item("Conjured Mana Cake", 0, 20),//20                
            };
            
            this.inventario = new Inventory(itemsNuevos);
            this.inventario.updateQuality();
        }

        [TestMethod]
        public void TestParaElemento1DeLaLista()
        {
            Assert.AreEqual(this.itemsSinCambios[0].SellIn, this.itemsNuevos[0].SellIn);
            Assert.AreEqual(this.itemsSinCambios[0].Quality, this.itemsNuevos[0].Quality);

        }

        [TestMethod]
        public void TestParaElemento2DeLaLista()
        {
            Assert.AreEqual(this.itemsSinCambios[1].SellIn, this.itemsNuevos[1].SellIn);
            Assert.AreEqual(this.itemsSinCambios[1].Quality, this.itemsNuevos[1].Quality);

        }

        [TestMethod]
        public void TestParaElemento3DeLaLista()
        {
            Assert.AreEqual(this.itemsSinCambios[2].SellIn, this.itemsNuevos[2].SellIn);
            Assert.AreEqual(this.itemsSinCambios[2].Quality, this.itemsNuevos[2].Quality);

        }

        [TestMethod]
        public void TestParaElemento4DeLaLista()
        {
            Assert.AreEqual(this.itemsSinCambios[3].SellIn - 1, this.itemsNuevos[3].SellIn);
            Assert.AreEqual(this.itemsSinCambios[3].Quality, this.itemsNuevos[3].Quality);

        }

        [TestMethod]
        public void TestParaElemento5DeLaLista()
        {
            Assert.AreEqual(this.itemsSinCambios[4].SellIn - 1, this.itemsNuevos[4].SellIn);
            Assert.AreEqual(this.itemsSinCambios[4].Quality + 2, this.itemsNuevos[4].Quality);

        }

        [TestMethod]
        public void TestParaElemento6DeLaLista()
        {
            Assert.AreEqual(this.itemsSinCambios[5].SellIn - 1, this.itemsNuevos[5].SellIn);
            Assert.AreEqual(0, this.itemsNuevos[5].Quality);

        }

        [TestMethod]
        public void TestParaElemento7DeLaLista()
        {
            Assert.AreEqual(this.itemsSinCambios[6].SellIn - 1, this.itemsNuevos[6].SellIn);
            Assert.AreEqual(this.itemsSinCambios[6].Quality + 1, this.itemsNuevos[6].Quality);

        }

        [TestMethod]
        public void TestParaElemento8DeLaLista() 
        {
            Assert.AreEqual(this.itemsSinCambios[7].SellIn - 1, this.itemsNuevos[7].SellIn);
            Assert.AreEqual(this.itemsSinCambios[7].Quality + 1, this.itemsNuevos[7].Quality);

        }

        [TestMethod]
        public void TestParaElemento9DeLaLista() 
        {
            Assert.AreEqual(this.itemsSinCambios[8].SellIn - 1, this.itemsNuevos[8].SellIn);
            Assert.AreEqual(this.itemsSinCambios[8].Quality + 2, this.itemsNuevos[8].Quality);

        }

        [TestMethod]
        public void TestParaElemento10DeLaLista() 
        {
            Assert.AreEqual(this.itemsSinCambios[9].SellIn - 1, this.itemsNuevos[9].SellIn);
            Assert.AreEqual(this.itemsSinCambios[9].Quality + 3, this.itemsNuevos[9].Quality);

        }

        [TestMethod]
        public void TestParaElemento11DeLaLista()
        {
            Assert.AreEqual(this.itemsSinCambios[10].SellIn - 1, this.itemsNuevos[10].SellIn);
            Assert.AreEqual(0, this.itemsNuevos[10].Quality);

        }

        [TestMethod]
        public void TestParaElemento12DeLaLista()
        {
            Assert.AreEqual(this.itemsSinCambios[11].SellIn - 1, this.itemsNuevos[11].SellIn);
            Assert.AreEqual(0, this.itemsNuevos[11].Quality);

        }

        [TestMethod]
        public void TestParaElemento13DeLaLista()
        {
            Assert.AreEqual(this.itemsSinCambios[12].SellIn - 1, this.itemsNuevos[12].SellIn);
            Assert.AreEqual(this.itemsSinCambios[12].Quality - 1, this.itemsNuevos[12].Quality);

        }

        [TestMethod]
        public void TestParaElemento14DeLaLista()
        {
            Assert.AreEqual(this.itemsSinCambios[13].SellIn - 1, this.itemsNuevos[13].SellIn);
            Assert.AreEqual(this.itemsSinCambios[13].Quality - 1, this.itemsNuevos[13].Quality);

        }

        [TestMethod]
        public void TestParaElemento15DeLaLista()
        {
            Assert.AreEqual(this.itemsSinCambios[14].SellIn - 1, this.itemsNuevos[14].SellIn);
            Assert.AreEqual(this.itemsSinCambios[14].Quality - 2, this.itemsNuevos[14].Quality);

        }

        //verifica que conjured disminuye en 2
        [TestMethod]
        public void TestParaElemento16DeLaLista()
        {
            Assert.AreEqual(this.itemsSinCambios[15].SellIn - 1, this.itemsNuevos[15].SellIn);
            Assert.AreEqual(0, this.itemsNuevos[15].Quality);

        }

        [TestMethod]
        public void TestParaElemento17DeLaLista()
        {
            Assert.AreEqual(this.itemsSinCambios[16].SellIn - 1, this.itemsNuevos[16].SellIn);
            Assert.AreEqual(this.itemsSinCambios[16].Quality - 2, this.itemsNuevos[16].Quality);

        }

        //verifica que sulfuras tenga calidad constante de 80 y sellin constante de 0
        [TestMethod]
        public void TestParaElemento18DeLaLista()
        {
            Assert.AreEqual(this.itemsSinCambios[17].SellIn, this.itemsNuevos[17].SellIn);
            Assert.AreEqual(this.itemsSinCambios[17].Quality, this.itemsNuevos[17].Quality);
        }

        //Conjured sin vencer decrementa de a 2 la calidad
        [TestMethod]
        public void TestParaElemento19DeLaLista()
        {
            Assert.AreEqual(this.itemsSinCambios[18].SellIn - 1, this.itemsNuevos[18].SellIn);
            Assert.AreEqual(this.itemsSinCambios[18].Quality - 2, this.itemsNuevos[18].Quality);
        }

        //Conjured vencido decrementa de a 4 la calidad
        [TestMethod]
        public void TestParaElemento20DeLaLista()
        {
            Assert.AreEqual(this.itemsSinCambios[19].SellIn - 1, this.itemsNuevos[19].SellIn);
            Assert.AreEqual(this.itemsSinCambios[19].Quality - 4, this.itemsNuevos[19].Quality);
        } 
    }
}

