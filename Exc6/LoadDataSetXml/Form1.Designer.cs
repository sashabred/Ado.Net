namespace LoadDataSetXml
{
    partial class Form1
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
            this.loadSchemaButton = new System.Windows.Forms.Button();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.customersGrid = new System.Windows.Forms.DataGridView();
            this.ordersGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // loadSchemaButton
            // 
            this.loadSchemaButton.Location = new System.Drawing.Point(66, 378);
            this.loadSchemaButton.Name = "loadSchemaButton";
            this.loadSchemaButton.Size = new System.Drawing.Size(97, 60);
            this.loadSchemaButton.TabIndex = 0;
            this.loadSchemaButton.Text = "Load Schema";
            this.loadSchemaButton.UseVisualStyleBackColor = true;
            this.loadSchemaButton.Click += new System.EventHandler(this.loadSchemaButton_Click);
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(213, 378);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(110, 60);
            this.loadDataButton.TabIndex = 0;
            this.loadDataButton.Text = "Load Data";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // customersGrid
            // 
            this.customersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGrid.Location = new System.Drawing.Point(12, 29);
            this.customersGrid.Name = "customersGrid";
            this.customersGrid.RowHeadersWidth = 51;
            this.customersGrid.RowTemplate.Height = 24;
            this.customersGrid.Size = new System.Drawing.Size(535, 324);
            this.customersGrid.TabIndex = 1;
            // 
            // ordersGrid
            // 
            this.ordersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGrid.Location = new System.Drawing.Point(566, 29);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.RowHeadersWidth = 51;
            this.ordersGrid.RowTemplate.Height = 24;
            this.ordersGrid.Size = new System.Drawing.Size(548, 324);
            this.ordersGrid.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 455);
            this.Controls.Add(this.ordersGrid);
            this.Controls.Add(this.customersGrid);
            this.Controls.Add(this.loadDataButton);
            this.Controls.Add(this.loadSchemaButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadSchemaButton;
        private System.Windows.Forms.Button loadDataButton;
        private System.Windows.Forms.DataGridView customersGrid;
        private System.Windows.Forms.DataGridView ordersGrid;
    }
}

