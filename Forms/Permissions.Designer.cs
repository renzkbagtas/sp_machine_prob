
namespace UI.Forms
{
    partial class Permissions
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
            this.lblPermissionName = new System.Windows.Forms.Label();
            this.cboPermissionType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // lblPermissionName
            // 
            this.lblPermissionName.AutoSize = true;
            this.lblPermissionName.Location = new System.Drawing.Point(13, 16);
            this.lblPermissionName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPermissionName.Name = "lblPermissionName";
            this.lblPermissionName.Size = new System.Drawing.Size(146, 21);
            this.lblPermissionName.TabIndex = 0;
            this.lblPermissionName.Text = "Delete Team Project";
            // 
            // cboPermissionType
            // 
            this.cboPermissionType.BackColor = System.Drawing.Color.Transparent;
            this.cboPermissionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPermissionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPermissionType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPermissionType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPermissionType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPermissionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboPermissionType.ItemHeight = 30;
            this.cboPermissionType.Items.AddRange(new object[] {
            "Allow",
            "Not Allow",
            "Other",
            "Setting",
            "?"});
            this.cboPermissionType.Location = new System.Drawing.Point(263, 12);
            this.cboPermissionType.Name = "cboPermissionType";
            this.cboPermissionType.Size = new System.Drawing.Size(165, 36);
            this.cboPermissionType.StartIndex = 0;
            this.cboPermissionType.TabIndex = 1;
            this.cboPermissionType.SelectedIndexChanged += new System.EventHandler(this.cboPermissionType_SelectedIndexChanged);
            // 
            // Permissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 59);
            this.Controls.Add(this.cboPermissionType);
            this.Controls.Add(this.lblPermissionName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LabelName = "Permissions";
            this.Text = "Permissions";
            this.Load += new System.EventHandler(this.Permissions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPermissionName;
        private Guna.UI2.WinForms.Guna2ComboBox cboPermissionType;
    }
}