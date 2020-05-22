namespace GridPopup
{
    partial class Popup
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
            this.btnSave = new System.Windows.Forms.Button();
            this.chkOnsale = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Arrival Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Product Origin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Product Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 21;
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
            this.cboProductType.Location = new System.Drawing.Point(193, 89);
            this.cboProductType.Name = "cboProductType";
            this.cboProductType.Size = new System.Drawing.Size(201, 26);
            this.cboProductType.TabIndex = 20;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(193, 48);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(201, 28);
            this.txtProductName.TabIndex = 19;
            // 
            // txtProductOrigin
            // 
            this.txtProductOrigin.Location = new System.Drawing.Point(193, 161);
            this.txtProductOrigin.Name = "txtProductOrigin";
            this.txtProductOrigin.Size = new System.Drawing.Size(200, 28);
            this.txtProductOrigin.TabIndex = 18;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(193, 127);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 28);
            this.txtPrice.TabIndex = 17;
            // 
            // dateArrivalDate
            // 
            this.dateArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateArrivalDate.Location = new System.Drawing.Point(193, 195);
            this.dateArrivalDate.Name = "dateArrivalDate";
            this.dateArrivalDate.Size = new System.Drawing.Size(200, 28);
            this.dateArrivalDate.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(124, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 84);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkOnsale
            // 
            this.chkOnsale.AutoSize = true;
            this.chkOnsale.Location = new System.Drawing.Point(161, 257);
            this.chkOnsale.Name = "chkOnsale";
            this.chkOnsale.Size = new System.Drawing.Size(97, 22);
            this.chkOnsale.TabIndex = 27;
            this.chkOnsale.Text = "On Sale";
            this.chkOnsale.UseVisualStyleBackColor = true;
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 461);
            this.Controls.Add(this.chkOnsale);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboProductType);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductOrigin);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.dateArrivalDate);
            this.Name = "Popup";
            this.Text = "Popup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.ComboBox cboProductType;
        public System.Windows.Forms.TextBox txtProductName;
        public System.Windows.Forms.TextBox txtProductOrigin;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.DateTimePicker dateArrivalDate;
        public System.Windows.Forms.CheckBox chkOnsale;
    }
}