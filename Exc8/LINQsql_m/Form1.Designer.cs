﻿namespace LINQsql_m
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
            this.best10Button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tenMost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // best10Button
            // 
            this.best10Button.Location = new System.Drawing.Point(36, 335);
            this.best10Button.Name = "best10Button";
            this.best10Button.Size = new System.Drawing.Size(198, 44);
            this.best10Button.TabIndex = 0;
            this.best10Button.Text = "10 best";
            this.best10Button.UseVisualStyleBackColor = true;
            this.best10Button.Click += new System.EventHandler(this.best10Button_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tenMost,
            this.unitPrice});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(36, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(491, 308);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tenMost
            // 
            this.tenMost.Text = "Ten Most";
            this.tenMost.Width = 232;
            // 
            // unitPrice
            // 
            this.unitPrice.Text = "Unit Price";
            this.unitPrice.Width = 442;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.best10Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button best10Button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader tenMost;
        private System.Windows.Forms.ColumnHeader unitPrice;
    }
}

