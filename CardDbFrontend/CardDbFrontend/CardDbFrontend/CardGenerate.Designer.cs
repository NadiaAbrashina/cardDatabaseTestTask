namespace CardDbFrontend
{
    partial class CardGenerate
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
            this.label1 = new System.Windows.Forms.Label();
            this.cardsSeries = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cardsNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cardActiveTerm = new System.Windows.Forms.ComboBox();
            this.startGenerationButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardsNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cardsSeries, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cardsNumber, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cardActiveTerm, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.startGenerationButton, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42863F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.14295F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42863F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.14295F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42863F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.14295F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28525F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(169, 238);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Серія";
            // 
            // cardsSeries
            // 
            this.cardsSeries.Location = new System.Drawing.Point(3, 30);
            this.cardsSeries.Name = "cardsSeries";
            this.cardsSeries.Size = new System.Drawing.Size(34, 20);
            this.cardsSeries.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кількість";
            // 
            // cardsNumber
            // 
            this.cardsNumber.Location = new System.Drawing.Point(3, 97);
            this.cardsNumber.Name = "cardsNumber";
            this.cardsNumber.Size = new System.Drawing.Size(120, 20);
            this.cardsNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Строк дії";
            // 
            // cardActiveTerm
            // 
            this.cardActiveTerm.FormattingEnabled = true;
            this.cardActiveTerm.Location = new System.Drawing.Point(3, 164);
            this.cardActiveTerm.Name = "cardActiveTerm";
            this.cardActiveTerm.Size = new System.Drawing.Size(121, 21);
            this.cardActiveTerm.TabIndex = 5;
            // 
            // startGenerationButton
            // 
            this.startGenerationButton.Location = new System.Drawing.Point(3, 204);
            this.startGenerationButton.Name = "startGenerationButton";
            this.startGenerationButton.Size = new System.Drawing.Size(75, 23);
            this.startGenerationButton.TabIndex = 6;
            this.startGenerationButton.Text = "Створити";
            this.startGenerationButton.UseVisualStyleBackColor = true;
            this.startGenerationButton.Click += new System.EventHandler(this.startGenerationButton_Click);
            // 
            // CardGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CardGenerate";
            this.Text = "Генерувати картки";
            this.Load += new System.EventHandler(this.CardGenerate_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardsNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cardsSeries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown cardsNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cardActiveTerm;
        private System.Windows.Forms.Button startGenerationButton;
    }
}