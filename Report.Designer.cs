namespace WindowsFormsApp1
{
    partial class Report
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
            this.dateTimePickerFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTimePickerTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Checked = true;
            this.dateTimePickerFrom.CheckedState.Parent = this.dateTimePickerFrom;
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerFrom.HoverState.Parent = this.dateTimePickerFrom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(122, 74);
            this.dateTimePickerFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.ShadowDecoration.Parent = this.dateTimePickerFrom;
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 36);
            this.dateTimePickerFrom.TabIndex = 0;
            this.dateTimePickerFrom.Value = new System.DateTime(2022, 1, 31, 8, 17, 1, 850);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Checked = true;
            this.dateTimePickerTo.CheckedState.Parent = this.dateTimePickerTo;
            this.dateTimePickerTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerTo.HoverState.Parent = this.dateTimePickerTo;
            this.dateTimePickerTo.Location = new System.Drawing.Point(450, 74);
            this.dateTimePickerTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.ShadowDecoration.Parent = this.dateTimePickerTo;
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 36);
            this.dateTimePickerTo.TabIndex = 1;
            this.dateTimePickerTo.Value = new System.DateTime(2022, 1, 31, 8, 17, 1, 850);
            this.dateTimePickerTo.CloseUp += new System.EventHandler(this.dateTimePickerTo_CloseUp);
            // 
            // lblFrom
            // 
            this.lblFrom.AccessibleDescription = "lb";
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblFrom.Location = new System.Drawing.Point(162, 30);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(55, 24);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AccessibleDescription = "lb";
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTo.Location = new System.Drawing.Point(502, 30);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(33, 24);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "To";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AccessibleDescription = "lb";
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblDisplay.ForeColor = System.Drawing.Color.Green;
            this.lblDisplay.Location = new System.Drawing.Point(340, 154);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(75, 24);
            this.lblDisplay.TabIndex = 4;
            this.lblDisplay.Text = "Display";
            this.lblDisplay.Visible = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Name = "Report";
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblDisplay;
    }
}