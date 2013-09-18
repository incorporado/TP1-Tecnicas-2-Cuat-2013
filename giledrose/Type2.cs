using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fiuba.Tecnicas.Giledrose
{
    class Type2 : Product
    {
        public const int MAX_QUALITY = 50;

        public void update(Item item)
        {
            item.SellIn -= 1;

            if ((item.Quality + 1 < MAX_QUALITY) && (item.SellIn < 0))
            {
                item.Quality += 2;
            }
            else if (item.Quality < MAX_QUALITY)
            {
                item.Quality += 1;
            }
        }
    }
}
