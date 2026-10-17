using ApplicationRecette.DataAccess;
using ApplicationRecette.Forms;
using ApplicationRecette.Model;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Wordprocessing;
using Irony.Parsing;
using System.Data;
using System.Drawing.Text;
using System.Globalization;
using System.Linq.Expressions;
namespace ApplicationRecette
{
    public partial class Encodage : Form
    {
        string[] anciennesValeurs;
        string[] anciennesValeurs21 = new string[3];
        string[] anciennesValeurs12 = new string[3];
        string[] anciennesValeurs6 = new string[3];

        public static Recette updatedRecette = new Recette();
        public static Recette nouvelleRecette = new Recette();
        public static List<Recette> clickedRecette = new List<Recette>();
        public static string prevousDateEntry = " ";
        public static string titreLabelAvertissement;
        public static bool suppression = false;
        public static bool confirmation = false;

        public Encodage()
        {
            InitializeComponent();
            labelDernièreDateDOperation.Text = DateOperations.ChangeDateFormat(SelectQuery.GetLastDateOfOperation(), "yyyy-MM-dd", "dd-MM-yyyy");
            dateTimePicker1.CustomFormat = " ";
           // dateTimePicker1.Text = "dd-MM-yyyy";
            dateTimePicker1.MaxDate = DateTime.Now.Date;

        }

        private void textBoxDateEntry_Click(object sender, EventArgs e)
        {
            if (textBoxDateEntry.Text != "")
                prevousDateEntry = textBoxDateEntry.Text;
        }

        //private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        //{
        //    string jour = monthCalendar1.SelectionRange.Start.ToString("dddd");
        //    if (jour == "mercredi")
        //    {
        //        MessageBox.Show("Attention, c'est un jour de fermeture.");
        //    }

        //    textBoxDateEntry.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd");

        //}

        //private void buttonCalendar_Click(object sender, EventArgs e)
        //{
        //    prevousDateEntry = textBoxDateEntry.Text;
        //    buttonCreerDate.Hide();
        //    buttonConfirmer.Show();
        //    monthCalendar1.Show();
        //    monthCalendar1.BringToFront();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    monthCalendar1.Hide();
        //    buttonConfirmer.Hide();
        //    buttonCreerDate.Show();
        //}

        private void TextBoxEnabled(bool status)
        {
            textBoxTVAC21.Enabled = status;
            textBoxHTVA21.Enabled = status;
            textBoxTVA21.Enabled = status;
            textBoxTVAC12.Enabled = status;
            textBoxHTVA12.Enabled = status;
            textBoxTVA12.Enabled = status;
            textBoxTVAC6.Enabled = status;
            textBoxHTVA6.Enabled = status;
            textBoxTVA6.Enabled = status;
            textBoxCartesBancaires.Enabled = status;
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            CheckForModifications();
            this.Close();
        }

        //private void buttonRechercher_Click(object sender, EventArgs e)
        //{
        //    CheckForModifications();


        //    if (dateTimePicker1.Text == " ")
        //    {
        //        MessageBox.Show("Veuillez sélectionner une date.");
        //        return;
        //    }

        //    //if (!DateTime.TryParse(textBoxDateEntry.Text, out var result))
        //    //{
        //    //    MessageBox.Show("Veuillez entrer une date valide (AAAA-MM-JJ).");
        //    //    ChangeTextBoxesContent("", textBoxDateEntry);
        //    //    return;
        //    //}

        //    try
        //    {
        //        List<Recette> recetteTrouvee = DataAccess.SelectQuery.SearchDate(dateTimePicker1.Text);
        //        if (recetteTrouvee.Count != 0)
        //        {
        //            MapObjectToTextBox(recetteTrouvee);
        //            TextBoxEnabled(true);
        //            ChangeButtonName("Modifier", buttonCalculer21, buttonCalculer12, buttonCalculer6);
        //            ChangeButtonName("Mettre à jour", buttonEnregistrer);
        //            ShowButton(buttonCalculer21, buttonCalculer12, buttonCalculer6, buttonAnnuler, buttonEnregistrer, buttondSupprimer);
        //            EnableButtons(false, buttonEnregistrer);


        //        }
        //        else
        //        {
        //            MessageBox.Show($"Aucune opération n'a été trouvée à la date du {dateTimePicker1.Text}.\nVous pouvez créer une nouvelle date en appuyant sur le bouton \"Créer date\"");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erreur : " + ex.Message);
        //    }
        //}

        private void CheckForModifications()
        {
            string date;
            if (prevousDateEntry != " ") //si on a change de date
                date = prevousDateEntry;
            else
                date = dateTimePicker1.Text;


            //Cas où l'on veut chercher sans sauver les changements
            if (buttonEnregistrer.Enabled == true && buttonEnregistrer.Text == "Mettre à jour")
            {
                try
                {
                    CheckEmptyTextBoxes();
                    updatedRecette = new Recette
                    {
                        DateOperation = DateOperations.ChangeDateFormat(date, "dd-MM-yyyy", "yyyy-MM-dd"),
                        MontantTVAC_21 = decimal.Parse(textBoxTVAC21.Text),
                        MontantHTVA_21 = decimal.Parse(textBoxHTVA21.Text),
                        MontantTVA_21 = decimal.Parse(textBoxTVA21.Text),
                        MontantTVAC_12 = decimal.Parse(textBoxTVAC12.Text),
                        MontantHTVA_12 = decimal.Parse(textBoxHTVA12.Text),
                        MontantTVA_12 = decimal.Parse(textBoxTVA12.Text),
                        MontantTVAC_6 = decimal.Parse(textBoxTVAC6.Text),
                        MontantHTVA_6 = decimal.Parse(textBoxHTVA6.Text),
                        MontantTVA_6 = decimal.Parse(textBoxTVA6.Text),
                        TotalTVAC = decimal.Parse(labelTotalTVAC.Text),
                        TotalHTVA = decimal.Parse(labelTotalHTVA.Text),
                        TotalTVA = decimal.Parse(labelTotalTVA.Text),
                        DateModification = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"),
                        Remarque = null,
                        TotalCartes = decimal.Parse(textBoxCartesBancaires.Text),
                        TotalLiquide = decimal.Parse(labelLiquide.Text)

                    };
                    titreLabelAvertissement = "Voulez vous mettre à jour les données modifiées?";
                    Avertissement enregistrerForm = new Avertissement();
                    enregistrerForm.ShowDialog();
                    EnableButtons(false, buttonEnregistrer);
                    prevousDateEntry = " ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }


            else if (buttonEnregistrer.Enabled == true && buttonEnregistrer.Text == "Enregistrer")
            {
                //check for empty textboxes
                CheckEmptyTextBoxes();
                try
                {
                    nouvelleRecette = new Recette
                    {
                        DateOperation = DateOperations.ChangeDateFormat(date, "dd-MM-yyyy", "yyyy-MM-dd"),
                        MontantTVAC_21 = decimal.Parse(textBoxTVAC21.Text),
                        MontantHTVA_21 = decimal.Parse(textBoxHTVA21.Text),
                        MontantTVA_21 = decimal.Parse(textBoxTVA21.Text),
                        MontantTVAC_12 = decimal.Parse(textBoxTVAC12.Text),
                        MontantHTVA_12 = decimal.Parse(textBoxHTVA12.Text),
                        MontantTVA_12 = decimal.Parse(textBoxTVA12.Text),
                        MontantTVAC_6 = decimal.Parse(textBoxTVAC6.Text),
                        MontantHTVA_6 = decimal.Parse(textBoxHTVA6.Text),
                        MontantTVA_6 = decimal.Parse(textBoxTVA6.Text),
                        TotalTVAC = decimal.Parse(labelTotalTVAC.Text),
                        TotalHTVA = decimal.Parse(labelTotalHTVA.Text),
                        TotalTVA = decimal.Parse(labelTotalTVA.Text),
                        DateCreation = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"),
                        DateModification = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"),
                        Remarque = null,
                        TotalCartes = decimal.Parse(textBoxCartesBancaires.Text),
                        TotalLiquide = decimal.Parse(labelLiquide.Text)

                    };
                    titreLabelAvertissement = "Enregistrer la nouvelle date ?";
                    Avertissement enregistrerForm = new Avertissement();
                    enregistrerForm.ShowDialog();
                    labelDernièreDateDOperation.Text = SelectQuery.GetLastDateOfOperation();
                    EnableButtons(false, buttonEnregistrer);
                    prevousDateEntry = " ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void MapObjectToTextBox(List<Recette> recetteTrouvee)
        {
            try
            {
                textBoxTVAC21.Text = recetteTrouvee[0].MontantTVAC_21.ToString() == "" ? "0" : recetteTrouvee[0].MontantTVAC_21.ToString();
                textBoxHTVA21.Text = recetteTrouvee[0].MontantHTVA_21.ToString() == "" ? "0" : recetteTrouvee[0].MontantHTVA_21.ToString();
                textBoxTVA21.Text = recetteTrouvee[0].MontantTVA_21.ToString() == "" ? "0" : recetteTrouvee[0].MontantTVA_21.ToString();
                textBoxTVAC12.Text = recetteTrouvee[0].MontantTVAC_12.ToString() == "" ? "0" : recetteTrouvee[0].MontantTVAC_12.ToString();
                textBoxHTVA12.Text = recetteTrouvee[0].MontantHTVA_12.ToString() == "" ? "0" : recetteTrouvee[0].MontantHTVA_12.ToString();
                textBoxTVA12.Text = recetteTrouvee[0].MontantTVA_12.ToString() == "" ? "0" : recetteTrouvee[0].MontantTVA_12.ToString();
                textBoxTVAC6.Text = recetteTrouvee[0].MontantTVAC_6.ToString() == "" ? "0" : recetteTrouvee[0].MontantTVAC_6.ToString();
                textBoxHTVA6.Text = recetteTrouvee[0].MontantHTVA_6.ToString() == "" ? "0" : recetteTrouvee[0].MontantHTVA_6.ToString();
                textBoxTVA6.Text = recetteTrouvee[0].MontantTVA_6.ToString() == "" ? "0" : recetteTrouvee[0].MontantTVA_6.ToString();
                labelTotalTVAC.Text = recetteTrouvee[0].TotalTVAC.ToString() == "" ? "0" : recetteTrouvee[0].TotalTVAC.ToString();
                labelTotalHTVA.Text = recetteTrouvee[0].TotalHTVA.ToString() == "" ? "0" : recetteTrouvee[0].TotalHTVA.ToString();
                labelTotalTVA.Text = recetteTrouvee[0].TotalTVA.ToString() == "" ? "0" : recetteTrouvee[0].TotalTVA.ToString();
                textBoxCartesBancaires.Text = recetteTrouvee[0].TotalCartes.ToString() == "" ? "0" : recetteTrouvee[0].TotalCartes.ToString();
                labelLiquide.Text = recetteTrouvee[0].TotalLiquide.ToString() == "" ? "0" : recetteTrouvee[0].TotalLiquide.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void ShowButton(params Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                button.Show();
            }
        }

        private void HideButton(params Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                button.Hide();
            }
        }
        private void ChangeButtonName(string name, params Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                button.Text = name;
            }
        }


        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            CheckForModifications();
            ChangeTextBoxesContent("", textBoxTVAC21, textBoxHTVA21, textBoxTVA21, textBoxTVAC12, textBoxHTVA12, textBoxTVA12,
                textBoxTVAC6, textBoxHTVA6, textBoxTVA6, textBoxDateEntry, textBoxCartesBancaires);
            dateTimePicker1.CustomFormat = " ";

            TextBoxEnabled(false);
            ClearLabels(labelTotalTVAC, labelTotalHTVA, labelTotalTVA, labelLiquide);
            HideButton(buttondSupprimer, buttonAnnuler, buttonEnregistrer, buttonCalculer21, buttonCalculer12, buttonCalculer6);

        }

        private void ChangeTextBoxesContent(string content, params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = content;
            }

        }

        private void ClearLabels(params Label[] labels)
        {
            foreach (Label label in labels)
            {
                label.Text = "";
            }
        }

        private void buttonCalculer21_Click(object sender, EventArgs e)
        {
            ButtonCalculerN_Click(buttonCalculer21, buttonAnnuler21, textBoxTVAC21, textBoxHTVA21, textBoxTVA21,
                21, textBoxTVAC12, textBoxHTVA12, textBoxTVA12, textBoxTVAC6, textBoxHTVA6, textBoxTVA6, anciennesValeurs21);
            this.ActiveControl = textBoxHTVA12;
            textBoxHTVA12_Enter(sender, e);

        }

        private void ButtonCalculerN_Click(Button buttonCalculerN, Button buttonAnnulerN, TextBox TVACN, TextBox HTVAN,
            TextBox TVAN, decimal N, TextBox TVAC1, TextBox HTVA1, TextBox TVA1, TextBox TVAC2, TextBox HTVA2, TextBox TVA2, string[] anciennesValeursN)
        {
            try
            {

                //cas d'une nouvelle date

                if (buttonCalculerN.Text == "Calculer")
                {
                    //calcul des autres champs
                    CalculerTextBoxes(TVACN, HTVAN, TVAN, buttonAnnulerN, N);

                    //bouton calculer deviens modifier
                    ChangeButtonName("Modifier", buttonCalculerN);

                    //Activer les boutons Annuler et Enregistrer
                    EnableButtons(true, buttonAnnuler, buttonEnregistrer);
                    EnableButtons(false, buttonCalculer21, buttonCalculer12, buttonCalculer6);

                    //Mettre à jour les labels des totaux
                    UpdateLabelsTotal(TVACN, HTVAN, TVAN, TVAC1, TVAC2, HTVA1,
                        HTVA2, TVA1, TVA2);

                }
                else if (buttonCalculerN.Text == "Modifier")
                {
                    //on demande à confirmer les modifications seulement si y'a eu modification
                    if (anciennesValeursN[0] != TVACN.Text || anciennesValeursN[1] != HTVAN.Text || anciennesValeursN[2] != TVAN.Text)
                    {
                        titreLabelAvertissement = "Confirmer les modifications ?";
                        Avertissement confirmationDemande = new Avertissement();
                        confirmationDemande.ShowDialog();
                    }

                    if (confirmation == false)
                    {
                        buttonAnnulerN_Click(TVACN, HTVAN, TVAN, buttonAnnulerN, buttonCalculerN, anciennesValeursN);
                        EnableButtons(false, buttonCalculer21, buttonCalculer12, buttonCalculer6);
                        return;
                    }




                    //Calculer les champs
                    CalculerTextBoxes(TVACN, HTVAN, TVAN, buttonAnnulerN, N);
                    //Changer le nom du bouton en modifier
                    ChangeButtonName("Modifier", buttonCalculerN);
                    //Cacher le bouton Annuler du groupBox
                    HideButton(buttonAnnulerN);
                    //Activer les boutons Annuler et Enregistrer
                    EnableButtons(true, buttonAnnuler, buttonEnregistrer);
                    //Mettre à jour les labels des totaux
                    UpdateLabelsTotal(TVACN, HTVAN, TVAN, TVAC1, TVAC2, HTVA1,
                        HTVA2, TVA1, TVA2);

                    //si on confirme, on a plus besoin des anciennes valeurs et on les remplaces par les nouvelles
                    anciennesValeursN = new string[] { TVACN.Text, HTVAN.Text, TVAN.Text };
                    EnableButtons(false, buttonCalculer21, buttonCalculer12, buttonCalculer6);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Veuillez entrer un montant valide");
            }
        }

        private void buttonCalculer12_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonCalculerN_Click(buttonCalculer12, buttonAnnuler12, textBoxTVAC12, textBoxHTVA12, textBoxTVA12, 12,
                    textBoxTVAC21, textBoxHTVA21, textBoxTVA21, textBoxTVAC6, textBoxHTVA6, textBoxTVA6, anciennesValeurs12);
                this.ActiveControl = textBoxHTVA6;
                textBoxHTVA6_Enter(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }


        private void buttonCalculer6_Click(object sender, EventArgs e)
        {
            try
            {

                ButtonCalculerN_Click(buttonCalculer6, buttonAnnuler6, textBoxTVAC6, textBoxHTVA6, textBoxTVA6, 6,
                    textBoxTVAC21, textBoxHTVA21, textBoxTVA21, textBoxTVAC12, textBoxHTVA12, textBoxTVA12, anciennesValeurs6);
                this.ActiveControl = textBoxCartesBancaires;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez rentrer un montant valide.");
            }

        }

        private void UpdateLabelsTotal(TextBox TVACMAIN, TextBox HTVAMAIN, TextBox TVAMAIN, TextBox textBoxTVAC1, TextBox textBoxTVAC2, TextBox textBoxHTVA1, TextBox textBoxHTVA2,
            TextBox textBoxTVA1, TextBox textBoxTVA2)
        {
            //update total TVAC
            decimal TVAC1 = textBoxTVAC1.Text == "" ? 0 : decimal.Parse(textBoxTVAC1.Text);
            decimal TVAC2 = textBoxTVAC2.Text == "" ? 0 : decimal.Parse(textBoxTVAC2.Text);
            labelTotalTVAC.Text = Calculs.CalculTotalTVAC(decimal.Parse(TVACMAIN.Text), TVAC1,
                TVAC2).ToString("0.##");

            //update total HTVA
            decimal HTVA1 = textBoxHTVA1.Text == "" ? 0 : decimal.Parse(textBoxHTVA1.Text);
            decimal HTVA2 = textBoxHTVA2.Text == "" ? 0 : decimal.Parse(textBoxHTVA2.Text);
            labelTotalHTVA.Text = Calculs.CalculTotalHTVA(decimal.Parse(HTVAMAIN.Text), HTVA1,
                HTVA2).ToString("0.##");

            //update total TVA
            decimal TVA1 = textBoxTVA1.Text == "" ? 0 : decimal.Parse(textBoxTVA1.Text);
            decimal TVA2 = textBoxTVA2.Text == "" ? 0 : decimal.Parse(textBoxTVA2.Text);
            labelTotalTVA.Text = Calculs.CalculTotalTVA(decimal.Parse(TVAMAIN.Text), TVA1,
                TVA2).ToString("0.##");
        }

        private void PrepareForModification(Button buttonCalculerN, Button buttonAnnulerN,
            TextBox textBoxTVACN, TextBox textBoxHTVAN, TextBox textBoxTVAN)
        {
            anciennesValeurs = new string[] { textBoxTVACN.Text, textBoxHTVAN.Text, textBoxTVAN.Text };
            ChangeTextBoxesContent("", textBoxTVACN, textBoxHTVAN, textBoxTVAN);
            buttonAnnuler.Enabled = false;
            ShowButton(buttonAnnulerN);
            ChangeButtonName("Calculer", buttonCalculerN);
        }

        private void buttonAnnuler21_Click(object sender, EventArgs e)
        {

            buttonAnnulerN_Click(textBoxTVAC21, textBoxHTVA21, textBoxTVA21, buttonAnnuler21, buttonCalculer21, anciennesValeurs21);
            // this.ActiveControl = null;
        }



        private void buttonAnnuler12_Click(object sender, EventArgs e)
        {
            buttonAnnulerN_Click(textBoxTVAC12, textBoxHTVA12, textBoxTVA12, buttonAnnuler12, buttonCalculer12, anciennesValeurs12);
            //this.ActiveControl = null;
        }



        private void buttonAnnuler6_Click(object sender, EventArgs e)
        {
            buttonAnnulerN_Click(textBoxTVAC6, textBoxHTVA6, textBoxTVA6, buttonAnnuler6, buttonCalculer6, anciennesValeurs6);
            //this.ActiveControl = null;
        }

        private void buttonAnnulerN_Click(TextBox textBoxTVACN, TextBox textBoxHTVAN, TextBox textBoxTVAN, Button buttonAnnulerN, Button buttonCalculerN, string[] anciennesValeursN)
        {
            textBoxTVACN.Text = anciennesValeursN[0];
            textBoxHTVAN.Text = anciennesValeursN[1];
            textBoxTVAN.Text = anciennesValeursN[2];
            HideButton(buttonAnnulerN);
            buttonAnnuler.Enabled = true;
            buttonCalculerN.Enabled = false;
            //ChangeButtonName("Modifier", buttonCalculerN);
            EnableTextBoxes(true, textBoxTVACN, textBoxHTVAN, textBoxTVAN);
        }

        private void EnableButtons(bool status, params Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                button.Enabled = status;
            }
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {

            if (dateTimePicker1.Value.ToString("dddd") == "mercredi")
            {
                MessageBox.Show("Attention c'est un jour de fermeture.");
                titreLabelAvertissement = "Veuillez vous quand meme ajouter la date ?";

                Avertissement avertissement = new Avertissement();
                avertissement.ShowDialog();

                if (Encodage.confirmation == false)
                {
                    buttonAnnuler_Click(sender, e);
                    labelFermeture.Hide();
                    return;
                }

            }

            if (buttonEnregistrer.Text == "Enregistrer")
            {
                try
                {
                    //check for empty textboxes
                    CheckEmptyTextBoxes();

                    if (dateTimePicker1.Value.ToString("dddd") == "mercredi")
                    {
                        labelFermeture.Show();
                    }


                    nouvelleRecette = new Recette
                    {
                        DateOperation = DateOperations.ChangeDateFormat(dateTimePicker1.Text, "dd-MM-yyyy", "yyyy-MM-dd"),
                        MontantTVAC_21 = decimal.Parse(textBoxTVAC21.Text),
                        MontantHTVA_21 = decimal.Parse(textBoxHTVA21.Text),
                        MontantTVA_21 = decimal.Parse(textBoxTVA21.Text),
                        MontantTVAC_12 = decimal.Parse(textBoxTVAC12.Text),
                        MontantHTVA_12 = decimal.Parse(textBoxHTVA12.Text),
                        MontantTVA_12 = decimal.Parse(textBoxTVA12.Text),
                        MontantTVAC_6 = decimal.Parse(textBoxTVAC6.Text),
                        MontantHTVA_6 = decimal.Parse(textBoxHTVA6.Text),
                        MontantTVA_6 = decimal.Parse(textBoxTVA6.Text),
                        TotalTVAC = decimal.Parse(labelTotalTVAC.Text),
                        TotalHTVA = decimal.Parse(labelTotalHTVA.Text),
                        TotalTVA = decimal.Parse(labelTotalTVA.Text),
                        DateCreation = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"),
                        DateModification = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"),
                        Remarque = null,
                        TotalCartes = decimal.Parse(textBoxCartesBancaires.Text),
                        TotalLiquide = decimal.Parse(labelLiquide.Text)

                    };
                    Inserts.InsertNew(nouvelleRecette);




                    string dateNow = DateTime.Now.ToString("dd-MM-yyyy");
                    if (dateTimePicker1.Text != dateNow)
                    {
                        CleanForm();
                        dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
                    }
                    else
                    {
                        ChangeButtonName("Mettre à jour", buttonEnregistrer);
                    }

                    //ChangeButtonName("Modifier", buttonCalculer21, buttonCalculer12, buttonCalculer6);
                    //ChangeButtonName("Mettre à jour", buttonEnregistrer);
                    EnableButtons(false, buttonEnregistrer, buttonCalculer21, buttonCalculer12, buttonCalculer6);
                    //ShowButton(buttondSupprimer);

                    labelDernièreDateDOperation.Text = DateOperations.ChangeDateFormat(nouvelleRecette.DateOperation, "yyyy-MM-dd", "dd-MM-yyyy");





                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }

            else if (buttonEnregistrer.Text == "Mettre à jour")
            {
                try
                {

                    updatedRecette = new Recette
                    {
                        DateOperation = DateOperations.ChangeDateFormat(dateTimePicker1.Text, "dd-MM-yyyy", "yyyy-MM-dd"),
                        MontantTVAC_21 = decimal.Parse(textBoxTVAC21.Text),
                        MontantHTVA_21 = decimal.Parse(textBoxHTVA21.Text),
                        MontantTVA_21 = decimal.Parse(textBoxTVA21.Text),
                        MontantTVAC_12 = decimal.Parse(textBoxTVAC12.Text),
                        MontantHTVA_12 = decimal.Parse(textBoxHTVA12.Text),
                        MontantTVA_12 = decimal.Parse(textBoxTVA12.Text),
                        MontantTVAC_6 = decimal.Parse(textBoxTVAC6.Text),
                        MontantHTVA_6 = decimal.Parse(textBoxHTVA6.Text),
                        MontantTVA_6 = decimal.Parse(textBoxTVA6.Text),
                        TotalTVAC = decimal.Parse(labelTotalTVAC.Text),
                        TotalHTVA = decimal.Parse(labelTotalHTVA.Text),
                        TotalTVA = decimal.Parse(labelTotalTVA.Text),
                        DateModification = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"),
                        Remarque = null,
                        TotalCartes = decimal.Parse(textBoxCartesBancaires.Text),
                        TotalLiquide = decimal.Parse(labelLiquide.Text)

                    };

                    Updates.UpdateDate(updatedRecette);

                    EnableButtons(false, buttonEnregistrer, buttonCalculer21, buttonCalculer12, buttonCalculer6);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }

            }
        }

        private void CleanForm()
        {
            ChangeTextBoxesContent("", textBoxTVAC21, textBoxHTVA21, textBoxTVA21, textBoxTVAC12, textBoxHTVA12, textBoxTVA12,
                textBoxTVAC6, textBoxHTVA6, textBoxTVA6, textBoxDateEntry, textBoxCartesBancaires);
            ClearLabels(labelTotalTVAC, labelTotalHTVA, labelTotalTVA, labelLiquide);
            EnableButtons(false, buttonEnregistrer, buttonCalculer21, buttonCalculer12, buttonCalculer6);




        }

        private void CheckEmptyTextBoxes()
        {
            //21% textboxes
            if (textBoxTVAC21.Text == "")
                textBoxTVAC21.Text = "0";
            if (textBoxHTVA21.Text == "")
                textBoxHTVA21.Text = "0";
            if (textBoxTVA21.Text == "")
                textBoxTVA21.Text = "0";

            //12% textboxes
            if (textBoxTVAC12.Text == "")
                textBoxTVAC12.Text = "0";
            if (textBoxHTVA12.Text == "")
                textBoxHTVA12.Text = "0";
            if (textBoxTVA12.Text == "")
                textBoxTVA12.Text = "0";

            //6% textboxes
            if (textBoxTVAC6.Text == "")
                textBoxTVAC6.Text = "0";
            if (textBoxHTVA6.Text == "")
                textBoxHTVA6.Text = "0";
            if (textBoxTVA6.Text == "")
                textBoxTVA6.Text = "0";
        }

        private void buttondSupprimer_Click(object sender, EventArgs e)
        {
            try
            {

                titreLabelAvertissement = "Êtes vous sûr de supprimer cette date ?\nL'action est irréversible.";
                Avertissement avertissementForm = new Avertissement();
                avertissementForm.ShowDialog();
                if (suppression == true)
                {
                    string dateSupprimer = DateOperations.ChangeDateFormat(dateTimePicker1.Text, "dd-MM-yyyy", "yyyy-MM-dd");
                    Delete.DeleteRow(dateSupprimer);
                    ChangeTextBoxesContent("", textBoxTVAC21, textBoxHTVA21, textBoxTVA21, textBoxTVAC12, textBoxHTVA12, textBoxTVA12,
                    textBoxTVAC6, textBoxHTVA6, textBoxTVA6, textBoxDateEntry, textBoxCartesBancaires);
                    dateTimePicker1.CustomFormat = " ";

                    TextBoxEnabled(false);
                    ClearLabels(labelTotalTVAC, labelTotalHTVA, labelTotalTVA, labelLiquide);
                    HideButton(buttondSupprimer, buttonAnnuler, buttonEnregistrer, buttonCalculer21, buttonCalculer12, buttonCalculer6);
                    labelDernièreDateDOperation.Text = SelectQuery.GetLastDateOfOperation();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void buttonConsultation_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultationTreeView consultationForm = new ConsultationTreeView();
                this.Hide();
                consultationForm.ShowDialog();
                if (clickedRecette.Count > 0)
                {
                    MapObjectToTextBox(clickedRecette);

                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    DateTime clickedDate = DateTime.ParseExact(clickedRecette[0].DateOperation, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                    dateTimePicker1.Text = clickedDate.ToString("yyyy-MM-dd");
                    HideButton(buttonAnnuler21, buttonAnnuler12, buttonAnnuler6);
                    ChangeButtonName("Modifier", buttonCalculer21, buttonCalculer12, buttonCalculer6);
                    ChangeButtonName("Mettre à jour", buttonEnregistrer);
                    ShowButton(buttondSupprimer, buttonAnnuler, buttonEnregistrer, buttonCalculer21, buttonCalculer12,
                        buttonCalculer6);
                    TextBoxEnabled(true);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                this.Show();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";


            CheckForModifications();


            if (dateTimePicker1.Text == " ")
            {
                MessageBox.Show("Veuillez sélectionner une date.");
                return;
            }
            if (dateTimePicker1.Value.ToString("dddd") == "mercredi")
            {
                labelFermeture.Show();
            }
            else
            {
                labelFermeture.Hide();
            }

            //if (!DateTime.TryParse(textBoxDateEntry.Text, out var result))
            //{
            //    MessageBox.Show("Veuillez entrer une date valide (AAAA-MM-JJ).");
            //    ChangeTextBoxesContent("", textBoxDateEntry);
            //    return;
            //}

            try
            {
                string searchDate = DateOperations.ChangeDateFormat(dateTimePicker1.Text, "dd-MM-yyyy", "yyyy-MM-dd");
                List<Recette> recetteTrouvee = DataAccess.SelectQuery.SearchDate(searchDate);
                if (recetteTrouvee.Count != 0)
                {
                    MapObjectToTextBox(recetteTrouvee);
                    TextBoxEnabled(true);
                    ChangeButtonName("Modifier", buttonCalculer21, buttonCalculer12, buttonCalculer6);
                    ChangeButtonName("Mettre à jour", buttonEnregistrer);
                    ShowButton(buttonCalculer21, buttonCalculer12, buttonCalculer6, buttonAnnuler, buttonEnregistrer, buttondSupprimer);
                    EnableButtons(false, buttonEnregistrer);
                }
                else
                {
                    //try
                    //{

                    ChangeTextBoxesContent("", textBoxTVAC21, textBoxHTVA21, textBoxTVA21,
                        textBoxTVAC12, textBoxHTVA12, textBoxTVA12,
                        textBoxTVAC6, textBoxHTVA6, textBoxTVA6, textBoxCartesBancaires);

                    ClearLabels(labelTotalTVA, labelTotalHTVA, labelTotalTVAC, labelLiquide);
                    TextBoxEnabled(true);
                    ChangeButtonName("Calculer", buttonCalculer21, buttonCalculer12, buttonCalculer6);
                    ChangeButtonName("Enregistrer", buttonEnregistrer);
                    ShowButton(buttonCalculer21, buttonCalculer12, buttonCalculer6, buttonAnnuler, buttonEnregistrer);
                    HideButton(buttondSupprimer);



                    //MessageBox.Show(this.ActiveControl.ToString());
                    this.ActiveControl = textBoxHTVA21;

                    ////textBoxHTVA21.Clear();
                    textBoxHTVA21_Enter(sender, e);
                    //textBoxHTVA21.Select();
                    //MessageBox.Show(this.ActiveControl.ToString());



                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show("Erreur : " + ex.Message);
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }



        }

        private void dateTimePicker1_Enter(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text != " ")
                prevousDateEntry = dateTimePicker1.Text;

        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Enter)
            //{
            //    dateTimePicker1.CustomFormat = " ";
            //}
        }

        private void CheckForPoint(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxTVAC21.Text.Contains('.'))
            {
                MessageBox.Show("Séparer les décimales par une virgule.");
                e.Cancel = true;
            }

        }




        private void EnableTextBoxes(bool status, params TextBox[] textBoxes)
        {
            foreach (TextBox box in textBoxes)
            {
                box.Enabled = status;
            }
        }




        private void CalculerTextBoxes(TextBox textBoxTVAC, TextBox textBoxHTVA, TextBox textBoxTVA, Button buttonAnnulerN,
            decimal taux)
        {
            if (textBoxTVAC.Enabled == true)
            {
                if (textBoxTVAC.Text != "")
                {
                    decimal TVAC;
                    if (decimal.TryParse(textBoxTVAC.Text, out TVAC))
                    {
                        //MessageBox.Show(textBoxTVA.Text);
                        textBoxTVA.Text = Calculs.CalculTVAavecTVAC(TVAC, taux).ToString("0.##");
                        //MessageBox.Show(textBoxTVA.Text);
                        textBoxHTVA.Text = Calculs.CalculHTVAavecTVAC(TVAC, taux).ToString("0.##");
                        textBoxTVAC.Text = TVAC.ToString("0.##");
                        EnableTextBoxes(true, textBoxHTVA, textBoxTVA);
                        HideButton(buttonAnnulerN);
                        EnableButtons(true, buttonEnregistrer);
                        return;

                    }
                    //else
                    //{
                    //    MessageBox.Show("Veuillez entrer une valeur de TVAC valide.");
                    //    return;
                    //}
                }
            }

            else if (textBoxHTVA.Enabled == true)
            {
                if (textBoxHTVA.Text != "")
                {
                    decimal HTVA;
                    if (decimal.TryParse(textBoxHTVA.Text, out HTVA))
                    {
                        textBoxTVAC.Text = Calculs.CalculTVACAvecHTVA(HTVA, taux).ToString("0.##");
                        textBoxTVA.Text = Calculs.CalculTVAavecHTVA(HTVA, taux).ToString("0.##");
                        textBoxHTVA.Text = HTVA.ToString("0.##");
                        EnableTextBoxes(true, textBoxTVAC, textBoxTVA);
                        return;

                    }
                    //else
                    //{
                    //    MessageBox.Show("Veuillez entrer une valeur de HTVA valide.");
                    //    return;
                    //}
                }
            }

            else if (textBoxTVA.Enabled == true)
            {
                if (textBoxTVA.Text != "")
                {
                    decimal TVA;
                    if (decimal.TryParse(textBoxTVA.Text, out TVA))
                    {
                        textBoxTVAC.Text = Calculs.CalculTVACAvecTVA(TVA, taux).ToString("0.##");
                        textBoxHTVA.Text = Calculs.CalculHTVAavecTVA(TVA, taux).ToString("0.##");
                        textBoxTVA.Text = TVA.ToString("0.##");
                        EnableTextBoxes(true, textBoxTVAC, textBoxHTVA);
                        return;
                    }
                    //else
                    //{
                    //    MessageBox.Show("Veuillez entrer une valeur de TVA valide.");
                    //    return;
                    //}
                }
            }

        }





        //Enter event


        private void textBoxTVAC21_Enter(object sender, EventArgs e)
        {
            anciennesValeurs21 = new string[] { textBoxTVAC21.Text, textBoxHTVA21.Text, textBoxTVA21.Text };
            EnableTextBoxes(false, textBoxHTVA21, textBoxTVA21);
            EnableButtons(true, buttonCalculer21);
            //si la date existe deja
            if (textBoxTVAC21.Text != "")
            {
                ShowButton(buttonAnnuler21);
            }

        }

        private void textBoxHTVA21_Enter(object sender, EventArgs e)
        {
            anciennesValeurs21 = new string[] { textBoxTVAC21.Text, textBoxHTVA21.Text, textBoxTVA21.Text };
            EnableTextBoxes(false, textBoxTVAC21, textBoxTVA21);
            EnableButtons(true, buttonCalculer21);
            //si la date existe deja
            if (textBoxHTVA21.Text != "")
            {
                ShowButton(buttonAnnuler21);
            }
        }

        private void textBoxTVA21_Enter(object sender, EventArgs e)
        {
            anciennesValeurs21 = new string[] { textBoxTVAC21.Text, textBoxHTVA21.Text, textBoxTVA21.Text };
            EnableTextBoxes(false, textBoxTVAC21, textBoxHTVA21);
            EnableButtons(true, buttonCalculer21);
            //si la date existe deja
            if (textBoxTVA21.Text != "")
            {
                ShowButton(buttonAnnuler21);
            }
        }

        private void textBoxTVAC12_Enter(object sender, EventArgs e)
        {
            anciennesValeurs12 = new string[] { textBoxTVAC12.Text, textBoxHTVA12.Text, textBoxTVA12.Text };
            EnableTextBoxes(false, textBoxHTVA12, textBoxTVA12);
            EnableButtons(true, buttonCalculer12);
            //si la date existe deja
            if (textBoxTVAC12.Text != "")
            {
                ShowButton(buttonAnnuler12);
            }
        }

        private void textBoxHTVA12_Enter(object sender, EventArgs e)
        {
            anciennesValeurs12 = new string[] { textBoxTVAC12.Text, textBoxHTVA12.Text, textBoxTVA12.Text };
            EnableTextBoxes(false, textBoxTVAC12, textBoxTVA12);
            EnableButtons(true, buttonCalculer12);
            //si la date existe deja
            if (textBoxHTVA12.Text != "")
            {
                ShowButton(buttonAnnuler12);
            }
        }

        private void textBoxTVA12_Enter(object sender, EventArgs e)
        {
            anciennesValeurs12 = new string[] { textBoxTVAC12.Text, textBoxHTVA12.Text, textBoxTVA12.Text };
            EnableTextBoxes(false, textBoxTVAC12, textBoxHTVA12);
            EnableButtons(true, buttonCalculer12);
            //si la date existe deja
            if (textBoxTVA12.Text != "")
            {
                ShowButton(buttonAnnuler12);
            }
        }

        private void textBoxTVAC6_Enter(object sender, EventArgs e)
        {
            anciennesValeurs6 = new string[] { textBoxTVAC6.Text, textBoxHTVA6.Text, textBoxTVA6.Text };
            EnableTextBoxes(false, textBoxHTVA6, textBoxTVA6);
            EnableButtons(true, buttonCalculer6);
            //si la date existe deja
            if (textBoxTVAC6.Text != "")
            {
                ShowButton(buttonAnnuler6);
            }
        }

        private void textBoxHTVA6_Enter(object sender, EventArgs e)
        {
            anciennesValeurs6 = new string[] { textBoxTVAC6.Text, textBoxHTVA6.Text, textBoxTVA6.Text };
            EnableTextBoxes(false, textBoxTVAC6, textBoxTVA6);
            EnableButtons(true, buttonCalculer6);

            //si la date existe deja
            if (textBoxHTVA6.Text != "")
            {
                ShowButton(buttonAnnuler6);
            }
        }

        private void textBoxTVA6_Enter(object sender, EventArgs e)
        {
            anciennesValeurs6 = new string[] { textBoxTVAC6.Text, textBoxHTVA6.Text, textBoxTVA6.Text };
            EnableTextBoxes(false, textBoxTVAC6, textBoxHTVA6);
            EnableButtons(true, buttonCalculer6);
            //si la date existe deja
            if (textBoxTVA6.Text != "")
            {
                ShowButton(buttonAnnuler6);
            }
        }




        //Validating 
        private void textBoxHTVA21_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxHTVA21.Text.Contains('.'))
            {
                MessageBox.Show("Séparer les décimales par une virgule.");
                e.Cancel = true;
            }
        }

        private void textBoxTVA21_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxTVA21.Text.Contains('.'))
            {
                MessageBox.Show("Séparer les décimales par une virgule.");
                e.Cancel = true;
            }
        }

        private void textBoxTVAC12_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxTVAC12.Text.Contains('.'))
            {
                MessageBox.Show("Séparer les décimales par une virgule.");
                e.Cancel = true;
            }
        }

        private void textBoxHTVA12_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxHTVA12.Text.Contains('.'))
            {
                MessageBox.Show("Séparer les décimales par une virgule.");
                e.Cancel = true;
            }
        }

        private void textboxTVA12_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxTVA12.Text.Contains('.'))
            {
                MessageBox.Show("Séparer les décimales par une virgule.");
                e.Cancel = true;
            }
        }

        private void textBoxTVAC6_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxTVAC6.Text.Contains('.'))
            {
                MessageBox.Show("Séparer les décimales par une virgule.");
                e.Cancel = true;
            }
        }

        private void textBoxHTVA6_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxHTVA6.Text.Contains('.'))
            {
                MessageBox.Show("Séparer les décimales par une virgule.");
                e.Cancel = true;
            }
        }

        private void textBoxTVA6_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxTVA6.Text.Contains('.'))
            {
                MessageBox.Show("Séparer les décimales par une virgule.");
                e.Cancel = true;
            }
        }



        // UNUSED
        private void buttonCreerDate_Click(object sender, EventArgs e)
        {


            CheckForModifications();

            if (dateTimePicker1.Text == " ")
            {
                MessageBox.Show("Veuillez sélectionner une date.");
                return;
            }
            ////check le format de la date
            //if (!DateTime.TryParse(textBoxDateEntry.Text, out var result))
            //{
            //    MessageBox.Show("Veuillez entrer une date valide (AAAA-MM-JJ).");
            //    ChangeTextBoxesContent("", textBoxDateEntry);
            //    return;
            //}
            //else
            //{
            //    if (result.ToString("dddd") == "mercredi")
            //    {
            //        MessageBox.Show("Attention, c'est un jour de fermeture.");
            //    }
            //}

            try
            {


                List<Recette> recetteTrouvee = DataAccess.SelectQuery.SearchDate(dateTimePicker1.Text);

                if (recetteTrouvee.Count != 0)
                {
                    MessageBox.Show("Cette date existe déjà");
                    MapObjectToTextBox(recetteTrouvee);
                    TextBoxEnabled(true);
                    ChangeButtonName("Modifier", buttonCalculer21, buttonCalculer12, buttonCalculer6);
                    ChangeButtonName("Mettre à jour", buttonEnregistrer);
                    ShowButton(buttonCalculer21, buttonCalculer12, buttonCalculer6, buttondSupprimer, buttonAnnuler, buttonEnregistrer);
                }
                else
                {
                    ChangeTextBoxesContent("", textBoxTVAC21, textBoxHTVA21, textBoxTVA21,
                        textBoxTVAC12, textBoxHTVA12, textBoxTVA12,
                        textBoxTVAC6, textBoxHTVA6, textBoxTVA6, textBoxCartesBancaires);

                    ClearLabels(labelTotalTVA, labelTotalHTVA, labelTotalTVAC, labelLiquide);
                    TextBoxEnabled(true);
                    ChangeButtonName("Calculer", buttonCalculer21, buttonCalculer12, buttonCalculer6);
                    ChangeButtonName("Enregistrer", buttonEnregistrer);
                    ShowButton(buttonCalculer21, buttonCalculer12, buttonCalculer6, buttonAnnuler, buttonEnregistrer);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }



        //KeyUp Events 
        private void textBoxTVAC21_KeyUp(object sender, KeyEventArgs e)
        {

            //si on appuie sur enter on se comporte comme le boutonCalculer
            if (e.KeyCode == Keys.Enter)
            {


                //if (textBoxTVAC21.Text.Contains(".") || textBoxHTVA21.Text.Contains(".") || textBoxTVA21.Text.Contains("."))
                //{
                //    MessageBox.Show("Séparer les décimales par une virgule.");
                //    return;
                //}
                if (textBoxHTVA21.Text != "")
                {

                    ButtonCalculerN_Click(buttonCalculer21, buttonAnnuler21, textBoxTVAC21, textBoxHTVA21, textBoxTVA21,
                   21, textBoxTVAC12, textBoxHTVA12, textBoxTVA12, textBoxTVAC6, textBoxHTVA6, textBoxTVA6, anciennesValeurs21);
                    this.ActiveControl = textBoxHTVA12;
                    textBoxHTVA12_Enter(sender, e);
                }

            }

        }

        private void textBox12_KeyUp(object sender, KeyEventArgs e)
        {

            //si on appuie sur enter on se comporte comme le boutonCalculer
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxTVAC12.Text.Contains(".") || textBoxHTVA12.Text.Contains(".") || textBoxTVA12.Text.Contains("."))
                {
                    MessageBox.Show("Séparer les décimales par une virgule.");
                    return;
                }
                ButtonCalculerN_Click(buttonCalculer12, buttonAnnuler12, textBoxTVAC12, textBoxHTVA12, textBoxTVA12,
               12, textBoxTVAC21, textBoxHTVA21, textBoxTVA21, textBoxTVAC6, textBoxHTVA6, textBoxTVA6, anciennesValeurs12);
                this.ActiveControl = textBoxHTVA6;
                textBoxHTVA6_Enter(sender, e);
            }
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {

            //si on appuie sur enter on se comporte comme le boutonCalculer
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxTVAC6.Text.Contains(".") || textBoxHTVA6.Text.Contains(".") || textBoxTVA6.Text.Contains("."))
                {
                    MessageBox.Show("Séparer les décimales par une virgule.");
                    return;
                }
                ButtonCalculerN_Click(buttonCalculer6, buttonAnnuler6, textBoxTVAC6, textBoxHTVA6, textBoxTVA6,
               6, textBoxTVAC21, textBoxHTVA21, textBoxTVA21, textBoxTVAC12, textBoxHTVA12, textBoxTVA12, anciennesValeurs6);
                this.ActiveControl = textBoxCartesBancaires;
            }
        }

        private void textBoxCartesBancaires_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxCartesBancaires.Text == "")
                    textBoxCartesBancaires.Text = "0";
                else if (decimal.TryParse(textBoxCartesBancaires.Text, out decimal montantCartes))
                {
                    if (decimal.TryParse(labelTotalTVAC.Text, out decimal totalTVAC))
                    {
                        if (totalTVAC >= montantCartes)
                        {
                            decimal totalLiquide = totalTVAC - montantCartes;
                            labelLiquide.Text = totalLiquide.ToString();
                            buttonEnregistrer.Enabled = true;
                            this.ActiveControl = buttonEnregistrer;
                        }
                        else
                        {
                            MessageBox.Show("Le montant carte est supérieur au TotalTVAC.");
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Entrez un montant valide.");
                    return;
                }

            }
        }

        private void buttonEnregistrer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonEnregistrer_Click(sender, e);

            }
        }


        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';
        }

        private void textBoxHTVA_ShowCursor(object sender, EventArgs e)
        {

            textBoxHTVA21.Select(textBoxHTVA21.Text.Length, 0);
        }

        private void textBoxDateEntry_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
