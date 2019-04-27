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
    public partial class NPCSearch : Form
    {
        String conn_string = "Data Source=mssql.cs.ksu.edu;Initial Catalog=zhengrui;Integrated Security=True";
        String q = "";
        String error_msg = "";
        SqlConnection conn = null;

        public NPCSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            string NPCName = txtNPCName.Text;
            string skill = txtSkill.Text;
            string type = txtType.Text;
            string faction = txtFaction.Text;

            conn.Close();
        }

        private void NPCSearch_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conn_string);
        }
    }
}
