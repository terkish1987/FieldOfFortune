namespace FieldsOfFortune
{
    partial class StorageCrate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_stock_capacity = new System.Windows.Forms.Label();
            this.btn_bin_icon = new System.Windows.Forms.Button();
            this.btn_buy = new System.Windows.Forms.Button();
            this.btn_storage_crate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_stock_capacity
            // 
            this.lbl_stock_capacity.AutoSize = true;
            this.lbl_stock_capacity.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock_capacity.ForeColor = System.Drawing.Color.Black;
            this.lbl_stock_capacity.Location = new System.Drawing.Point(34, 75);
            this.lbl_stock_capacity.Name = "lbl_stock_capacity";
            this.lbl_stock_capacity.Size = new System.Drawing.Size(82, 33);
            this.lbl_stock_capacity.TabIndex = 2;
            this.lbl_stock_capacity.Text = "0/150";
            this.lbl_stock_capacity.Visible = false;
            // 
            // btn_bin_icon
            // 
            this.btn_bin_icon.BackColor = System.Drawing.SystemColors.Control;
            this.btn_bin_icon.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Bin_Icon___Red;
            this.btn_bin_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bin_icon.FlatAppearance.BorderSize = 0;
            this.btn_bin_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bin_icon.Location = new System.Drawing.Point(107, 14);
            this.btn_bin_icon.Name = "btn_bin_icon";
            this.btn_bin_icon.Size = new System.Drawing.Size(30, 30);
            this.btn_bin_icon.TabIndex = 3;
            this.btn_bin_icon.UseVisualStyleBackColor = false;
            this.btn_bin_icon.Visible = false;
            // 
            // btn_buy
            // 
            this.btn_buy.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Button_Frame2;
            this.btn_buy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buy.FlatAppearance.BorderSize = 0;
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy.ForeColor = System.Drawing.Color.White;
            this.btn_buy.Location = new System.Drawing.Point(45, 50);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(60, 20);
            this.btn_buy.TabIndex = 1;
            this.btn_buy.Text = "Buy";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // btn_storage_crate
            // 
            this.btn_storage_crate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_storage_crate.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Screenshot_2024_11_21_175122;
            this.btn_storage_crate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_storage_crate.FlatAppearance.BorderSize = 0;
            this.btn_storage_crate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_storage_crate.Location = new System.Drawing.Point(0, 0);
            this.btn_storage_crate.Name = "btn_storage_crate";
            this.btn_storage_crate.Size = new System.Drawing.Size(150, 120);
            this.btn_storage_crate.TabIndex = 0;
            this.btn_storage_crate.UseVisualStyleBackColor = false;
            // 
            // StorageCrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_bin_icon);
            this.Controls.Add(this.lbl_stock_capacity);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.btn_storage_crate);
            this.Name = "StorageCrate";
            this.Size = new System.Drawing.Size(150, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_storage_crate;
        public System.Windows.Forms.Button btn_buy;
        public System.Windows.Forms.Label lbl_stock_capacity;
        public System.Windows.Forms.Button btn_bin_icon;
    }
}
