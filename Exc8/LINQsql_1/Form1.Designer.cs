namespace LINQsql_1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addObjbutton = new System.Windows.Forms.Button();
            this.delObjButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrdersCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.updateListViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(145, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(327, 372);
            this.listBox1.TabIndex = 0;
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(12, 39);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(127, 33);
            this.downloadButton.TabIndex = 1;
            this.downloadButton.Text = "Загрузка данных";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 78);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(127, 36);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Очистить список";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addObjbutton
            // 
            this.addObjbutton.Location = new System.Drawing.Point(12, 120);
            this.addObjbutton.Name = "addObjbutton";
            this.addObjbutton.Size = new System.Drawing.Size(127, 39);
            this.addObjbutton.TabIndex = 2;
            this.addObjbutton.Text = "Add object";
            this.addObjbutton.UseVisualStyleBackColor = true;
            this.addObjbutton.Click += new System.EventHandler(this.addObjbutton_Click);
            // 
            // delObjButton
            // 
            this.delObjButton.Location = new System.Drawing.Point(12, 165);
            this.delObjButton.Name = "delObjButton";
            this.delObjButton.Size = new System.Drawing.Size(127, 37);
            this.delObjButton.TabIndex = 2;
            this.delObjButton.Text = "Delete object";
            this.delObjButton.UseVisualStyleBackColor = true;
            this.delObjButton.Click += new System.EventHandler(this.delObjButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerID,
            this.City,
            this.OrdersCount});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(605, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(388, 405);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // CustomerID
            // 
            this.CustomerID.Text = "CustomerID";
            this.CustomerID.Width = 97;
            // 
            // City
            // 
            this.City.Text = "City";
            this.City.Width = 144;
            // 
            // OrdersCount
            // 
            this.OrdersCount.Text = "OrdersCount";
            this.OrdersCount.Width = 143;
            // 
            // updateListViewButton
            // 
            this.updateListViewButton.Location = new System.Drawing.Point(605, 465);
            this.updateListViewButton.Name = "updateListViewButton";
            this.updateListViewButton.Size = new System.Drawing.Size(182, 33);
            this.updateListViewButton.TabIndex = 4;
            this.updateListViewButton.Text = "Orders";
            this.updateListViewButton.UseVisualStyleBackColor = true;
            this.updateListViewButton.Click += new System.EventHandler(this.updateListViewButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 545);
            this.Controls.Add(this.updateListViewButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.delObjButton);
            this.Controls.Add(this.addObjbutton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addObjbutton;
        private System.Windows.Forms.Button delObjButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CustomerID;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader OrdersCount;
        private System.Windows.Forms.Button updateListViewButton;
    }
}

