using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fiuba.Tecnicas.Giledrose
{
    class Tipo2 : Producto
    {
        public const int MAXIMA_CALIDAD = 50;

        public void actualizar(Item item)
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
    }
}
