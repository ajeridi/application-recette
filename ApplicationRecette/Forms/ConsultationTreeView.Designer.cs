namespace ApplicationRecette.Forms
{
    partial class ConsultationTreeView
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
            treeView1 = new TreeView();
            dataGridView1 = new DataGridView();
            buttonRetour = new Button();
            buttonImprimer = new Button();
            buttonExport = new Button();
            labelConsultation = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(27, 140);
            treeView1.Margin = new Padding(3, 4, 3, 4);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(173, 584);
            treeView1.TabIndex = 0;
            treeView1.NodeMouseDoubleClick += treeView1_NodeMouseDoubleClick;
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
            dataGridView1.Location = new Point(228, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1673, 683);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // buttonRetour
            // 
            buttonRetour.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRetour.Location = new Point(12, 904);
            buttonRetour.Name = "buttonRetour";
            buttonRetour.Size = new Size(279, 49);
            buttonRetour.TabIndex = 10;
            buttonRetour.Text = "Retour vers Encodage";
            buttonRetour.UseVisualStyleBackColor = true;
            buttonRetour.Click += buttonRetour_Click;
            // 
            // buttonImprimer
            // 
            buttonImprimer.Location = new Point(1694, 904);
            buttonImprimer.Name = "buttonImprimer";
            buttonImprimer.Size = new Size(187, 39);
            buttonImprimer.TabIndex = 12;
            buttonImprimer.Text = "Imprimer";
            buttonImprimer.UseVisualStyleBackColor = true;
            buttonImprimer.Click += buttonImprimer_Click;
            // 
            // buttonExport
            // 
            buttonExport.Location = new Point(1445, 904);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(187, 39);
            buttonExport.TabIndex = 11;
            buttonExport.Text = "Exporter vers Excel";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // labelConsultation
            // 
            labelConsultation.AutoSize = true;
            labelConsultation.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelConsultation.Location = new Point(508, 35);
            labelConsultation.Name = "labelConsultation";
            labelConsultation.Size = new Size(409, 81);
            labelConsultation.TabIndex = 13;
            labelConsultation.Text = "Consultation ";
            // 
            // ConsultationTreeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(labelConsultation);
            Controls.Add(buttonImprimer);
            Controls.Add(buttonExport);
            Controls.Add(buttonRetour);
            Controls.Add(dataGridView1);
            Controls.Add(treeView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConsultationTreeView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultationTreeView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private DataGridView dataGridView1;
        private Button buttonRetour;
        private Button buttonImprimer;
        private Button buttonExport;
        private Label labelConsultation;
    }
}