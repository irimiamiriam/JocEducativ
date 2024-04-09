using JocEducativ.Models;
using JocEducativ.SqlDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocEducativ.Forms
{
    public partial class AlegeJoc : Form
    {
        public UtilizatorModel utilizator = new UtilizatorModel();
        public AlegeJoc()
        {
            InitializeComponent();
        }

        private void AlegeJoc_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = "Bine ai venit, "+ utilizator.Name.Trim() + " ("+ utilizator.Email + ")";
            TopScoruri();
           
        }

        private void TopScoruri()
        {  var topGhiceste = DatabaseHelper.GetScoruriGhiceste().OrderByDescending(x => x.Punctaj).Take(3);
            var topSarpe = DatabaseHelper.GetScoruriSarpe().OrderByDescending(x => x.Punctaj).Take(3);
            topGhicestedataGridView.Columns.Add("Nume","Nume utilizator");
            topGhicestedataGridView.Columns.Add("Email", "Email utilizator");
            topGhicestedataGridView.Columns.Add("Punctaj", "Punctaj utilizator");
            topSarpedataGridView.Columns.Add("Nume", "Nume utilizator");
            topSarpedataGridView.Columns.Add("Email", "Email utilizator");
            topSarpedataGridView.Columns.Add("Punctaj", "Punctaj utilizator");


            foreach (PunctajUtilizator utilizator in topGhiceste) 
            {
                topGhicestedataGridView.Rows.Add(utilizator.Name, utilizator.Email, utilizator.Punctaj);
            }
            foreach (PunctajUtilizator utilizator in topSarpe)
            {
                topSarpedataGridView.Rows.Add(utilizator.Name, utilizator.Email, utilizator.Punctaj);
            }

        }

        private void ghicesteButton_Click(object sender, EventArgs e)
        {
            GhicesteCuvant ghicesteCuvant = new GhicesteCuvant();
            this.Hide();
            ghicesteCuvant.ShowDialog();
            int punctaj=ghicesteCuvant.punctaj;
            DatabaseHelper.RezultatUser(utilizator, punctaj,0);
            TopScoruri();
            this.Show();
        }

        private void sarpeButton_Click(object sender, EventArgs e)
        {
            SarpeEducativ sarpeEducativ = new SarpeEducativ();
            this.Hide();
            sarpeEducativ.ShowDialog();
            int punctaj = sarpeEducativ.punctaj;
            DatabaseHelper.RezultatUser(utilizator, punctaj, 1);
            TopScoruri();
            this.Show();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
