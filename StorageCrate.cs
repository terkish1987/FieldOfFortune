using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldsOfFortune
{
    public partial class StorageCrate : UserControl
    {
        public static StorageCrate Instance = new StorageCrate();

        public int ID { get; set; }

        public StorageCrate()
        {
            InitializeComponent();
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            GameController.Instance.purchaseType = "storage";
            GameController.Instance.OpenBuyForm(ID, GameController.Instance.purchaseType);
        }

        public void BuyStorageCrateGraphics()
        {
            btn_buy.Visible = false;
            btn_buy.Enabled = false;
        }
    }
}
