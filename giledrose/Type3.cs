using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fiuba.Tecnicas.Giledrose
{
    class Type3 : Product
    {
        public const int MAX_QUALITY = 50;
        public const int TEN_DAYS_TO_EXPIRATION = 11;
        public const int FIVE_DAYS_TO_EXPIRATION = 6;

        public void update(Item item)
        {
            if (item.SellIn - 1 < 0)
            {
                item.Quality = 0;
            }
            else
            {
                if (item.Quality + 1 > MAX_QUALITY - 1)
                {
                    item.Quality += 1;
                }
                else if ((item.Quality + 2 < MAX_QUALITY) && (item.SellIn < FIVE_DAYS_TO_EXPIRATION))
                {
                    item.Quality += 3;
                }
                else if ((item.Quality + 1 < MAX_QUALITY) && (item.SellIn < TEN_DAYS_TO_EXPIRATION))
                {
                    item.Quality += 2;
                }
            }

            item.SellIn -= 1;
        }
    }
}
