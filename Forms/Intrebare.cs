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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace JocEducativ.Forms
{
    public partial class Intrebare : Form
    {
        ItemModel item = new ItemModel();
        string raspuns;
        public int punctaj;
        public Intrebare()
        {
            InitializeComponent();
        }

        private void Intrebare_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int id = random.Next(1,21);
             item = DatabaseHelper.GetItem(id);
            intrebareTextBox.Text = item.Enunt;
            RadioButton raspuns1Button = new RadioButton();
            {
                raspuns1Button.Tag = 1;
                raspuns1Button.Text = item.Raspuns1;
                raspuns1Button.Location = new Point(10, 10);
                panel1.Controls.Add(raspuns1Button);
            }
            RadioButton raspuns2Button = new RadioButton();
            {
                raspuns2Button.Tag = 2;
                raspuns2Button.Text = item.Raspuns2;
                raspuns2Button.Location = new Point(10, 30);
                panel1.Controls.Add(raspuns2Button);
            }
            RadioButton raspuns3Button = new RadioButton();
            {
                raspuns3Button.Tag = 3;
                raspuns3Button.Text = item.Raspuns3;
                raspuns3Button.Location = new Point(10, 50);
                panel1.Controls.Add(raspuns3Button);
            }
            switch (item.RaspunsCorect)
            {
                case 1: raspuns = raspuns1Button.Text; break;
                case 2: raspuns = raspuns2Button.Text; break;
                case 3: raspuns = raspuns3Button.Text; break;
            }

        }

        private void raspunsButton_Click(object sender, EventArgs e)
        {
            foreach(RadioButton rb in panel1.Controls) 
            {
                if (rb.Checked)
                {
                    if (rb.Text == raspuns)
                    {
                        MessageBox.Show("Felicitări, ai răspuns corect!");
                        punctaj = item.Punctaj;
                        this.Close();

                    }
                    else { MessageBox.Show(" Răspunsul tău este greșit! Răspunsul corect este " + raspuns); punctaj = 0; this.Close(); }

                }
            }
            this.Close();
        }
    }
}
