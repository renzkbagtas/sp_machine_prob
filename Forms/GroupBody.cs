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
    public partial class GroupBody : Form
    {
        public Model.DBConnection dbConn;

        private string _groupname;

        public string GroupName
        {
            get { return _groupname; }
            set { _groupname = value; }
        }


        public GroupBody()
        {
            InitializeComponent();
        }


        private void GroupBody_Load(object sender, EventArgs e)
        {
            List<string> paramList = new List<string>();
            paramList.Add(string.Format("@name-{0}", _groupname));

            DataTable dtTemp = dbConn.GetDataTable("get_permissions_by_group_name", out string ex, paramList);
            DataRow drTemp;

            if (ex.Length > 0)
                return;

            for (int i = dtTemp.Rows.Count; i > 0; i--)
            {
                drTemp = dtTemp.Rows[i-1];

                Permissions frm = new Permissions();
                frm.dbConn = this.dbConn;
                frm.LabelName = drTemp["name"].ToString();
                frm.PermissionType = drTemp["permission_type"].ToString();
                frm.permissionIdDict.Add(drTemp["name"].ToString(), Convert.ToInt32(drTemp["upg_id"].ToString()));
                frm.TopLevel = false;
                frm.Dock = DockStyle.Top;
                tpPermissions.Controls.Add(frm);
                frm.Show();
            }
        }


    }
}
