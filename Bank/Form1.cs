using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int CashCount = 0;
            foreach (var Use in UserManagament.ListOfUsers)
            {
                CashCount += Use.TotalCash;
            }
            TotalCashBankText.Text = CashCount.ToString();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Result.Text = UserManagament.login(UserNameText.Text, PasswordText.Text);

            foreach (var user in UserManagament.ListOfUsers)
            {
                if (user.UserName == UserNameText.Text && user.Password == PasswordText.Text)
                {
                    UserTotalCashText.Text = user.TotalCash.ToString();
                    break;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            foreach (var user in UserManagament.ListOfUsers)
            {
                user.Cash = Convert.ToInt32(ValueCashText.Value);
                user.TotalCash += Convert.ToInt32(ValueCashText.Value);
                UserTotalCashText.Text = user.TotalCash.ToString();
                UserDetailText.Items.Add(user.ToString());
                break;
            }
            int CashCount = 0;
            foreach (var Use in UserManagament.ListOfUsers)
            {
                CashCount += Use.TotalCash;
            }
            TotalCashBankText.Text = CashCount.ToString();
        }
        

    }
}
