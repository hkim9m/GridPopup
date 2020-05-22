namespace GridPopup
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboProductType = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductOrigin = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dateArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnPopup = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grdProduct = new System.Windows.Forms.DataGridView();
            this.SELECT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_TYPE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PRODUCT_ORIGIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARRIVAL_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ON_SALE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkOnsale = new System.Windows.Forms.CheckBox();
            this.PRODUCT_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.chkOnsale);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboProductType);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.txtProductOrigin);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.dateArrivalDate);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnPopup);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 227);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Arrival Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Product Origin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Product Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Product Name :";
            // 
            // cboProductType
            // 
            this.cboProductType.FormattingEnabled = true;
            this.cboProductType.Items.AddRange(new object[] {
            "Vegetable",
            "Meat",
            "Fruit",
            "Drinks",
            "ETC"});
            this.cboProductType.Location = new System.Drawing.Point(176, 85);
            this.cboProductType.Name = "cboProductType";
            this.cboProductType.Size = new System.Drawing.Size(210, 26);
            this.cboProductType.TabIndex = 10;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(176, 44);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(210, 28);
            this.txtProductName.TabIndex = 9;
            // 
            // txtProductOrigin
            // 
            this.txtProductOrigin.Location = new System.Drawing.Point(556, 75);
            this.txtProductOrigin.Name = "txtProductOrigin";
            this.txtProductOrigin.Size = new System.Drawing.Size(200, 28);
            this.txtProductOrigin.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(556, 41);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 28);
            this.txtPrice.TabIndex = 5;
            // 
            // dateArrivalDate
            // 
            this.dateArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateArrivalDate.Location = new System.Drawing.Point(556, 109);
            this.dateArrivalDate.Name = "dateArrivalDate";
            this.dateArrivalDate.Size = new System.Drawing.Size(200, 28);
            this.dateArrivalDate.TabIndex = 4;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(1041, 75);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(163, 57);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnPopup
            // 
            this.btnPopup.Location = new System.Drawing.Point(1041, 12);
            this.btnPopup.Name = "btnPopup";
            this.btnPopup.Size = new System.Drawing.Size(163, 57);
            this.btnPopup.TabIndex = 2;
            this.btnPopup.Text = "Popup";
            this.btnPopup.UseVisualStyleBackColor = true;
            this.btnPopup.Click += new System.EventHandler(this.btnPopup_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(872, 75);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 57);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(872, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 57);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grdProduct
            // 
            this.grdProduct.AllowUserToAddRows = false;
            this.grdProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECT,
            this.PRODUCT_NAME,
            this.PRODUCT_TYPE,
            this.PRODUCT_ORIGIN,
            this.ARRIVAL_DATE,
            this.ON_SALE,
            this.PRODUCT_PRICE});
            this.grdProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProduct.Location = new System.Drawing.Point(0, 227);
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.RowHeadersWidth = 62;
            this.grdProduct.RowTemplate.Height = 30;
            this.grdProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProduct.Size = new System.Drawing.Size(1279, 557);
            this.grdProduct.TabIndex = 1;
            this.grdProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProduct_CellClick);
            this.grdProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProduct_CellDoubleClick);
            // 
            // SELECT
            // 
            this.SELECT.HeaderText = "Select";
            this.SELECT.MinimumWidth = 8;
            this.SELECT.Name = "SELECT";
            this.SELECT.Width = 60;
            // 
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.HeaderText = "Product Name";
            this.PRODUCT_NAME.MinimumWidth = 8;
            this.PRODUCT_NAME.Name = "PRODUCT_NAME";
            this.PRODUCT_NAME.Width = 150;
            // 
            // PRODUCT_TYPE
            // 
            this.PRODUCT_TYPE.HeaderText = "Product Type";
            this.PRODUCT_TYPE.Items.AddRange(new object[] {
            "Vegetable",
            "Meat",
            "Fruit",
            "Drinks",
            "ETC"});
            this.PRODUCT_TYPE.MinimumWidth = 8;
            this.PRODUCT_TYPE.Name = "PRODUCT_TYPE";
            this.PRODUCT_TYPE.Width = 150;
            // 
            // PRODUCT_ORIGIN
            // 
            this.PRODUCT_ORIGIN.HeaderText = "Product Origin";
            this.PRODUCT_ORIGIN.MinimumWidth = 8;
            this.PRODUCT_ORIGIN.Name = "PRODUCT_ORIGIN";
            this.PRODUCT_ORIGIN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRODUCT_ORIGIN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PRODUCT_ORIGIN.Width = 150;
            // 
            // ARRIVAL_DATE
            // 
            this.ARRIVAL_DATE.HeaderText = "Arrival Date";
            this.ARRIVAL_DATE.MinimumWidth = 8;
            this.ARRIVAL_DATE.Name = "ARRIVAL_DATE";
            this.ARRIVAL_DATE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ARRIVAL_DATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ARRIVAL_DATE.Width = 150;
            // 
            // ON_SALE
            // 
            this.ON_SALE.HeaderText = "On Sale";
            this.ON_SALE.MinimumWidth = 8;
            this.ON_SALE.Name = "ON_SALE";
            this.ON_SALE.Width = 150;
            // 
            // chkOnsale
            // 
            this.chkOnsale.AutoSize = true;
            this.chkOnsale.Location = new System.Drawing.Point(176, 135);
            this.chkOnsale.Name = "chkOnsale";
            this.chkOnsale.Size = new System.Drawing.Size(97, 22);
            this.chkOnsale.TabIndex = 28;
            this.chkOnsale.Text = "On Sale";
            this.chkOnsale.UseVisualStyleBackColor = true;
            this.chkOnsale.CheckedChanged += new System.EventHandler(this.chkOnsale_CheckedChanged);
            // 
            // PRODUCT_PRICE
            // 
            this.PRODUCT_PRICE.HeaderText = "Price";
            this.PRODUCT_PRICE.MinimumWidth = 8;
            this.PRODUCT_PRICE.Name = "PRODUCT_PRICE";
            this.PRODUCT_PRICE.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 784);
            this.Controls.Add(this.grdProduct);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboProductType;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductOrigin;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dateArrivalDate;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnPopup;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView grdProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewComboBoxColumn PRODUCT_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_ORIGIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARRIVAL_DATE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ON_SALE;
        private System.Windows.Forms.CheckBox chkOnsale;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_PRICE;
    }
}

