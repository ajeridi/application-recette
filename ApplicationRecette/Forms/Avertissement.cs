using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationRecette.Forms
{
    public partial class Avertissement : Form
    {
        
        public Avertissement()
        {
            InitializeComponent();
            label1.Text = Encodage.titreLabelAvertissement;
        }

        private void buttonNon_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Êtes vous sûr de supprimer cette date\nL'action est irréversible.")
                Encodage.suppression = false;

            else if (label1.Text == "Confirmer les modifications ?")
            {
                Encodage.confirmation = false;
            }
            else if (label1.Text == "Veuillez vous quand meme ajouter la date ?")
            {
                Encodage.confirmation = false;
            }



            this.Close();
        }

        private void buttonOui_Click(object sender, EventArgs e)
        {
            //cas update
            if (label1.Text == "Voulez vous mettre à jour les données modifiées?")
            {
                DataAccess.Updates.UpdateDate(Encodage.updatedRecette);
                
            }

            //cas enregistrement
            else if (label1.Text == "Enregistrer la nouvelle date ?")
            {
                DataAccess.Inserts.InsertNew(Encodage.nouvelleRecette);
            }

            //cas suppression
            else if (label1.Text == "Êtes vous sûr de supprimer cette date ?\nL'action est irréversible.")
            {
                Encodage.suppression = true;
            }

            else if (label1.Text == "Confirmer les modifications ?")
            {
                Encodage.confirmation = true;
                this.Close();
            }
            
            else if (label1.Text == "Veuillez vous quand meme ajouter la date ?")
            {
                Encodage.confirmation = true;
                this.Close();
            }


            this.Close();
        }
    }
}
