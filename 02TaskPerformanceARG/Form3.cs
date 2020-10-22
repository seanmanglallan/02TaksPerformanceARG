using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02TaskPerformanceARG
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }

        private void CustomerView_Load(object sender, EventArgs e){
            try{
                lblDisplayQueueNumber.Text = CashierClass.CashierQueue.Peek();
            }
            catch (System.InvalidOperationException){
                MessageBox.Show("Theres nothing in the Queue.", "Message");
                this.Close();
            }
        }

        private void lblDisplayQueueNumber_Click(object sender, EventArgs e)
        {

        }
    }
}

