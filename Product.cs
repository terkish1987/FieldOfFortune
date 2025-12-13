using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsOfFortune
{
    public class Product
    {
        public static Product Instance = new Product();

        public int index;
        public string name;
        public string type;
        public decimal cost;
        public int growTime;
        public int growQty;
        public int harvestTime;
        public int spaceReq;
        public int marketRating;
        public decimal marketMargin;
        public decimal marketCost;
        public bool onMarket;
        public Image icon;

    }
}