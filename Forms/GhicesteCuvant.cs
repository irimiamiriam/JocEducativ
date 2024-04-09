using JocEducativ.SqlDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocEducativ.Forms
{
    public partial class GhicesteCuvant : Form
    {
        int lastX = 44;
        int litereGasite = 0;
        int litereCuvant = 0;
        int greseli = 0;
        List<Bitmap> imaginiFlori= new List<Bitmap>();
        int indStadiu = 5;
        public int punctaj;
        public GhicesteCuvant()
        {
            InitializeComponent();
        }

        private void GhicesteCuvant_Load(object sender, EventArgs e)
        {
            List<string> cuvinte = DatabaseHelper.GetCuvinte();
            Random rnd = new Random();

            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string folderName = @"Resurse\StadiiFloare";
            string path = Path.Combine(projectDirectory, folderName);
            var imaginiFloare = Directory.GetFiles(path);
            foreach(string file in imaginiFloare)
            {
                Bitmap img = new Bitmap(file);
                imaginiFlori.Add(img);
            }
            stadiuPictureBox.Image = imaginiFlori[5];

            int randomInd = rnd.Next(0, cuvinte.Count-1);
            litereCuvant= cuvinte[randomInd].Trim().Length;


            foreach (char c in cuvinte[randomInd].Trim())
            {
              
                Label liniutaLabel= new Label();
                liniutaLabel.Text = "_";
                liniutaLabel.Location = new Point(lastX, 200);  
                this.Controls.Add(liniutaLabel);
                liniutaLabel.BringToFront();

                Label literaLabel = new Label();
                literaLabel.Text = char.ToUpper(c).ToString();
                literaLabel.Location = new Point(lastX, 180);
                literaLabel.Visible= false;
                this.Controls.Add(literaLabel);
                literaLabel.BringToFront();

                lastX += 24;
            }

            foreach(Control control in this.Controls)
            {
                if(control is Button)
                {
                    control.Click += button_Click;
                }
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
          Button button = sender as Button;
          button.Visible= false;
          bool exista = false;
          foreach(Control control in this.Controls)
            {
                if(control is Label)
                {
                    if(control.Text == button.Text) 
                    {
                        exista = true;
                        litereGasite++;
                        control.Visible = true;
                    }
                }
           }
            if (exista == false)
            {
                greseli++;
                indStadiu--;
                if (indStadiu > -1) { stadiuPictureBox.Image = imaginiFlori[indStadiu]; }
                if(indStadiu == 0 ) { punctajLabel.Text = "Punctaj : "+ 0;  punctaj = 0; this.Close(); }
            }
            else
            {
                if (indStadiu < 5) { indStadiu++; stadiuPictureBox.Image = imaginiFlori[indStadiu]; }
                if (litereGasite == litereCuvant)
                {
                    punctajLabel.Text = "Punctaj : " + (100- 4*greseli);
                    punctaj = 100 - 4 * greseli; this.Close();

                }
            }
        }
    }
}
