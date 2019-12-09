namespace SirketClient
{
    partial class LoginPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müsteriGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurumsalGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mdi_parentForm = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdi_parentForm)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müsteriGirişiToolStripMenuItem,
            this.kurumsalGirişToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müsteriGirişiToolStripMenuItem
            // 
            this.müsteriGirişiToolStripMenuItem.Name = "müsteriGirişiToolStripMenuItem";
            this.müsteriGirişiToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.müsteriGirişiToolStripMenuItem.Text = "Müsteri Girişi";
            this.müsteriGirişiToolStripMenuItem.Click += new System.EventHandler(this.müsteriGirişiToolStripMenuItem_Click);
            // 
            // kurumsalGirişToolStripMenuItem
            // 
            this.kurumsalGirişToolStripMenuItem.Name = "kurumsalGirişToolStripMenuItem";
            this.kurumsalGirişToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.kurumsalGirişToolStripMenuItem.Text = "Kurumsal Giriş";
            this.kurumsalGirişToolStripMenuItem.Click += new System.EventHandler(this.kurumsalGirişToolStripMenuItem_Click);
            // 
            // mdi_parentForm
            // 
            this.mdi_parentForm.MdiParent = this;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(478, 526);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdi_parentForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müsteriGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurumsalGirişToolStripMenuItem;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager mdi_parentForm;
    }
}