using System;
using System.Data;
using System.Windows.Forms;

namespace DBCpnncetion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asyncConnectionDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonProductsCount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.productCountLabel = new System.Windows.Forms.Label();
            this.buttonProductCount2 = new System.Windows.Forms.Button();
            this.listOfProductsBut = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butTransaction = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectDBToolStripMenuItem,
            this.disconnectDBToolStripMenuItem,
            this.asyncConnectionDBToolStripMenuItem,
            this.listOfConnectionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectDBToolStripMenuItem
            // 
            this.connectDBToolStripMenuItem.Name = "connectDBToolStripMenuItem";
            this.connectDBToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.connectDBToolStripMenuItem.Text = "Connect DB";
            this.connectDBToolStripMenuItem.Click += new System.EventHandler(this.connectDBToolStripMenuItem_Click);
            // 
            // disconnectDBToolStripMenuItem
            // 
            this.disconnectDBToolStripMenuItem.Name = "disconnectDBToolStripMenuItem";
            this.disconnectDBToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.disconnectDBToolStripMenuItem.Text = "Disconnect DB";
            this.disconnectDBToolStripMenuItem.Click += new System.EventHandler(this.disconnectDBToolStripMenuItem_Click);
            // 
            // asyncConnectionDBToolStripMenuItem
            // 
            this.asyncConnectionDBToolStripMenuItem.Name = "asyncConnectionDBToolStripMenuItem";
            this.asyncConnectionDBToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.asyncConnectionDBToolStripMenuItem.Text = "Async connection DB";
            this.asyncConnectionDBToolStripMenuItem.Click += new System.EventHandler(this.asyncConnectionDBToolStripMenuItem_Click);
            // 
            // listOfConnectionsToolStripMenuItem
            // 
            this.listOfConnectionsToolStripMenuItem.Name = "listOfConnectionsToolStripMenuItem";
            this.listOfConnectionsToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.listOfConnectionsToolStripMenuItem.Text = "List of connections";
            this.listOfConnectionsToolStripMenuItem.Click += new System.EventHandler(this.listOfConnectionsToolStripMenuItem_Click);
            // 
            // buttonProductsCount
            // 
            this.buttonProductsCount.Location = new System.Drawing.Point(38, 72);
            this.buttonProductsCount.Name = "buttonProductsCount";
            this.buttonProductsCount.Size = new System.Drawing.Size(163, 33);
            this.buttonProductsCount.TabIndex = 1;
            this.buttonProductsCount.Text = "Сколько продуктов?";
            this.buttonProductsCount.UseVisualStyleBackColor = true;
            this.buttonProductsCount.Click += new System.EventHandler(this.buttonProductsCount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // productCountLabel
            // 
            this.productCountLabel.AutoSize = true;
            this.productCountLabel.Location = new System.Drawing.Point(232, 132);
            this.productCountLabel.Name = "productCountLabel";
            this.productCountLabel.Size = new System.Drawing.Size(14, 16);
            this.productCountLabel.TabIndex = 3;
            this.productCountLabel.Text = "0";
            // 
            // buttonProductCount2
            // 
            this.buttonProductCount2.Location = new System.Drawing.Point(38, 119);
            this.buttonProductCount2.Name = "buttonProductCount2";
            this.buttonProductCount2.Size = new System.Drawing.Size(163, 43);
            this.buttonProductCount2.TabIndex = 4;
            this.buttonProductCount2.Text = "Сколько продуктов? (из класса)";
            this.buttonProductCount2.UseVisualStyleBackColor = true;
            this.buttonProductCount2.Click += new System.EventHandler(this.buttonProductCount2_Click);
            // 
            // listOfProductsBut
            // 
            this.listOfProductsBut.Location = new System.Drawing.Point(307, 73);
            this.listOfProductsBut.Name = "listOfProductsBut";
            this.listOfProductsBut.Size = new System.Drawing.Size(101, 60);
            this.listOfProductsBut.TabIndex = 5;
            this.listOfProductsBut.Text = "Список продуктов";
            this.listOfProductsBut.UseVisualStyleBackColor = true;
            this.listOfProductsBut.Click += new System.EventHandler(this.listOfProductsBut_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(414, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(362, 315);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название продукта";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Цена";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Фасовка";
            this.columnHeader3.Width = 218;
            // 
            // butTransaction
            // 
            this.butTransaction.Location = new System.Drawing.Point(38, 238);
            this.butTransaction.Name = "butTransaction";
            this.butTransaction.Size = new System.Drawing.Size(145, 49);
            this.butTransaction.TabIndex = 7;
            this.butTransaction.Text = "Транзакции";
            this.butTransaction.UseVisualStyleBackColor = true;
            this.butTransaction.Click += new System.EventHandler(this.butTransaction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butTransaction);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listOfProductsBut);
            this.Controls.Add(this.buttonProductCount2);
            this.Controls.Add(this.productCountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonProductsCount);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private StateChangeEventHandler newStateChangeEventHandler(ToolStripMenuItem connection_StateChange)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asyncConnectionDBToolStripMenuItem;
        private ToolStripMenuItem listOfConnectionsToolStripMenuItem;
        private Button buttonProductsCount;
        private Label label1;
        private Label productCountLabel;
        private Button buttonProductCount2;
        private Button listOfProductsBut;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button butTransaction;
    }
}

