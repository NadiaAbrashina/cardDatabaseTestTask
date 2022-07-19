namespace CardDbFrontend
{
    partial class PerformOperation
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
            this.Perform = new System.Windows.Forms.Button();
            this.operationType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sumToOperate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.purpous = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumToOperate)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Perform, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.operationType, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sumToOperate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.purpous, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.3442F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.3442F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.3442F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.3479F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.34568F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.92593F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.3479F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(222, 255);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Perform
            // 
            this.Perform.Location = new System.Drawing.Point(3, 224);
            this.Perform.Name = "Perform";
            this.Perform.Size = new System.Drawing.Size(75, 23);
            this.Perform.TabIndex = 6;
            this.Perform.Text = "Виконати";
            this.Perform.UseVisualStyleBackColor = true;
            this.Perform.Click += new System.EventHandler(this.Perform_Click);
            // 
            // operationType
            // 
            this.operationType.FormattingEnabled = true;
            this.operationType.Items.AddRange(new object[] {
            "Додати",
            "Відняти"});
            this.operationType.Location = new System.Drawing.Point(3, 96);
            this.operationType.Name = "operationType";
            this.operationType.Size = new System.Drawing.Size(121, 21);
            this.operationType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип операції";
            // 
            // sumToOperate
            // 
            this.sumToOperate.DecimalPlaces = 2;
            this.sumToOperate.Location = new System.Drawing.Point(3, 34);
            this.sumToOperate.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.sumToOperate.Name = "sumToOperate";
            this.sumToOperate.Size = new System.Drawing.Size(120, 20);
            this.sumToOperate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сума";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Мета";
            // 
            // purpous
            // 
            this.purpous.Location = new System.Drawing.Point(3, 158);
            this.purpous.Name = "purpous";
            this.purpous.Size = new System.Drawing.Size(216, 60);
            this.purpous.TabIndex = 8;
            this.purpous.Text = "";
            // 
            // PerformOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 281);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PerformOperation";
            this.Text = "Виконати операцію";
            this.Load += new System.EventHandler(this.PerformOperation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumToOperate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Perform;
        private System.Windows.Forms.ComboBox operationType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sumToOperate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox purpous;
    }
}