namespace DataViewExample
{
    partial class MainForm
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
            this.customersGrid = new System.Windows.Forms.DataGridView();
            this.sortTextBox = new System.Windows.Forms.TextBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.setDataViewPropButton = new System.Windows.Forms.Button();
            this.addRowButton = new System.Windows.Forms.Button();
            this.customersTableAdapter1 = new DataViewExample.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.ordersTableAdapter1 = new DataViewExample.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.northwindDataSet1 = new DataViewExample.NorthwindDataSet();
            this.getOrdersButton = new System.Windows.Forms.Button();
            this.ordersGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customersGrid
            // 
            this.customersGrid.ColumnHeadersHeight = 29;
            this.customersGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.customersGrid.Location = new System.Drawing.Point(0, 0);
            this.customersGrid.Name = "customersGrid";
            this.customersGrid.RowHeadersWidth = 51;
            this.customersGrid.RowTemplate.Height = 24;
            this.customersGrid.Size = new System.Drawing.Size(531, 622);
            this.customersGrid.TabIndex = 0;
            this.customersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersGrid_CellContentClick);
            // 
            // sortTextBox
            // 
            this.sortTextBox.Location = new System.Drawing.Point(553, 12);
            this.sortTextBox.Name = "sortTextBox";
            this.sortTextBox.Size = new System.Drawing.Size(131, 22);
            this.sortTextBox.TabIndex = 1;
            this.sortTextBox.Text = "CustomerID";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(553, 40);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(131, 22);
            this.filterTextBox.TabIndex = 2;
            this.filterTextBox.Text = "London";
            // 
            // setDataViewPropButton
            // 
            this.setDataViewPropButton.Location = new System.Drawing.Point(553, 117);
            this.setDataViewPropButton.Name = "setDataViewPropButton";
            this.setDataViewPropButton.Size = new System.Drawing.Size(131, 44);
            this.setDataViewPropButton.TabIndex = 3;
            this.setDataViewPropButton.Text = "Set Data View Properties";
            this.setDataViewPropButton.UseVisualStyleBackColor = true;
            this.setDataViewPropButton.Click += new System.EventHandler(this.setDataViewPropButton_Click);
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new System.Drawing.Point(553, 167);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(131, 39);
            this.addRowButton.TabIndex = 4;
            this.addRowButton.Text = "Add Row";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "NorthwindDataSet";
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getOrdersButton
            // 
            this.getOrdersButton.Location = new System.Drawing.Point(553, 212);
            this.getOrdersButton.Name = "getOrdersButton";
            this.getOrdersButton.Size = new System.Drawing.Size(131, 47);
            this.getOrdersButton.TabIndex = 5;
            this.getOrdersButton.Text = "Get Orders";
            this.getOrdersButton.UseVisualStyleBackColor = true;
            this.getOrdersButton.Click += new System.EventHandler(this.getOrdersButton_Click);
            // 
            // ordersGrid
            // 
            this.ordersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.ordersGrid.Location = new System.Drawing.Point(706, 0);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.RowHeadersWidth = 51;
            this.ordersGrid.RowTemplate.Height = 24;
            this.ordersGrid.Size = new System.Drawing.Size(608, 622);
            this.ordersGrid.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1314, 622);
            this.Controls.Add(this.ordersGrid);
            this.Controls.Add(this.getOrdersButton);
            this.Controls.Add(this.addRowButton);
            this.Controls.Add(this.setDataViewPropButton);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.sortTextBox);
            this.Controls.Add(this.customersGrid);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customersGrid;
        private System.Windows.Forms.TextBox sortTextBox;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button setDataViewPropButton;
        private System.Windows.Forms.Button addRowButton;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private NorthwindDataSet northwindDataSet1;
        private System.Windows.Forms.Button getOrdersButton;
        private System.Windows.Forms.DataGridView ordersGrid;
    }
}

