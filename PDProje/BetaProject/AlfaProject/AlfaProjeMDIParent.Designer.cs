
namespace AlfaProject
{
    partial class AlfaProjeMDIParent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oranOrantıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üslüSayılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hızProblemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yolProblemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.köklüSayılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mutlakDeğerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oranOrantıToolStripMenuItem,
            this.üslüSayılarToolStripMenuItem,
            this.problemlerToolStripMenuItem,
            this.köklüSayılarToolStripMenuItem,
            this.mutlakDeğerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1272, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oranOrantıToolStripMenuItem
            // 
            this.oranOrantıToolStripMenuItem.Name = "oranOrantıToolStripMenuItem";
            this.oranOrantıToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.oranOrantıToolStripMenuItem.Text = "Oran Orantı";
            this.oranOrantıToolStripMenuItem.Click += new System.EventHandler(this.oranOrantıToolStripMenuItem_Click);
            // 
            // üslüSayılarToolStripMenuItem
            // 
            this.üslüSayılarToolStripMenuItem.Name = "üslüSayılarToolStripMenuItem";
            this.üslüSayılarToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.üslüSayılarToolStripMenuItem.Text = "Üslü Sayılar";
            this.üslüSayılarToolStripMenuItem.Click += new System.EventHandler(this.üslüSayılarToolStripMenuItem_Click);
            // 
            // problemlerToolStripMenuItem
            // 
            this.problemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hızProblemleriToolStripMenuItem,
            this.yolProblemleriToolStripMenuItem});
            this.problemlerToolStripMenuItem.Name = "problemlerToolStripMenuItem";
            this.problemlerToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.problemlerToolStripMenuItem.Text = "Problemler";
            // 
            // hızProblemleriToolStripMenuItem
            // 
            this.hızProblemleriToolStripMenuItem.Name = "hızProblemleriToolStripMenuItem";
            this.hızProblemleriToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.hızProblemleriToolStripMenuItem.Text = "İşçi Problemleri";
            this.hızProblemleriToolStripMenuItem.Click += new System.EventHandler(this.hızProblemleriToolStripMenuItem_Click);
            // 
            // yolProblemleriToolStripMenuItem
            // 
            this.yolProblemleriToolStripMenuItem.Name = "yolProblemleriToolStripMenuItem";
            this.yolProblemleriToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.yolProblemleriToolStripMenuItem.Text = "Hareket Problemleri";
            this.yolProblemleriToolStripMenuItem.Click += new System.EventHandler(this.yolProblemleriToolStripMenuItem_Click);
            // 
            // köklüSayılarToolStripMenuItem
            // 
            this.köklüSayılarToolStripMenuItem.Name = "köklüSayılarToolStripMenuItem";
            this.köklüSayılarToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.köklüSayılarToolStripMenuItem.Text = "Köklü Sayılar";
            this.köklüSayılarToolStripMenuItem.Click += new System.EventHandler(this.köklüSayılarToolStripMenuItem_Click);
            // 
            // mutlakDeğerToolStripMenuItem
            // 
            this.mutlakDeğerToolStripMenuItem.Name = "mutlakDeğerToolStripMenuItem";
            this.mutlakDeğerToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.mutlakDeğerToolStripMenuItem.Text = "Mutlak Değer";
            this.mutlakDeğerToolStripMenuItem.Click += new System.EventHandler(this.mutlakDeğerToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 726);
            this.panel1.TabIndex = 6;
            // 
            // AlfaProjeMDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 754);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlfaProjeMDIParent";
            this.Text = "AlfaProjeMDIParent";
            this.Load += new System.EventHandler(this.AlfaProjeMDIParent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oranOrantıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üslüSayılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hızProblemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yolProblemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem köklüSayılarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem mutlakDeğerToolStripMenuItem;
    }
}



