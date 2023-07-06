using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Koledar
{

    public class Gumb : Button
    {
        // Polja
        private int velikostOkvirja = 0;
        private int radijOkvirja = 0;
        private Color barvaOkvirja = Color.PaleVioletRed;

        // Lastnosti
        [Category("Custom nastavitve")]
        public int VelikostOkvirja
        {
            get { return velikostOkvirja; }
            set
            {
                velikostOkvirja = value;
                this.Invalidate();
            }
        }

        [Category("Custom nastavitve")]
        public int RadijOkvirja
        {
            get { return radijOkvirja; }
            set
            {
                radijOkvirja = value;
                this.Invalidate();
            }
        }

        [Category("Custom nastavitve")]
        public Color BarvaOkvirja
        {
            get { return barvaOkvirja; }
            set
            {
                barvaOkvirja = value;
                this.Invalidate();
            }
        }

        [Category("Custom nastavitve")]
        public Color BarvaOzadja
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("Custom nastavitve")]
        public Color BarvaTeksta
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        // Konstruktor
        public Gumb()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(SpremembaVelikostiGumba);
        }

        // Metode
        private GraphicsPath DobiPozicijoFigure(Rectangle pravokotnik, int radij)
        {
            GraphicsPath pot = new GraphicsPath();
            float velikostKrivulje = radij * 2F;

            pot.StartFigure();
            pot.AddArc(pravokotnik.X, pravokotnik.Y, velikostKrivulje, velikostKrivulje, 180, 90);
            pot.AddArc(pravokotnik.Right - velikostKrivulje, pravokotnik.Y, velikostKrivulje, velikostKrivulje, 270, 90);
            pot.AddArc(pravokotnik.Right - velikostKrivulje, pravokotnik.Bottom - velikostKrivulje, velikostKrivulje, velikostKrivulje, 0, 90);
            pot.AddArc(pravokotnik.X, pravokotnik.Bottom - velikostKrivulje, velikostKrivulje, velikostKrivulje, 90, 90);
            pot.CloseFigure();
            return pot;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            Rectangle povrsinaPravokotnika = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(povrsinaPravokotnika, -velikostOkvirja, -velikostOkvirja);
            int gladkost = 2;
            if (velikostOkvirja > 0)
                gladkost = velikostOkvirja;

            if (radijOkvirja > 2) // Okrogel gumb
            {
                using (GraphicsPath potPovrsine = DobiPozicijoFigure(povrsinaPravokotnika, radijOkvirja))
                using (GraphicsPath potOkvirja = DobiPozicijoFigure(rectBorder, radijOkvirja - velikostOkvirja))
                using (Pen pS = new Pen(this.Parent.BackColor, gladkost))
                using (Pen pB = new Pen(barvaOkvirja, velikostOkvirja))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    this.Region = new Region(potPovrsine);
                    e.Graphics.DrawPath(pS, potPovrsine);

                    // Okvir gumba               
                    if (velikostOkvirja >= 1)
                        // Nariši okvir
                        e.Graphics.DrawPath(pB, potOkvirja);
                }
            }
            else // Normalen gumb
            {
                e.Graphics.SmoothingMode = SmoothingMode.None;

                // Površina gumba
                this.Region = new Region(povrsinaPravokotnika);

                // Okvir gumb
                if (velikostOkvirja >= 1)
                {
                    using (Pen pB = new Pen(barvaOkvirja, velikostOkvirja))
                    {
                        pB.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(pB, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Kontejner_spremembaBarve);
        }

        private void Kontejner_spremembaBarve(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void SpremembaVelikostiGumba(object sender, EventArgs e)
        {
            if (radijOkvirja > this.Height)
                radijOkvirja = this.Height;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}