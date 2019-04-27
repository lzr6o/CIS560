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

namespace Crusader
{
    public partial class Login : Form
    {
        String conn_string = "Data Source=mssql.cs.ksu.edu;Initial Catalog=zhengrui;Integrated Security=True";
        SqlDataReader dr;
        SqlCommand cmd;
        SqlConnection con;
        String q = "";

        public Login()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                
                con.Open();
                q = "SELECT * FROM Crusader.[User] u WHERE u.UserName = " + txtUsername.Text;
                cmd = new SqlCommand(q, con);
                dr = cmd.ExecuteReader();
                if (dr == null)
                {
                    MessageBox.Show("bad");
                }
                else
                {
                    MessageBox.Show("good");
                    if(dr.Read())
                        MessageBox.Show(dr[1].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conn_string);

        }
    }
}
