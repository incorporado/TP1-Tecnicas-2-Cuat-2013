using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fiuba.Tecnicas.Giledrose
{
    class Tipo1 : Producto
    {
        public void actualizar(Item item)
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
    }
}
