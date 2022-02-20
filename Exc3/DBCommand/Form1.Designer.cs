namespace DBCommand
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
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.butQueryParam = new System.Windows.Forms.Button();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.sqlCmdQueryParam = new System.Data.SqlClient.SqlCommand();
            this.butProcedureParam = new System.Windows.Forms.Button();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.OrdYearTextBox = new System.Windows.Forms.TextBox();
            this.sqlCmdProcedure = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=" +
    "True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT CustomerID, CompanyName\r\nFROM     Customers";
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запрос данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(169, 21);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(582, 255);
            this.ResultsTextBox.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "Создание таблицы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.Connection = this.sqlConnection1;
            // 
            // butQueryParam
            // 
            this.butQueryParam.Location = new System.Drawing.Point(27, 277);
            this.butQueryParam.Name = "butQueryParam";
            this.butQueryParam.Size = new System.Drawing.Size(117, 66);
            this.butQueryParam.TabIndex = 3;
            this.butQueryParam.Text = "Запрос с параметром";
            this.butQueryParam.UseVisualStyleBackColor = true;
            this.butQueryParam.Click += new System.EventHandler(this.butQueryParam_Click);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(185, 299);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(240, 22);
            this.CityTextBox.TabIndex = 4;
            this.CityTextBox.Text = "London";
            // 
            // sqlCmdQueryParam
            // 
            this.sqlCmdQueryParam.CommandText = "SELECT CustomerID, CompanyName, City\r\nFROM     Customers\r\nWHERE  (City = @City)";
            this.sqlCmdQueryParam.Connection = this.sqlConnection1;
            this.sqlCmdQueryParam.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City")});
            // 
            // butProcedureParam
            // 
            this.butProcedureParam.Location = new System.Drawing.Point(27, 349);
            this.butProcedureParam.Name = "butProcedureParam";
            this.butProcedureParam.Size = new System.Drawing.Size(117, 55);
            this.butProcedureParam.TabIndex = 5;
            this.butProcedureParam.Text = "Процедура с параметром";
            this.butProcedureParam.UseVisualStyleBackColor = true;
            this.butProcedureParam.Click += new System.EventHandler(this.butProcedureParam_Click);
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(185, 365);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(102, 22);
            this.CategoryNameTextBox.TabIndex = 6;
            this.CategoryNameTextBox.Text = "Beverages";
            // 
            // OrdYearTextBox
            // 
            this.OrdYearTextBox.Location = new System.Drawing.Point(325, 365);
            this.OrdYearTextBox.Name = "OrdYearTextBox";
            this.OrdYearTextBox.Size = new System.Drawing.Size(107, 22);
            this.OrdYearTextBox.TabIndex = 7;
            this.OrdYearTextBox.Text = "1997";
            // 
            // sqlCmdProcedure
            // 
            this.sqlCmdProcedure.CommandText = "SalesByCategory";
            this.sqlCmdProcedure.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdProcedure.Connection = this.sqlConnection1;
            this.sqlCmdProcedure.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15),
            new System.Data.SqlClient.SqlParameter("@OrdYear", System.Data.SqlDbType.NVarChar, 4)});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrdYearTextBox);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.butProcedureParam);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.butQueryParam);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button button2;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.Button butQueryParam;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Data.SqlClient.SqlCommand sqlCmdQueryParam;
        private System.Windows.Forms.Button butProcedureParam;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.TextBox OrdYearTextBox;
        private System.Data.SqlClient.SqlCommand sqlCmdProcedure;
    }
}

