using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace banking
{
    public partial class ViewTransactionForm : Form
    {
        public ViewTransactionForm()
        {
            InitializeComponent();
        }

        private void ViewTransactionForm_Load(object sender, EventArgs e)
        {
            LoadTransactionHistory();
        }

        private void LoadTransactionHistory()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=banking;Integrated Security=True;";
            string query = @"
                SELECT 
                    t.TransactionID, 
                    u1.Username AS SenderUsername, 
                    u2.Username AS ReceiverUsername, 
                    t.Amount, 
                    t.TransactionDate 
                FROM 
                    Transactions t
                INNER JOIN 
                    Users u1 ON t.SenderID = u1.UserId
                INNER JOIN 
                    Users u2 ON t.ReceiverID = u2.UserId
                ORDER BY 
                    t.TransactionDate DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewTransactions.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnExportToText_Click(object sender, EventArgs e)
        {
            ExportToText();
        }

        private void ExportToText()
        {
            try
            {
                DataTable dt = (DataTable)dataGridViewTransactions.DataSource;

                if (dt != null && dt.Rows.Count > 0)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Text file|*.txt",
                        Title = "Save a Text File"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            foreach (DataColumn column in dt.Columns)
                            {
                                writer.Write(column.ColumnName + "\t");
                            }
                            writer.WriteLine();

                            foreach (DataRow row in dt.Rows)
                            {
                                foreach (object cell in row.ItemArray)
                                {
                                    writer.Write(cell.ToString() + "\t");
                                }
                                writer.WriteLine();
                            }
                        }

                        MessageBox.Show("Report exported successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("No transactions available to export.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
