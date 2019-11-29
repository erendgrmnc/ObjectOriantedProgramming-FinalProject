/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2018-2018 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: PROJE
**				ÖĞRENCİ ADI............: SALİH EREN DEĞİRMENCİ
**				ÖĞRENCİ NUMARASI.......: G181210017
**                         DERSİN ALINDIĞI GRUP...:
****************************************************************************/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace NDP_PROJECT_1._0
{
    public partial class Coop : Form
    {

        Chicken Chicken1 = new Chicken();
        Duck Duck1 = new Duck();
        Cow Cow1 = new Cow();
        Goat Goat1 = new Goat();
        
       


        int elapsed_Time = 0;
        public int Cash = 0;



        public Coop()
        {
            InitializeComponent();
            
            #region Timers
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();

            timerChicken.Enabled = true;
            timerChicken.Interval = 3000;
            timerChicken.Start();

            timerDuck.Enabled = true;
            timerDuck.Interval = 5000;
            timerDuck.Start();

            timerCow.Enabled = true;
            timerCow.Interval = 8000;
            timerCow.Start();

            timerGoat.Enabled = true;
            timerGoat.Interval = 7000;
            timerGoat.Start();

            timerCowDeath.Enabled = true;
            timerCowDeath.Interval = 1000;
            timerCowDeath.Start();

            timerChickenDeath.Enabled = true;
            timerChickenDeath.Interval = 1000;
            timerChickenDeath.Start();

            timerDuckDeath.Enabled = true;
            timerDuckDeath.Interval = 1000;
            timerDuckDeath.Start();

            timerGoatDeath.Enabled = true;
            timerGoatDeath.Interval = 1000;
            timerGoatDeath.Start(); 
            #endregion


        }

  
        private void Form1_Load(object sender, EventArgs e)
        {
           
            //Chicken 
            prgrsChicken.Maximum = Chicken1.health;
            prgrsChicken.Minimum = 0;
            prgrsChicken.Value = Chicken1.health;

         

            //Duck
            prgrsDuck.Maximum = Duck1.health;
            prgrsDuck.Minimum = 0;
            prgrsDuck.Value = Duck1.health;
            
           

            //COW
            prgrsCow.Maximum = Cow1.health;
            prgrsCow.Minimum = 0;
            prgrsCow.Value = Cow1.health;

            



            //GOAT
            prgrsGoat.Maximum = Goat1.health;
            prgrsGoat.Minimum = 0;
            prgrsGoat.Value = Goat1.health;

          

          
           
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            

            elapsed_Time++;

            lblElapsedTime.Text = Convert.ToString(elapsed_Time + " second");
            lblCash.Text = Convert.ToString(Cash + " $");


            lblChickenEgg.Text = Convert.ToString(Chicken1.chickenEgg);
            lblDuckEgg.Text = Convert.ToString(Duck1.duckEgg);
            lblCowMilk.Text = Convert.ToString(Cow1.cowMilk);
            lblGoatMilk.Text = Convert.ToString(Goat1.goatMilk);

            //CHİCKEN 

            if (prgrsChicken.Value > 0)
            {
                prgrsChicken.Value -= 2;
            }

            else if (prgrsChicken.Value == 0)
            {

                btnFeedChicken.Enabled = false;
                lblChickenStatus.Text = "DEAD";
                prgrsChicken.Enabled = false;

            }

            //DUCK

            if (prgrsDuck.Value > 1)
            {
                prgrsDuck.Value -= 3;
            }

            else if (prgrsDuck.Value <= 1)
            {
                prgrsDuck.Value = 0;
                prgrsDuck.Enabled = false;
                Duck1.health = 0;
                lblDuckStatus.Text = "DEAD";

            }


            //COW
            if (prgrsCow.Value > 4)
            {
                prgrsCow.Value -= 8;
            }
            else if (prgrsCow.Value <= 4)
            {
                prgrsCow.Value = 0;

                Cow1.health = 0;

                lblCowStatus.Text = "DEAD";

            }


            //GOAT

            if (prgrsGoat.Value > 4)
            {

                prgrsGoat.Value -= 6;
            }

            else if (prgrsGoat.Value <= 4)

            {
                prgrsGoat.Value = 0;
                prgrsGoat.Enabled = false;
                Goat1.health = 0;
                lblGoatStatus.Text = "DEAD";

            }



        }
        

        private void btnFeedChicken_Click(object sender, EventArgs e)
        {
            if (prgrsChicken.Value != prgrsChicken.Minimum)
            {
                prgrsChicken.Value = 100;
            }
            
        }

        private void btnFeedDuck_Click(object sender, EventArgs e)
        {
            if (prgrsDuck.Value != prgrsDuck.Minimum)
            {
                prgrsDuck.Value = 100;
            }
            
        }

        private void btnFeedCow_Click(object sender, EventArgs e)
        {
            if (prgrsCow.Value != prgrsCow.Minimum)
            {
                prgrsCow.Value = 100;
            }
           
        }

        private void btnFeedGoat_Click(object sender, EventArgs e)
        {
            if (prgrsGoat.Value != prgrsGoat.Minimum)
            {
                prgrsGoat.Value = 100;
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
         
                Chicken1.Increase(); 
           
        }

        private void timerDuck_Tick(object sender, EventArgs e)
        {

            Duck1.Increase();
            
        }

        private void timerCow_Tick(object sender, EventArgs e)
        {
            Cow1.Increase();
            
          
           
        }

        private void timerGoat_Tick(object sender, EventArgs e)
        {

            Goat1.Increase();
            
           
            
        }

        private void btnSellChickenEgg_Click(object sender, EventArgs e)
        {
            if (Chicken1.chickenEgg > 0)
            {
                Chicken1.Sell();
                Cash += 1;
            }
            

            
        }

        private void btnSellDuckEgg_Click(object sender, EventArgs e)
        {
            if (Duck1.duckEgg > 0)
            {
                Duck1.Sell();
                Cash += 3;
            }
            
        }

        private void btnSellCowMilk_Click(object sender, EventArgs e)
        {
           
            if (Cow1.cowMilk > 0)
            {
                Cow1.Sell();
                Cash += 5;
            }
        }

        private void btnSellGoatMilk_Click(object sender, EventArgs e)
        {
            if (Goat1.goatMilk > 0)
            {
                Goat1.Sell();
                Cash += 7;
            }
        }

      

        private void timerCowDeath_Tick(object sender, EventArgs e)
        {
            if (lblCowStatus.Text == "DEAD")
            {
                Cow1.isAlive = false;
                Cow1.death(Cow1.isAlive);
                timerCowDeath.Stop();
            }
        }

        private void timerGoatDeath_Tick(object sender, EventArgs e)
        {
            if (lblGoatStatus.Text == "DEAD")
            {
                Goat1.isAlive = false;
                Goat1.death(Goat1.isAlive);
                timerGoatDeath.Stop();
            }
        }

        private void timerChickenDeath_Tick(object sender, EventArgs e)
        {
            if (lblChickenStatus.Text == "DEAD")
            {
                Chicken1.isAlive = false;
                Chicken1.death(Chicken1.isAlive);
                timerChickenDeath.Stop();
            }
        }

        private void timerDuckDeath_Tick(object sender, EventArgs e)
        {
            if (lblDuckStatus.Text =="DEAD")
            {
                Duck1.isAlive = false;
                Duck1.death(Duck1.isAlive);
                timerDuckDeath.Stop();
            }
        }
    }
}
