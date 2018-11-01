using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Přestřižená_šňůra
{
    public partial class Form1 : Form
    {

        //parametry kružnice
        int xStředuKružnice = 100;
        int yStředuKružnice = 100;
        int poloměrKružnice = 60;

        //parametry kuličky

        double úhel = 0; //Úhel průvodiče ve stupních
        double omega = 80; //Úhlová rychlost ve stupních za sekundu
        double xStředuKuličky, yStředuKuličky;
        double vx, vy;
        int poloměrKuličky = 5;

        //Fáze programu příznak přestřižení
        bool přestřiženo = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void časovač_Tick(object sender, EventArgs e)
        {
            double čas = 0.001 * časovač.Interval;
            if (!přestřiženo)
            {
                //Změna úhlu při kruhovém pohybu
                úhel += omega * čas;

                //Výpočet středu kuličky
                double úhelRad = úhel * Math.PI / 100;
                double rozdílX = poloměrKružnice * Math.Cos(úhelRad);
                double rozdílY = poloměrKružnice * Math.Sin(úhelRad);
                xStředuKuličky = xStředuKružnice + rozdílX;
                yStředuKuličky = yStředuKružnice + rozdílY;
            }
            else
            {
                //Přímočarý pohyb
                xStředuKuličky += vx * čas;
                yStředuKuličky += vy * čas;
            }
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;

            //Souřadnice kuličky do intu

            int xInt = Convert.ToInt32(xStředuKuličky);
            int yInt = Convert.ToInt32(yStředuKuličky);

            //Šňůra

            if (!přestřiženo)
                kp.DrawLine(Pens.CornflowerBlue, xStředuKružnice, yStředuKružnice, xInt, yInt);

            //Kulička
            int xLH = xInt - poloměrKuličky;
            int yLH = yInt - poloměrKuličky;
            int šířka = 2 * poloměrKuličky;
            int výška = šířka;
            kp.FillEllipse(Brushes.CornflowerBlue, xLH, yLH, šířka, výška);
        }

        private void tlPřestřihni_Click(object sender, EventArgs e)
        {

            přestřiženo = true;
            tlPřestřihni.Enabled = false;
            tlZnovu.Enabled = true;

            //Výpočet rychlosti přímočarého pohybu
            double omegaRadS = omega * Math.PI / 180;
            double rychlost = omegaRadS * poloměrKružnice;
            double směrRychlosti = úhel + 90;
            double směrRad = směrRychlosti * Math.PI / 180;
            vx = rychlost * Math.Cos(směrRad);
            vy = rychlost * Math.Sin(směrRad);

        }

        private void tlZnovu_Click(object sender, EventArgs e)
        {

            přestřiženo = false;
            úhel = 0;
            tlPřestřihni.Enabled = true;
            tlZnovu.Enabled = true;


        }
    }
}
