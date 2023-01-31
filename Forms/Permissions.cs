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
    public partial class Permissions : Form
    {
        public Model.DBConnection dbConn;

        private string _labelName;

        public string LabelName
        {
            get { return _labelName; }
            set { _labelName = value; }
        }

        private string _permissionType;

        public string PermissionType
        {
            get { return _permissionType; }
            set { _permissionType = value; }
        }

        public Dictionary<string, int> permissionIdDict = new Dictionary<string, int>();
        const string sPreSQL = "update user_groups_permissions set permission_type = @value1 where id = @id";


        public Permissions()
        {
            InitializeComponent();
        }


        private void Permissions_Load(object sender, EventArgs e)
        {
            lblPermissionName.Text = _labelName;
            cboPermissionType.Text = PermissionType;
        }

        private void cboPermissionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPermissionType.SelectedItem == null)
            {
                cboPermissionType.SelectedIndex = 0;
            }
            else
            {
                int upg_id = permissionIdDict.FirstOrDefault(x => x.Key == lblPermissionName.Text).Value;

                List<string> paramList = new List<string>();
                paramList.Add(string.Format("@id-{0}", upg_id));
                paramList.Add(string.Format("@value1-{0}", cboPermissionType.Text));

                bool bSucess = dbConn.UpdateData(sPreSQL, out string ex, paramList);

                if (!bSucess)
                {
                    // Show the error mesage, ex
                }
            }
        }
    }
}
