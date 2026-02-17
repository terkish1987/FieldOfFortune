using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldsOfFortune
{
    public partial class MarketDisplay: Form
    {
        public static MarketDisplay Instance = new MarketDisplay();

        public MarketDisplay()
        {
            InitializeComponent();
        }

        private void MarketDisplay_Load(object sender, EventArgs e) //triggered by making form visible in GameController (loads for the first time)
        {
            GameController.Instance.SaveGameCheck();

            GameController.Instance.AddMarketRow(MarketRow_0);
            MarketRow_0.ID = 0;
            GameController.Instance.AddMarketRow(MarketRow_1);
            MarketRow_1.ID = 1;
            GameController.Instance.AddMarketRow(MarketRow_2);
            MarketRow_2.ID = 2;
            GameController.Instance.AddMarketRow(MarketRow_3);
            MarketRow_3.ID = 3;
            GameController.Instance.AddMarketRow(MarketRow_4);
            MarketRow_4.ID = 4;
            GameController.Instance.AddMarketRow(MarketRow_5);
            MarketRow_5.ID = 5;
            GameController.Instance.AddMarketRow(MarketRow_6);
            MarketRow_6.ID = 6;
            GameController.Instance.AddMarketRow(MarketRow_7);
            MarketRow_7.ID = 7;
            GameController.Instance.AddMarketRow(MarketRow_8);
            MarketRow_8.ID = 8;
            GameController.Instance.AddMarketRow(MarketRow_9);
            MarketRow_9.ID = 9;
            GameController.Instance.AddMarketRow(MarketRow_10);
            MarketRow_10.ID = 10;
            GameController.Instance.AddMarketRow(MarketRow_11);
            MarketRow_11.ID = 11;
            GameController.Instance.AddMarketRow(MarketRow_12);
            MarketRow_12.ID = 12;
            GameController.Instance.AddMarketRow(MarketRow_13);
            MarketRow_13.ID = 13;
            GameController.Instance.AddMarketRow(MarketRow_14);
            MarketRow_14.ID = 14;
            GameController.Instance.AddMarketRow(MarketRow_15);
            MarketRow_15.ID = 15;
            GameController.Instance.AddMarketRow(MarketRow_16);
            MarketRow_16.ID = 16;
            GameController.Instance.AddMarketRow(MarketRow_17);
            MarketRow_17.ID = 17;
            GameController.Instance.AddMarketRow(MarketRow_18);
            MarketRow_18.ID = 18;
            GameController.Instance.AddMarketRow(MarketRow_19);
            MarketRow_19.ID = 19;
        }

        /*public void GameController.Instance.AddMarketRow(MarketRow mr)
        {
            Market m = new Market();
            m.mr = mr;

            s.owned = false;
            s.capacity = 150;
            s.productID = -1; // If there is no product, ID is -1
            s.productName = "";
            s.productQty = 0;
            s.onMarket = false;
            s.price = 0;

            GameController.Instance.AddStorage(s);
        }*/

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            GameController.Instance.CloseMarketDisplay();
        }
    }
}
