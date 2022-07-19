namespace CardDbFrontend
{
    partial class OperationsSearchResult
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
            this.operations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.operations)).BeginInit();
            this.SuspendLayout();
            // 
            // operations
            // 
            this.operations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operations.Location = new System.Drawing.Point(12, 12);
            this.operations.Name = "operations";
            this.operations.Size = new System.Drawing.Size(776, 426);
            this.operations.TabIndex = 0;
            // 
            // OperationsSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.operations);
            this.Name = "OperationsSearchResult";
            this.Text = "Операції по карті";
            this.Load += new System.EventHandler(this.OperationsSearchResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.operations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView operations;
    }
}