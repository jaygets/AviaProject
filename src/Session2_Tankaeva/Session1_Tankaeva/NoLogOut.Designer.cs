namespace Session1_Tankaeva
{
    partial class NoLogOut
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSoft = new System.Windows.Forms.RadioButton();
            this.rbSystem = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No logout detected on your last login  ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 87);
            this.textBox1.MaxLength = 100;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 127);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reason:";
            // 
            // rbSoft
            // 
            this.rbSoft.AutoSize = true;
            this.rbSoft.Location = new System.Drawing.Point(319, 88);
            this.rbSoft.Name = "rbSoft";
            this.rbSoft.Size = new System.Drawing.Size(137, 24);
            this.rbSoft.TabIndex = 3;
            this.rbSoft.TabStop = true;
            this.rbSoft.Text = "Software Crush";
            this.rbSoft.UseVisualStyleBackColor = true;
            // 
            // rbSystem
            // 
            this.rbSystem.AutoSize = true;
            this.rbSystem.Location = new System.Drawing.Point(319, 118);
            this.rbSystem.Name = "rbSystem";
            this.rbSystem.Size = new System.Drawing.Size(126, 24);
            this.rbSystem.TabIndex = 4;
            this.rbSystem.TabStop = true;
            this.rbSystem.Text = "System Crush";
            this.rbSystem.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(319, 173);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(114, 41);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // NoLogOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 225);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.rbSystem);
            this.Controls.Add(this.rbSoft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NoLogOut";
            this.Text = "No LogOut Detected";
            this.Load += new System.EventHandler(this.NoLogOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSoft;
        private System.Windows.Forms.RadioButton rbSystem;
        private System.Windows.Forms.Button btnConfirm;
    }
}