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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 97);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 6;
            label1.Text = "pojemność naczynia w ml";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 157);
            label2.Name = "label2";
            label2.Size = new Size(189, 15);
            label2.TabIndex = 7;
            label2.Text = "zawartość procentowa spirytusu %";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 225);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 8;
            label3.Text = "ilość sztuk naczyń";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 135);
            label4.Name = "label4";
            label4.Size = new Size(145, 15);
            label4.TabIndex = 9;
            label4.Text = "całkowita objętość napoju";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(492, 192);
            label5.Name = "label5";
            label5.Size = new Size(152, 15);
            label5.TabIndex = 10;
            label5.Text = "objętość czystego spirytusu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
