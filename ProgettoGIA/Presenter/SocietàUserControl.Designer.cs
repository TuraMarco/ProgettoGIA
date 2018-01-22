namespace ProgettoGIA.Presenter
{
    partial class SocietàUserControl
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._societàGridView = new System.Windows.Forms.DataGridView();
            this._panelSocietà = new System.Windows.Forms.Panel();
            this._clearButton = new System.Windows.Forms.Button();
            this._editSocietàButton = new System.Windows.Forms.Button();
            this._removeSocietàButton = new System.Windows.Forms.Button();
            this._addSocietàButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._sedeSocietàTextBox = new System.Windows.Forms.TextBox();
            this._nomeSocietàTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._societàGridView)).BeginInit();
            this._panelSocietà.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 494F));
            this.tableLayoutPanel1.Controls.Add(this._societàGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._panelSocietà, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.6F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _societàGridView
            // 
            this._societàGridView.AllowUserToAddRows = false;
            this._societàGridView.AllowUserToDeleteRows = false;
            this._societàGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._societàGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._societàGridView.Location = new System.Drawing.Point(3, 3);
            this._societàGridView.Name = "_societàGridView";
            this._societàGridView.ReadOnly = true;
            this._societàGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._societàGridView.Size = new System.Drawing.Size(300, 594);
            this._societàGridView.TabIndex = 0;
            this._societàGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._societàGridView_CellClick);
            // 
            // _panelSocietà
            // 
            this._panelSocietà.Controls.Add(this._clearButton);
            this._panelSocietà.Controls.Add(this._editSocietàButton);
            this._panelSocietà.Controls.Add(this._removeSocietàButton);
            this._panelSocietà.Controls.Add(this._addSocietàButton);
            this._panelSocietà.Controls.Add(this.label2);
            this._panelSocietà.Controls.Add(this.label1);
            this._panelSocietà.Controls.Add(this._sedeSocietàTextBox);
            this._panelSocietà.Controls.Add(this._nomeSocietàTextBox);
            this._panelSocietà.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelSocietà.Location = new System.Drawing.Point(309, 3);
            this._panelSocietà.Name = "_panelSocietà";
            this._panelSocietà.Size = new System.Drawing.Size(488, 594);
            this._panelSocietà.TabIndex = 1;
            // 
            // _clearButton
            // 
            this._clearButton.Image = global::ProgettoGIA.Properties.Resources.ClearWindowContent_16x;
            this._clearButton.Location = new System.Drawing.Point(455, 3);
            this._clearButton.Name = "_clearButton";
            this._clearButton.Size = new System.Drawing.Size(30, 30);
            this._clearButton.TabIndex = 32;
            this._clearButton.UseVisualStyleBackColor = true;
            this._clearButton.Click += new System.EventHandler(this._clearButton_Click);
            // 
            // _editSocietàButton
            // 
            this._editSocietàButton.Location = new System.Drawing.Point(271, 3);
            this._editSocietàButton.Name = "_editSocietàButton";
            this._editSocietàButton.Size = new System.Drawing.Size(128, 30);
            this._editSocietàButton.TabIndex = 6;
            this._editSocietàButton.Text = "Modifica Società";
            this._editSocietàButton.UseVisualStyleBackColor = true;
            this._editSocietàButton.Click += new System.EventHandler(this._editSocietàButton_Click);
            // 
            // _removeSocietàButton
            // 
            this._removeSocietàButton.Location = new System.Drawing.Point(137, 3);
            this._removeSocietàButton.Name = "_removeSocietàButton";
            this._removeSocietàButton.Size = new System.Drawing.Size(128, 30);
            this._removeSocietàButton.TabIndex = 5;
            this._removeSocietàButton.Text = "Rimuovi Società";
            this._removeSocietàButton.UseVisualStyleBackColor = true;
            this._removeSocietàButton.Click += new System.EventHandler(this._removeSocietàButton_Click);
            // 
            // _addSocietàButton
            // 
            this._addSocietàButton.Location = new System.Drawing.Point(3, 3);
            this._addSocietàButton.Name = "_addSocietàButton";
            this._addSocietàButton.Size = new System.Drawing.Size(128, 30);
            this._addSocietàButton.TabIndex = 4;
            this._addSocietàButton.Text = "Aggiungi Società";
            this._addSocietàButton.UseVisualStyleBackColor = true;
            this._addSocietàButton.Click += new System.EventHandler(this._addSocietàButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sede Società";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Società";
            // 
            // _sedeSocietàTextBox
            // 
            this._sedeSocietàTextBox.Location = new System.Drawing.Point(137, 288);
            this._sedeSocietàTextBox.Name = "_sedeSocietàTextBox";
            this._sedeSocietàTextBox.Size = new System.Drawing.Size(290, 20);
            this._sedeSocietàTextBox.TabIndex = 1;
            // 
            // _nomeSocietàTextBox
            // 
            this._nomeSocietàTextBox.Location = new System.Drawing.Point(137, 228);
            this._nomeSocietàTextBox.Name = "_nomeSocietàTextBox";
            this._nomeSocietàTextBox.Size = new System.Drawing.Size(290, 20);
            this._nomeSocietàTextBox.TabIndex = 0;
            // 
            // SocietàUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SocietàUserControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._societàGridView)).EndInit();
            this._panelSocietà.ResumeLayout(false);
            this._panelSocietà.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView _societàGridView;
        private System.Windows.Forms.Panel _panelSocietà;
        private System.Windows.Forms.TextBox _sedeSocietàTextBox;
        private System.Windows.Forms.TextBox _nomeSocietàTextBox;
        private System.Windows.Forms.Button _editSocietàButton;
        private System.Windows.Forms.Button _removeSocietàButton;
        private System.Windows.Forms.Button _addSocietàButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _clearButton;
    }
}
