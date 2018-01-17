namespace ProgettoGIA.Presenter
{
    partial class AtletiUserControl
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
            this._atletiGridView = new System.Windows.Forms.DataGridView();
            this._panelAtleti = new System.Windows.Forms.Panel();
            this._editAtletaButton = new System.Windows.Forms.Button();
            this._removeAtletaButton = new System.Windows.Forms.Button();
            this._addAtletaButton = new System.Windows.Forms.Button();
            this._nomeTextBox = new System.Windows.Forms.TextBox();
            this._cognomeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._codiceFiscaleTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this._istruttoreCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._atletiGridView)).BeginInit();
            this._panelAtleti.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.75F));
            this.tableLayoutPanel1.Controls.Add(this._atletiGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._panelAtleti, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _atletiGridView
            // 
            this._atletiGridView.AllowUserToAddRows = false;
            this._atletiGridView.AllowUserToDeleteRows = false;
            this._atletiGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._atletiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._atletiGridView.Location = new System.Drawing.Point(3, 3);
            this._atletiGridView.Name = "_atletiGridView";
            this._atletiGridView.ReadOnly = true;
            this._atletiGridView.Size = new System.Drawing.Size(300, 594);
            this._atletiGridView.TabIndex = 1;
            // 
            // _panelAtleti
            // 
            this._panelAtleti.Controls.Add(this.label10);
            this._panelAtleti.Controls.Add(this.dateTimePicker3);
            this._panelAtleti.Controls.Add(this.label9);
            this._panelAtleti.Controls.Add(this.comboBox2);
            this._panelAtleti.Controls.Add(this.label8);
            this._panelAtleti.Controls.Add(this._istruttoreCheckBox);
            this._panelAtleti.Controls.Add(this.dateTimePicker2);
            this._panelAtleti.Controls.Add(this.label7);
            this._panelAtleti.Controls.Add(this._codiceFiscaleTextBox);
            this._panelAtleti.Controls.Add(this.label2);
            this._panelAtleti.Controls.Add(this.label1);
            this._panelAtleti.Controls.Add(this._cognomeTextBox);
            this._panelAtleti.Controls.Add(this._nomeTextBox);
            this._panelAtleti.Controls.Add(this._editAtletaButton);
            this._panelAtleti.Controls.Add(this._removeAtletaButton);
            this._panelAtleti.Controls.Add(this._addAtletaButton);
            this._panelAtleti.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelAtleti.Location = new System.Drawing.Point(309, 3);
            this._panelAtleti.Name = "_panelAtleti";
            this._panelAtleti.Size = new System.Drawing.Size(488, 594);
            this._panelAtleti.TabIndex = 2;
            // 
            // _editAtletaButton
            // 
            this._editAtletaButton.Location = new System.Drawing.Point(271, 3);
            this._editAtletaButton.Name = "_editAtletaButton";
            this._editAtletaButton.Size = new System.Drawing.Size(128, 30);
            this._editAtletaButton.TabIndex = 9;
            this._editAtletaButton.Text = "Modifica Atleta";
            this._editAtletaButton.UseVisualStyleBackColor = true;
            // 
            // _removeAtletaButton
            // 
            this._removeAtletaButton.Location = new System.Drawing.Point(137, 3);
            this._removeAtletaButton.Name = "_removeAtletaButton";
            this._removeAtletaButton.Size = new System.Drawing.Size(128, 30);
            this._removeAtletaButton.TabIndex = 8;
            this._removeAtletaButton.Text = "Rimuovi Atleta";
            this._removeAtletaButton.UseVisualStyleBackColor = true;
            // 
            // _addAtletaButton
            // 
            this._addAtletaButton.Location = new System.Drawing.Point(3, 3);
            this._addAtletaButton.Name = "_addAtletaButton";
            this._addAtletaButton.Size = new System.Drawing.Size(128, 30);
            this._addAtletaButton.TabIndex = 7;
            this._addAtletaButton.Text = "Aggiungi Atleta";
            this._addAtletaButton.UseVisualStyleBackColor = true;
            // 
            // _nomeTextBox
            // 
            this._nomeTextBox.Location = new System.Drawing.Point(150, 80);
            this._nomeTextBox.Name = "_nomeTextBox";
            this._nomeTextBox.Size = new System.Drawing.Size(290, 20);
            this._nomeTextBox.TabIndex = 10;
            // 
            // _cognomeTextBox
            // 
            this._cognomeTextBox.Location = new System.Drawing.Point(150, 123);
            this._cognomeTextBox.Name = "_cognomeTextBox";
            this._cognomeTextBox.Size = new System.Drawing.Size(290, 20);
            this._cognomeTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cognome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "C.F.";
            // 
            // _codiceFiscaleTextBox
            // 
            this._codiceFiscaleTextBox.Location = new System.Drawing.Point(150, 165);
            this._codiceFiscaleTextBox.Name = "_codiceFiscaleTextBox";
            this._codiceFiscaleTextBox.Size = new System.Drawing.Size(290, 20);
            this._codiceFiscaleTextBox.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(150, 205);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // _istruttoreCheckBox
            // 
            this._istruttoreCheckBox.AutoSize = true;
            this._istruttoreCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._istruttoreCheckBox.Location = new System.Drawing.Point(373, 210);
            this._istruttoreCheckBox.Name = "_istruttoreCheckBox";
            this._istruttoreCheckBox.Size = new System.Drawing.Size(67, 17);
            this._istruttoreCheckBox.TabIndex = 21;
            this._istruttoreCheckBox.Text = "Istruttore";
            this._istruttoreCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Data di Nascita";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(150, 245);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(290, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Società di Appartenenza";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(150, 287);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker3.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Scadenza Certificato";
            // 
            // AtletiUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AtletiUserControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._atletiGridView)).EndInit();
            this._panelAtleti.ResumeLayout(false);
            this._panelAtleti.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView _atletiGridView;
        private System.Windows.Forms.Panel _panelAtleti;
        private System.Windows.Forms.Button _editAtletaButton;
        private System.Windows.Forms.Button _removeAtletaButton;
        private System.Windows.Forms.Button _addAtletaButton;
        private System.Windows.Forms.TextBox _cognomeTextBox;
        private System.Windows.Forms.TextBox _nomeTextBox;
        private System.Windows.Forms.DateTimePicker _dataNascitaTimePicker;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _codiceFiscaleTextBox;
        private System.Windows.Forms.CheckBox _istruttoreCheckBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}
