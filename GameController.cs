using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Security.Cryptography;

namespace FieldsOfFortune
{
    public class GameController
    {
        public static readonly GameController Instance = new GameController();

        public List<Field> fieldList = new List<Field>();

        public List<Storage> storageList = new List<Storage>();

        public List<Form> InitializedForms = new List<Form>();

        public List<int> fieldPriceList = new List<int> {100, 120, 140, 170, 200, 240, 290, 350, 420, 500, 600, 710, 840, 1000, 1200, 1400, 1700, 2000, 2400, 2800, 3300, 3900, 4600, 5400, 6400, 7500, 8800, 10000, 12000, 14000, 16000, 19000, 22000, 26000, 30000, 35000, 41000, 48000, 56000, 65000, 75000, 87000, 10000, 120000, 140000, 160000, 180000, 210000, 240000, 280000, 320000, 370000, 420000, 480000, 550000, 630000, 720000, 820000, 940000, 1100000, 1300000, 1500000, 1700000, 1900000 };
        public List<int> storagePriceList = new List<int> {50, 90, 160, 280, 500, 880, 1500, 2600, 4500, 7800, 13000, 22000, 38000, 65000, 110000, 190000, 320000, 540000, 900000, 1500000};

        public Form form1;
        public Form buyForm;
        public Form storageDisplay;

        //Runtime parameters

        public int fieldID;
        public int storageID;
        public int fieldCount = 0;
        public int storageCount = 0;
        public int money = 150;
        public string purchaseType = "";

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
                InitializedForms[1].Show();
                InitializedForms[1].Enabled = true;
            }
            else if (purchaseType == "storage")
            {
                storageID = ID;
                InitializedForms[1].Show();
                InitializedForms[1].Enabled = true;
            }
        }

        public void OpenStorageDisplay()
        {
            InitializedForms[2].Show();
            InitializedForms[2].Enabled = true;
        }

        public void CloseBuyForm()
        {
            InitializedForms[1].Hide();
            InitializedForms[1].Enabled = false;
        }

        public void CloseStorageDisplay()
        {
            InitializedForms[2].Hide();
            InitializedForms[2].Enabled = false;
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
            Debug.Write("Test");
        }

        public void AddField (Field f)
        {
            fieldList.Add(f);
        }

        public void AddStorage(Storage s)
        {
            storageList.Add(s);
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