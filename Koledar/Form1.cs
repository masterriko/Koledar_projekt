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
    public partial class Form1 : Form
    {
        private List<Praznik> prazniki = new List<Praznik>();
        private int DOLZINA = 800;
        private int VISINA = 650;
        private int velikost_kvadrata = 65;
        private int stevilo_stolpcev = 7;
        private int odmik = 10;
        private Datum datum;

        public Form1()
        {
            
            InitializeComponent();
            ustvari_okvir();
            ustvari_tabelo();
            nastavi_pozicijo();
            this.Size = new Size(DOLZINA, VISINA);
        }

        /// <summary>
        /// Nastavimo pozicijo komponent
        /// </summary>
        private void nastavi_pozicijo()
        {
            // Pozicija tabele
            tabela.Location = new Point((DOLZINA - tabela.Width) / 2, (VISINA - tabela.Height)/ 2);

            // Pozicija okvirja
            okvir.Location = new Point(tabela.Location.X, tabela.Location.Y - velikost_kvadrata);

            // Pozicija comboBox
            comboBox.Location = new Point(okvir.Location.X, tabela.Location.Y - velikost_kvadrata - comboBox.Height - odmik);

            // Pozicija vnosa
            vnos.Location = new Point(comboBox.Location.X + comboBox.Width + 2 * odmik, comboBox.Location.Y);

            // Pozicija gumba
            gumb.Location = new Point(comboBox.Location.X + (stevilo_stolpcev) * (velikost_kvadrata) - gumb.Width, comboBox.Location.Y);

            //Pozicija teksta izberi mesec
            izberi_mesec.Location = new Point(tabela.Location.X, comboBox.Location.Y - 2 * odmik);

            //Pozicija teksta vpisi leto
            vpisi_leto.Location = new Point(vnos.Location.X, comboBox.Location.Y - 2 * odmik);

        }

        /// <summary>
        /// Ustvarimo tabelo, kamor bomo vpisovali datume
        /// </summary>
        private void ustvari_tabelo()
        {
            int stevilo_vrstic = 6;
            tabela.Controls.Clear();
            tabela.RowCount = stevilo_vrstic;
            tabela.ColumnCount = stevilo_stolpcev;
            tabela.Width = velikost_kvadrata * stevilo_stolpcev;
            tabela.Height = velikost_kvadrata * stevilo_vrstic;

            // Set equal column and row sizes
            for (int i = 0; i < tabela.ColumnCount; i++)
            {
                tabela.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, velikost_kvadrata));
            }

            for (int i = 0; i < tabela.RowCount; i++)
            {
                tabela.RowStyles.Add(new RowStyle(SizeType.Absolute, velikost_kvadrata));
            }

            // Add controls to the table cells
            for (int row = 0; row < tabela.RowCount; row++)
            {
                for (int col = 0; col < tabela.ColumnCount; col++)
                {
                    Panel squarePanel = new Panel();
                    squarePanel.BackColor = Color.Teal;
                    squarePanel.Margin = new Padding(1);
                    tabela.Controls.Add(squarePanel, col, row);
                }
            }
        }

        /// <summary>
        /// Dodamo okvir z dnevi v tednu
        /// </summary>
        private void ustvari_okvir()
        {

            okvir.Width = velikost_kvadrata * stevilo_stolpcev;
            okvir.Height = velikost_kvadrata;
            okvir.RowCount = 1;
            okvir.ColumnCount = stevilo_stolpcev;
            okvir.ColumnStyles.Clear();
            okvir.RowStyles.Clear();

            for (int i = 0; i < okvir.ColumnCount; i++)
            {
                okvir.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, velikost_kvadrata));
            }
                
            for (int i = 0; i < okvir.RowCount; i++)
            {
                okvir.RowStyles.Add(new RowStyle(SizeType.Absolute, velikost_kvadrata));
            }

            // Add controls to the table cells
            for (int row = 0; row < okvir.RowCount; row++)
            {
                for (int col = 0; col < okvir.ColumnCount; col++)
                {
                    Panel okno = new Panel();
                    okno.BackColor = Color.BurlyWood;
                    okno.Margin = new Padding(1);

                    System.Windows.Forms.Label tekst = new System.Windows.Forms.Label();
                    tekst.Text = Datum.tabela_dni()[col];
                    tekst.Dock = DockStyle.Fill;
                    tekst.TextAlign = ContentAlignment.MiddleCenter;
                    okno.Controls.Add(tekst);

                    okvir.Controls.Add(okno, col, row);
                }
            }
        }

        /// <summary>
        /// Narišemo dneve na tabelo
        /// </summary>
        private void narisi_dneve()
        {
            //Animacija je brez skokov
            tabela.SuspendLayout();

            int zacetek = datum.dan_v_tednu();
            int konec = Datum.dolzine_mesecev(datum.Leto)[datum.Mesec - 1];

            for (int i = 0; i < 42; i++)
            {
                Panel okno = (Panel)tabela.GetControlFromPosition(i % 7, i / 7);
                System.Windows.Forms.Label tekst = new System.Windows.Forms.Label();

                okno.Controls.Clear();

                if (i >= zacetek && i < konec + zacetek)
                {
                    // Nastavimo barvo za polja, ki so v danem mesecu
                    okno.BackColor = Color.DarkGreen;

                    tekst.Text = (i - zacetek + 1).ToString();
                   

                }
                else 
                {
                    // Nastavimo barvo polja, ki niso v danem mesecu
                    okno.BackColor = Color.Teal;

                    int prejsnji = Datum.prejsnji_mesec(datum.Mesec - 1, datum.Leto);

                    if (i < zacetek)
                    {
                        tekst.Text = (prejsnji - zacetek + i + 1).ToString();
                    }
                    else
                    {
                        tekst.Text = (i + 1 - (zacetek + konec)).ToString();
                    }


                }
                okno.Controls.Add(tekst);
            }
            tabela.ResumeLayout();
        }

        /// <summary>
        /// Preberemo datoteko s prazniki in napolnimo List prazniki
        /// </summary>
        /// <param name="datoteka"></param>
        private void preberi_datoteko(string datoteka)
        {
            try
            {
                string[] vrstice = File.ReadAllLines(datoteka);

                foreach (string vrstica in vrstice)
                {
                    string[] komponente = vrstica.Split(',');
                    Praznik praznik = new Praznik(int.Parse(komponente[0]), komponente[1], komponente.Length > 2 ? int.Parse(komponente[2]) : 1, komponente.Length > 2 ? true : false);
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
        /// Ko kliknemo gumb posodobimo koledar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumb_klik(object sender, EventArgs e)
        {

            datum = new Datum(1, comboBox.Text, int.Parse(vnos.Text));
            preberi_datoteko("prazniki.txt");
            this.narisi_dneve();
            this.Invalidate();
        }

        
    }
}
