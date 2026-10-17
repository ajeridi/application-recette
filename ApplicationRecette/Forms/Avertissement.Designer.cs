namespace ApplicationRecette.Forms
{
    partial class Avertissement
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
            label1 = new Label();
            buttonOui = new Button();
            buttonNon = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(375, 23);
            label1.TabIndex = 0;
            label1.Text = "Enregistrer le travail avant de changer de date ?";
            // 
            // buttonOui
            // 
            buttonOui.Location = new Point(53, 91);
            buttonOui.Name = "buttonOui";
            buttonOui.Size = new Size(136, 41);
            buttonOui.TabIndex = 1;
            buttonOui.Text = "Oui";
            buttonOui.UseVisualStyleBackColor = true;
            buttonOui.Click += buttonOui_Click;
            // 
            // buttonNon
            // 
            buttonNon.Location = new Point(258, 91);
            buttonNon.Name = "buttonNon";
            buttonNon.Size = new Size(136, 41);
            buttonNon.TabIndex = 2;
            buttonNon.Text = "Non";
            buttonNon.UseVisualStyleBackColor = true;
            buttonNon.Click += buttonNon_Click;
            // 
            // Enregistrer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 168);
            Controls.Add(buttonNon);
            Controls.Add(buttonOui);
            Controls.Add(label1);
            Name = "Enregistrer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attention";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonOui;
        private Button buttonNon;
    }
}