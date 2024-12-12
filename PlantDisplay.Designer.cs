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
            this.btn_form_frame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_form_frame
            // 
            this.btn_form_frame.BackgroundImage = global::FieldsOfFortune.Properties.Resources.Screenshot_2024_12_12_224404;
            this.btn_form_frame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_form_frame.FlatAppearance.BorderSize = 0;
            this.btn_form_frame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_form_frame.Location = new System.Drawing.Point(0, 0);
            this.btn_form_frame.Name = "btn_form_frame";
            this.btn_form_frame.Size = new System.Drawing.Size(1000, 640);
            this.btn_form_frame.TabIndex = 0;
            this.btn_form_frame.UseVisualStyleBackColor = true;
            // 
            // PlantDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 593);
            this.Controls.Add(this.btn_form_frame);
            this.Name = "PlantDisplay";
            this.Text = "PlantDisplay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_form_frame;
    }
}