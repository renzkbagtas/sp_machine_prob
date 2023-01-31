
namespace UI.Forms
{
    partial class GroupBody
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
            this.tcBody = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpPermissions = new System.Windows.Forms.TabPage();
            this.tpMembers = new System.Windows.Forms.TabPage();
            this.tpMemberOf = new System.Windows.Forms.TabPage();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tcBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcBody
            // 
            this.tcBody.Controls.Add(this.tpPermissions);
            this.tcBody.Controls.Add(this.tpMembers);
            this.tcBody.Controls.Add(this.tpMemberOf);
            this.tcBody.Controls.Add(this.tpSettings);
            this.tcBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBody.ItemSize = new System.Drawing.Size(180, 40);
            this.tcBody.Location = new System.Drawing.Point(0, 0);
            this.tcBody.Name = "tcBody";
            this.tcBody.SelectedIndex = 0;
            this.tcBody.Size = new System.Drawing.Size(1017, 850);
            this.tcBody.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcBody.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcBody.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcBody.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcBody.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcBody.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcBody.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcBody.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcBody.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcBody.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcBody.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcBody.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcBody.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcBody.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcBody.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcBody.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcBody.TabIndex = 0;
            this.tcBody.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcBody.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpPermissions
            // 
            this.tpPermissions.Location = new System.Drawing.Point(4, 44);
            this.tpPermissions.Name = "tpPermissions";
            this.tpPermissions.Size = new System.Drawing.Size(1009, 802);
            this.tpPermissions.TabIndex = 0;
            this.tpPermissions.Text = "Permissions";
            this.tpPermissions.UseVisualStyleBackColor = true;
            // 
            // tpMembers
            // 
            this.tpMembers.Location = new System.Drawing.Point(4, 44);
            this.tpMembers.Name = "tpMembers";
            this.tpMembers.Size = new System.Drawing.Size(1009, 802);
            this.tpMembers.TabIndex = 1;
            this.tpMembers.Text = "Members";
            this.tpMembers.UseVisualStyleBackColor = true;
            // 
            // tpMemberOf
            // 
            this.tpMemberOf.Location = new System.Drawing.Point(4, 44);
            this.tpMemberOf.Name = "tpMemberOf";
            this.tpMemberOf.Size = new System.Drawing.Size(1009, 802);
            this.tpMemberOf.TabIndex = 2;
            this.tpMemberOf.Text = "Members Of";
            this.tpMemberOf.UseVisualStyleBackColor = true;
            // 
            // tpSettings
            // 
            this.tpSettings.Location = new System.Drawing.Point(4, 44);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(1009, 802);
            this.tpSettings.TabIndex = 3;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // GroupBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 850);
            this.Controls.Add(this.tcBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupBody";
            this.Text = "GroupBody";
            this.Load += new System.EventHandler(this.GroupBody_Load);
            this.tcBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcBody;
        private System.Windows.Forms.TabPage tpPermissions;
        private System.Windows.Forms.TabPage tpMembers;
        private System.Windows.Forms.TabPage tpMemberOf;
        private System.Windows.Forms.TabPage tpSettings;
    }
}