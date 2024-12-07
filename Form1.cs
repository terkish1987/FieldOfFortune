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
    public partial class Form1 : Form
    {
        public static Form1 Instance = new Form1();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameController.Instance.SaveGameCheck();

            FieldInitialization(FieldGroup_0);
            FieldGroup_0.ID = 0;
            FieldInitialization(FieldGroup_1);
            FieldGroup_1.ID = 1;
            FieldInitialization(FieldGroup_2);
            FieldGroup_2.ID = 2;
            FieldInitialization(FieldGroup_3);
            FieldGroup_3.ID = 3;
            FieldInitialization(FieldGroup_4);
            FieldGroup_4.ID = 4;
            FieldInitialization(FieldGroup_5);
            FieldGroup_5.ID = 5;
            FieldInitialization(FieldGroup_6);
            FieldGroup_6.ID = 6;
            FieldInitialization(FieldGroup_7);
            FieldGroup_7.ID = 7;
            FieldInitialization(FieldGroup_8);
            FieldGroup_8.ID = 8;
            FieldInitialization(FieldGroup_9);
            FieldGroup_9.ID = 9;
            FieldInitialization(FieldGroup_10);
            FieldGroup_10.ID = 10;
            FieldInitialization(FieldGroup_11);
            FieldGroup_11.ID = 11;
            FieldInitialization(FieldGroup_12);
            FieldGroup_12.ID = 12;
            FieldInitialization(FieldGroup_13);
            FieldGroup_13.ID = 13;
            FieldInitialization(FieldGroup_14);
            FieldGroup_14.ID = 14;
            FieldInitialization(FieldGroup_15);
            FieldGroup_15.ID = 15;
            FieldInitialization(FieldGroup_16);
            FieldGroup_16.ID = 16;
            FieldInitialization(FieldGroup_17);
            FieldGroup_17.ID = 17;
            FieldInitialization(FieldGroup_18);
            FieldGroup_18.ID = 18;
            FieldInitialization(FieldGroup_19);
            FieldGroup_19.ID = 19;
            FieldInitialization(FieldGroup_20);
            FieldGroup_20.ID = 20;
            FieldInitialization(FieldGroup_21);
            FieldGroup_21.ID = 21;
            FieldInitialization(FieldGroup_22);
            FieldGroup_22.ID = 22;
            FieldInitialization(FieldGroup_23);
            FieldGroup_23.ID = 23;
            FieldInitialization(FieldGroup_24);
            FieldGroup_24.ID = 24;
            FieldInitialization(FieldGroup_25);
            FieldGroup_25.ID = 25;
            FieldInitialization(FieldGroup_26);
            FieldGroup_26.ID = 26;
            FieldInitialization(FieldGroup_27);
            FieldGroup_27.ID = 27;
            FieldInitialization(FieldGroup_28);
            FieldGroup_28.ID = 28;
            FieldInitialization(FieldGroup_29);
            FieldGroup_29.ID = 29;
            FieldInitialization(FieldGroup_30);
            FieldGroup_30.ID = 30;
            FieldInitialization(FieldGroup_31);
            FieldGroup_31.ID = 31;
            FieldInitialization(FieldGroup_32);
            FieldGroup_32.ID = 32;
            FieldInitialization(FieldGroup_33);
            FieldGroup_33.ID = 33;
            FieldInitialization(FieldGroup_34);
            FieldGroup_34.ID = 34;
            FieldInitialization(FieldGroup_35);
            FieldGroup_35.ID = 35;
            FieldInitialization(FieldGroup_36);
            FieldGroup_36.ID = 36;
            FieldInitialization(FieldGroup_37);
            FieldGroup_37.ID = 37;
            FieldInitialization(FieldGroup_38);
            FieldGroup_38.ID = 38;
            FieldInitialization(FieldGroup_39);
            FieldGroup_39.ID = 39;
            FieldInitialization(FieldGroup_40);
            FieldGroup_40.ID = 40;
            FieldInitialization(FieldGroup_41);
            FieldGroup_41.ID = 41;
            FieldInitialization(FieldGroup_42);
            FieldGroup_42.ID = 42;
            FieldInitialization(FieldGroup_43);
            FieldGroup_43.ID = 43;
            FieldInitialization(FieldGroup_44);
            FieldGroup_44.ID = 44;
            FieldInitialization(FieldGroup_45);
            FieldGroup_45.ID = 45;
            FieldInitialization(FieldGroup_46);
            FieldGroup_46.ID = 46;
            FieldInitialization(FieldGroup_47);
            FieldGroup_47.ID = 47;
            FieldInitialization(FieldGroup_48);
            FieldGroup_48.ID = 48;
            FieldInitialization(FieldGroup_49);
            FieldGroup_49.ID = 49;
            FieldInitialization(FieldGroup_50);
            FieldGroup_50.ID = 50;
            FieldInitialization(FieldGroup_51);
            FieldGroup_51.ID = 51;
            FieldInitialization(FieldGroup_52);
            FieldGroup_52.ID = 52;
            FieldInitialization(FieldGroup_53);
            FieldGroup_53.ID = 53;
            FieldInitialization(FieldGroup_54);
            FieldGroup_54.ID = 54;
            FieldInitialization(FieldGroup_55);
            FieldGroup_55.ID = 55;
            FieldInitialization(FieldGroup_56);
            FieldGroup_56.ID = 56;
            FieldInitialization(FieldGroup_57);
            FieldGroup_57.ID = 57;
            FieldInitialization(FieldGroup_58);
            FieldGroup_58.ID = 58;
            FieldInitialization(FieldGroup_59);
            FieldGroup_59.ID = 59;
            FieldInitialization(FieldGroup_60);
            FieldGroup_60.ID = 60;
            FieldInitialization(FieldGroup_61);
            FieldGroup_61.ID = 61;
            FieldInitialization(FieldGroup_62);
            FieldGroup_62.ID = 62;
            FieldInitialization(FieldGroup_63);
            FieldGroup_63.ID = 63;
            GameController.Instance.SetReference(this, 0);
        }
        public void FieldInitialization(FieldGroup fg)
        {

            Field f = new Field();
            f.fg = fg;

            GameController.Instance.AddField(f);

        }

        /*public void Test()
        {
            GameController.Instance.fieldList[0].fg.btn_buy_field_cell.Visible = false;
            GameController.Instance.fieldList[0].fg.btn_unused_field_cell.Visible = false;
            GameController.Instance.fieldList[0].fg.btn_growing_field_cell.Visible = true;
            GameController.Instance.fieldList[0].fg.txt_day_progress.Visible = true;
            GameController.Instance.fieldList[0].fg.txt_day_progress.Text = "test";
        }*/

        public void ChangeMoney()
        {
            txt_money.Text = GameController.Instance.money.ToString();
        }

        private void btn_storage_Click(object sender, EventArgs e)
        {
            GameController.Instance.OpenStorageDisplay();
        }
    }
}
