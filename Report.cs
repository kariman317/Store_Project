using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void dateTimePickerTo_CloseUp(object sender, EventArgs e)
        {
            DateTime fromDate = Convert.ToDateTime(dateTimePickerFrom.Text);
            DateTime toDate   = Convert.ToDateTime(dateTimePickerTo.Text);
            if(fromDate <= toDate)
            {
                TimeSpan timeSpan = toDate.Subtract(fromDate);
                int days = Convert.ToInt32(timeSpan.Days);
                lblDisplay.Text = "Report for Date you enter" + fromDate +" " + toDate;
            }
            else
            {
                lblDisplay.Text = "The Date must ....." + fromDate + " " + toDate;
                lblDisplay.ForeColor = Color.Red;
            }
        }
    }
}
