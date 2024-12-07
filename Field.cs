using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldsOfFortune
{
    public class Field
    {
        public static Field Instance = new Field();

        //variables of values
        public int index;
        public bool owned;
        public bool growing;
        public int currentGrowInteger;
        public int growTime;
        public bool harvesting;
        public int currentHarvest;
        public int harvestTime;

        public void BuyFieldCellVar()
        {
            owned = true;
        }

        //references for graphical elements

        public FieldGroup fg = new FieldGroup();

        //buy button
        //status text
        //product icon
        //product icon overlay
        //ready for collection icon
        //inventory full icon
        //tractor icon
        //soil (ready)
        //soil (growing)
        //soil (unused)
    }
}
