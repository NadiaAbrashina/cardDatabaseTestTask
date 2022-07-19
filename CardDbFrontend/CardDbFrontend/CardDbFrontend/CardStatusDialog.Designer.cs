namespace CardDbFrontend
{
    partial class CardStatusDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.changeStatus = new System.Windows.Forms.Button();
            this.statusSelected = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.changeStatus, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusSelected, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(167, 74);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // changeStatus
            // 
            this.changeStatus.Location = new System.Drawing.Point(3, 40);
            this.changeStatus.Name = "changeStatus";
            this.changeStatus.Size = new System.Drawing.Size(75, 23);
            this.changeStatus.TabIndex = 0;
            this.changeStatus.Text = "ОК";
            this.changeStatus.UseVisualStyleBackColor = true;
            this.changeStatus.Click += new System.EventHandler(this.changeStatus_Click);
            // 
            // statusSelected
            // 
            this.statusSelected.FormattingEnabled = true;
            this.statusSelected.Location = new System.Drawing.Point(3, 3);
            this.statusSelected.Name = "statusSelected";
            this.statusSelected.Size = new System.Drawing.Size(121, 21);
            this.statusSelected.TabIndex = 1;
            // 
            // CardStatusDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 102);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CardStatusDialog";
            this.Text = "Статус";
            this.Load += new System.EventHandler(this.CardStatusDialog_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button changeStatus;
        private System.Windows.Forms.ComboBox statusSelected;
    }
}