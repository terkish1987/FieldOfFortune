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
    public partial class StorageDisplay : Form
    {
        public static readonly StorageDisplay Instance = new StorageDisplay();

        public StorageDisplay()
        {
            InitializeComponent();
        }

        private void StorageDisplay_Load(object sender, EventArgs e)
        {
            GameController.Instance.SaveGameCheck();

            StorageInitialization(StorageCrate_0);
            storageCrate_0.ID = 0;
            StorageInitialization(StorageCrate_1);
            storageCrate_1.ID = 1;
            StorageInitialization(StorageCrate_2);
            storageCrate_2.ID = 2;
            StorageInitialization(StorageCrate_3);
            storageCrate_3.ID = 3;
            StorageInitialization(StorageCrate_4);
            storageCrate_4.ID = 4;
            StorageInitialization(StorageCrate_5);
            storageCrate_5.ID = 5;
            StorageInitialization(StorageCrate_6);
            storageCrate_6.ID = 6;
            StorageInitialization(StorageCrate_7);
            storageCrate_7.ID = 7;
            StorageInitialization(StorageCrate_8);
            storageCrate_8.ID = 8;
            StorageInitialization(StorageCrate_9);
            storageCrate_9.ID = 9;
            StorageInitialization(StorageCrate_10);
            storageCrate_10.ID = 10;
            StorageInitialization(StorageCrate_11);
            storageCrate_11.ID = 11;
            StorageInitialization(StorageCrate_12);
            storageCrate_12.ID = 12;
            StorageInitialization(StorageCrate_13);
            storageCrate_13.ID = 13;
            StorageInitialization(StorageCrate_14;
            storageCrate_14.ID = 14;
            StorageInitialization(StorageCrate_15);
            storageCrate_15.ID = 15;
            StorageInitialization(StorageCrate_16);
            storageCrate_16.ID = 16;
            StorageInitialization(StorageCrate_17);
            storageCrate_17.ID = 17;
            StorageInitialization(StorageCrate_18);
            storageCrate_18.ID = 18;
            StorageInitialization(StorageCrate_19);
            storageCrate_19.ID = 19;
        }

        public void StorageInitialization(StorageCrate sc)
        {
            Storage s = new Storage();
            s.sc = sc;

            GameController.Instance.AddStorage(s);
        }
    }
}
