using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingDataTable
{
    public partial class DataTableForm : Form
    {
        private DataSet _dataSet;
        private BindingSource _bindingSource1;
        private BindingSource _bindingSource2;
        public DataTableForm()
        {
            InitializeComponent();
            MakeDataTables();
        }

        private void makeParentTable()
        {
            DataTable table = new DataTable("ParentTable");
            DataColumn column;
            DataRow row;
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "ID";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ParentItem";
            column.AutoIncrement = false;
            column.Caption = "ParentItem";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            table.Columns.Add("Total", typeof(Double));
            table.Columns.Add("SalesTax", typeof(Double), "Total * 0.13");

            DataColumn[] primaryKeyColumn = new DataColumn[1];
            primaryKeyColumn[0] = table.Columns["ID"];
            table.PrimaryKey = primaryKeyColumn;
            _dataSet = new DataSet();
            _dataSet.Tables.Add(table);

            for (int i = 0; i <= 2; i++)
            {
                row = table.NewRow();
                row["ID"] = i;
                row["ParentItem"] = "ParentItem " + i;
                row["Total"] = 2 * i + 0.5;
                table.Rows.Add(row);
            }
        }
        private void MakeChildTable()
        {
            DataTable table = new DataTable("childTable");
            DataColumn column;
            DataRow row;
            column = new DataColumn();

            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "ChildID";
            column.AutoIncrement = true;
            column.Caption = "ID";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ChildItem";
            column.AutoIncrement = false;
            column.Caption = "ChildItem";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "ParentID";
            column.AutoIncrement = false;
            column.Caption = "ParentID";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            _dataSet.Tables.Add(table);

            for (int i = 0; i <= 4; i++)
            {
                row = table.NewRow();
                row["childID"] = i;
                row["ChildItem"] = "Item " + i;
                row["ParentID"] = 0;
                table.Rows.Add(row);
            }
            for (int i = 0; i <= 4; i++)
            {
                row = table.NewRow();
                row["childID"] = i + 5;
                row["ChildItem"] = "Item " + i;
                row["ParentID"] = 1;
                table.Rows.Add(row);
            }
            for (int i = 0; i <= 4; i++)
            {
                row = table.NewRow();
                row["childID"] = i + 10;
                row["ChildItem"] = "Item " + i;
                row["ParentID"] = 2;
                table.Rows.Add(row);
            }
        }

            private void makeDataRelation()
        {
            DataColumn parentColumn = _dataSet.Tables["ParentTable"].Columns["ID"];
            DataColumn childColumn = _dataSet.Tables["ChildTable"].Columns["ParentID"];
            DataRelation relation = new DataRelation("parent2Child", parentColumn, childColumn);
            _dataSet.Tables["ChildTable"].ParentRelations.Add(relation);
        }

        private void bindToDataGrid()
        {
            _bindingSource1= new BindingSource();
            _bindingSource2= new BindingSource();
            _bindingSource1.DataSource = _dataSet.Tables["ParentTable"];
            _bindingSource2.DataSource = _dataSet.Tables["ChildTable"];
        }
        private void butChildTable_Click(object sender, EventArgs e)
        {
            dataGridViewChild.DataSource = _bindingSource2;
        }

        private void butMainTable_Click(object sender, EventArgs e)
        {
            dataGridViewMain.DataSource = _bindingSource1;
        }

        private void MakeDataTables()
        {
            makeParentTable();
            MakeChildTable();
            makeDataRelation();
            bindToDataGrid();
        }
    }
}
