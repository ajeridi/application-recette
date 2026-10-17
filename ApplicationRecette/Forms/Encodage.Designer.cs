namespace ApplicationRecette
{
    partial class Encodage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelEncodage = new Label();
            labelDernièreDateDOperation = new Label();
            labelTitre = new Label();
            labelDate = new Label();
            textBoxDateEntry = new TextBox();
            groupBox1 = new GroupBox();
            buttonAnnuler21 = new Button();
            buttonCalculer21 = new Button();
            label5 = new Label();
            textBoxTVA21 = new TextBox();
            label6 = new Label();
            label3 = new Label();
            textBoxHTVA21 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            textBoxTVAC21 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonAnnuler12 = new Button();
            buttonCalculer12 = new Button();
            label7 = new Label();
            textBoxTVA12 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBoxHTVA12 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            textBoxTVAC12 = new TextBox();
            label12 = new Label();
            groupBox3 = new GroupBox();
            buttonAnnuler6 = new Button();
            buttonCalculer6 = new Button();
            label13 = new Label();
            textBoxTVA6 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            textBoxHTVA6 = new TextBox();
            label16 = new Label();
            label17 = new Label();
            textBoxTVAC6 = new TextBox();
            label18 = new Label();
            groupBox4 = new GroupBox();
            label25 = new Label();
            labelLiquide = new Label();
            labelTotalLiquide = new Label();
            label23 = new Label();
            label21 = new Label();
            label20 = new Label();
            labelTotalHTVA = new Label();
            label24 = new Label();
            labelTotalTVA = new Label();
            label22 = new Label();
            labelTotalTVAC = new Label();
            label19 = new Label();
            buttondSupprimer = new Button();
            buttonAnnuler = new Button();
            buttonEnregistrer = new Button();
            buttonConsultation = new Button();
            buttonQuitter = new Button();
            dateTimePicker1 = new DateTimePicker();
            labelFermeture = new Label();
            groupBoxCarteCredit = new GroupBox();
            label30 = new Label();
            textBoxCartesBancaires = new TextBox();
            labelMontantCarteBancaire = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBoxCarteCredit.SuspendLayout();
            SuspendLayout();
            // 
            // labelEncodage
            // 
            labelEncodage.AutoSize = true;
            labelEncodage.Location = new Point(11, 52);
            labelEncodage.Name = "labelEncodage";
            labelEncodage.Size = new Size(169, 20);
            labelEncodage.TabIndex = 0;
            labelEncodage.Text = "Dernière date ajoutée :  ";
            // 
            // labelDernièreDateDOperation
            // 
            labelDernièreDateDOperation.AutoSize = true;
            labelDernièreDateDOperation.Location = new Point(181, 52);
            labelDernièreDateDOperation.Name = "labelDernièreDateDOperation";
            labelDernièreDateDOperation.Size = new Size(0, 20);
            labelDernièreDateDOperation.TabIndex = 1;
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitre.Location = new Point(578, 9);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(168, 38);
            labelTitre.TabIndex = 2;
            labelTitre.Text = "ENCODAGE";
            labelTitre.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(387, 100);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(238, 20);
            labelDate.TabIndex = 3;
            labelDate.Text = " Date d'opération (AAAA-MM-JJ) : ";
            // 
            // textBoxDateEntry
            // 
            textBoxDateEntry.Location = new Point(631, 97);
            textBoxDateEntry.Name = "textBoxDateEntry";
            textBoxDateEntry.Size = new Size(123, 27);
            textBoxDateEntry.TabIndex = 4;
            textBoxDateEntry.Visible = false;
            textBoxDateEntry.Click += textBoxDateEntry_Click;
            textBoxDateEntry.TextChanged += textBoxDateEntry_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAnnuler21);
            groupBox1.Controls.Add(buttonCalculer21);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxTVA21);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxHTVA21);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxTVAC21);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(34, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 300);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "TVA 21%";
            // 
            // buttonAnnuler21
            // 
            buttonAnnuler21.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAnnuler21.Location = new Point(19, 240);
            buttonAnnuler21.Name = "buttonAnnuler21";
            buttonAnnuler21.Size = new Size(91, 29);
            buttonAnnuler21.TabIndex = 17;
            buttonAnnuler21.Text = "Annuler";
            buttonAnnuler21.UseVisualStyleBackColor = true;
            buttonAnnuler21.Visible = false;
            buttonAnnuler21.Click += buttonAnnuler21_Click;
            // 
            // buttonCalculer21
            // 
            buttonCalculer21.Enabled = false;
            buttonCalculer21.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCalculer21.Location = new Point(139, 240);
            buttonCalculer21.Name = "buttonCalculer21";
            buttonCalculer21.Size = new Size(143, 29);
            buttonCalculer21.TabIndex = 16;
            buttonCalculer21.Text = "Calculer";
            buttonCalculer21.UseVisualStyleBackColor = true;
            buttonCalculer21.Visible = false;
            buttonCalculer21.Click += buttonCalculer21_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(265, 189);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 15;
            label5.Text = "EUR";
            // 
            // textBoxTVA21
            // 
            textBoxTVA21.Enabled = false;
            textBoxTVA21.Location = new Point(139, 181);
            textBoxTVA21.Name = "textBoxTVA21";
            textBoxTVA21.Size = new Size(119, 27);
            textBoxTVA21.TabIndex = 14;
            textBoxTVA21.Click += textBoxTVA21_Enter;
            textBoxTVA21.KeyPress += textBox_KeyPress;
            textBoxTVA21.KeyUp += textBoxTVAC21_KeyUp;
            textBoxTVA21.Validating += textBoxTVA21_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 185);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 13;
            label6.Text = "Montant TVA : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(265, 121);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 12;
            label3.Text = "EUR";
            // 
            // textBoxHTVA21
            // 
            textBoxHTVA21.Enabled = false;
            textBoxHTVA21.Location = new Point(139, 115);
            textBoxHTVA21.Name = "textBoxHTVA21";
            textBoxHTVA21.Size = new Size(119, 27);
            textBoxHTVA21.TabIndex = 11;
            textBoxHTVA21.Click += textBoxHTVA21_Enter;
            textBoxHTVA21.Enter += textBoxHTVA_ShowCursor;
            textBoxHTVA21.KeyDown += textBoxTVAC21_KeyUp;
            textBoxHTVA21.KeyPress += textBox_KeyPress;
            textBoxHTVA21.Validating += textBoxHTVA21_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 117);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 10;
            label4.Text = "Montant HTVA : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(265, 61);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 9;
            label2.Text = "EUR";
            // 
            // textBoxTVAC21
            // 
            textBoxTVAC21.Enabled = false;
            textBoxTVAC21.Location = new Point(139, 55);
            textBoxTVAC21.Name = "textBoxTVAC21";
            textBoxTVAC21.Size = new Size(119, 27);
            textBoxTVAC21.TabIndex = 1;
            textBoxTVAC21.Click += textBoxTVAC21_Enter;
            textBoxTVAC21.KeyPress += textBox_KeyPress;
            textBoxTVAC21.KeyUp += textBoxTVAC21_KeyUp;
            textBoxTVAC21.Validating += CheckForPoint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 59);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Montant TVAC : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonAnnuler12);
            groupBox2.Controls.Add(buttonCalculer12);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBoxTVA12);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBoxHTVA12);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBoxTVAC12);
            groupBox2.Controls.Add(label12);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(466, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(378, 300);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "TVA 12%";
            // 
            // buttonAnnuler12
            // 
            buttonAnnuler12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAnnuler12.Location = new Point(19, 240);
            buttonAnnuler12.Name = "buttonAnnuler12";
            buttonAnnuler12.Size = new Size(91, 29);
            buttonAnnuler12.TabIndex = 18;
            buttonAnnuler12.Text = "Annuler";
            buttonAnnuler12.UseVisualStyleBackColor = true;
            buttonAnnuler12.Visible = false;
            buttonAnnuler12.Click += buttonAnnuler12_Click;
            // 
            // buttonCalculer12
            // 
            buttonCalculer12.Enabled = false;
            buttonCalculer12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCalculer12.Location = new Point(141, 240);
            buttonCalculer12.Name = "buttonCalculer12";
            buttonCalculer12.Size = new Size(143, 29);
            buttonCalculer12.TabIndex = 17;
            buttonCalculer12.Text = "Calculer";
            buttonCalculer12.UseVisualStyleBackColor = true;
            buttonCalculer12.Visible = false;
            buttonCalculer12.Click += buttonCalculer12_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(265, 189);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 15;
            label7.Text = "EUR";
            // 
            // textBoxTVA12
            // 
            textBoxTVA12.Enabled = false;
            textBoxTVA12.Location = new Point(139, 181);
            textBoxTVA12.Name = "textBoxTVA12";
            textBoxTVA12.Size = new Size(119, 27);
            textBoxTVA12.TabIndex = 14;
            textBoxTVA12.Click += textBoxTVA12_Enter;
            textBoxTVA12.KeyPress += textBox_KeyPress;
            textBoxTVA12.KeyUp += textBox12_KeyUp;
            textBoxTVA12.Validating += textboxTVA12_Validating;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 185);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 13;
            label8.Text = "Montant TVA : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(265, 121);
            label9.Name = "label9";
            label9.Size = new Size(36, 20);
            label9.TabIndex = 12;
            label9.Text = "EUR";
            // 
            // textBoxHTVA12
            // 
            textBoxHTVA12.Enabled = false;
            textBoxHTVA12.Location = new Point(139, 115);
            textBoxHTVA12.Name = "textBoxHTVA12";
            textBoxHTVA12.Size = new Size(119, 27);
            textBoxHTVA12.TabIndex = 11;
            textBoxHTVA12.Click += textBoxHTVA12_Enter;
            textBoxHTVA12.KeyDown += textBox12_KeyUp;
            textBoxHTVA12.KeyPress += textBox_KeyPress;
            textBoxHTVA12.Validating += textBoxHTVA12_Validating;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(19, 117);
            label10.Name = "label10";
            label10.Size = new Size(117, 20);
            label10.TabIndex = 10;
            label10.Text = "Montant HTVA : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(265, 61);
            label11.Name = "label11";
            label11.Size = new Size(36, 20);
            label11.TabIndex = 9;
            label11.Text = "EUR";
            // 
            // textBoxTVAC12
            // 
            textBoxTVAC12.Enabled = false;
            textBoxTVAC12.Location = new Point(139, 55);
            textBoxTVAC12.Name = "textBoxTVAC12";
            textBoxTVAC12.Size = new Size(119, 27);
            textBoxTVAC12.TabIndex = 1;
            textBoxTVAC12.Click += textBoxTVAC12_Enter;
            textBoxTVAC12.KeyPress += textBox_KeyPress;
            textBoxTVAC12.KeyUp += textBox12_KeyUp;
            textBoxTVAC12.Validating += textBoxTVAC12_Validating;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(19, 59);
            label12.Name = "label12";
            label12.Size = new Size(115, 20);
            label12.TabIndex = 0;
            label12.Text = "Montant TVAC : ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonAnnuler6);
            groupBox3.Controls.Add(buttonCalculer6);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(textBoxTVA6);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(textBoxHTVA6);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(textBoxTVAC6);
            groupBox3.Controls.Add(label18);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(872, 157);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(378, 300);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "TVA 6%";
            // 
            // buttonAnnuler6
            // 
            buttonAnnuler6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAnnuler6.Location = new Point(19, 240);
            buttonAnnuler6.Name = "buttonAnnuler6";
            buttonAnnuler6.Size = new Size(91, 29);
            buttonAnnuler6.TabIndex = 19;
            buttonAnnuler6.Text = "Annuler";
            buttonAnnuler6.UseVisualStyleBackColor = true;
            buttonAnnuler6.Visible = false;
            buttonAnnuler6.Click += buttonAnnuler6_Click;
            // 
            // buttonCalculer6
            // 
            buttonCalculer6.Enabled = false;
            buttonCalculer6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCalculer6.Location = new Point(139, 240);
            buttonCalculer6.Name = "buttonCalculer6";
            buttonCalculer6.Size = new Size(143, 29);
            buttonCalculer6.TabIndex = 18;
            buttonCalculer6.Text = "Calculer";
            buttonCalculer6.UseVisualStyleBackColor = true;
            buttonCalculer6.Visible = false;
            buttonCalculer6.Click += buttonCalculer6_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(265, 189);
            label13.Name = "label13";
            label13.Size = new Size(36, 20);
            label13.TabIndex = 15;
            label13.Text = "EUR";
            // 
            // textBoxTVA6
            // 
            textBoxTVA6.Enabled = false;
            textBoxTVA6.Location = new Point(139, 181);
            textBoxTVA6.Name = "textBoxTVA6";
            textBoxTVA6.Size = new Size(119, 27);
            textBoxTVA6.TabIndex = 14;
            textBoxTVA6.Click += textBoxTVA6_Enter;
            textBoxTVA6.KeyPress += textBox_KeyPress;
            textBoxTVA6.KeyUp += textBox6_KeyUp;
            textBoxTVA6.Validating += textBoxTVA6_Validating;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(19, 185);
            label14.Name = "label14";
            label14.Size = new Size(106, 20);
            label14.TabIndex = 13;
            label14.Text = "Montant TVA : ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(265, 121);
            label15.Name = "label15";
            label15.Size = new Size(36, 20);
            label15.TabIndex = 12;
            label15.Text = "EUR";
            // 
            // textBoxHTVA6
            // 
            textBoxHTVA6.Enabled = false;
            textBoxHTVA6.Location = new Point(139, 115);
            textBoxHTVA6.Name = "textBoxHTVA6";
            textBoxHTVA6.Size = new Size(119, 27);
            textBoxHTVA6.TabIndex = 11;
            textBoxHTVA6.Click += textBoxHTVA6_Enter;
            textBoxHTVA6.KeyDown += textBox6_KeyUp;
            textBoxHTVA6.KeyPress += textBox_KeyPress;
            textBoxHTVA6.Validating += textBoxHTVA6_Validating;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(19, 117);
            label16.Name = "label16";
            label16.Size = new Size(117, 20);
            label16.TabIndex = 10;
            label16.Text = "Montant HTVA : ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(265, 61);
            label17.Name = "label17";
            label17.Size = new Size(36, 20);
            label17.TabIndex = 9;
            label17.Text = "EUR";
            // 
            // textBoxTVAC6
            // 
            textBoxTVAC6.Enabled = false;
            textBoxTVAC6.Location = new Point(139, 55);
            textBoxTVAC6.Name = "textBoxTVAC6";
            textBoxTVAC6.Size = new Size(119, 27);
            textBoxTVAC6.TabIndex = 1;
            textBoxTVAC6.Click += textBoxTVAC6_Enter;
            textBoxTVAC6.KeyPress += textBox_KeyPress;
            textBoxTVAC6.KeyUp += textBox6_KeyUp;
            textBoxTVAC6.Validating += textBoxTVAC6_Validating;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(19, 59);
            label18.Name = "label18";
            label18.Size = new Size(115, 20);
            label18.TabIndex = 0;
            label18.Text = "Montant TVAC : ";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label25);
            groupBox4.Controls.Add(labelLiquide);
            groupBox4.Controls.Add(labelTotalLiquide);
            groupBox4.Controls.Add(label23);
            groupBox4.Controls.Add(label21);
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(labelTotalHTVA);
            groupBox4.Controls.Add(label24);
            groupBox4.Controls.Add(labelTotalTVA);
            groupBox4.Controls.Add(label22);
            groupBox4.Controls.Add(labelTotalTVAC);
            groupBox4.Controls.Add(label19);
            groupBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(387, 523);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(621, 245);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Total";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(321, 195);
            label25.Name = "label25";
            label25.Size = new Size(44, 25);
            label25.TabIndex = 12;
            label25.Text = "EUR";
            // 
            // labelLiquide
            // 
            labelLiquide.AutoSize = true;
            labelLiquide.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLiquide.Location = new Point(178, 195);
            labelLiquide.Name = "labelLiquide";
            labelLiquide.Size = new Size(0, 25);
            labelLiquide.TabIndex = 11;
            // 
            // labelTotalLiquide
            // 
            labelTotalLiquide.AutoSize = true;
            labelTotalLiquide.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalLiquide.Location = new Point(62, 195);
            labelTotalLiquide.Name = "labelTotalLiquide";
            labelTotalLiquide.Size = new Size(125, 25);
            labelTotalLiquide.TabIndex = 10;
            labelTotalLiquide.Text = "Total Liquide : ";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(321, 149);
            label23.Name = "label23";
            label23.Size = new Size(44, 25);
            label23.TabIndex = 9;
            label23.Text = "EUR";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(321, 104);
            label21.Name = "label21";
            label21.Size = new Size(44, 25);
            label21.TabIndex = 8;
            label21.Text = "EUR";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(321, 61);
            label20.Name = "label20";
            label20.Size = new Size(44, 25);
            label20.TabIndex = 7;
            label20.Text = "EUR";
            // 
            // labelTotalHTVA
            // 
            labelTotalHTVA.AutoSize = true;
            labelTotalHTVA.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalHTVA.Location = new Point(178, 104);
            labelTotalHTVA.Name = "labelTotalHTVA";
            labelTotalHTVA.Size = new Size(0, 25);
            labelTotalHTVA.TabIndex = 6;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(56, 104);
            label24.Name = "label24";
            label24.Size = new Size(112, 25);
            label24.TabIndex = 5;
            label24.Text = "Total HTVA : ";
            // 
            // labelTotalTVA
            // 
            labelTotalTVA.AutoSize = true;
            labelTotalTVA.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalTVA.Location = new Point(178, 149);
            labelTotalTVA.Name = "labelTotalTVA";
            labelTotalTVA.Size = new Size(0, 25);
            labelTotalTVA.TabIndex = 4;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(62, 149);
            label22.Name = "label22";
            label22.Size = new Size(99, 25);
            label22.TabIndex = 3;
            label22.Text = "Total TVA : ";
            // 
            // labelTotalTVAC
            // 
            labelTotalTVAC.AutoSize = true;
            labelTotalTVAC.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalTVAC.Location = new Point(171, 61);
            labelTotalTVAC.Name = "labelTotalTVAC";
            labelTotalTVAC.Size = new Size(0, 25);
            labelTotalTVAC.TabIndex = 1;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(56, 61);
            label19.Name = "label19";
            label19.Size = new Size(110, 25);
            label19.TabIndex = 0;
            label19.Text = "Total TVAC : ";
            // 
            // buttondSupprimer
            // 
            buttondSupprimer.Location = new Point(229, 823);
            buttondSupprimer.Name = "buttondSupprimer";
            buttondSupprimer.Size = new Size(104, 36);
            buttondSupprimer.TabIndex = 12;
            buttondSupprimer.Text = "Supprimer";
            buttondSupprimer.UseVisualStyleBackColor = true;
            buttondSupprimer.Visible = false;
            buttondSupprimer.Click += buttondSupprimer_Click;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Location = new Point(565, 823);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(104, 36);
            buttonAnnuler.TabIndex = 13;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            buttonAnnuler.Visible = false;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // buttonEnregistrer
            // 
            buttonEnregistrer.Enabled = false;
            buttonEnregistrer.Location = new Point(706, 823);
            buttonEnregistrer.Name = "buttonEnregistrer";
            buttonEnregistrer.Size = new Size(112, 36);
            buttonEnregistrer.TabIndex = 14;
            buttonEnregistrer.Text = "Enregistrer";
            buttonEnregistrer.UseVisualStyleBackColor = true;
            buttonEnregistrer.Visible = false;
            buttonEnregistrer.Click += buttonEnregistrer_Click;
            buttonEnregistrer.KeyDown += buttonEnregistrer_KeyUp;
            // 
            // buttonConsultation
            // 
            buttonConsultation.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonConsultation.Location = new Point(1054, 924);
            buttonConsultation.Name = "buttonConsultation";
            buttonConsultation.Size = new Size(197, 53);
            buttonConsultation.TabIndex = 15;
            buttonConsultation.Text = "Consultation";
            buttonConsultation.UseVisualStyleBackColor = true;
            buttonConsultation.Click += buttonConsultation_Click;
            // 
            // buttonQuitter
            // 
            buttonQuitter.Location = new Point(15, 901);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(155, 56);
            buttonQuitter.TabIndex = 16;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = true;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AllowDrop = true;
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(631, 92);
            dateTimePicker1.MaxDate = new DateTime(2024, 4, 28, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(158, 34);
            dateTimePicker1.TabIndex = 19;
            dateTimePicker1.Value = new DateTime(2024, 4, 14, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker1.Enter += dateTimePicker1_Enter;
            dateTimePicker1.KeyDown += dateTimePicker1_KeyDown;
            // 
            // labelFermeture
            // 
            labelFermeture.AutoSize = true;
            labelFermeture.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFermeture.ForeColor = Color.Red;
            labelFermeture.Location = new Point(831, 95);
            labelFermeture.Name = "labelFermeture";
            labelFermeture.Size = new Size(244, 31);
            labelFermeture.TabIndex = 20;
            labelFermeture.Text = "JOUR DE FERMETURE";
            labelFermeture.Visible = false;
            // 
            // groupBoxCarteCredit
            // 
            groupBoxCarteCredit.Controls.Add(label30);
            groupBoxCarteCredit.Controls.Add(textBoxCartesBancaires);
            groupBoxCarteCredit.Controls.Add(labelMontantCarteBancaire);
            groupBoxCarteCredit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxCarteCredit.Location = new Point(34, 481);
            groupBoxCarteCredit.Name = "groupBoxCarteCredit";
            groupBoxCarteCredit.Size = new Size(321, 172);
            groupBoxCarteCredit.TabIndex = 21;
            groupBoxCarteCredit.TabStop = false;
            groupBoxCarteCredit.Text = "Cartes Bancaires";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.Location = new Point(265, 60);
            label30.Name = "label30";
            label30.Size = new Size(36, 20);
            label30.TabIndex = 9;
            label30.Text = "EUR";
            // 
            // textBoxCartesBancaires
            // 
            textBoxCartesBancaires.Enabled = false;
            textBoxCartesBancaires.Location = new Point(139, 55);
            textBoxCartesBancaires.Name = "textBoxCartesBancaires";
            textBoxCartesBancaires.Size = new Size(119, 27);
            textBoxCartesBancaires.TabIndex = 1;
            textBoxCartesBancaires.KeyDown += textBoxCartesBancaires_KeyUp;
            textBoxCartesBancaires.KeyPress += textBox_KeyPress;
            // 
            // labelMontantCarteBancaire
            // 
            labelMontantCarteBancaire.AutoSize = true;
            labelMontantCarteBancaire.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMontantCarteBancaire.Location = new Point(19, 57);
            labelMontantCarteBancaire.Name = "labelMontantCarteBancaire";
            labelMontantCarteBancaire.Size = new Size(121, 20);
            labelMontantCarteBancaire.TabIndex = 0;
            labelMontantCarteBancaire.Text = "Montant Cartes : ";
            // 
            // Encodage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 989);
            Controls.Add(groupBoxCarteCredit);
            Controls.Add(labelFermeture);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonQuitter);
            Controls.Add(buttonConsultation);
            Controls.Add(buttonEnregistrer);
            Controls.Add(buttonAnnuler);
            Controls.Add(buttondSupprimer);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBoxDateEntry);
            Controls.Add(labelDate);
            Controls.Add(labelTitre);
            Controls.Add(labelDernièreDateDOperation);
            Controls.Add(labelEncodage);
            Name = "Encodage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Encodage";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBoxCarteCredit.ResumeLayout(false);
            groupBoxCarteCredit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEncodage;
        private Label labelDernièreDateDOperation;
        private Label labelTitre;
        private Label labelDate;
        private TextBox textBoxDateEntry;
        private GroupBox groupBox1;
        private TextBox textBoxTVAC21;
        private Label label1;
        private Label label5;
        private TextBox textBoxTVA21;
        private Label label6;
        private Label label3;
        private TextBox textBoxHTVA21;
        private Label label4;
        private Label label2;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox textBoxTVA12;
        private Label label8;
        private Label label9;
        private TextBox textBoxHTVA12;
        private Label label10;
        private Label label11;
        private TextBox textBoxTVAC12;
        private Label label12;
        private GroupBox groupBox3;
        private Label label13;
        private TextBox textBoxTVA6;
        private Label label14;
        private Label label15;
        private TextBox textBoxHTVA6;
        private Label label16;
        private Label label17;
        private TextBox textBoxTVAC6;
        private Label label18;
        private GroupBox groupBox4;
        private Label label19;
        private Label labelTotalHTVA;
        private Label label24;
        private Label labelTotalTVA;
        private Label label22;
        private Label labelTotalTVAC;
        private Button buttondSupprimer;
        private Button buttonAnnuler;
        private Button buttonEnregistrer;
        private Button buttonConsultation;
        private Button buttonQuitter;
        private Button buttonCalculer21;
        private Button buttonCalculer12;
        private Button buttonCalculer6;
        private Button buttonAnnuler21;
        private Button buttonAnnuler12;
        private Button buttonAnnuler6;
        private DateTimePicker dateTimePicker1;
        private Label label23;
        private Label label21;
        private Label label20;
        private Label labelFermeture;
        private Label label25;
        private Label labelLiquide;
        private Label labelTotalLiquide;
        private GroupBox groupBoxCarteCredit;
        private Label label30;
        private TextBox textBoxCartesBancaires;
        private Label labelMontantCarteBancaire;
    }
}
