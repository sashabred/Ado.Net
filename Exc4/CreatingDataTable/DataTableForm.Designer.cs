namespace CreatingDataTable
{
    partial class DataTableForm
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
            this.butChildTable = new System.Windows.Forms.Button();
            this.dataGridViewChild = new System.Windows.Forms.DataGridView();
            this.butMainTable = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // butChildTable
            // 
            this.butChildTable.Location = new System.Drawing.Point(127, 13);
            this.butChildTable.Name = "butChildTable";
            this.butChildTable.Size = new System.Drawing.Size(141, 41);
            this.butChildTable.TabIndex = 0;
            this.butChildTable.Text = "Заполнить дочернюю таблицу";
            this.butChildTable.UseVisualStyleBackColor = true;
            this.butChildTable.Click += new System.EventHandler(this.butChildTable_Click);
            // 
            // dataGridViewChild
            // 
            this.dataGridViewChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChild.Location = new System.Drawing.Point(22, 72);
            this.dataGridViewChild.Name = "dataGridViewChild";
            this.dataGridViewChild.RowHeadersWidth = 51;
            this.dataGridViewChild.RowTemplate.Height = 24;
            this.dataGridViewChild.Size = new System.Drawing.Size(360, 366);
            this.dataGridViewChild.TabIndex = 1;
            // 
            // butMainTable
            // 
            this.butMainTable.Location = new System.Drawing.Point(530, 7);
            this.butMainTable.Name = "butMainTable";
            this.butMainTable.Size = new System.Drawing.Size(147, 53);
            this.butMainTable.TabIndex = 2;
            this.butMainTable.Text = "Заполнить основную таблицу";
            this.butMainTable.UseVisualStyleBackColor = true;
            this.butMainTable.Click += new System.EventHandler(this.butMainTable_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(388, 72);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.Size = new System.Drawing.Size(400, 366);
            this.dataGridViewMain.TabIndex = 3;
            // 
            // DataTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.butMainTable);
            this.Controls.Add(this.dataGridViewChild);
            this.Controls.Add(this.butChildTable);
            this.Name = "DataTableForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butChildTable;
        private System.Windows.Forms.DataGridView dataGridViewChild;
        private System.Windows.Forms.Button butMainTable;
        private System.Windows.Forms.DataGridView dataGridViewMain;
    }
}

