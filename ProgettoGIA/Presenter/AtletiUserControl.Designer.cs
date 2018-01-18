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
            this._clearButton = new System.Windows.Forms.Button();
            this._femminaRadioButton = new System.Windows.Forms.RadioButton();
            this._maschioRadioButton = new System.Windows.Forms.RadioButton();
            this._IscrizioneGaraGroupBox = new System.Windows.Forms.GroupBox();
            this._rimuoviAtletiDallaGaraButton = new System.Windows.Forms.Button();
            this._aggiungiAtletiAllaGaraButton = new System.Windows.Forms.Button();
            this._camCheckBox = new System.Windows.Forms.CheckBox();
            this._cnfCheckBox = new System.Windows.Forms.CheckBox();
            this._cwmCheckBox = new System.Windows.Forms.CheckBox();
            this._fioCheckBox = new System.Windows.Forms.CheckBox();
            this._dymCheckBox = new System.Windows.Forms.CheckBox();
            this._dnfCheckBox = new System.Windows.Forms.CheckBox();
            this._dynCheckBox = new System.Windows.Forms.CheckBox();
            this._cwfCheckBox = new System.Windows.Forms.CheckBox();
            this._staCheckBox = new System.Windows.Forms.CheckBox();
            this._fimCheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this._scadenzaCertificatoTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this._societàComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this._istruttoreCheckBox = new System.Windows.Forms.CheckBox();
            this._dataNascitaTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this._codiceFiscaleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._cognomeTextBox = new System.Windows.Forms.TextBox();
            this._nomeTextBox = new System.Windows.Forms.TextBox();
            this._editAtletaButton = new System.Windows.Forms.Button();
            this._removeAtletaButton = new System.Windows.Forms.Button();
            this._addAtletaButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._atletiGridView)).BeginInit();
            this._panelAtleti.SuspendLayout();
            this._IscrizioneGaraGroupBox.SuspendLayout();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
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
            this._atletiGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._atletiGridView_CellClick);
            // 
            // _panelAtleti
            // 
            this._panelAtleti.Controls.Add(this._clearButton);
            this._panelAtleti.Controls.Add(this._femminaRadioButton);
            this._panelAtleti.Controls.Add(this._maschioRadioButton);
            this._panelAtleti.Controls.Add(this._IscrizioneGaraGroupBox);
            this._panelAtleti.Controls.Add(this.label10);
            this._panelAtleti.Controls.Add(this._scadenzaCertificatoTimePicker);
            this._panelAtleti.Controls.Add(this.label9);
            this._panelAtleti.Controls.Add(this._societàComboBox);
            this._panelAtleti.Controls.Add(this.label8);
            this._panelAtleti.Controls.Add(this._istruttoreCheckBox);
            this._panelAtleti.Controls.Add(this._dataNascitaTimePicker);
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
            // _clearButton
            // 
            this._clearButton.Image = global::ProgettoGIA.Properties.Resources.ClearWindowContent_16x;
            this._clearButton.Location = new System.Drawing.Point(455, 3);
            this._clearButton.Name = "_clearButton";
            this._clearButton.Size = new System.Drawing.Size(30, 30);
            this._clearButton.TabIndex = 31;
            this._clearButton.UseVisualStyleBackColor = true;
            this._clearButton.Click += new System.EventHandler(this._clearButton_Click);
            // 
            // _femminaRadioButton
            // 
            this._femminaRadioButton.AutoSize = true;
            this._femminaRadioButton.Location = new System.Drawing.Point(150, 309);
            this._femminaRadioButton.Name = "_femminaRadioButton";
            this._femminaRadioButton.Size = new System.Drawing.Size(74, 17);
            this._femminaRadioButton.TabIndex = 29;
            this._femminaRadioButton.TabStop = true;
            this._femminaRadioButton.Text = "FEMMINA";
            this._femminaRadioButton.UseVisualStyleBackColor = true;
            // 
            // _maschioRadioButton
            // 
            this._maschioRadioButton.AutoSize = true;
            this._maschioRadioButton.Location = new System.Drawing.Point(150, 286);
            this._maschioRadioButton.Name = "_maschioRadioButton";
            this._maschioRadioButton.Size = new System.Drawing.Size(74, 17);
            this._maschioRadioButton.TabIndex = 28;
            this._maschioRadioButton.TabStop = true;
            this._maschioRadioButton.Text = "MASCHIO";
            this._maschioRadioButton.UseVisualStyleBackColor = true;
            // 
            // _IscrizioneGaraGroupBox
            // 
            this._IscrizioneGaraGroupBox.Controls.Add(this._rimuoviAtletiDallaGaraButton);
            this._IscrizioneGaraGroupBox.Controls.Add(this._aggiungiAtletiAllaGaraButton);
            this._IscrizioneGaraGroupBox.Controls.Add(this._camCheckBox);
            this._IscrizioneGaraGroupBox.Controls.Add(this._cnfCheckBox);
            this._IscrizioneGaraGroupBox.Controls.Add(this._cwmCheckBox);
            this._IscrizioneGaraGroupBox.Controls.Add(this._fioCheckBox);
            this._IscrizioneGaraGroupBox.Controls.Add(this._dymCheckBox);
            this._IscrizioneGaraGroupBox.Controls.Add(this._dnfCheckBox);
            this._IscrizioneGaraGroupBox.Controls.Add(this._dynCheckBox);
            this._IscrizioneGaraGroupBox.Controls.Add(this._cwfCheckBox);
            this._IscrizioneGaraGroupBox.Controls.Add(this._staCheckBox);
            this._IscrizioneGaraGroupBox.Controls.Add(this._fimCheckBox);
            this._IscrizioneGaraGroupBox.Location = new System.Drawing.Point(24, 384);
            this._IscrizioneGaraGroupBox.Name = "_IscrizioneGaraGroupBox";
            this._IscrizioneGaraGroupBox.Size = new System.Drawing.Size(416, 180);
            this._IscrizioneGaraGroupBox.TabIndex = 27;
            this._IscrizioneGaraGroupBox.TabStop = false;
            this._IscrizioneGaraGroupBox.Text = "Iscrizione Atleti alla Gara";
            // 
            // _rimuoviAtletiDallaGaraButton
            // 
            this._rimuoviAtletiDallaGaraButton.Location = new System.Drawing.Point(247, 90);
            this._rimuoviAtletiDallaGaraButton.Name = "_rimuoviAtletiDallaGaraButton";
            this._rimuoviAtletiDallaGaraButton.Size = new System.Drawing.Size(142, 40);
            this._rimuoviAtletiDallaGaraButton.TabIndex = 12;
            this._rimuoviAtletiDallaGaraButton.Text = "Rimuovi Atleta dalla Gara";
            this._rimuoviAtletiDallaGaraButton.UseVisualStyleBackColor = true;
            this._rimuoviAtletiDallaGaraButton.Click += new System.EventHandler(this._rimuoviAtletiDallaGaraButton_Click);
            // 
            // _aggiungiAtletiAllaGaraButton
            // 
            this._aggiungiAtletiAllaGaraButton.Location = new System.Drawing.Point(247, 34);
            this._aggiungiAtletiAllaGaraButton.Name = "_aggiungiAtletiAllaGaraButton";
            this._aggiungiAtletiAllaGaraButton.Size = new System.Drawing.Size(142, 40);
            this._aggiungiAtletiAllaGaraButton.TabIndex = 11;
            this._aggiungiAtletiAllaGaraButton.Text = "Aggiungi Atleta alla Gara";
            this._aggiungiAtletiAllaGaraButton.UseVisualStyleBackColor = true;
            this._aggiungiAtletiAllaGaraButton.Click += new System.EventHandler(this._aggiungiAtletiAllaGaraButton_Click);
            // 
            // _camCheckBox
            // 
            this._camCheckBox.AutoSize = true;
            this._camCheckBox.Location = new System.Drawing.Point(113, 126);
            this._camCheckBox.Name = "_camCheckBox";
            this._camCheckBox.Size = new System.Drawing.Size(49, 17);
            this._camCheckBox.TabIndex = 10;
            this._camCheckBox.Text = "CAM";
            this._camCheckBox.UseVisualStyleBackColor = true;
            // 
            // _cnfCheckBox
            // 
            this._cnfCheckBox.AutoSize = true;
            this._cnfCheckBox.Location = new System.Drawing.Point(113, 80);
            this._cnfCheckBox.Name = "_cnfCheckBox";
            this._cnfCheckBox.Size = new System.Drawing.Size(47, 17);
            this._cnfCheckBox.TabIndex = 9;
            this._cnfCheckBox.Text = "CNF";
            this._cnfCheckBox.UseVisualStyleBackColor = true;
            // 
            // _cwmCheckBox
            // 
            this._cwmCheckBox.AutoSize = true;
            this._cwmCheckBox.Location = new System.Drawing.Point(113, 57);
            this._cwmCheckBox.Name = "_cwmCheckBox";
            this._cwmCheckBox.Size = new System.Drawing.Size(53, 17);
            this._cwmCheckBox.TabIndex = 8;
            this._cwmCheckBox.Text = "CWM";
            this._cwmCheckBox.UseVisualStyleBackColor = true;
            // 
            // _fioCheckBox
            // 
            this._fioCheckBox.AutoSize = true;
            this._fioCheckBox.Location = new System.Drawing.Point(27, 126);
            this._fioCheckBox.Name = "_fioCheckBox";
            this._fioCheckBox.Size = new System.Drawing.Size(43, 17);
            this._fioCheckBox.TabIndex = 7;
            this._fioCheckBox.Text = "FIO";
            this._fioCheckBox.UseVisualStyleBackColor = true;
            // 
            // _dymCheckBox
            // 
            this._dymCheckBox.AutoSize = true;
            this._dymCheckBox.Location = new System.Drawing.Point(27, 80);
            this._dymCheckBox.Name = "_dymCheckBox";
            this._dymCheckBox.Size = new System.Drawing.Size(50, 17);
            this._dymCheckBox.TabIndex = 5;
            this._dymCheckBox.Text = "DYM";
            this._dymCheckBox.UseVisualStyleBackColor = true;
            // 
            // _dnfCheckBox
            // 
            this._dnfCheckBox.AutoSize = true;
            this._dnfCheckBox.Location = new System.Drawing.Point(27, 103);
            this._dnfCheckBox.Name = "_dnfCheckBox";
            this._dnfCheckBox.Size = new System.Drawing.Size(48, 17);
            this._dnfCheckBox.TabIndex = 4;
            this._dnfCheckBox.Text = "DNF";
            this._dnfCheckBox.UseVisualStyleBackColor = true;
            // 
            // _dynCheckBox
            // 
            this._dynCheckBox.AutoSize = true;
            this._dynCheckBox.Location = new System.Drawing.Point(27, 57);
            this._dynCheckBox.Name = "_dynCheckBox";
            this._dynCheckBox.Size = new System.Drawing.Size(49, 17);
            this._dynCheckBox.TabIndex = 3;
            this._dynCheckBox.Text = "DYN";
            this._dynCheckBox.UseVisualStyleBackColor = true;
            // 
            // _cwfCheckBox
            // 
            this._cwfCheckBox.AutoSize = true;
            this._cwfCheckBox.Location = new System.Drawing.Point(113, 34);
            this._cwfCheckBox.Name = "_cwfCheckBox";
            this._cwfCheckBox.Size = new System.Drawing.Size(50, 17);
            this._cwfCheckBox.TabIndex = 2;
            this._cwfCheckBox.Text = "CWF";
            this._cwfCheckBox.UseVisualStyleBackColor = true;
            // 
            // _staCheckBox
            // 
            this._staCheckBox.AutoSize = true;
            this._staCheckBox.Location = new System.Drawing.Point(27, 34);
            this._staCheckBox.Name = "_staCheckBox";
            this._staCheckBox.Size = new System.Drawing.Size(47, 17);
            this._staCheckBox.TabIndex = 1;
            this._staCheckBox.Text = "STA";
            this._staCheckBox.UseVisualStyleBackColor = true;
            // 
            // _fimCheckBox
            // 
            this._fimCheckBox.AutoSize = true;
            this._fimCheckBox.Location = new System.Drawing.Point(113, 103);
            this._fimCheckBox.Name = "_fimCheckBox";
            this._fimCheckBox.Size = new System.Drawing.Size(44, 17);
            this._fimCheckBox.TabIndex = 0;
            this._fimCheckBox.Text = "FIM";
            this._fimCheckBox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Scadenza Certificato";
            // 
            // _scadenzaCertificatoTimePicker
            // 
            this._scadenzaCertificatoTimePicker.Location = new System.Drawing.Point(150, 342);
            this._scadenzaCertificatoTimePicker.Name = "_scadenzaCertificatoTimePicker";
            this._scadenzaCertificatoTimePicker.Size = new System.Drawing.Size(191, 20);
            this._scadenzaCertificatoTimePicker.TabIndex = 25;
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
            // _societàComboBox
            // 
            this._societàComboBox.FormattingEnabled = true;
            this._societàComboBox.Location = new System.Drawing.Point(150, 245);
            this._societàComboBox.Name = "_societàComboBox";
            this._societàComboBox.Size = new System.Drawing.Size(290, 21);
            this._societàComboBox.TabIndex = 23;
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
            // _dataNascitaTimePicker
            // 
            this._dataNascitaTimePicker.Location = new System.Drawing.Point(150, 205);
            this._dataNascitaTimePicker.Name = "_dataNascitaTimePicker";
            this._dataNascitaTimePicker.Size = new System.Drawing.Size(191, 20);
            this._dataNascitaTimePicker.TabIndex = 20;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cognome";
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
            // _cognomeTextBox
            // 
            this._cognomeTextBox.Location = new System.Drawing.Point(150, 123);
            this._cognomeTextBox.Name = "_cognomeTextBox";
            this._cognomeTextBox.Size = new System.Drawing.Size(290, 20);
            this._cognomeTextBox.TabIndex = 11;
            // 
            // _nomeTextBox
            // 
            this._nomeTextBox.Location = new System.Drawing.Point(150, 80);
            this._nomeTextBox.Name = "_nomeTextBox";
            this._nomeTextBox.Size = new System.Drawing.Size(290, 20);
            this._nomeTextBox.TabIndex = 10;
            // 
            // _editAtletaButton
            // 
            this._editAtletaButton.Location = new System.Drawing.Point(271, 3);
            this._editAtletaButton.Name = "_editAtletaButton";
            this._editAtletaButton.Size = new System.Drawing.Size(128, 30);
            this._editAtletaButton.TabIndex = 9;
            this._editAtletaButton.Text = "Modifica Atleta";
            this._editAtletaButton.UseVisualStyleBackColor = true;
            this._editAtletaButton.Click += new System.EventHandler(this._editAtletaButton_Click);
            // 
            // _removeAtletaButton
            // 
            this._removeAtletaButton.Location = new System.Drawing.Point(137, 3);
            this._removeAtletaButton.Name = "_removeAtletaButton";
            this._removeAtletaButton.Size = new System.Drawing.Size(128, 30);
            this._removeAtletaButton.TabIndex = 8;
            this._removeAtletaButton.Text = "Rimuovi Atleta";
            this._removeAtletaButton.UseVisualStyleBackColor = true;
            this._removeAtletaButton.Click += new System.EventHandler(this._removeAtletaButton_Click);
            // 
            // _addAtletaButton
            // 
            this._addAtletaButton.Location = new System.Drawing.Point(3, 3);
            this._addAtletaButton.Name = "_addAtletaButton";
            this._addAtletaButton.Size = new System.Drawing.Size(128, 30);
            this._addAtletaButton.TabIndex = 7;
            this._addAtletaButton.Text = "Aggiungi Atleta";
            this._addAtletaButton.UseVisualStyleBackColor = true;
            this._addAtletaButton.Click += new System.EventHandler(this._addAtletaButton_Click);
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
            this._IscrizioneGaraGroupBox.ResumeLayout(false);
            this._IscrizioneGaraGroupBox.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _codiceFiscaleTextBox;
        private System.Windows.Forms.CheckBox _istruttoreCheckBox;
        private System.Windows.Forms.DateTimePicker _dataNascitaTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox _societàComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker _scadenzaCertificatoTimePicker;
        private System.Windows.Forms.GroupBox _IscrizioneGaraGroupBox;
        private System.Windows.Forms.CheckBox _cnfCheckBox;
        private System.Windows.Forms.CheckBox _cwmCheckBox;
        private System.Windows.Forms.CheckBox _fioCheckBox;
        private System.Windows.Forms.CheckBox _dymCheckBox;
        private System.Windows.Forms.CheckBox _dnfCheckBox;
        private System.Windows.Forms.CheckBox _dynCheckBox;
        private System.Windows.Forms.CheckBox _cwfCheckBox;
        private System.Windows.Forms.CheckBox _staCheckBox;
        private System.Windows.Forms.CheckBox _fimCheckBox;
        private System.Windows.Forms.Button _rimuoviAtletiDallaGaraButton;
        private System.Windows.Forms.Button _aggiungiAtletiAllaGaraButton;
        private System.Windows.Forms.CheckBox _camCheckBox;
        private System.Windows.Forms.RadioButton _femminaRadioButton;
        private System.Windows.Forms.RadioButton _maschioRadioButton;
        private System.Windows.Forms.Button _clearButton;
    }
}
