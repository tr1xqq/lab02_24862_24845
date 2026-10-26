namespace lab02_24862_24845
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRes = new Button();
            txtVolume = new TextBox();
            txtProcent = new TextBox();
            txtQuantity = new TextBox();
            txtVolumeDrink = new TextBox();
            txtVolumeSpirt = new TextBox();
            SuspendLayout();
            // 
            // btnRes
            // 
            btnRes.Location = new Point(351, 175);
            btnRes.Name = "btnRes";
            btnRes.Size = new Size(75, 23);
            btnRes.TabIndex = 0;
            btnRes.Text = "=";
            btnRes.UseVisualStyleBackColor = true;
            btnRes.Click += btnRes_Click;
            // 
            // txtVolume
            // 
            txtVolume.Location = new Point(156, 112);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(123, 23);
            txtVolume.TabIndex = 1;
            // 
            // txtProcent
            // 
            txtProcent.Location = new Point(156, 175);
            txtProcent.Name = "txtProcent";
            txtProcent.Size = new Size(123, 23);
            txtProcent.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(156, 240);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(123, 23);
            txtQuantity.TabIndex = 3;
            // 
            // txtVolumeDrink
            // 
            txtVolumeDrink.Location = new Point(494, 146);
            txtVolumeDrink.Name = "txtVolumeDrink";
            txtVolumeDrink.Size = new Size(108, 23);
            txtVolumeDrink.TabIndex = 4;
            // 
            // txtVolumeSpirt
            // 
            txtVolumeSpirt.Location = new Point(494, 204);
            txtVolumeSpirt.Name = "txtVolumeSpirt";
            txtVolumeSpirt.Size = new Size(108, 23);
            txtVolumeSpirt.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtVolumeSpirt);
            Controls.Add(txtVolumeDrink);
            Controls.Add(txtQuantity);
            Controls.Add(txtProcent);
            Controls.Add(txtVolume);
            Controls.Add(btnRes);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRes;
        private TextBox txtVolume;
        private TextBox txtProcent;
        private TextBox txtQuantity;
        private TextBox txtVolumeDrink;
        private TextBox txtVolumeSpirt;
    }
}
