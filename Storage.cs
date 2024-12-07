using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsOfFortune
{
    public class Storage
    {
        public static Storage Instance = new Storage();

        //variables of values
        public int index;
        public bool owned;
        public int capacity;
        public bool onMarket;
        public int price;
        public int productID;
        public string productName;
        public int productQty;

        public void BuyStorageCrateVar()
        {
            owned = true;
        }

        public StorageCrate sc = new StorageCrate();
    }
}
