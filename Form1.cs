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
    public partial class Form1 : Form
    {

        public static string productName;
        public static string productType;
        public static string price;
        public static string productOrigin;
        public static string arrivalDate;
        public static bool onSale;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            grdProduct.Rows.Add(
                false,
                txtProductName.Text,
                cboProductType.SelectedItem,
                txtProductOrigin.Text,
                dateArrivalDate.Text,
                chkOnsale.Checked,
                txtPrice.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for(int rowIndex = grdProduct.Rows.Count - 1; rowIndex >= 0; rowIndex--)
            {
                if ((bool)grdProduct.Rows[rowIndex].Cells["SELECT"].Value)
                {
                    grdProduct.Rows.RemoveAt(rowIndex);
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (grdProduct.SelectedRows.Count > 0)
            {
                grdProduct.SelectedRows[0].Cells["PRODUCT_NAME"].Value = txtProductName.Text;
                grdProduct.SelectedRows[0].Cells["PRODUCT_TYPE"].Value = cboProductType.SelectedItem;
                grdProduct.SelectedRows[0].Cells["PRICE"].Value = txtPrice.Text;
                grdProduct.SelectedRows[0].Cells["PRODUCT_ORIGIN"].Value = txtProductOrigin.Text;
                grdProduct.SelectedRows[0].Cells["ARRIVAL_DATE"].Value = dateArrivalDate.Text;
            }
        }

        private void btnPopup_Click(object sender, EventArgs e)
        {
            
            Popup pop = new Popup();
            
            pop.ShowDialog();
            grdProduct.Rows.Add(false,
                productName,
                productType,
                productOrigin,
                arrivalDate,
                onSale,
                price);


        }

        private void grdProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = grdProduct.SelectedRows[0].Cells["PRODUCT_NAME"].Value.ToString();
            cboProductType.Text = grdProduct.SelectedRows[0].Cells["PRODUCT_TYPE"].Value.ToString();
            txtPrice.Text = grdProduct.SelectedRows[0].Cells["PRICE"].Value.ToString();
            txtProductOrigin.Text = grdProduct.SelectedRows[0].Cells["PRODUCT_ORIGIN"].Value.ToString();
            dateArrivalDate.Text = grdProduct.SelectedRows[0].Cells["ARRIVAL_DATE"].Value.ToString();
            
            if(e.ColumnIndex == grdProduct.Columns["ARRIVAL_DATE"].Index)
            {
                DatePicker datePopup = new DatePicker();
                DateTime date;
                if (!grdProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].
                    Value.ToString().Equals(string.Empty))
                {
                    date = Convert.ToDateTime(grdProduct.
                        Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                else
                {
                    date = DateTime.Today.Date;
                }
                //date : datepopup 에 전달하기 위한 값
                datePopup.selectedDate = date;
                datePopup.ShowDialog();
                //date : grid 의 Arrival Date 에 넘기기 위한 값
                date = datePopup.selectedDate;
                grdProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value 
                    = date.Date.ToString("yyyy-MM-dd");
                //DateTime 타입을 Data 타입으로
                datePopup.Dispose();
            }
        }

        private void grdProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Popup pop = new Popup();
            pop.txtProductName.Text = grdProduct.Rows[e.RowIndex].
                Cells["PRODUCT_NAME"].Value.ToString();
            pop.cboProductType.Text = grdProduct.Rows[e.RowIndex].
                Cells["PRODUCT_TYPE"].Value.ToString();
            pop.txtPrice.Text = grdProduct.Rows[e.RowIndex].
                Cells["PRICE"].Value.ToString();
            pop.txtProductOrigin.Text = grdProduct.Rows[e.RowIndex].
                Cells["PRODUCT_ORIGIN"].Value.ToString();
            pop.dateArrivalDate.Text = grdProduct.Rows[e.RowIndex].
                Cells["ARRIVAL_DATE"].Value.ToString();

            pop.ShowDialog();

            grdProduct.SelectedRows[0].Cells["PRODUCT_NAME"].Value = productName;
            grdProduct.SelectedRows[0].Cells["PRODUCT_TYPE"].Value = productType;
            grdProduct.SelectedRows[0].Cells["PRICE"].Value = price;
            grdProduct.SelectedRows[0].Cells["PRODUCT_ORIGIN"].Value = productOrigin;
            grdProduct.SelectedRows[0].Cells["ARRIVAL_DATE"].Value = arrivalDate;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboProductType.SelectedIndex = 0;
        }

        private void chkOnsale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
