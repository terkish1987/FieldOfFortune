using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using FieldsOfFortune.Properties;

namespace FieldsOfFortune
{
    public class GameController
    {
        public static readonly GameController Instance = new GameController();

        public List<Field> fieldList = new List<Field>();

        public List<Storage> storageList = new List<Storage>();

        //public List<Plant> plantList = new List<Plant>();

        public List<Product> productList = new List<Product>();

        public List<MarketRow> marketList = new List<MarketRow>();

        public List<Form> InitializedForms = new List<Form>();

        public List<int> fieldPriceList = new List<int> {100, 120, 140, 170, 200, 240, 290, 350, 420, 500, 600, 710, 840, 1000, 1200, 1400, 1700, 2000, 2400, 2800, 3300, 3900, 4600, 5400, 6400, 7500, 8800, 10000, 12000, 14000, 16000, 19000, 22000, 26000, 30000, 35000, 41000, 48000, 56000, 65000, 75000, 87000, 10000, 120000, 140000, 160000, 180000, 210000, 240000, 280000, 320000, 370000, 420000, 480000, 550000, 630000, 720000, 820000, 940000, 1100000, 1300000, 1500000, 1700000, 1900000};
        public List<int> storagePriceList = new List<int> {47, 90, 160, 280, 500, 880, 1500, 2600, 4500, 7800, 13000, 22000, 38000, 65000, 110000, 190000, 320000, 540000, 900000, 1500000};
        public List<bool> tutorialList = new List<bool> { false, false, false, false, false, false, false, false };

        public Form form1;
        public Form buyForm;
        public Form storageDisplay;
        public Form plantDisplay;
        public Form marketDisplay;

        //Validation variables

        public bool fieldCheck;
        public bool storageCheck;
        public bool marketCheck;
        public bool offersCheck;

        //Runtime variables

        public int fieldID;
        public int storageID;
        public int plantID;
        public int productID;

        public int fieldCount = 0;
        public int storageCount = 0;

        public decimal marketMargin = 0.2m;

        public List<int> oldSupplyList = new List<int> {1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000};
        public List<int> supplyList = new List<int> {1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000 };
        public List<int> sDiffList = new List<int> {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        public List<int> oldDemandList = new List<int> { 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000 };
        public List<int> demandList = new List<int> { 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000 };
        public List<int> dDiffList = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public List<int> mRatingList = new List<int> { 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000 };

        public int money = 150;
        public int day = 1;

        public string purchaseType = "";

        //Default variables

        public int minSupply = 500;
        public int maxSupply = 1500;

        public int minDemand = 700;
        public int maxDemand = 1500;

        public int defaultMarketRating = 1000;
        public decimal defaultMarketMargin = 0.2m;
        public int defaultMoney = 150;
        public int defaultDay = 1;

        public bool ValidateOpen()
        {
            bool check = false;
            if (fieldCheck || storageCheck || marketCheck || offersCheck)
            {
                check = true;
            }
            return check;
        }

        public void ValidateBuy(int ID, string purchaseType)
        {
            if (ValidateOpen())
            {
                return;
            }

            fieldCheck = true;
            OpenBuyForm(ID, purchaseType);
        }

        public void BuyFieldCell()
        {
            money -= fieldPriceList[fieldCount];

            Form1.Instance.ChangeMoney();
            fieldList[fieldID].fg.BuyFieldCellGraphics();

            fieldList[fieldID].owned = true;
            fieldCount += 1;

            Field.Instance.BuyFieldCellVar();
        }

        public void BuyStorageCrate()
        {
            money -= storagePriceList[storageCount];

            Form1.Instance.ChangeMoney();
            storageList[storageID].sc.BuyStorageCrateGraphics();

            storageList[storageID].owned = true;
            storageCount += 1;

            Storage.Instance.BuyStorageCrateVar();
        }

        public void OpenBuyForm(int ID, string purchaseType)
        {
            if (purchaseType == "field")
            {
                fieldID = ID;
            }
            else if (purchaseType == "storage")
            {
                storageID = ID;
            }

            InitializedForms[1].Enabled = true;
            InitializedForms[1].Show();
        }

        public void CloseBuyForm()
        {
            InitializedForms[1].Hide();
            InitializedForms[1].Enabled = false;

            if (fieldCheck)
            {
                fieldCheck = false;
            }
        }

        public void OpenStorageDisplay()
        {
            if (ValidateOpen())
            {
                return;
            }

            storageCheck = true;
            InitializedForms[2].Enabled = true;
            InitializedForms[2].Show();
        }

        public void CloseStorageDisplay()
        {
            InitializedForms[2].Hide();
            InitializedForms[2].Enabled = false;

            storageCheck = false;
        }

        public void OpenPlantDisplay(int ID)
        {
            if (!fieldList[ID].owned)
            {
                return;
            }
            InitializedForms[3].Show();
            InitializedForms[3].Enabled = true;
        }

        public void ClosePlantDisplay()
        {
            InitializedForms[3].Hide();
            InitializedForms[3].Enabled = false;
        }

        public void OpenMarketDisplay() //triggered by button click event on Form1
        {
            if (ValidateOpen())
            {
                return;
            }

            InitializedForms[4].Show(); //event that triggers MarketDisplay_Load() function
            InitializedForms[4].Enabled = true;

            marketCheck = true;

            /*
            #region Garlicky Example
            

            Debug.WriteLine(marketList.Count);
            Debug.WriteLine(productList.Count);

            //INFO
            marketList[0].pb_product_icon.BackgroundImage = productList[0].icon;
            marketList[0].lbl_product_name.Text = productList[0].name;

            //SELL
            marketList[0].lbl_sell_price.Text = (productList[0].onMarket) ? productList[0].sellingPrice.ToString("F2") : productList[0].marketCost.ToString("f2");
            marketList[0].btn_no_mark.Visible = !productList[0].onMarket;
            marketList[0].btn_yes_mark.Visible = productList[0].onMarket;

            //TRENDS
            if (productList[0].sDiff > 0)
            {
                marketList[0].pb_supply_fluc.BackgroundImage = Resources.Arrow_Up_Green;
            }
            else if (productList[0].sDiff == 0)
            {
                marketList[0].pb_supply_fluc.BackgroundImage = Resources.Arrow_Flat_Yellow;
            }
            else
            {
                marketList[0].pb_supply_fluc.BackgroundImage = Resources.Arrow_Down_Red;
            }

            if (productList[0].dDiff > 0)
            {
                marketList[0].pb_demand_fluc.BackgroundImage = Resources.Arrow_Up_Green;
            }
            else if (productList[0].dDiff == 0)
            {
                marketList[0].pb_demand_fluc.BackgroundImage = Resources.Arrow_Flat_Yellow;
            }
            else
            {
                marketList[0].pb_demand_fluc.BackgroundImage = Resources.Arrow_Down_Red;
            }

            marketList[0].txt_supply_value.Text = ((float)productList[0].sDiff / productList[0].oldSupply).ToString("F1");
            marketList[0].txt_demand_value.Text = ((float)productList[0].dDiff / productList[0].oldDemand).ToString("F1");

            marketList[0].txt_market_value.Text = productList[0].marketRating.ToString();
            
            switch (productList[0].marketRating)
            {
                case int n when (n >= 1700):
                    marketList[0].pb_market_rating.BackgroundImage = Resources._5of5Bar;
                    break;
                case int n when (n >= 1400):
                    marketList[0].pb_market_rating.BackgroundImage = Resources._4of5Bar;
                    break;
                case int n when (n >= 1100):
                    marketList[0].pb_market_rating.BackgroundImage = Resources._3of5Bar;
                    break;
                case int n when (n >= 800):
                    marketList[0].pb_market_rating.BackgroundImage = Resources._2of5Bar;
                    break;
                case int n when (n >= 500):
                    marketList[0].pb_market_rating.BackgroundImage = Resources._1of5Bar;
                    break;
                default:
                    marketList[0].pb_market_rating.BackgroundImage = Resources._0of5Bar;
                    break;
            }

            //BUY
            marketList[0].txt_prod_amount.Text = "0";
            marketList[0].txt_prod_price.Text = productList[0].marketCost.ToString("F2");

            #endregion
            */

            //loop through 20 products - each individual product line 4 sections update (info, sell, trends, buy)
            for (int i = 0; i < productList.Count; i++)
            {
                //INFO: *static*
                //fetch product icon and update object 
                //fetch product name and update object

                //SELL: if statement; product on-market? if so, display user's selling price; if not, default 
                if (productList[i].onMarket)
                {
                    //fetch latest price (possibly user-edited, or still default) and update object
                    //update sign to tick
                }
                else
                {
                    //display price
                    //update sign to cross
                }

                //TRENDS: *6 elements total* update both arrows (based on change from previous day; requires mathematical calculations to determine % of change) and rating bar

                //supply arrow... fetch sDiff, update
                //demand arow... fetch dDiff, update

                //float sChange = (divide sDiff by oldSupply); display as percentage
                //float dChange = (divide dDiff by oldDemand); display as percentage

                //display marketRating
                //fetch marketRating; display and update bar level object

                //BUY: default sets amount to 0; product purchase price fluctuates based on market rating
                //fetch marketCost and update object
                //amount = 0
            }
        }

        public void CloseMarketDisplay()
        {
            InitializedForms[4].Hide();
            InitializedForms[4].Enabled = false;

            marketCheck = false;
        }

        public void AddForm(Form form)
        {
            InitializedForms.Add(form);
        }

        public void RemoveForm(Form form)
        {
            InitializedForms.Remove(form);
        }
        
        public void ShowInitializedForms()
        {
            foreach (var form in InitializedForms)
            {
                Console.WriteLine($"Form: {form.Name}, IsDisposed: {form.IsDisposed}");
            }
        }

        public void SaveGameCheck () {
            //Debug.Write("Test");
        }

        public void AddField (Field f)
        {
            fieldList.Add(f);
        }

        public void AddStorage(Storage s)
        {
            storageList.Add(s);
        }

        public void AddMarketRow(MarketRow mr)
        {
            marketList.Add(mr);
        }

        public void SetReference(Form f, int id)
        {

            if (id == 0)
            {
                form1 = f;
            }

            else if (id == 1)
            {
                buyForm = f;
            }

            else if (id == 2)
            {
                storageDisplay = f;
            }

            else if (id == 3)
            {
                plantDisplay = f;
            }

            else if (id == 4)
            {
                marketDisplay = f;
            }
        }

        public void ShowForm(int id)
        {
            if (id == 1)
            {
                buyForm.Show();
            }
        }
    }
}