namespace CardDbFrontend
{
    partial class Card
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
            this.cardData = new System.Windows.Forms.Panel();
            this.ChangeCard = new System.Windows.Forms.Button();
            this.PerformOperation = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cvv = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cardId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteCard = new System.Windows.Forms.Button();
            this.cardData.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardData
            // 
            this.cardData.Controls.Add(this.deleteCard);
            this.cardData.Controls.Add(this.ChangeCard);
            this.cardData.Controls.Add(this.PerformOperation);
            this.cardData.Controls.Add(this.History);
            this.cardData.Controls.Add(this.status);
            this.cardData.Controls.Add(this.label6);
            this.cardData.Controls.Add(this.count);
            this.cardData.Controls.Add(this.label5);
            this.cardData.Controls.Add(this.cvv);
            this.cardData.Controls.Add(this.label4);
            this.cardData.Controls.Add(this.endDate);
            this.cardData.Controls.Add(this.label3);
            this.cardData.Controls.Add(this.startDate);
            this.cardData.Controls.Add(this.label2);
            this.cardData.Controls.Add(this.cardId);
            this.cardData.Controls.Add(this.label1);
            this.cardData.Location = new System.Drawing.Point(12, 12);
            this.cardData.Name = "cardData";
            this.cardData.Size = new System.Drawing.Size(379, 327);
            this.cardData.TabIndex = 0;
            // 
            // ChangeCard
            // 
            this.ChangeCard.Location = new System.Drawing.Point(179, 162);
            this.ChangeCard.Name = "ChangeCard";
            this.ChangeCard.Size = new System.Drawing.Size(149, 23);
            this.ChangeCard.TabIndex = 14;
            this.ChangeCard.Text = "Змінити статус картки";
            this.ChangeCard.UseVisualStyleBackColor = true;
            this.ChangeCard.Click += new System.EventHandler(this.ChangeCard_Click);
            // 
            // PerformOperation
            // 
            this.PerformOperation.Location = new System.Drawing.Point(179, 123);
            this.PerformOperation.Name = "PerformOperation";
            this.PerformOperation.Size = new System.Drawing.Size(149, 23);
            this.PerformOperation.TabIndex = 13;
            this.PerformOperation.Text = "Здійснити операцію";
            this.PerformOperation.UseVisualStyleBackColor = true;
            this.PerformOperation.Click += new System.EventHandler(this.PerformOperation_Click);
            // 
            // History
            // 
            this.History.Location = new System.Drawing.Point(179, 87);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(149, 23);
            this.History.TabIndex = 12;
            this.History.Text = "Історія операцій по карті";
            this.History.UseVisualStyleBackColor = true;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(21, 299);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(35, 13);
            this.status.TabIndex = 11;
            this.status.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Статус";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(21, 241);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(35, 13);
            this.count.TabIndex = 9;
            this.count.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Грощі на рахунку";
            // 
            // cvv
            // 
            this.cvv.AutoSize = true;
            this.cvv.Location = new System.Drawing.Point(21, 194);
            this.cvv.Name = "cvv";
            this.cvv.Size = new System.Drawing.Size(35, 13);
            this.cvv.TabIndex = 7;
            this.cvv.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CVV код";
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Location = new System.Drawing.Point(21, 145);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(35, 13);
            this.endDate.TabIndex = 5;
            this.endDate.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата закінчення дії";
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Location = new System.Drawing.Point(24, 87);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(35, 13);
            this.startDate.TabIndex = 3;
            this.startDate.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата створення";
            // 
            // cardId
            // 
            this.cardId.AutoSize = true;
            this.cardId.Location = new System.Drawing.Point(22, 34);
            this.cardId.Name = "cardId";
            this.cardId.Size = new System.Drawing.Size(37, 13);
            this.cardId.TabIndex = 1;
            this.cardId.Text = "cardId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер";
            // 
            // deleteCard
            // 
            this.deleteCard.Location = new System.Drawing.Point(179, 231);
            this.deleteCard.Name = "deleteCard";
            this.deleteCard.Size = new System.Drawing.Size(149, 23);
            this.deleteCard.TabIndex = 15;
            this.deleteCard.Text = "Видалити картку";
            this.deleteCard.UseVisualStyleBackColor = true;
            this.deleteCard.Click += new System.EventHandler(this.deleteCard_Click);
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 352);
            this.Controls.Add(this.cardData);
            this.Name = "Card";
            this.Text = "Профіль картки";
            this.Load += new System.EventHandler(this.Card_Load);
            this.cardData.ResumeLayout(false);
            this.cardData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cardData;
        private System.Windows.Forms.Button ChangeCard;
        private System.Windows.Forms.Button PerformOperation;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cvv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label endDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cardId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteCard;
    }
}