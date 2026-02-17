using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
