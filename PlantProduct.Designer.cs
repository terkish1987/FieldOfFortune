namespace FieldsOfFortune
{
    partial class PlantProduct
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
            this.btn_box_frame = new System.Windows.Forms.Button();
            this.btn_plant_product = new System.Windows.Forms.Button();
            this.btn_product_icon_overlay = new System.Windows.Forms.Button();
            this.txt_stock_amount = new System.Windows.Forms.TextBox();
            this.pb_product_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_product_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_box_frame
            // 
            this.btn_box_frame.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Button_Frame;
            this.btn_box_frame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_box_frame.FlatAppearance.BorderSize = 0;
            this.btn_box_frame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_box_frame.Location = new System.Drawing.Point(0, 0);
            this.btn_box_frame.Margin = new System.Windows.Forms.Padding(2);
            this.btn_box_frame.Name = "btn_box_frame";
            this.btn_box_frame.Size = new System.Drawing.Size(135, 200);
            this.btn_box_frame.TabIndex = 0;
            this.btn_box_frame.UseVisualStyleBackColor = true;
            // 
            // btn_plant_product
            // 
            this.btn_plant_product.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Confirm_Button;
            this.btn_plant_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_plant_product.FlatAppearance.BorderSize = 0;
            this.btn_plant_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plant_product.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plant_product.ForeColor = System.Drawing.Color.White;
            this.btn_plant_product.Location = new System.Drawing.Point(30, 136);
            this.btn_plant_product.Margin = new System.Windows.Forms.Padding(2);
            this.btn_plant_product.Name = "btn_plant_product";
            this.btn_plant_product.Size = new System.Drawing.Size(76, 41);
            this.btn_plant_product.TabIndex = 1;
            this.btn_plant_product.Text = "Plant";
            this.btn_plant_product.UseVisualStyleBackColor = true;
            // 
            // btn_product_icon_overlay
            // 
            this.btn_product_icon_overlay.BackgroundImage = global::FieldsOfFortune.Properties.Resources.circle_frame;
            this.btn_product_icon_overlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_product_icon_overlay.FlatAppearance.BorderSize = 0;
            this.btn_product_icon_overlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product_icon_overlay.Location = new System.Drawing.Point(22, 11);
            this.btn_product_icon_overlay.Margin = new System.Windows.Forms.Padding(2);
            this.btn_product_icon_overlay.Name = "btn_product_icon_overlay";
            this.btn_product_icon_overlay.Size = new System.Drawing.Size(91, 97);
            this.btn_product_icon_overlay.TabIndex = 27;
            this.btn_product_icon_overlay.UseVisualStyleBackColor = true;
            // 
            // txt_stock_amount
            // 
            this.txt_stock_amount.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock_amount.Location = new System.Drawing.Point(38, 100);
            this.txt_stock_amount.Margin = new System.Windows.Forms.Padding(2);
            this.txt_stock_amount.Name = "txt_stock_amount";
            this.txt_stock_amount.Size = new System.Drawing.Size(56, 43);
            this.txt_stock_amount.TabIndex = 28;
            this.txt_stock_amount.TabStop = false;
            this.txt_stock_amount.Text = "1";
            this.txt_stock_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_stock_amount.Visible = false;
            // 
            // pb_product_icon
            // 
            this.pb_product_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_product_icon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pb_product_icon.Location = new System.Drawing.Point(22, 11);
            this.pb_product_icon.Margin = new System.Windows.Forms.Padding(2);
            this.pb_product_icon.Name = "pb_product_icon";
            this.pb_product_icon.Size = new System.Drawing.Size(91, 97);
            this.pb_product_icon.TabIndex = 29;
            this.pb_product_icon.TabStop = false;
            // 
            // PlantProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_stock_amount);
            this.Controls.Add(this.pb_product_icon);
            this.Controls.Add(this.btn_product_icon_overlay);
            this.Controls.Add(this.btn_plant_product);
            this.Controls.Add(this.btn_box_frame);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlantProduct";
            this.Size = new System.Drawing.Size(135, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pb_product_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btn_plant_product;
        public System.Windows.Forms.Button btn_product_icon_overlay;
        public System.Windows.Forms.TextBox txt_stock_amount;
        public System.Windows.Forms.PictureBox pb_product_icon;
        public System.Windows.Forms.Button btn_box_frame;
    }
}
