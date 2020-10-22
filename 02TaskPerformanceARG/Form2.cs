using System;
using System.Collections;
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
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }
       
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }


        private void CashierWindowQueue_Load(object sender, EventArgs e){
            DisplayCashierQueue(CashierClass.CashierQueue);
            timer1.Stop();
        }
        private void btnRefresh_Click(object sender, EventArgs e){
            DisplayCashierQueue(CashierClass.CashierQueue);
            timer1.Stop();
        }
        private void btnNext_Click(object sender, EventArgs e){
            timer1.Start();
        }
        public int _TimerCount;
        private void timer1_Tick_1(object sender, EventArgs e){
            try{
                _TimerCount++;
                lblWaitingTime.Text = _TimerCount.ToString();
                if (_TimerCount == 13){
                    timer1.Stop();
                    _TimerCount = 0;
                    CustomerView frame3 = new CustomerView();
                    frame3.ShowDialog();
                    DisplayCashierQueue(CashierClass.CashierQueue.Dequeue());
                    DisplayCashierQueue(CashierClass.CashierQueue);
                }
            }
            catch (System.InvalidOperationException){
                this.Close();
            }
        }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}