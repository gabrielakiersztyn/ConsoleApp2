using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Generator_Haseł
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGeneruj_Click(object sender, EventArgs e)
        {
            string male = "abcdefghijklmnopqrstuvwxyz";
            string duze = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string cyfry = "0123456789";
            string znaki = "!@#$%^&*()_-+=<>?";

            string zestaw = "";

            if (checkBoxMale.Checked) zestaw += male;
            if (checkBoxDuze.Checked) zestaw += duze;
            if (checkBoxCyfry.Checked) zestaw += cyfry;
            if (checkBoxZnaki.Checked) zestaw += znaki;

            if (string.IsNullOrEmpty(zestaw))
            {
                MessageBox.Show("Zaznacz chociaż jedną opcję!");
                return;
            }

            int dlugosc = (int)numericUpDown1.Value;
            StringBuilder haslo = new StringBuilder();
            Random rand = new Random();

            for (int i = 0; i < dlugosc; i++)
            {
                int index = rand.Next(zestaw.Length);
                haslo.Append(zestaw[index]);
            }

            textBoxHaslo.Text = haslo.ToString();
            OcenaSilyHasla(haslo.ToString());
        }

        private void OcenaSilyHasla(string haslo)
        {
            int sila = 0;

            if (haslo.Length >= 12) sila++;
            if (Regex.IsMatch(haslo, "[A-Z]")) sila++;
            if (Regex.IsMatch(haslo, "[0-9]")) sila++;
            if (Regex.IsMatch(haslo, "[^a-zA-Z0-9]")) sila++;

            switch (sila)
            {
                case 1:
                    labelOcena.Text = "Słabe hasło";
                    labelOcena.ForeColor = System.Drawing.Color.Red;
                    break;
                case 2:
                    labelOcena.Text = "Średnie hasło";
                    labelOcena.ForeColor = System.Drawing.Color.Orange;
                    break;
                case 3:
                    labelOcena.Text = "Dobre hasło";
                    labelOcena.ForeColor = System.Drawing.Color.Green;
                    break;
                case 4:
                    labelOcena.Text = "Bardzo mocne hasło";
                    labelOcena.ForeColor = System.Drawing.Color.DarkGreen;
                    break;
                default:
                    labelOcena.Text = "Bardzo słabe";
                    labelOcena.ForeColor = System.Drawing.Color.DarkRed;
                    break;
            }
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            string sciezka = "hasla.txt";
            string haslo = textBoxHaslo.Text;

            if (string.IsNullOrEmpty(haslo))
            {
                MessageBox.Show("Brak hasła do zapisania.");
                return;
            }

            using (StreamWriter sw = File.AppendText(sciezka))
            {
                sw.WriteLine($"{DateTime.Now}: {haslo}");
            }

            MessageBox.Show("Hasło zapisane do pliku.");
        }
    }
}
