using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fiuba.Tecnicas.Giledrose
{
    class Tipo3 : Producto
    {
        public const int MAXIMA_CALIDAD = 50;
        public const int A_DIEZ_DIAS_DEL_VENCIMIENTO = 11;
        public const int A_CINCO_DIAS_DEL_VENCIMIENTO = 6;

        public void actualizar(Item item)
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
    }
}
