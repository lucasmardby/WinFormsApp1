namespace WinFormsApp1
{
    partial class MainForm
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
            txtAmount = new TextBox();
            txtRate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnOK = new Button();
            lblResult = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(191, 27);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(143, 23);
            txtAmount.TabIndex = 0;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(191, 66);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(143, 23);
            txtRate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 2;
            label1.Text = "Amount to Convert";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 69);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 3;
            label2.Text = "Exchange Rate";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(122, 109);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(149, 23);
            btnOK.TabIndex = 4;
            btnOK.Text = "Convert";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Location = new Point(191, 154);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(143, 28);
            lblResult.TabIndex = 5;
            lblResult.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 161);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 6;
            label4.Text = "The Converted Amount";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 267);
            Controls.Add(label4);
            Controls.Add(lblResult);
            Controls.Add(btnOK);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRate);
            Controls.Add(txtAmount);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Calculators";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAmount;
        private TextBox txtRate;
        private Label label1;
        private Label label2;
        private Button btnOK;
        private Label lblResult;
        private Label label4;
    }
}
