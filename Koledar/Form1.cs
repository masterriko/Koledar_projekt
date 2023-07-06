using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koledar
{
    public partial class Koledar : Form
    {
        private List<Praznik> prazniki = new List<Praznik>();
        private Datum datum;

        public Koledar()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = true;
            this.MaximizeBox = false;
            UstvariTabelo();
            datum = new Datum(1, "januar", 2023);
            PreberiDatoteko("prazniki.txt");
            Posodobi();
            NarisiDneve();
        }

        /// <summary>
        /// Ustvarimo tabelo, kamor bomo vpisovali datume
        /// </summary>
        private void UstvariTabelo()
        {
            tabela.Controls.Clear();

            for (int i = 0; i < tabela.RowCount; i++)
            {
                for (int j = 0; j < tabela.ColumnCount; j++)
                {
                    Panel squarePanel = new Panel();
                    squarePanel.Margin = new Padding(1);
                    tabela.Controls.Add(squarePanel, j, i);
                }
            }
        }

        /// <summary>
        /// Pobarvamo okno, kjer se nahaja praznik
        /// </summary>
        /// <param name="dan"></param>
        /// <param name="okno"></param>
        public void IzrisiPraznik(Datum dan, Panel okno)
        {
            foreach (Praznik p in prazniki)
            {
                if (p.CompareTo(dan) == 0)
                {
                    okno.BackColor = ColorTranslator.FromHtml("#FCABE1");
                }
            }
        }

        /// <summary>
        /// Narišemo dneve na tabelo
        /// </summary>
        private void NarisiDneve()
        {

            int zacetek = datum.DanVTednu();
            int konec = Datum.DolzineMesecev(datum.Leto)[datum.Mesec - 1];

            for (int i = 0; i < 42; i++)
            {
                Panel okno = (Panel)tabela.GetControlFromPosition(i % 7, i / 7);
                System.Windows.Forms.Label tekst = new System.Windows.Forms.Label();
                tekst.Dock = DockStyle.Fill;
                tekst.TextAlign = ContentAlignment.MiddleCenter;

                okno.Controls.Clear();

                // Font 
                tekst.Font = new Font("Segoe UI", 10, FontStyle.Italic);

                // Barva teksta
                tekst.ForeColor = i % 7 == 6 ? ColorTranslator.FromHtml("#FF4160") : ColorTranslator.FromHtml("#000000");

                if (i >= zacetek && i < konec + zacetek)
                {

                    // Barva okna
                    okno.BackColor = ColorTranslator.FromHtml("#FFF2FC");

                    tekst.Text = (i - zacetek + 1).ToString();

                    Datum dan = new Datum(i - zacetek + 1, Datum.PretvoriSteviloVMesec(datum.Mesec), datum.Leto);

                    IzrisiPraznik(dan, okno);


                }
                else
                {
                    int prejsnji = Datum.PrejsnjiMesec(datum.Mesec - 1, datum.Leto);
                    tekst.Text = i < zacetek ? (prejsnji - zacetek + i + 1).ToString() : (i + 1 - (zacetek + konec)).ToString();

                    // Barva polja, ki ni v danem mesecu
                    okno.BackColor = ColorTranslator.FromHtml("#FFFFFF");

                }
                okno.Controls.Add(tekst);
            }
        }

        /// <summary>
        /// Preberemo datoteko s prazniki in napolnimo List prazniki
        /// </summary>
        /// <param name="datoteka"></param>
        private void PreberiDatoteko(string datoteka)
        {
            try
            {
                string[] vrstice = File.ReadAllLines(datoteka);

                foreach (string vrstica in vrstice.Skip(3).ToArray())
                {
                    string[] komponente = vrstica.Split(',');
                    Praznik praznik = new Praznik(int.Parse(komponente[0]), komponente[1], komponente.Length > 2 ? int.Parse(komponente[2]) : 1, komponente.Length < 3);

                    prazniki.Add(praznik);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Datoteka: {datoteka}, ni bila najdena.");
            }
            catch (IOException)
            {
                Console.WriteLine("Napaka pri branju datoteke");
            }
        }

        /// <summary>
        /// Posodobimo koledar
        /// </summary>
        public void Posodobi()
        {
            // preberi_datoteko("prazniki.txt");
            LetoNaslov.Text = (datum.Leto).ToString();
            MesecNaslov.Text = (Datum.PretvoriSteviloVMesec(datum.Mesec)).ToString();
            NarisiDneve();
            this.Invalidate();
        }

        /// <summary>
        /// Posodobimo naslov, če uporabnik vnese v polja
        /// </summary>
        public void PosodobiNaslov()
        {
            LetoNaslov.Text = LetoVnos.Text;
            MesecNaslov.Text = MesecComboBox.Text;
        }


        /// <summary>
        /// Ko kliknemo na gumb se prestavimo za en mesec naprej
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GumbNaslednjiKlik(object sender, EventArgs e)
        {
            tekstIkona.Text = "";
            datum.OdstejMesec(false);
            Posodobi();
        }

        /// <summary>
        /// Ko kliknemo na gumb se prestavimo za en mesec nazaj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GumbPrejsnjiKlik(object sender, EventArgs e)
        {
            tekstIkona.Text = "";
            datum.OdstejMesec(true);
            Posodobi();
        }

        /// <summary>
        /// Ko kliknemo gumb posodobimo koledar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GumbPotrdiKlik(object sender, EventArgs e)
        {
            try
            {
                datum = new Datum(1, MesecComboBox.Text, int.Parse(LetoVnos.Text));
                tekstIkona.ForeColor = Color.Green;
                tekstIkona.Text = "✔";
                Posodobi();
            }
            catch 
            {
                tekstIkona.ForeColor = Color.Red;
                tekstIkona.Text = "✘";
            }
        }
    }
}
