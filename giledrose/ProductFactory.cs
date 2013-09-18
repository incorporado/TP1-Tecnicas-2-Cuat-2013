using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Fiuba.Tecnicas.Giledrose
{
    class ProductFactory
    {
        private ArrayList productType1 =  new ArrayList();
        private ArrayList productType2 =  new ArrayList();
        private ArrayList productType3 =  new ArrayList();
        private ArrayList productType4 =  new ArrayList();

        public void addProducts () 
        {
            this.productType1.Add("+5 Dexterity Vest");
            this.productType1.Add("Elixir of the Mongoose");
            this.productType2.Add("Aged Brie");
            this.productType3.Add("Backstage passes to a TAFKAL80ETC concert");
            this.productType4.Add("Conjured Mana Cake");
        }

        public Product createProduct(string itemName)
        {
            if (this.productType1.Contains(itemName))
            {
                return new Type1();
            }
            if (this.productType2.Contains(itemName))
            {
                return new Type2();
            }
            if (this.productType3.Contains(itemName))
            {
                return new Type3();
            }
            if (this.productType4.Contains(itemName))
            {
                return new Type4();
            }
            
            return new NullType();        
        }
    }
}
