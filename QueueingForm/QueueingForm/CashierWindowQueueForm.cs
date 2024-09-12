using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace QueueingForm
{
    public partial class CashierWindowQueueForm : Form
    {
        System.Windows.Forms.Timer timer;
        public CashierWindowQueueForm()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = (1 * 1000);  // 1 second interval
            timer.Tick += new EventHandler(timer1_tick);  // Link to the tick event handler
            timer.Start();
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.cashierQueue);  // Auto-refresh the list
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.cashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.cashierQueue.Count > 0)
            {
                CashierClass.cashierQueue.Dequeue();  
                DisplayCashierQueue(CashierClass.cashierQueue);  
            }
        }

        
    }
}
