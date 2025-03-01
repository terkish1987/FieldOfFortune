namespace FieldsOfFortune
{
    partial class PlantDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.plantProduct1 = new FieldsOfFortune.PlantProduct();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.plantProduct1);
            this.panel1.Location = new System.Drawing.Point(72, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 468);
            this.panel1.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Cancel_Button;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(871, 55);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(60, 60);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // plantProduct1
            // 
            this.plantProduct1.Location = new System.Drawing.Point(3, 68);
            this.plantProduct1.Name = "plantProduct1";
            this.plantProduct1.Size = new System.Drawing.Size(180, 250);
            this.plantProduct1.TabIndex = 0;
            // 
            // PlantDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Screenshot_2024_12_12_224404;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 593);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "PlantDisplay";
            this.Text = "PlantDisplay";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private PlantProduct plantProduct1;
    }
}