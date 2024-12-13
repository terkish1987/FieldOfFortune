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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_box_frame
            // 
            this.btn_box_frame.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Button_Frame;
            this.btn_box_frame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_box_frame.FlatAppearance.BorderSize = 0;
            this.btn_box_frame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_box_frame.Location = new System.Drawing.Point(0, 0);
            this.btn_box_frame.Name = "btn_box_frame";
            this.btn_box_frame.Size = new System.Drawing.Size(180, 250);
            this.btn_box_frame.TabIndex = 0;
            this.btn_box_frame.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Confirm_Button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(40, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Plant";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PlantProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_box_frame);
            this.Name = "PlantProduct";
            this.Size = new System.Drawing.Size(180, 250);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_box_frame;
        public System.Windows.Forms.Button button1;
    }
}
