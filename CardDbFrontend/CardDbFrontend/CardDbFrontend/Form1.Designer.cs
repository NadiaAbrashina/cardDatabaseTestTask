namespace CardDbFrontend
{
    partial class Index
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
            this.SeeCards = new System.Windows.Forms.Button();
            this.SearchCards = new System.Windows.Forms.Button();
            this.AddCards = new System.Windows.Forms.Button();
            this.SeeLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SeeCards
            // 
            this.SeeCards.Location = new System.Drawing.Point(42, 36);
            this.SeeCards.Name = "SeeCards";
            this.SeeCards.Size = new System.Drawing.Size(130, 23);
            this.SeeCards.TabIndex = 0;
            this.SeeCards.Text = "Переглянути картки";
            this.SeeCards.UseVisualStyleBackColor = true;
            this.SeeCards.Click += new System.EventHandler(this.SeeCards_Click);
            // 
            // SearchCards
            // 
            this.SearchCards.Location = new System.Drawing.Point(42, 66);
            this.SearchCards.Name = "SearchCards";
            this.SearchCards.Size = new System.Drawing.Size(130, 23);
            this.SearchCards.TabIndex = 1;
            this.SearchCards.Text = "Шукати картки";
            this.SearchCards.UseVisualStyleBackColor = true;
            this.SearchCards.Click += new System.EventHandler(this.SearchCards_Click);
            // 
            // AddCards
            // 
            this.AddCards.Location = new System.Drawing.Point(42, 95);
            this.AddCards.Name = "AddCards";
            this.AddCards.Size = new System.Drawing.Size(130, 23);
            this.AddCards.TabIndex = 3;
            this.AddCards.Text = "Створити картки";
            this.AddCards.UseVisualStyleBackColor = true;
            this.AddCards.Click += new System.EventHandler(this.AddCards_Click);
            // 
            // SeeLog
            // 
            this.SeeLog.Location = new System.Drawing.Point(42, 156);
            this.SeeLog.Name = "SeeLog";
            this.SeeLog.Size = new System.Drawing.Size(130, 23);
            this.SeeLog.TabIndex = 4;
            this.SeeLog.Text = "Переглянути лог";
            this.SeeLog.UseVisualStyleBackColor = true;
            this.SeeLog.Click += new System.EventHandler(this.SeeLog_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 220);
            this.Controls.Add(this.SeeLog);
            this.Controls.Add(this.AddCards);
            this.Controls.Add(this.SearchCards);
            this.Controls.Add(this.SeeCards);
            this.Name = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SeeCards;
        private System.Windows.Forms.Button SearchCards;
        private System.Windows.Forms.Button AddCards;
        private System.Windows.Forms.Button SeeLog;
    }
}

