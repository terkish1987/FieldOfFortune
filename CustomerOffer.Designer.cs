namespace FieldsOfFortune
{
    partial class CustomerOffer
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
            this.pb_customer_pfp = new System.Windows.Forms.PictureBox();
            this.btn_customer_pfp_overlay = new System.Windows.Forms.Button();
            this.lbl_customer_name = new System.Windows.Forms.TextBox();
            this.pb_product_icon = new System.Windows.Forms.PictureBox();
            this.btn_product_icon_overlay = new System.Windows.Forms.Button();
            this.lbl_product_name = new System.Windows.Forms.TextBox();
            this.lbl_product_quantity = new System.Windows.Forms.TextBox();
            this.btn_coin_icon = new System.Windows.Forms.Button();
            this.lbl_price = new System.Windows.Forms.TextBox();
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_counter = new System.Windows.Forms.Button();
            this.btn_decline = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_customer_pfp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_product_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_customer_pfp
            // 
            this.pb_customer_pfp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_customer_pfp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pb_customer_pfp.Location = new System.Drawing.Point(65, 24);
            this.pb_customer_pfp.Name = "pb_customer_pfp";
            this.pb_customer_pfp.Size = new System.Drawing.Size(80, 80);
            this.pb_customer_pfp.TabIndex = 29;
            this.pb_customer_pfp.TabStop = false;
            // 
            // btn_customer_pfp_overlay
            // 
            this.btn_customer_pfp_overlay.BackgroundImage = global::FieldsOfFortune.Properties.Resources.circle_frame;
            this.btn_customer_pfp_overlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_customer_pfp_overlay.FlatAppearance.BorderSize = 0;
            this.btn_customer_pfp_overlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer_pfp_overlay.Location = new System.Drawing.Point(65, 24);
            this.btn_customer_pfp_overlay.Name = "btn_customer_pfp_overlay";
            this.btn_customer_pfp_overlay.Size = new System.Drawing.Size(80, 80);
            this.btn_customer_pfp_overlay.TabIndex = 30;
            this.btn_customer_pfp_overlay.UseVisualStyleBackColor = true;
            // 
            // lbl_customer_name
            // 
            this.lbl_customer_name.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer_name.Location = new System.Drawing.Point(56, 74);
            this.lbl_customer_name.Name = "lbl_customer_name";
            this.lbl_customer_name.ReadOnly = true;
            this.lbl_customer_name.Size = new System.Drawing.Size(98, 43);
            this.lbl_customer_name.TabIndex = 31;
            this.lbl_customer_name.Text = "Claire";
            this.lbl_customer_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pb_product_icon
            // 
            this.pb_product_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_product_icon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pb_product_icon.Location = new System.Drawing.Point(176, 29);
            this.pb_product_icon.Name = "pb_product_icon";
            this.pb_product_icon.Size = new System.Drawing.Size(80, 80);
            this.pb_product_icon.TabIndex = 32;
            this.pb_product_icon.TabStop = false;
            // 
            // btn_product_icon_overlay
            // 
            this.btn_product_icon_overlay.BackgroundImage = global::FieldsOfFortune.Properties.Resources.circle_frame;
            this.btn_product_icon_overlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_product_icon_overlay.FlatAppearance.BorderSize = 0;
            this.btn_product_icon_overlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product_icon_overlay.Location = new System.Drawing.Point(176, 29);
            this.btn_product_icon_overlay.Name = "btn_product_icon_overlay";
            this.btn_product_icon_overlay.Size = new System.Drawing.Size(80, 80);
            this.btn_product_icon_overlay.TabIndex = 33;
            this.btn_product_icon_overlay.UseVisualStyleBackColor = true;
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_name.Location = new System.Drawing.Point(256, 29);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.ReadOnly = true;
            this.lbl_product_name.Size = new System.Drawing.Size(94, 43);
            this.lbl_product_name.TabIndex = 34;
            this.lbl_product_name.Text = "prod";
            this.lbl_product_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_product_quantity
            // 
            this.lbl_product_quantity.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_quantity.Location = new System.Drawing.Point(256, 61);
            this.lbl_product_quantity.Name = "lbl_product_quantity";
            this.lbl_product_quantity.ReadOnly = true;
            this.lbl_product_quantity.Size = new System.Drawing.Size(60, 37);
            this.lbl_product_quantity.TabIndex = 35;
            this.lbl_product_quantity.Text = "qty";
            this.lbl_product_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_coin_icon
            // 
            this.btn_coin_icon.BackColor = System.Drawing.Color.Transparent;
            this.btn_coin_icon.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Picture2;
            this.btn_coin_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_coin_icon.FlatAppearance.BorderSize = 0;
            this.btn_coin_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_coin_icon.Location = new System.Drawing.Point(368, 40);
            this.btn_coin_icon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_coin_icon.Name = "btn_coin_icon";
            this.btn_coin_icon.Size = new System.Drawing.Size(45, 55);
            this.btn_coin_icon.TabIndex = 36;
            this.btn_coin_icon.UseVisualStyleBackColor = false;
            // 
            // lbl_price
            // 
            this.lbl_price.Font = new System.Drawing.Font("Berlin Sans FB", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(409, 40);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.ReadOnly = true;
            this.lbl_price.Size = new System.Drawing.Size(34, 55);
            this.lbl_price.TabIndex = 37;
            this.lbl_price.Text = "0";
            this.lbl_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_accept
            // 
            this.btn_accept.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Confirm_Button;
            this.btn_accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_accept.FlatAppearance.BorderSize = 0;
            this.btn_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accept.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accept.ForeColor = System.Drawing.Color.White;
            this.btn_accept.Location = new System.Drawing.Point(502, 45);
            this.btn_accept.Margin = new System.Windows.Forms.Padding(2);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_accept.Size = new System.Drawing.Size(120, 50);
            this.btn_accept.TabIndex = 38;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = true;
            // 
            // btn_counter
            // 
            this.btn_counter.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Confirm_Button;
            this.btn_counter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_counter.FlatAppearance.BorderSize = 0;
            this.btn_counter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_counter.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_counter.ForeColor = System.Drawing.Color.White;
            this.btn_counter.Location = new System.Drawing.Point(620, 45);
            this.btn_counter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_counter.Name = "btn_counter";
            this.btn_counter.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_counter.Size = new System.Drawing.Size(120, 50);
            this.btn_counter.TabIndex = 39;
            this.btn_counter.Text = "Counter";
            this.btn_counter.UseVisualStyleBackColor = true;
            // 
            // btn_decline
            // 
            this.btn_decline.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Confirm_Button;
            this.btn_decline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_decline.FlatAppearance.BorderSize = 0;
            this.btn_decline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_decline.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decline.ForeColor = System.Drawing.Color.White;
            this.btn_decline.Location = new System.Drawing.Point(738, 45);
            this.btn_decline.Margin = new System.Windows.Forms.Padding(2);
            this.btn_decline.Name = "btn_decline";
            this.btn_decline.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_decline.Size = new System.Drawing.Size(120, 50);
            this.btn_decline.TabIndex = 40;
            this.btn_decline.Text = "Decline";
            this.btn_decline.UseVisualStyleBackColor = true;
            // 
            // CustomerOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Button_Frame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_decline);
            this.Controls.Add(this.btn_counter);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.btn_coin_icon);
            this.Controls.Add(this.lbl_product_quantity);
            this.Controls.Add(this.lbl_product_name);
            this.Controls.Add(this.pb_product_icon);
            this.Controls.Add(this.lbl_customer_name);
            this.Controls.Add(this.pb_customer_pfp);
            this.Controls.Add(this.btn_customer_pfp_overlay);
            this.Controls.Add(this.btn_product_icon_overlay);
            this.DoubleBuffered = true;
            this.Name = "CustomerOffer";
            this.Size = new System.Drawing.Size(954, 144);
            ((System.ComponentModel.ISupportInitialize)(this.pb_customer_pfp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_product_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pb_customer_pfp;
        public System.Windows.Forms.Button btn_customer_pfp_overlay;
        public System.Windows.Forms.TextBox lbl_customer_name;
        public System.Windows.Forms.PictureBox pb_product_icon;
        public System.Windows.Forms.Button btn_product_icon_overlay;
        public System.Windows.Forms.TextBox lbl_product_name;
        public System.Windows.Forms.TextBox lbl_product_quantity;
        public System.Windows.Forms.Button btn_coin_icon;
        public System.Windows.Forms.TextBox lbl_price;
        public System.Windows.Forms.Button btn_accept;
        public System.Windows.Forms.Button btn_counter;
        public System.Windows.Forms.Button btn_decline;
    }
}
