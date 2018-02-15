using POS1.Presenter;
using POS1.View;
using POS1.Cashier;
using System;

using System.Windows.Forms;

namespace POS1
{
    public partial class Form1 : Form, IView
    {
         private MyPresenter presenter = null;

        public Form1()
        {
            presenter = new MyPresenter(this);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            presenter.validateInput(username.Text, password.Text);
        }

        public void onLoginResult(bool result)
        {
            if (result)
            {
             
                MainForm cashier = new MainForm();
                Hide();   
                cashier.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }

        public void onValidateInput(bool isNotEmpty)
        {
            if (isNotEmpty)
            {
                presenter.doLogin();
            }
            else
            {
                MessageBox.Show("Input username or password");
            }
        }

    }
}
