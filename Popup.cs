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
    public partial class Popup : Form
    {
        public Popup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form1.productName = txtProductName.Text;
            Form1.productType = cboProductType.Text;
            Form1.price = txtPrice.Text;
            Form1.productOrigin = txtProductOrigin.Text;
            Form1.arrivalDate = dateArrivalDate.Text;
            Form1.onSale = chkOnsale.Checked;
            this.Close();

        }
    }
}
