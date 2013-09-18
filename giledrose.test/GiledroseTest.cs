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
        List<Item> newItems;
        List<Item> unchangedItems;
        
        Inventory inventory;
                
        [TestInitialize()]
        public void setUp()
        {
            this.newItems = new List<Item>
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

            this.unchangedItems = new List<Item>
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
            
            this.inventory = new Inventory(newItems);
            this.inventory.updateQuality();
        }

        //Test Sulfuras maints its Quality and Sell In
        [TestMethod]
        public void TestForItem1()
        {
            Assert.AreEqual(this.unchangedItems[0].SellIn, this.newItems[0].SellIn);
            Assert.AreEqual(this.unchangedItems[0].Quality, this.newItems[0].Quality);

        }

        //Test Sulfuras maints its Quality and Sell In
        [TestMethod]
        public void TestForItem2()
        {
            Assert.AreEqual(this.unchangedItems[1].SellIn, this.newItems[1].SellIn);
            Assert.AreEqual(this.unchangedItems[1].Quality, this.newItems[1].Quality);

        }

        //Test Sulfuras maints its Quality and Sell In
        [TestMethod]
        public void TestForItem3()
        {
            Assert.AreEqual(this.unchangedItems[2].SellIn, this.newItems[2].SellIn);
            Assert.AreEqual(this.unchangedItems[2].Quality, this.newItems[2].Quality);

        }

        //Test for Aged Brie not going upper that 50
        [TestMethod]
        public void TestForItem4()
        {
            Assert.AreEqual(this.unchangedItems[3].SellIn - 1, this.newItems[3].SellIn);
            Assert.AreEqual(this.unchangedItems[3].Quality, this.newItems[3].Quality);

        }

        //Test for Aged Brie Quality goes up by 2 points when expired
        [TestMethod]
        public void TestForItem5()
        {
            Assert.AreEqual(this.unchangedItems[4].SellIn - 1, this.newItems[4].SellIn);
            Assert.AreEqual(this.unchangedItems[4].Quality + 2, this.newItems[4].Quality);

        }

        //Test Backstage Quality goes to 0 when expired
        [TestMethod]
        public void TestForItem6()
        {
            Assert.AreEqual(this.unchangedItems[5].SellIn - 1, this.newItems[5].SellIn);
            Assert.AreEqual(0, this.newItems[5].Quality);

        }

        //Test Backstage Quality not goes upper than 50
        [TestMethod]
        public void TestForItem7()
        {
            Assert.AreEqual(this.unchangedItems[6].SellIn - 1, this.newItems[6].SellIn);
            Assert.AreEqual(this.unchangedItems[6].Quality + 1, this.newItems[6].Quality);

        }

        //Test Backstage Quality not goes upper than 50
        [TestMethod]
        public void TestForItem8() 
        {
            Assert.AreEqual(this.unchangedItems[7].SellIn - 1, this.newItems[7].SellIn);
            Assert.AreEqual(this.unchangedItems[7].Quality + 1, this.newItems[7].Quality);

        }

        //Test Backstage Quality not goes upper than 50
        [TestMethod]
        public void TestForItem9() 
        {
            Assert.AreEqual(this.unchangedItems[8].SellIn - 1, this.newItems[8].SellIn);
            Assert.AreEqual(this.unchangedItems[8].Quality + 2, this.newItems[8].Quality);

        }

        //Test Backstage Quality not goes upper than 50
        [TestMethod]
        public void TestForItem10() 
        {
            Assert.AreEqual(this.unchangedItems[9].SellIn - 1, this.newItems[9].SellIn);
            Assert.AreEqual(this.unchangedItems[9].Quality + 3, this.newItems[9].Quality);

        }

        //Test Backstage Quality goes to 0 when expired
        [TestMethod]
        public void TestForItem11()
        {
            Assert.AreEqual(this.unchangedItems[10].SellIn - 1, this.newItems[10].SellIn);
            Assert.AreEqual(0, this.newItems[10].Quality);

        }

        //Test Backstage Quality goes to 0 when expired
        [TestMethod]
        public void TestForItem12()
        {
            Assert.AreEqual(this.unchangedItems[11].SellIn - 1, this.newItems[11].SellIn);
            Assert.AreEqual(0, this.newItems[11].Quality);

        }

        //Test +5 Dexterity Vest Quality doesn't go under 0
        [TestMethod]
        public void TestForItem13()
        {
            Assert.AreEqual(this.unchangedItems[12].SellIn - 1, this.newItems[12].SellIn);
            Assert.AreEqual(this.unchangedItems[12].Quality - 1, this.newItems[12].Quality);

        }

        //Test +5 Dexterity Vest Quality doesn't go under 0
        [TestMethod]
        public void TestForItem14()
        {
            Assert.AreEqual(this.unchangedItems[13].SellIn - 1, this.newItems[13].SellIn);
            Assert.AreEqual(this.unchangedItems[13].Quality - 1, this.newItems[13].Quality);

        }

        //Test +5 Dexterity Vest Quality doesn't go under 0
        [TestMethod]
        public void TestForItem15()
        {
            Assert.AreEqual(this.unchangedItems[14].SellIn - 1, this.newItems[14].SellIn);
            Assert.AreEqual(this.unchangedItems[14].Quality - 2, this.newItems[14].Quality);

        }

        //Test that Conjured no expired reduce quality by 2 points
        [TestMethod]
        public void TestForItem16()
        {
            Assert.AreEqual(this.unchangedItems[15].SellIn - 1, this.newItems[15].SellIn);
            Assert.AreEqual(0, this.newItems[15].Quality);

        }

        //Test that Elixir of the Mongoose reduce its Quality by 2 points when expired.
        [TestMethod]
        public void TestForItem17()
        {
            Assert.AreEqual(this.unchangedItems[16].SellIn - 1, this.newItems[16].SellIn);
            Assert.AreEqual(this.unchangedItems[16].Quality - 2, this.newItems[16].Quality);

        }

        //Test that Sulfuras maintains the Quality at 80 and Sell In at 0
        [TestMethod]
        public void TestForItem18()
        {
            Assert.AreEqual(this.unchangedItems[17].SellIn, this.newItems[17].SellIn);
            Assert.AreEqual(this.unchangedItems[17].Quality, this.newItems[17].Quality);
        }

        //Test that Conjured no expired reduce quality by 2 points
        [TestMethod]
        public void TestForItem19()
        {
            Assert.AreEqual(this.unchangedItems[18].SellIn - 1, this.newItems[18].SellIn);
            Assert.AreEqual(this.unchangedItems[18].Quality - 2, this.newItems[18].Quality);
        }

        //Test that Conjured expired reduce quality by 4 points
        [TestMethod]
        public void TestForItem20()
        {
            Assert.AreEqual(this.unchangedItems[19].SellIn - 1, this.newItems[19].SellIn);
            Assert.AreEqual(this.unchangedItems[19].Quality - 4, this.newItems[19].Quality);
        } 
    }
}

