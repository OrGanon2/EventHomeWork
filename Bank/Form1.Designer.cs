
namespace Bank
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
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.TotalCashBankText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserDetailText = new System.Windows.Forms.ListBox();
            this.UserTotalCashText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ValueCashText = new System.Windows.Forms.NumericUpDown();
            this.DepositButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ValueCashText)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameText
            // 
            this.UserNameText.Location = new System.Drawing.Point(96, 50);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(172, 27);
            this.UserNameText.TabIndex = 0;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(96, 83);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(172, 27);
            this.PasswordText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(96, 27);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(49, 20);
            this.Result.TabIndex = 5;
            this.Result.Text = "Result";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(96, 116);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(172, 29);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // TotalCashBankText
            // 
            this.TotalCashBankText.Location = new System.Drawing.Point(634, 329);
            this.TotalCashBankText.Name = "TotalCashBankText";
            this.TotalCashBankText.Size = new System.Drawing.Size(117, 27);
            this.TotalCashBankText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cash Deposit";
            // 
            // UserDetailText
            // 
            this.UserDetailText.FormattingEnabled = true;
            this.UserDetailText.ItemHeight = 20;
            this.UserDetailText.Location = new System.Drawing.Point(532, 50);
            this.UserDetailText.Name = "UserDetailText";
            this.UserDetailText.Size = new System.Drawing.Size(219, 264);
            this.UserDetailText.TabIndex = 9;
            // 
            // UserTotalCashText
            // 
            this.UserTotalCashText.Location = new System.Drawing.Point(95, 314);
            this.UserTotalCashText.Name = "UserTotalCashText";
            this.UserTotalCashText.Size = new System.Drawing.Size(119, 27);
            this.UserTotalCashText.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Deposit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total Cash";
            // 
            // ValueCashText
            // 
            this.ValueCashText.Location = new System.Drawing.Point(96, 272);
            this.ValueCashText.Name = "ValueCashText";
            this.ValueCashText.Size = new System.Drawing.Size(119, 27);
            this.ValueCashText.TabIndex = 14;
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(95, 347);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(119, 29);
            this.DepositButton.TabIndex = 15;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.ValueCashText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserTotalCashText);
            this.Controls.Add(this.UserDetailText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalCashBankText);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UserNameText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ValueCashText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox TotalCashBankText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox UserDetailText;
        private System.Windows.Forms.TextBox UserTotalCashText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ValueCashText;
        private System.Windows.Forms.Button DepositButton;
    }
}

