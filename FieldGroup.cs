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
    public partial class FieldGroup : UserControl
    {
        public static FieldGroup Instance = new FieldGroup();

        public int ID { get; set; }

        public FieldGroup()
        {
            InitializeComponent();
        }

        private void btn_buy_field_cell_Click(object sender, EventArgs e)
        {
            GameController.Instance.purchaseType = "field";
            GameController.Instance.OpenBuyForm(ID, GameController.Instance.purchaseType);
        }

        public void BuyFieldCellGraphics()
        {
            btn_buy_field_cell.Visible = false;
            btn_buy_field_cell.Enabled = false;
        }
    }
}
