namespace ApplicationRecette.Forms
{
    partial class Consultation
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            buttonRechercher = new Button();
            dataGridView1 = new DataGridView();
            buttonExport = new Button();
            buttonImprimer = new Button();
            buttonRetour = new Button();
            buttonPremierePage = new Button();
            buttonPagePrecedente = new Button();
            buttonPageSuivante = new Button();
            buttonDernierePage = new Button();
            labelPage = new Label();
            labelConsultation = new Label();
            comboBoxModesRecherche = new ComboBox();
            labelModeSelection = new Label();
            comboBoxMois = new ComboBox();
            comboBoxAnnee = new ComboBox();
            comboBoxMoisDebut = new ComboBox();
            comboBoxAnneeDebut = new ComboBox();
            labelMoisDebut = new Label();
            labelMoisFin = new Label();
            comboBoxMoisFin = new ComboBox();
            comboBoxAnneeFin = new ComboBox();
            comboBoxAnneeSimple = new ComboBox();
            labelAnneeDebut = new Label();
            labelAnneeFin = new Label();
            comboBoxAnneeDebut2 = new ComboBox();
            comboBoxAnneeFin2 = new ComboBox();
            menuStrip1 = new MenuStrip();
            toolStripComboBox1 = new ToolStripComboBox();
            menuToolStripMenuItem = new ToolStripMenuItem();
            selectionToolStripMenuItem = new ToolStripMenuItem();
            paraToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(401, 76);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 1;
            label1.Text = "Date début :";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(688, 76);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 3;
            label2.Text = "Date fin :";
            label2.Visible = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Font = new Font("Segoe UI", 12F);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(771, 73);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(131, 29);
            dateTimePicker2.TabIndex = 2;
            dateTimePicker2.Visible = false;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            dateTimePicker2.KeyDown += dateTimePicker2_KeyDown;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(510, 73);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(131, 29);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.Visible = false;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker1.KeyDown += dateTimePicker1_KeyUp;
            // 
            // buttonRechercher
            // 
            buttonRechercher.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRechercher.Location = new Point(599, 125);
            buttonRechercher.Margin = new Padding(3, 2, 3, 2);
            buttonRechercher.Name = "buttonRechercher";
            buttonRechercher.Size = new Size(186, 31);
            buttonRechercher.TabIndex = 5;
            buttonRechercher.Text = "Rechercher";
            buttonRechercher.UseVisualStyleBackColor = true;
            buttonRechercher.Click += buttonRechercher_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Green;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 175);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1298, 372);
            dataGridView1.TabIndex = 6;

            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // buttonExport
            // 
            buttonExport.Enabled = false;
            buttonExport.Location = new Point(956, 658);
            buttonExport.Margin = new Padding(3, 2, 3, 2);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(164, 29);
            buttonExport.TabIndex = 7;
            buttonExport.Text = "Exporter vers Excel";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // buttonImprimer
            // 
            buttonImprimer.Enabled = false;
            buttonImprimer.Location = new Point(1139, 658);
            buttonImprimer.Margin = new Padding(3, 2, 3, 2);
            buttonImprimer.Name = "buttonImprimer";
            buttonImprimer.Size = new Size(164, 29);
            buttonImprimer.TabIndex = 8;
            buttonImprimer.Text = "Imprimer";
            buttonImprimer.UseVisualStyleBackColor = true;
            buttonImprimer.Click += buttonImprimer_Click;
            // 
            // buttonRetour
            // 
            buttonRetour.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRetour.Location = new Point(4, 641);
            buttonRetour.Margin = new Padding(3, 2, 3, 2);
            buttonRetour.Name = "buttonRetour";
            buttonRetour.Size = new Size(244, 29);
            buttonRetour.TabIndex = 9;
            buttonRetour.Text = "Retour vers Encodage";
            buttonRetour.UseVisualStyleBackColor = true;
            buttonRetour.Click += buttonRetour_Click;
            // 
            // buttonPremierePage
            // 
            buttonPremierePage.Enabled = false;
            buttonPremierePage.Location = new Point(732, 574);
            buttonPremierePage.Margin = new Padding(3, 2, 3, 2);
            buttonPremierePage.Name = "buttonPremierePage";
            buttonPremierePage.Size = new Size(111, 22);
            buttonPremierePage.TabIndex = 10;
            buttonPremierePage.Text = "Première page";
            buttonPremierePage.UseVisualStyleBackColor = true;
            buttonPremierePage.Click += buttonPremierePage_Click;
            // 
            // buttonPagePrecedente
            // 
            buttonPagePrecedente.Enabled = false;
            buttonPagePrecedente.Location = new Point(862, 574);
            buttonPagePrecedente.Margin = new Padding(3, 2, 3, 2);
            buttonPagePrecedente.Name = "buttonPagePrecedente";
            buttonPagePrecedente.Size = new Size(127, 22);
            buttonPagePrecedente.TabIndex = 11;
            buttonPagePrecedente.Text = "Page précédente";
            buttonPagePrecedente.UseVisualStyleBackColor = true;
            buttonPagePrecedente.Click += buttonPagePrecedente_Click;
            // 
            // buttonPageSuivante
            // 
            buttonPageSuivante.Enabled = false;
            buttonPageSuivante.Location = new Point(1008, 574);
            buttonPageSuivante.Margin = new Padding(3, 2, 3, 2);
            buttonPageSuivante.Name = "buttonPageSuivante";
            buttonPageSuivante.Size = new Size(111, 22);
            buttonPageSuivante.TabIndex = 12;
            buttonPageSuivante.Text = "Page suivante";
            buttonPageSuivante.UseVisualStyleBackColor = true;
            buttonPageSuivante.Click += buttonPageSuivante_Click;
            // 
            // buttonDernierePage
            // 
            buttonDernierePage.Enabled = false;
            buttonDernierePage.Location = new Point(1141, 574);
            buttonDernierePage.Margin = new Padding(3, 2, 3, 2);
            buttonDernierePage.Name = "buttonDernierePage";
            buttonDernierePage.Size = new Size(111, 22);
            buttonDernierePage.TabIndex = 13;
            buttonDernierePage.Text = "Dernière page";
            buttonDernierePage.UseVisualStyleBackColor = true;
            buttonDernierePage.Click += buttonDernierePage_Click;
            // 
            // labelPage
            // 
            labelPage.AutoSize = true;
            labelPage.Location = new Point(643, 577);
            labelPage.Name = "labelPage";
            labelPage.Size = new Size(0, 15);
            labelPage.TabIndex = 14;
            // 
            // labelConsultation
            // 
            labelConsultation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelConsultation.AutoSize = true;
            labelConsultation.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelConsultation.Location = new Point(599, 20);
            labelConsultation.Name = "labelConsultation";
            labelConsultation.Size = new Size(181, 37);
            labelConsultation.TabIndex = 15;
            labelConsultation.Text = "Consultation";
            // 
            // comboBoxModesRecherche
            // 
            comboBoxModesRecherche.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModesRecherche.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxModesRecherche.FormattingEnabled = true;
            comboBoxModesRecherche.Location = new Point(177, 73);
            comboBoxModesRecherche.Name = "comboBoxModesRecherche";
            comboBoxModesRecherche.Size = new Size(138, 29);
            comboBoxModesRecherche.TabIndex = 16;
            comboBoxModesRecherche.SelectedIndexChanged += comboBoxModesRecherche_SelectedIndexChanged;
            // 
            // labelModeSelection
            // 
            labelModeSelection.AutoSize = true;
            labelModeSelection.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelModeSelection.Location = new Point(6, 76);
            labelModeSelection.Name = "labelModeSelection";
            labelModeSelection.Size = new Size(150, 21);
            labelModeSelection.TabIndex = 17;
            labelModeSelection.Text = "Mode de recherche :";
            // 
            // comboBoxMois
            // 
            comboBoxMois.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMois.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxMois.FormattingEnabled = true;
            comboBoxMois.Location = new Point(630, 73);
            comboBoxMois.Name = "comboBoxMois";
            comboBoxMois.Size = new Size(111, 29);
            comboBoxMois.TabIndex = 18;
            comboBoxMois.Visible = false;
            // 
            // comboBoxAnnee
            // 
            comboBoxAnnee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAnnee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAnnee.FormattingEnabled = true;
            comboBoxAnnee.Location = new Point(771, 73);
            comboBoxAnnee.Name = "comboBoxAnnee";
            comboBoxAnnee.Size = new Size(99, 29);
            comboBoxAnnee.TabIndex = 19;
            comboBoxAnnee.Visible = false;
            // 
            // comboBoxMoisDebut
            // 
            comboBoxMoisDebut.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMoisDebut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxMoisDebut.FormattingEnabled = true;
            comboBoxMoisDebut.Location = new Point(510, 73);
            comboBoxMoisDebut.Name = "comboBoxMoisDebut";
            comboBoxMoisDebut.Size = new Size(111, 29);
            comboBoxMoisDebut.TabIndex = 20;
            comboBoxMoisDebut.Visible = false;
            // 
            // comboBoxAnneeDebut
            // 
            comboBoxAnneeDebut.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAnneeDebut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAnneeDebut.FormattingEnabled = true;
            comboBoxAnneeDebut.Location = new Point(627, 73);
            comboBoxAnneeDebut.Name = "comboBoxAnneeDebut";
            comboBoxAnneeDebut.Size = new Size(99, 29);
            comboBoxAnneeDebut.TabIndex = 21;
            comboBoxAnneeDebut.Visible = false;
            // 
            // labelMoisDebut
            // 
            labelMoisDebut.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelMoisDebut.AutoSize = true;
            labelMoisDebut.Font = new Font("Segoe UI", 12F);
            labelMoisDebut.Location = new Point(401, 76);
            labelMoisDebut.Name = "labelMoisDebut";
            labelMoisDebut.Size = new Size(95, 21);
            labelMoisDebut.TabIndex = 22;
            labelMoisDebut.Text = "Mois début :";
            labelMoisDebut.Visible = false;
            // 
            // labelMoisFin
            // 
            labelMoisFin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelMoisFin.AutoSize = true;
            labelMoisFin.Font = new Font("Segoe UI", 12F);
            labelMoisFin.Location = new Point(783, 76);
            labelMoisFin.Name = "labelMoisFin";
            labelMoisFin.Size = new Size(73, 21);
            labelMoisFin.TabIndex = 23;
            labelMoisFin.Text = "Mois fin :";
            labelMoisFin.Visible = false;
            // 
            // comboBoxMoisFin
            // 
            comboBoxMoisFin.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMoisFin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxMoisFin.FormattingEnabled = true;
            comboBoxMoisFin.Location = new Point(862, 73);
            comboBoxMoisFin.Name = "comboBoxMoisFin";
            comboBoxMoisFin.Size = new Size(111, 29);
            comboBoxMoisFin.TabIndex = 24;
            comboBoxMoisFin.Visible = false;
            // 
            // comboBoxAnneeFin
            // 
            comboBoxAnneeFin.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAnneeFin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAnneeFin.FormattingEnabled = true;
            comboBoxAnneeFin.Location = new Point(987, 73);
            comboBoxAnneeFin.Name = "comboBoxAnneeFin";
            comboBoxAnneeFin.Size = new Size(99, 29);
            comboBoxAnneeFin.TabIndex = 25;
            comboBoxAnneeFin.Visible = false;
            // 
            // comboBoxAnneeSimple
            // 
            comboBoxAnneeSimple.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAnneeSimple.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAnneeSimple.FormattingEnabled = true;
            comboBoxAnneeSimple.Location = new Point(599, 73);
            comboBoxAnneeSimple.Name = "comboBoxAnneeSimple";
            comboBoxAnneeSimple.Size = new Size(99, 29);
            comboBoxAnneeSimple.TabIndex = 26;
            comboBoxAnneeSimple.Visible = false;
            // 
            // labelAnneeDebut
            // 
            labelAnneeDebut.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelAnneeDebut.AutoSize = true;
            labelAnneeDebut.Font = new Font("Segoe UI", 12F);
            labelAnneeDebut.Location = new Point(401, 76);
            labelAnneeDebut.Name = "labelAnneeDebut";
            labelAnneeDebut.Size = new Size(105, 21);
            labelAnneeDebut.TabIndex = 27;
            labelAnneeDebut.Text = "Annee début :";
            labelAnneeDebut.Visible = false;
            // 
            // labelAnneeFin
            // 
            labelAnneeFin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelAnneeFin.AutoSize = true;
            labelAnneeFin.Font = new Font("Segoe UI", 12F);
            labelAnneeFin.Location = new Point(640, 76);
            labelAnneeFin.Name = "labelAnneeFin";
            labelAnneeFin.Size = new Size(86, 21);
            labelAnneeFin.TabIndex = 28;
            labelAnneeFin.Text = "Annee Fin :";
            labelAnneeFin.Visible = false;
            // 
            // comboBoxAnneeDebut2
            // 
            comboBoxAnneeDebut2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAnneeDebut2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAnneeDebut2.FormattingEnabled = true;
            comboBoxAnneeDebut2.Location = new Point(522, 73);
            comboBoxAnneeDebut2.Name = "comboBoxAnneeDebut2";
            comboBoxAnneeDebut2.Size = new Size(99, 29);
            comboBoxAnneeDebut2.TabIndex = 29;
            comboBoxAnneeDebut2.Visible = false;
            // 
            // comboBoxAnneeFin2
            // 
            comboBoxAnneeFin2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAnneeFin2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAnneeFin2.FormattingEnabled = true;
            comboBoxAnneeFin2.Location = new Point(732, 73);
            comboBoxAnneeFin2.Name = "comboBoxAnneeFin2";
            comboBoxAnneeFin2.Size = new Size(99, 29);
            comboBoxAnneeFin2.TabIndex = 30;
            comboBoxAnneeFin2.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBox1, menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1313, 27);
            menuStrip1.TabIndex = 31;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(106, 23);
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectionToolStripMenuItem, paraToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 23);
            menuToolStripMenuItem.Text = "menu";
            // 
            // selectionToolStripMenuItem
            // 
            selectionToolStripMenuItem.Name = "selectionToolStripMenuItem";
            selectionToolStripMenuItem.Size = new Size(121, 22);
            selectionToolStripMenuItem.Text = "selection";
            // 
            // paraToolStripMenuItem
            // 
            paraToolStripMenuItem.Name = "paraToolStripMenuItem";
            paraToolStripMenuItem.Size = new Size(121, 22);
            paraToolStripMenuItem.Text = "para";
            // 
            // Consultation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 791);
            Controls.Add(comboBoxAnneeFin2);
            Controls.Add(comboBoxAnneeDebut2);
            Controls.Add(labelAnneeFin);
            Controls.Add(labelAnneeDebut);
            Controls.Add(comboBoxAnneeSimple);
            Controls.Add(comboBoxAnneeFin);
            Controls.Add(comboBoxMoisFin);
            Controls.Add(labelMoisFin);
            Controls.Add(labelMoisDebut);
            Controls.Add(comboBoxAnneeDebut);
            Controls.Add(comboBoxMoisDebut);
            Controls.Add(comboBoxAnnee);
            Controls.Add(comboBoxMois);
            Controls.Add(labelModeSelection);
            Controls.Add(comboBoxModesRecherche);
            Controls.Add(labelConsultation);
            Controls.Add(labelPage);
            Controls.Add(buttonDernierePage);
            Controls.Add(buttonPageSuivante);
            Controls.Add(buttonPagePrecedente);
            Controls.Add(buttonPremierePage);
            Controls.Add(buttonRetour);
            Controls.Add(buttonImprimer);
            Controls.Add(buttonExport);
            Controls.Add(dataGridView1);
            Controls.Add(buttonRechercher);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Consultation";
            Text = "Consultation";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button buttonRechercher;
        private DataGridView dataGridView1;
        private Button buttonExport;
        private Button buttonImprimer;
        private Button buttonRetour;
        private Button buttonPremierePage;
        private Button buttonPagePrecedente;
        private Button buttonPageSuivante;
        private Button buttonDernierePage;
        private Label labelPage;
        private Label labelConsultation;
        private ComboBox comboBoxModesRecherche;
        private Label labelModeSelection;
        private ComboBox comboBoxMois;
        private ComboBox comboBoxAnnee;
        private ComboBox comboBoxMoisDebut;
        private ComboBox comboBoxAnneeDebut;
        private Label labelMoisDebut;
        private Label labelMoisFin;
        private ComboBox comboBoxMoisFin;
        private ComboBox comboBoxAnneeFin;
        private ComboBox comboBoxAnneeSimple;
        private Label labelAnneeDebut;
        private Label labelAnneeFin;
        private ComboBox comboBoxAnneeDebut2;
        private ComboBox comboBoxAnneeFin2;
        private MenuStrip menuStrip1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem selectionToolStripMenuItem;
        private ToolStripMenuItem paraToolStripMenuItem;
    }
}