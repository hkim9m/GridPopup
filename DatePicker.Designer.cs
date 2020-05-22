namespace GridPopup
{
    partial class DatePicker
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
            this.monCalender = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // monCalender
            // 
            this.monCalender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monCalender.Location = new System.Drawing.Point(0, 0);
            this.monCalender.Name = "monCalender";
            this.monCalender.TabIndex = 0;
            this.monCalender.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monCalender_DateSelected);
            // 
            // DatePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 254);
            this.Controls.Add(this.monCalender);
            this.Name = "DatePicker";
            this.Text = "DatePicker";
            this.Load += new System.EventHandler(this.DatePicker_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monCalender;
    }
}