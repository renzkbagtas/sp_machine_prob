
namespace UI.Forms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.bfrmMain = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlProjects = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlGroups = new Guna.UI2.WinForms.Guna2Panel();
            this.dcTop = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.cbExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlBody = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // bfrmMain
            // 
            this.bfrmMain.BorderRadius = 12;
            this.bfrmMain.ContainerControl = this;
            this.bfrmMain.DockIndicatorTransparencyValue = 0.6D;
            this.bfrmMain.TransparentWhileDrag = true;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.cbExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1280, 50);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlProjects
            // 
            this.pnlProjects.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProjects.Location = new System.Drawing.Point(0, 50);
            this.pnlProjects.Name = "pnlProjects";
            this.pnlProjects.Size = new System.Drawing.Size(124, 850);
            this.pnlProjects.TabIndex = 1;
            // 
            // pnlGroups
            // 
            this.pnlGroups.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGroups.Location = new System.Drawing.Point(124, 50);
            this.pnlGroups.Name = "pnlGroups";
            this.pnlGroups.Size = new System.Drawing.Size(139, 850);
            this.pnlGroups.TabIndex = 2;
            // 
            // dcTop
            // 
            this.dcTop.DockIndicatorTransparencyValue = 0.6D;
            this.dcTop.TargetControl = this.pnlTop;
            this.dcTop.UseTransparentDrag = true;
            // 
            // cbExit
            // 
            this.cbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.cbExit.IconColor = System.Drawing.Color.White;
            this.cbExit.Location = new System.Drawing.Point(1223, 12);
            this.cbExit.Name = "cbExit";
            this.cbExit.Size = new System.Drawing.Size(45, 29);
            this.cbExit.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(263, 50);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1017, 850);
            this.pnlBody.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 900);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlGroups);
            this.Controls.Add(this.pnlProjects);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm bfrmMain;
        private Guna.UI2.WinForms.Guna2Panel pnlGroups;
        private Guna.UI2.WinForms.Guna2Panel pnlProjects;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private Guna.UI2.WinForms.Guna2DragControl dcTop;
        private Guna.UI2.WinForms.Guna2ControlBox cbExit;
        private Guna.UI2.WinForms.Guna2Panel pnlBody;
    }
}