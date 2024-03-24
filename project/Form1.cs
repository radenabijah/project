using System.Data;
using System.Data.OleDb;

namespace project
{
    public partial class Form1 : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= D:\\Downloads\\Project.accdb");
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= D:\\Downloads\\Project.accdb");
            da = new OleDbDataAdapter("SELECT * FROM Income", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Income");
            dgvStudentInfo.DataSource = ds.Tables["Income"];
            myConn.Close();


            if (ds.Tables["Income"].Rows.Count > 0)
            {
                DataGridViewRow firstRow = dgvStudentInfo.Rows[0];
                tbxName.Text = firstRow.Cells["IncName"].Value.ToString();
                tbxCategory.Text = firstRow.Cells["Category"].Value.ToString();
                tbxAmount.Text = firstRow.Cells["Amount"].Value.ToString();


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Income (IncName, Category, Amount) VALUES (@Name, @Category, @Amount)";
                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("@LName", tbxName.Text);
                    cmd.Parameters.AddWithValue("@FName", tbxCategory.Text);
                    cmd.Parameters.AddWithValue("@Course", tbxAmount.Text); // Assuming this is the correct text box for Course

                    myConn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting record: " + ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                    myConn.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (indexRow >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvStudentInfo.Rows[indexRow];
                    string incName = row.Cells["IncName"].Value.ToString();
                    string category = row.Cells["Category"].Value.ToString();
                    string amount = row.Cells["Amount"].Value.ToString();

                    string query = "DELETE FROM Income WHERE IncName = @IncName AND Category = @Category AND Amount = @Amount";
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@IncName", incName);
                        cmd.Parameters.AddWithValue("@Category", category);
                        cmd.Parameters.AddWithValue("@Amount", amount);

                        myConn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message);
                }
                finally
                {
                    if (myConn.State == ConnectionState.Open)
                        myConn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (indexRow >= 0)
                {
                    string query = "UPDATE Income SET IncName = @Name, Category = @Category, Amount = @Amount WHERE IncName = @OriginalName AND Category = @OriginalCategory AND Amount = @OriginalAmount";
                    cmd = new OleDbCommand(query, myConn);
                    cmd.Parameters.AddWithValue("@Name", tbxName.Text);
                    cmd.Parameters.AddWithValue("@Category", tbxCategory.Text);
                    cmd.Parameters.AddWithValue("@Amount", tbxAmount.Text);
                    cmd.Parameters.AddWithValue("@OriginalName", dgvStudentInfo.Rows[indexRow].Cells["IncName"].Value.ToString());
                    cmd.Parameters.AddWithValue("@OriginalCategory", dgvStudentInfo.Rows[indexRow].Cells["Category"].Value.ToString());
                    cmd.Parameters.AddWithValue("@OriginalAmount", dgvStudentInfo.Rows[indexRow].Cells["Amount"].Value.ToString());

                    myConn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    myConn.Close();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Updated Successfully");
                        // Reload the data
                        btnLoad_Click(sender, e);
                    }
                    else
                        MessageBox.Show("No rows were updated.");
                }
                else
                {
                    MessageBox.Show("Please select a record to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dgvStudentInfo.Rows)
            {
                if (!row.IsNewRow)
                {
                    decimal amount = Convert.ToDecimal(row.Cells["Amount"].Value);
                    totalAmount += amount;
                }
            }

            MessageBox.Show($"Total Amount: {totalAmount}");
        }

        private void dgvStudentInfo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvStudentInfo.Rows[indexRow];
            tbxName.Text = row.Cells["IncName"].Value.ToString();
            tbxCategory.Text = row.Cells["Category"].Value.ToString();
            tbxAmount.Text = row.Cells["Amount"].Value.ToString();

        }
    }


}