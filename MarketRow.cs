using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FieldsOfFortune
{
    public partial class MarketRow: UserControl
    {
        public static MarketRow Instance = new MarketRow();

        public int ID { get; set; }
        public bool onMarket { get; set; }
        public int amount { get; set; }
        public decimal sellPrice { get; set; }

        public MarketRow()
        {
            InitializeComponent();
        }

        private void txt_enter_price_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("relevant comment " + ID.ToString());
            MarketDisplay.Instance.UpdateSellingPrice(ID);
        }
    }
}
