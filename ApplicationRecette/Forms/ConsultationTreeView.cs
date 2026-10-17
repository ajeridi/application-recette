using ApplicationRecette.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationRecette.DataAccess;
using DocumentFormat.OpenXml.Bibliography;
using DGVPrinterHelper;

namespace ApplicationRecette.Forms
{
    public partial class ConsultationTreeView : Form
    {
        public ConsultationTreeView()
        {
            InitializeComponent();
            GetRecettes();

            if (recettes.Count() >= 1)
            {
                ChangeFormatDateOperation();
                GetYears(recettes);
                AddYearsToTreeView(annees);

                GetMonths(annees, recettes);

            }



        }


        //1) voir ce qu on a dans la DB pour afficher les mois et annees dans le treeview
        //Importer toute la db dans une liste, d abord voir les annees qu il y a --> ajouter les noeuds annee
        // puis regarder les mois qu il ya --> ajouter les noeuds annee
        // puis quand on veut afficher dans datagridview, on cherche dans la liste les elements qui ont le meme mois et annee que les noeuds


        // importer la db dans une liste
        List<RecetteConsultation> recettes = new List<RecetteConsultation>();


        List<RecetteConsultation> recettesSelection = new List<RecetteConsultation>();

        private void GetRecettes()
        {
            recettes = SelectQuery.GetAllRecettes();
        }


        //Voir les annees qu on a
        List<int> annees = new List<int>();
        List<int> months = new List<int>();

        private void GetYears(List<RecetteConsultation> recettes)
        {
            DateTime annee;

            foreach (RecetteConsultation recette in recettes)
            {
                annee = DateTime.ParseExact(recette.DateOperation, "dd-MM-yyyy", null);

                if (!annees.Contains(annee.Year))
                {
                    annees.Add(annee.Year);
                }
            }
            annees.Sort();
            annees.Reverse();
        }

        private void AddYearsToTreeView(List<int> annees)
        {
            foreach (int annee in annees)
            {
                treeView1.Nodes.Add(annee.ToString());
            }
        }


        private void GetMonths(List<int> annees, List<RecetteConsultation> recettes)
        {
            DateTime month;
            foreach (TreeNode tn in treeView1.Nodes)
            {
                foreach (RecetteConsultation recette in recettes)
                {
                    month = DateTime.ParseExact(recette.DateOperation, "dd-MM-yyyy", null);

                    if (month.Year == int.Parse(tn.Text))
                    {
                        if (!months.Contains(month.Month))
                        {
                            months.Add(month.Month);
                        }
                    }
                }
                //on a une liste de mois pour l annee 
                //ajouter la liste de mois a la node correspondante
                months.Sort();
                AddMonthsTotreeView(months, tn);

                //vider la liste month
                months.Clear();

            }
        }

        private void AddMonthsTotreeView(List<int> months, TreeNode tn)
        {
            foreach (int month in months)
            {
                tn.Nodes.Add(GetMonthName(month));
            }
        }


        private string GetMonthName(int month)
        {
            switch (month)
            {
                case 1:
                    return "Janvier";

                case 2:
                    return "Fevrier";

                case 3:
                    return "Mars";
                case 4:
                    return "Avril";
                case 5:
                    return "Mai";
                case 6:
                    return "Juin";
                case 7:
                    return "Juillet";
                case 8:
                    return "Aout";
                case 9:
                    return "Septembre";
                case 10:
                    return "Octobre";
                case 11:
                    return "Novembre";
                case 12:
                    return "Decembre";
            }
            return null;
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            int annee;
            int mois;

            recettesSelection.Clear();
            dataGridView1.DataSource = null;

            if (e.Node.Parent != null) //Si on selectionne un mois
            {
                annee = int.Parse(e.Node.Parent.Text);
                mois = GetMonthNumber(e.Node.Text);

                //on a le mois + annee, on cherche dans la liste recettes pour tout les elements qui ont le mois et l annee
                // on peuple la liste qui sera notre datasource
                MakeDataSource(annee, mois);

                DataGridViewSetup();
                
                if (mois != 0)
                    labelConsultation.Text = $"Consultation du mois de {GetMonthName(mois)} {annee}";
               
                    
            }
            else //si on selectionne une annee
            {
                annee = int.Parse(e.Node.Text);
                mois = 0;
                MakeDataSource(annee, mois);
                DataGridViewSetup();
                labelConsultation.Text = $"Consultation de l'année {annee}";
            }



        }

        private void DataGridViewSetup()
        {
            dataGridView1.DataSource = recettesSelection;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dataGridView1.Rows[recettesSelection.Count - 1].Cells[0].Value.ToString() == "TOTAL")
                dataGridView1.Rows[recettesSelection.Count - 1].DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void MakeDataSource(int annee, int mois)
        {
            foreach (RecetteConsultation recette in recettes)
            {
                DateTime dateOperation = DateTime.ParseExact(recette.DateOperation, "dd-MM-yyyy", null);
                if (dateOperation.Year == annee && mois == 0)
                {

                    recettesSelection.Add(recette);

                }
                else if (dateOperation.Year == annee && dateOperation.Month == mois)
                {
                    recettesSelection.Add(recette);
                }
            }

            Consultation.AddTotalRow(recettesSelection);



        }

        private void ChangeFormatDateOperation()
        {
            foreach (RecetteConsultation recette in recettes)
            {
                DateTime dateOperation = DateTime.ParseExact(recette.DateOperation, "MM/dd/yyyy HH:mm:ss", null);
                recette.DateOperation = dateOperation.ToString("dd-MM-yyyy");
            }
        }

        private int GetMonthNumber(string month)
        {
            switch (month)
            {
                case "Janvier":
                    return 1;

                case "Fevrier":
                    return 2;

                case "Mars":
                    return 3;
                case "Avril":
                    return 4;

                case "Mai":
                    return 5;

                case "Juin":
                    return 6;

                case "Juillet":
                    return 7;

                case "Aout":
                    return 8;

                case "Septembre":
                    return 9;

                case "Octobre":
                    return 10;

                case "Novembre":
                    return 11;

                case "Decembre":
                    return 12;
            }
            return 0;
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (recettesSelection.Count > 0)
            {
                Consultation.ExportToExcel(recettesSelection);
            }
            else
            {
                MessageBox.Show("Selectionner une date avant d'exporter vers Excel.");
            }

        }

        private void buttonImprimer_Click(object sender, EventArgs e)
        {
            if (recettesSelection.Count > 0)
            {
                try
                {
                    string dateDebutString = recettesSelection[0].DateOperation;
                    string dateFinString = recettesSelection[recettesSelection.Count() - 2].DateOperation;

                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = "Rapport recettes";



                    printer.SubTitle = $"Date de début : {dateDebutString}\nDate de fin : {dateFinString}";
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;

                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer = "Casa Mia";
                    printer.FooterSpacing = 15;
                    //Print landscape mode
                    printer.printDocument.DefaultPageSettings.Landscape = true;
                    printer.PrintPreviewDataGridView(dataGridView1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selectionner une date avant d'imprimer.");
            }

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string? dateOperation = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (dateOperation == "TOTAL")
                    return;
                else
                {
                    dateOperation = DateOperations.ChangeDateFormat(dateOperation, "dd-MM-yyyy", "yyyy-MM-dd");
                    Encodage.clickedRecette = SelectQuery.SearchDate(dateOperation);
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
