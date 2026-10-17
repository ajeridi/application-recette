using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationRecette.DataAccess;
using ApplicationRecette.Model;
using DGVPrinterHelper;
using ClosedXML;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Vml.Spreadsheet;

namespace ApplicationRecette.Forms
{
    public partial class Consultation : Form
    {


        List<RecetteConsultation> recettes = new List<RecetteConsultation>();
        System.Drawing.Font titleFont = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
        private int rowsPerPage = 16;
        private int currentPage = 1;
        private int totalPages;

        private string[] modesDeRecherche = new string[] { "Mois simple", "Mois à Mois", "Date à Date", "Année Simple", "Année à Année" };
        private List<string> mois = new List<string> {"Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre",
            "Octobre", "Novembre", "Decembre" };
        private List<int> annees = Enumerable.Range(2000, DateTime.Today.Year - 1999).Reverse().ToList();

        bool removeLastDate;


        string dateDebutString;
        string dateFinString;

        public Consultation()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = " ";
            //DateTime newDateValue = new DateTime(dateTimePicker1.Value.Year, 1, 1);
            //dateTimePicker1.Value = newDateValue;
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "MMM-yyyy";
            //dateTimePicker1.ShowUpDown = true;
            dateTimePicker2.CustomFormat = " ";

            comboBoxModesRecherche.DataSource = modesDeRecherche;

            comboBoxMois.DataSource = new List<string>(mois);
            comboBoxMoisDebut.DataSource = new List<string>(mois);
            comboBoxMoisFin.DataSource = new List<string>(mois);

            comboBoxAnnee.DataSource = new List<int>(annees);
            comboBoxAnneeDebut.DataSource = new List<int>(annees);
            comboBoxAnneeFin.DataSource = new List<int>(annees);
            comboBoxAnneeSimple.DataSource = new List<int>(annees);
            comboBoxAnneeDebut2.DataSource = new List<int>(annees);
            comboBoxAnneeFin2.DataSource = new List<int>(annees);


        }






        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            //dateTimePicker1.CustomFormat = "MM/yyyy";

        }



        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            //dateTimePicker2.CustomFormat = "MM/yyyy";

        }

        private void dateTimePicker1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Enter)
            {
                dateTimePicker1.CustomFormat = " ";
            }
        }


        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Enter)
            {
                dateTimePicker2.CustomFormat = " ";
            }
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                string dateDebut = " ";
                string dateFin = " ";

                int moisDebut;
                int moisFin;

                int anneeDebut;
                int anneeFin;





                switch (comboBoxModesRecherche.SelectedIndex)
                {
                    case 0: //Mois Simple
                        moisDebut = (comboBoxMois.SelectedIndex + 1);
                        moisFin = (moisDebut == 12 ? 1 : moisDebut + 1);
                        anneeDebut = (int)comboBoxAnnee.SelectedItem;
                        anneeFin = (moisDebut == 12 ? (int)comboBoxAnnee.SelectedItem + 1 : (int)comboBoxAnnee.SelectedItem);
                        dateDebut = anneeDebut + "-" + (moisDebut < 10 ? "0" + moisDebut.ToString() : moisDebut.ToString()) + "-" + "01";
                        dateFin = anneeFin + "-" + (moisFin < 10 ? "0" + moisFin.ToString() : moisFin.ToString()) + "-" + "01";

                        //dateDebutString = "01" + "-" + (moisDebut < 10 ? "0" + moisDebut.ToString() : moisDebut.ToString()) + "-" + anneeDebut;
                        //dateFinString = "31" + "-" + (moisDebut < 10 ? "0" + moisDebut.ToString() : moisDebut.ToString()) + "-" + anneeDebut;
                        removeLastDate = true;
                        break;

                    case 1: //Mois a Mois
                        moisDebut = comboBoxMoisDebut.SelectedIndex + 1;
                        anneeDebut = (int)comboBoxAnneeDebut.SelectedItem;

                        moisFin = comboBoxMoisFin.SelectedIndex + 1;
                        anneeFin = (moisFin == 12 ? (int)comboBoxAnnee.SelectedItem + 1 : (int)comboBoxAnnee.SelectedItem);
                        moisFin = (moisFin == 12 ? 1 : moisFin + 1);


                        dateDebut = anneeDebut + "-" + (moisDebut < 10 ? "0" + moisDebut.ToString() : moisDebut.ToString()) + "-" + "01";
                        dateFin = anneeFin + "-" + (moisFin < 10 ? "0" + moisFin.ToString() : moisFin.ToString()) + "-" + "01";

                        //dateDebutString = "01"
                        //dateFinString = anneeFin + "-"
                        removeLastDate = true;
                        break;

                    case 2: //Date a Date
                        if (dateTimePicker1.Text != " ")
                            dateDebut = DateOperations.ChangeDateFormat(dateTimePicker1.Text, "dd-MM-yyyy", "yyyy-MM-dd");

                        if (dateTimePicker2.Text != " ")
                            dateFin = DateOperations.ChangeDateFormat(dateTimePicker2.Text, "dd-MM-yyyy", "yyyy-MM-dd");

                        removeLastDate = false;

                        break;

                    case 3: //Annee simple
                        moisDebut = 1;
                        moisFin = 12;

                        anneeDebut = (int)comboBoxAnneeSimple.SelectedItem;
                        dateDebut = anneeDebut + "-" + (moisDebut < 10 ? "0" + moisDebut.ToString() : moisDebut.ToString()) + "-" + "01";
                        dateFin = anneeDebut + "-" + moisFin.ToString() + "-" + "31";

                        dateFinString = dateFin;
                        removeLastDate = false;
                        break;

                    case 4: //Annee a Annee
                        moisDebut = 1;
                        moisFin = 12;

                        anneeDebut = (int)comboBoxAnneeDebut2.SelectedItem;
                        anneeFin = (int)comboBoxAnneeFin2.SelectedItem;

                        dateDebut = anneeDebut + "-" + (moisDebut < 10 ? "0" + moisDebut.ToString() : moisDebut.ToString()) + "-" + "01";
                        dateFin = anneeFin + "-" + moisFin.ToString() + "-" + "31";


                        removeLastDate = false;
                        break;
                }

                //dateDebutString = dateDebut;

                recettes = SelectQuery.GetRecette(dateDebut, dateFin, removeLastDate); //add removeLastDate parameter
                if (recettes.Count > 0)
                {
                    //if (recettes.Count > 299)
                    //{
                    //    MessageBox.Show("Fichier trop volumineux");
                    //    return;
                    //}
                    ChangeDateFormat(recettes);

                    //add total row
                    AddTotalRow(recettes);
                    currentPage = 1;
                    totalPages = (int)Math.Ceiling((double)recettes.Count / rowsPerPage);
                    EnableButton(true);
                    LoadDataOnPage(currentPage);
                    buttonImprimer.Enabled = true;
                    buttonExport.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Rien n'a été trouvé.");
                    currentPage = 0;
                    UpdateButtonState();
                    buttonPageSuivante.Enabled = false;
                    buttonDernierePage.Enabled = false;
                    labelPage.Text = null;
                    dataGridView1.DataSource = null;
                    buttonImprimer.Enabled = false;
                    buttonExport.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

        }

        private void ChangeDateFormat(List<RecetteConsultation> recettes)
        {
            try
            {
                foreach (RecetteConsultation rec in recettes)
                {
                    string dateString = rec.DateOperation;
                    string format = "MM/dd/yyyy HH:mm:ss";

                    DateTime parsedDate = DateTime.ParseExact(dateString, format, null);

                    //rec.DateOperation = parsedDate.ToString("yyyy-MM-dd");
                    rec.DateOperation = parsedDate.ToString("dd-MM-yyyy");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void DatagridViewSetup(List<RecetteConsultation> recettes)
        {
            dataGridView1.DataSource = recettes;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            // dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            if (dataGridView1.Rows[recettes.Count - 1].Cells[0].Value.ToString() == "TOTAL")
                dataGridView1.Rows[recettes.Count - 1].DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            //dataGridView1.Rows[recettes.Count - 1].DefaultCellStyle.ForeColor = Color.Black;
            //dataGridView1.Rows[recettes.Count - 1].DefaultCellStyle.BackColor = Color.Beige;

        }


        public static void AddTotalRow(List<RecetteConsultation> recettes)
        {
            try
            {
                decimal? totalHTVA21 = 0;
                decimal? totalHTVA12 = 0;
                decimal? totalHTVA6 = 0;

                decimal? totalTVA21 = 0;
                decimal? totalTVA12 = 0;
                decimal? totalTVA6 = 0;

                decimal? totalHTVA = 0;
                decimal? totalTVA = 0;
                decimal? totalTVAC = 0;

                decimal? totalCartes = 0;
                decimal? totalLiquide = 0;

                foreach (RecetteConsultation rec in recettes)
                {
                    totalHTVA21 += rec.MontantHTVA_21;
                    totalHTVA12 += rec.MontantHTVA_12;
                    totalHTVA6 += rec.MontantHTVA_6;

                    totalTVA21 += rec.MontantTVA_21;
                    totalTVA12 += rec.MontantTVA_12;
                    totalTVA6 += rec.MontantTVA_6;

                    totalHTVA += rec.TotalHTVA;
                    totalTVA += rec.TotalTVA;
                    totalTVAC += rec.TotalTVAC;

                    totalCartes += rec.TotalCartes;
                    totalLiquide += rec.TotalLiquide;
                }

                RecetteConsultation totalRow = new RecetteConsultation()
                {
                    DateOperation = "TOTAL",
                    MontantHTVA_21 = totalHTVA21,
                    MontantTVA_21 = totalTVA21,
                    MontantHTVA_12 = totalHTVA12,
                    MontantTVA_12 = totalTVA12,
                    MontantHTVA_6 = totalHTVA6,
                    MontantTVA_6 = totalTVA6,

                    TotalHTVA = totalHTVA,
                    TotalTVAC = totalTVAC,
                    TotalTVA = totalTVA,

                    TotalCartes = totalCartes,
                    TotalLiquide = totalLiquide,

                };
                recettes.Add(totalRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        struct DataParameter
        {
            public List<RecetteConsultation> Recettes;
            public string FileName { get; set; }
        }


        private void buttonExport_Click(object sender, EventArgs e)
        {
            ExportToExcel(recettes);
        }

        public static void ExportToExcel(List<RecetteConsultation> recettes)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel WorkBook|*.xlsx" };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = sfd.FileName;

                    //default file format is XLSX, we can override it using CreatingOptions
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Recette");

                        worksheet.Cell("A1").Value = "Hello World!";
                        //Colonnes
                        worksheet.Cell("A1").Value = "Date Operation";
                        worksheet.Cell("B1").Value = "MontantHTVA_21";
                        worksheet.Cell("C1").Value = "MontantTVA_21";
                        worksheet.Cell("D1").Value = "MontantHTVA_12";
                        worksheet.Cell("E1").Value = "MontantTVA_12";
                        worksheet.Cell("F1").Value = "MontantHTVA_6";
                        worksheet.Cell("G1").Value = "MontantTVA_6";
                        worksheet.Cell("H1").Value = "TotalHTVA";
                        worksheet.Cell("I1").Value = "TotalTVA";
                        worksheet.Cell("J1").Value = "TotalTVAC";
                        worksheet.Cell("K1").Value = "TotalCartes";
                        worksheet.Cell("L1").Value = "TotalLiquide";


                        //Remplir les colonnes
                        int index = 2;
                        foreach (RecetteConsultation rec in recettes)
                        {
                            worksheet.Cell($"A{index}").Value = rec.DateOperation;
                            worksheet.Cell($"B{index}").Value = rec.MontantHTVA_21;
                            worksheet.Cell($"C{index}").Value = rec.MontantTVA_21;
                            worksheet.Cell($"D{index}").Value = rec.MontantHTVA_12;
                            worksheet.Cell($"E{index}").Value = rec.MontantTVA_12;
                            worksheet.Cell($"F{index}").Value = rec.MontantHTVA_6;
                            worksheet.Cell($"G{index}").Value = rec.MontantTVA_6;
                            worksheet.Cell($"H{index}").Value = rec.TotalHTVA;
                            worksheet.Cell($"I{index}").Value = rec.TotalTVA;
                            worksheet.Cell($"J{index}").Value = rec.TotalTVAC;
                            worksheet.Cell($"K{index}").Value = rec.TotalCartes;
                            worksheet.Cell($"L{index}").Value = rec.TotalLiquide;
                            index++;
                        }

                        worksheet.Columns().AdjustToContents();
                        workbook.SaveAs($"{fileName}");
                        MessageBox.Show("Export Complete");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void buttonImprimer_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.DataSource = recettes;
                DatagridViewSetup(recettes);
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Rapport recettes";

                dateDebutString = recettes[0].DateOperation;
                dateFinString = recettes[recettes.Count() - 2].DateOperation;

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
                LoadDataOnPage(currentPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }


        private void LoadDataOnPage(int page) //On rempli le datagrid view avec la page choisie
        {
            try
            {


                List<RecetteConsultation> subRecette = new List<RecetteConsultation>();

                //chercher la subrecette de la page en particulier
                //on connait le nombre de page qu'on a, donc je dois juste prendre l'index du premier element 
                //de la page et ajouter les 9 prochains

                int indexLigne = (page * rowsPerPage) - rowsPerPage;
                int endIndex = Math.Min(indexLigne + rowsPerPage, recettes.Count);

                //ajouter dans la subliste
                for (int i = indexLigne; i < endIndex; i++)
                {
                    subRecette.Add(recettes[i]);
                }

                //associer la subrecette a la datasource
                DatagridViewSetup(subRecette);

                //On doit update l'état des boutons
                UpdateButtonState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

        }

        private void UpdateButtonState()
        {
            labelPage.Text = $"{currentPage}/{totalPages}";
            buttonPremierePage.Enabled = (currentPage != 1 && currentPage != 0);
            buttonPagePrecedente.Enabled = (currentPage > 1);
            buttonPageSuivante.Enabled = (currentPage < totalPages);
            buttonDernierePage.Enabled = (currentPage != totalPages);
            buttonImprimer.Enabled = (dataGridView1.DataSource != null);
        }

        private void buttonPremierePage_Click(object sender, EventArgs e)
        {
            currentPage = 1;

            LoadDataOnPage(currentPage);
        }

        private void buttonPagePrecedente_Click(object sender, EventArgs e)
        {
            currentPage--;

            LoadDataOnPage(currentPage);
        }

        private void buttonPageSuivante_Click(object sender, EventArgs e)
        {
            currentPage++;

            LoadDataOnPage(currentPage);
        }

        private void buttonDernierePage_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;

            LoadDataOnPage(currentPage);
        }

        private void EnableButton(bool status)
        {
            buttonPagePrecedente.Enabled = true;
            buttonPageSuivante.Enabled = true;
            buttonPremierePage.Enabled = true;
            buttonDernierePage.Enabled = true;
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

        private void comboBoxModesRecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAll();
            switch (comboBoxModesRecherche.SelectedIndex)
            {
                case 0:
                    comboBoxMois.Show();
                    comboBoxAnnee.Show();
                    break;

                case 1:
                    labelMoisDebut.Show();
                    comboBoxMoisDebut.Show();
                    comboBoxAnneeDebut.Show();
                    labelMoisFin.Show();
                    comboBoxMoisFin.Show();
                    comboBoxAnneeFin.Show();
                    break;

                case 2:
                    label1.Show();
                    label2.Show();
                    dateTimePicker1.Show();
                    dateTimePicker2.Show();
                    break;

                case 3:
                    comboBoxAnneeSimple.Show();
                    break;

                case 4:
                    labelAnneeDebut.Show();
                    comboBoxAnneeDebut2.Show();
                    labelAnneeFin.Show();
                    comboBoxAnneeFin2.Show();
                    break;


            }
        }

        private void HideAll()
        {
            comboBoxAnneeDebut.Hide();
            comboBoxAnneeFin.Hide();
            comboBoxAnnee.Hide();
            comboBoxAnneeSimple.Hide();
            comboBoxAnneeDebut2.Hide();
            comboBoxAnneeFin2.Hide();

            comboBoxMois.Hide();
            comboBoxMoisDebut.Hide();
            comboBoxMoisFin.Hide();

            label1.Hide();
            label2.Hide();
            labelMoisDebut.Hide();
            labelMoisFin.Hide();
            labelAnneeDebut.Hide();
            labelAnneeFin.Hide();

            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
        }


    }
}

