using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldsOfFortune
{
    public partial class BuyForm : Form
    {
        public BuyForm()
        {
            InitializeComponent();

            GameController.Instance.SetReference(this, 1);
        }

        public void UpdateBuyForm()
        {
            if (GameController.Instance.purchaseType == "field")
            {
                lbl_price.Text = GameController.Instance.fieldPriceList[GameController.Instance.fieldCount].ToString();
                if (GameController.Instance.money < GameController.Instance.fieldPriceList[GameController.Instance.fieldCount])
                {
                    btn_confirm.Enabled = false;
                }
                else
                {
                    btn_confirm.Enabled = true;
                }
            }
            else if (GameController.Instance.purchaseType == "storage")
            {
                lbl_price.Text = GameController.Instance.storagePriceList[GameController.Instance.storageCount].ToString();
                if (GameController.Instance.money < GameController.Instance.storagePriceList[GameController.Instance.storageCount])
                {
                    btn_confirm.Enabled = false;
                }
                else
                {
                    btn_confirm.Enabled = true;
                }
            }
        }

        private void BuyForm_VisibleChanged(object sender, EventArgs e)
        {
            UpdateBuyForm();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            GameController.Instance.CloseBuyForm();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (GameController.Instance.purchaseType == "field")
            {
                GameController.Instance.BuyFieldCell();

            }
            else if(GameController.Instance.purchaseType == "storage")
            {
                GameController.Instance.BuyStorageCrate();
            }

            GameController.Instance.CloseBuyForm();
        }
    }
}
