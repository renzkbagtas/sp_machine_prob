using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class Main : Form
    {
        Model.DBConnection dbConn;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dbConn = new Model.DBConnection(@"Server=.\SQLEXPRESS2019;Database=Sourcepass_MP;User Id=sa;Password=password;");
            if (dbConn.OpenConnection())
            {
                InitProjectButtons();
            }
            else
            {
                MessageBox.Show("Unable to connect!");
                Environment.Exit(0);
            }
        }

        void InitProjectButtons()
        {
            DataTable dtTemp = dbConn.GetDataTable("get_projects", out string ex);
            DataRow drTemp;

            if (ex.Length > 0)
                return;

            for (int i = 0; i < dtTemp.Rows.Count; i++)
            {
                drTemp = dtTemp.Rows[i];

                Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button();
                btn.Name = string.Format("btn{0}", drTemp[1].ToString());
                btn.FillColor = Color.White;
                btn.ForeColor = Color.Black;
                btn.BorderColor = Color.Black;
                btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                btn.BorderThickness = 1;
                btn.Text = drTemp[1].ToString();
                btn.Dock = DockStyle.Top;
                btn.Font = new Font("Segoe UI", 10f);
                btn.Size = new Size(124, 50);
                btn.Click += btnProjects_Click;
                pnlProjects.Controls.Add(btn);
            }
        }

        void btnProjects_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btnSender = sender as Guna.UI2.WinForms.Guna2Button;
            pnlGroups.Controls.Clear();

            List<string> paramList = new List<string>();
            paramList.Add(string.Format("@name-{0}", btnSender.Name.Replace("btn", "")));

            DataTable dtTemp = dbConn.GetDataTable("get_user_group_projects_by_name", out string ex, paramList);
            DataRow drTemp;

            if (ex.Length > 0)
                return;

            for (int i = 0; i < dtTemp.Rows.Count; i++)
            {
                drTemp = dtTemp.Rows[i];

                Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button();
                btn.Name = string.Format("btn{0}", drTemp["name"].ToString());
                btn.FillColor = Color.White;
                btn.ForeColor = Color.Black;
                btn.BorderColor = Color.Black;
                btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                btn.BorderThickness = 1;
                btn.Text = drTemp["name"].ToString();
                btn.Dock = DockStyle.Top;
                btn.Font = new Font("Segoe UI", 10f);
                btn.Size = new Size(124, 50);
                btn.Click += btnGroupsClick;
                pnlGroups.Controls.Add(btn);
            }
        }

        void btnGroupsClick(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btnSender = sender as Guna.UI2.WinForms.Guna2Button;
            pnlBody.Controls.Clear();

            GroupBody frm = new GroupBody();
            frm.dbConn = this.dbConn;
            frm.GroupName = btnSender.Name.Replace("btn", "");
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(frm);
            frm.Show();
        }
    }
}
