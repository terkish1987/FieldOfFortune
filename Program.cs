using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldsOfFortune
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static Form homescreen;
        public static Form buyForm;
        public static Form storageDisplay;
        public static Form plantDisplay;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetForms();
            Application.Run(homescreen);
        }

        static void SetForms()
        {
            homescreen = Form1.Instance;
            buyForm = new BuyForm();
            storageDisplay = new StorageDisplay();
            plantDisplay = new PlantDisplay();

            buyForm.Name = "BuyForm";

            GameController.Instance.AddForm(homescreen);
            GameController.Instance.AddForm(buyForm);
            GameController.Instance.AddForm(storageDisplay);
            GameController.Instance.AddForm(plantDisplay);
            GameController.Instance.ShowInitializedForms();

            GameController.Instance.InitializedForms[2].Owner = GameController.Instance.InitializedForms[0];
            GameController.Instance.InitializedForms[1].Owner = GameController.Instance.InitializedForms[2];
        }
    }
}
