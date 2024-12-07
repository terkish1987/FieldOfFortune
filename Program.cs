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
            buyForm.Name = "BuyForm";
            GameController.Instance.AddForm(homescreen);
            GameController.Instance.AddForm(buyForm);
            GameController.Instance.AddForm(storageDisplay);
            GameController.Instance.ShowInitializedForms();
        }
    }
}
