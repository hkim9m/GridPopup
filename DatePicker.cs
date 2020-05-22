using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridPopup
{
    public partial class DatePicker : Form
    {

        public DateTime selectedDate;


        public DatePicker()
        {
            InitializeComponent();
        }

        private void DatePicker_Load(object sender, EventArgs e)
        {
            monCalender.SetDate(selectedDate);
        }

        private void monCalender_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate = monCalender.SelectionRange.Start;
            this.Close();
        }
    }
}
