using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fiuba.Tecnicas.Giledrose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Giledrose.Test
{
    [TestClass]
    public class GiledroseTest
    {
        List<Item> items;
        Inventory inventario;

        public GiledroseTest()
        {
            this.items = new List<Item>
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
            };

            this.inventario = new Inventory(items);
            this.inventario.updateQuality();
        }

        [TestMethod]
        public void TestParaElemento1DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[0].SellIn;
            int valorAnteriorDeQuality = this.items[0].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn, this.items[0].SellIn);
            Assert.AreEqual(valorAnteriorDeQuality, this.items[0].Quality);

        }

        [TestMethod]
        public void TestParaElemento2DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[1].SellIn;
            int valorAnteriorDeQuality = this.items[1].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn, this.items[1].SellIn);
            Assert.AreEqual(valorAnteriorDeQuality, this.items[1].Quality);

        }

        [TestMethod]
        public void TestParaElemento3DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[2].SellIn;
            int valorAnteriorDeQuality = this.items[2].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn, this.items[2].SellIn);
            Assert.AreEqual(valorAnteriorDeQuality, this.items[2].Quality);

        }

        [TestMethod]
        public void TestParaElemento4DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[3].SellIn;
            int valorAnteriorDeQuality = this.items[3].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn - 1, this.items[3].SellIn);
            Assert.AreEqual(valorAnteriorDeQuality, this.items[3].Quality);

        }

        [TestMethod]
        public void TestParaElemento5DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[4].SellIn;
            int valorAnteriorDeQuality = this.items[4].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn - 1, this.items[4].SellIn);
            Assert.AreEqual(valorAnteriorDeQuality + 2, this.items[4].Quality);

        }

        [TestMethod]
        public void TestParaElemento6DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[5].SellIn;
            int valorAnteriorDeQuality = this.items[5].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn - 1, this.items[5].SellIn);
            Assert.AreEqual(0, this.items[5].Quality);

        }

        [TestMethod]
        public void TestParaElemento7DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[6].SellIn;
            int valorAnteriorDeQuality = this.items[6].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn - 1, this.items[6].SellIn);
            Assert.AreEqual(valorAnteriorDeQuality + 1, this.items[6].Quality);

        }

        [TestMethod]
        public void TestParaElemento8DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[7].SellIn;
            int valorAnteriorDeQuality = this.items[7].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn - 1, this.items[7].SellIn);
            Assert.AreEqual(valorAnteriorDeQuality + 1, this.items[7].Quality);

        }

        [TestMethod]
        public void TestParaElemento9DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[8].SellIn;
            int valorAnteriorDeQuality = this.items[8].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn - 1, this.items[8].SellIn);
            Assert.AreEqual(valorAnteriorDeQuality + 2, this.items[8].Quality);

        }

        [TestMethod]
        public void TestParaElemento10DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[9].SellIn;
            int valorAnteriorDeQuality = this.items[9].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn - 1, this.items[9].SellIn);
            Assert.AreEqual(valorAnteriorDeQuality + 3, this.items[9].Quality);

        }

        [TestMethod]
        public void TestParaElemento11DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[10].SellIn;
            int valorAnteriorDeQuality = this.items[10].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn - 1, this.items[10].SellIn);
            Assert.AreEqual(0, this.items[10].Quality);

        }

        [TestMethod]
        public void TestParaElemento12DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[11].SellIn;
            int valorAnteriorDeQuality = this.items[11].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn - 1, this.items[11].SellIn);
            Assert.AreEqual(0, this.items[11].Quality);

        }

        [TestMethod]
        public void TestParaElemento13DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[12].SellIn;
            int valorAnteriorDeQuality = this.items[12].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn - 1, this.items[12].SellIn);
            Assert.AreEqual(valorAnteriorDeQuality - 1, this.items[12].Quality);

        }

        [TestMethod]
        public void TestParaElemento14DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[13].SellIn;
            int valorAnteriorDeQuality = this.items[13].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn - 1, this.items[13].SellIn);
            Assert.AreEqual(valorAnteriorDeQuality - 1, this.items[13].Quality);

        }

        [TestMethod]
        public void TestParaElemento15DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[14].SellIn;
            int valorAnteriorDeQuality = this.items[14].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn - 1, this.items[14].SellIn);
            Assert.AreEqual(valorAnteriorDeQuality - 2, this.items[14].Quality);

        }

        //verifica que conjured disminuye en 2
        [TestMethod]
        public void TestParaElemento16DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[15].SellIn;
            int valorAnteriorDeQuality = this.items[15].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn - 1, this.items[15].SellIn);
            Assert.AreEqual(valorAnteriorDeQuality - 2, this.items[15].Quality);

        }

        [TestMethod]
        public void TestParaElemento17DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[16].SellIn;
            int valorAnteriorDeQuality = this.items[16].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn - 1, this.items[16].SellIn);
            Assert.AreEqual(valorAnteriorDeQuality - 2, this.items[16].Quality);

        }

        //verifica que sulfuras tenga calidad constante de 80 y sellin constante de 0
        [TestMethod]
        public void TestParaElemento18DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[17].SellIn;
            int valorAnteriorDeQuality = this.items[17].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn, this.items[17].SellIn);
            Assert.AreEqual(valorAnteriorDeQuality, this.items[17].Quality);
        }

        [TestMethod]
        public void TestParaElemento19DeLaLista()
        {
            int valorAnteriorDeSellIn = this.items[18].SellIn;
            int valorAnteriorDeQuality = this.items[18].Quality;
            Assert.AreEqual(valorAnteriorDeSellIn - 1, this.items[18].SellIn);
            Assert.AreEqual(valorAnteriorDeQuality - 2, this.items[18].Quality);
        }  
    }
}

