﻿namespace ProgettoGIA.Presenter
{
    partial class MainForm
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
            this._tabControl = new System.Windows.Forms.TabControl();
            this._atletiTabPage = new System.Windows.Forms.TabPage();
            this._garaTabPage = new System.Windows.Forms.TabPage();
            this._societàTabPage = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._saveDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this._esportaSocietàAtletiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._esportaGaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._tabControl.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tabControl
            // 
            this._tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tabControl.Controls.Add(this._societàTabPage);
            this._tabControl.Controls.Add(this._atletiTabPage);
            this._tabControl.Controls.Add(this._garaTabPage);
            this._tabControl.Location = new System.Drawing.Point(12, 12);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(632, 363);
            this._tabControl.TabIndex = 0;
            // 
            // _atletiTabPage
            // 
            this._atletiTabPage.Location = new System.Drawing.Point(4, 22);
            this._atletiTabPage.Name = "_atletiTabPage";
            this._atletiTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._atletiTabPage.Size = new System.Drawing.Size(624, 337);
            this._atletiTabPage.TabIndex = 1;
            this._atletiTabPage.Text = "Atleti";
            this._atletiTabPage.UseVisualStyleBackColor = true;
            // 
            // _garaTabPage
            // 
            this._garaTabPage.Location = new System.Drawing.Point(4, 22);
            this._garaTabPage.Name = "_garaTabPage";
            this._garaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._garaTabPage.Size = new System.Drawing.Size(624, 337);
            this._garaTabPage.TabIndex = 2;
            this._garaTabPage.Text = "Gara";
            this._garaTabPage.UseVisualStyleBackColor = true;
            // 
            // _societàTabPage
            // 
            this._societàTabPage.Location = new System.Drawing.Point(4, 22);
            this._societàTabPage.Name = "_societàTabPage";
            this._societàTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._societàTabPage.Size = new System.Drawing.Size(624, 337);
            this._societàTabPage.TabIndex = 0;
            this._societàTabPage.Text = "Società";
            this._societàTabPage.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._saveDropDownButton});
            this.statusStrip1.Location = new System.Drawing.Point(0, 415);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(656, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _saveDropDownButton
            // 
            this._saveDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._saveDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._esportaSocietàAtletiToolStripMenuItem,
            this._esportaGaraToolStripMenuItem});
            this._saveDropDownButton.Image = global::ProgettoGIA.Properties.Resources.Save_grey_16x;
            this._saveDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._saveDropDownButton.Name = "_saveDropDownButton";
            this._saveDropDownButton.Size = new System.Drawing.Size(29, 20);
            this._saveDropDownButton.Text = "toolStripDropDownButton1";
            // 
            // _esportaSocietàAtletiToolStripMenuItem
            // 
            this._esportaSocietàAtletiToolStripMenuItem.Image = global::ProgettoGIA.Properties.Resources.Save_16x;
            this._esportaSocietàAtletiToolStripMenuItem.Name = "_esportaSocietàAtletiToolStripMenuItem";
            this._esportaSocietàAtletiToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this._esportaSocietàAtletiToolStripMenuItem.Text = "Esporta Società/Atleti";
            this._esportaSocietàAtletiToolStripMenuItem.Click += new System.EventHandler(this._esportaSocietàAtletiToolStripMenuItem_Click);
            // 
            // _esportaGaraToolStripMenuItem
            // 
            this._esportaGaraToolStripMenuItem.Image = global::ProgettoGIA.Properties.Resources.Save_16x;
            this._esportaGaraToolStripMenuItem.Name = "_esportaGaraToolStripMenuItem";
            this._esportaGaraToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this._esportaGaraToolStripMenuItem.Text = "Esporta Gara";
            this._esportaGaraToolStripMenuItem.Click += new System.EventHandler(this._esportaGaraToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 437);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this._tabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this._tabControl.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _atletiTabPage;
        private System.Windows.Forms.TabPage _garaTabPage;
        private System.Windows.Forms.TabPage _societàTabPage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton _saveDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem _esportaSocietàAtletiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _esportaGaraToolStripMenuItem;
    }
}