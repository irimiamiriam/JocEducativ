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
    public partial class Autentificare : Form
    {
        public Autentificare()
        {
            InitializeComponent();
        }

       

        private void Autentificare_Load(object sender, EventArgs e)
        {
            emailtextBox.Text = "popescu.petre@ojti2023.ro";
            parolatextBox.Text = "abc123@A";
            DatabaseHelper.Initialisation();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            UtilizatorModel utilizator = DatabaseHelper.GetUtilizator(emailtextBox.Text, parolatextBox.Text);
            if (utilizator != null)
            {
                AlegeJoc alegeJoc = new AlegeJoc();
                alegeJoc.utilizator = utilizator;
                this.Hide();
                alegeJoc.ShowDialog();
                this.Close();
            }
            else { MessageBox.Show("Date de autentificare invalide!"); }
        }
    }
}
