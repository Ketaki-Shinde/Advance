using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace AdoDotNet1
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
            //step1
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EmpGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "insert into Employee values(@name,@salary)";
            try
            {
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@name",txtName.Text);
                cmd.Parameters.AddWithValue("@salary",Convert.ToDouble(txtSalary.Text));
                conn.Open();
                int result=cmd.ExecuteNonQuery();
                if(result==1)
                {
                    MessageBox.Show("Record Inserted Successfully");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private SqlCommand GetCmd()
        {
            return cmd;
        }

        private void btnSearch_Click(object sender, EventArgs e, SqlCommand cmd)
        {
           
        }
    }
}
