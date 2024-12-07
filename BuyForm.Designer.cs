namespace FieldsOfFortune
{
    partial class BuyForm
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
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_coin_icon = new System.Windows.Forms.Button();
            this.btn_form_frame = new System.Windows.Forms.Button();
            this.lbl_price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Confirm_Button;
            this.btn_confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Berlin Sans FB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.Location = new System.Drawing.Point(170, 240);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(160, 90);
            this.btn_confirm.TabIndex = 9;
            this.btn_confirm.Text = "Buy";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Cancel_Button;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(404, 39);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(60, 60);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_coin_icon
            // 
            this.btn_coin_icon.BackColor = System.Drawing.Color.Transparent;
            this.btn_coin_icon.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Picture2;
            this.btn_coin_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_coin_icon.FlatAppearance.BorderSize = 0;
            this.btn_coin_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_coin_icon.Location = new System.Drawing.Point(133, 161);
            this.btn_coin_icon.Name = "btn_coin_icon";
            this.btn_coin_icon.Size = new System.Drawing.Size(43, 45);
            this.btn_coin_icon.TabIndex = 7;
            this.btn_coin_icon.UseVisualStyleBackColor = false;
            // 
            // btn_form_frame
            // 
            this.btn_form_frame.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Form_Frame;
            this.btn_form_frame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_form_frame.FlatAppearance.BorderSize = 0;
            this.btn_form_frame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_form_frame.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_form_frame.ForeColor = System.Drawing.Color.White;
            this.btn_form_frame.Location = new System.Drawing.Point(0, 0);
            this.btn_form_frame.Name = "btn_form_frame";
            this.btn_form_frame.Padding = new System.Windows.Forms.Padding(0, 0, 0, 130);
            this.btn_form_frame.Size = new System.Drawing.Size(500, 370);
            this.btn_form_frame.TabIndex = 0;
            this.btn_form_frame.Text = "Price:\r\n";
            this.btn_form_frame.UseVisualStyleBackColor = true;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.Black;
            this.lbl_price.Location = new System.Drawing.Point(191, 152);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(117, 66);
            this.lbl_price.TabIndex = 10;
            this.lbl_price.Text = "100";
            // 
            // BuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 372);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_coin_icon);
            this.Controls.Add(this.btn_form_frame);
            this.Enabled = false;
            this.Name = "BuyForm";
            this.Text = "BuyForm";
            this.VisibleChanged += new System.EventHandler(this.BuyForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_form_frame;
        private System.Windows.Forms.Button btn_coin_icon;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label lbl_price;
    }
}