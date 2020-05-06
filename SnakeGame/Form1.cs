using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        string smer = "doprava";
        bool zmena_smeru = false;
        ulong score = 0;
        ulong highscore;
        uint score_rate;
        Random random = new Random();
        int x_food, y_food;

        List<PictureBox> pictureBoxes = new List<PictureBox>();
        List<int> x_souradnice = new List<int>();
        List<int> y_souradnice = new List<int>();
        int delka_hada = 1;

        Dictionary<string, Bitmap> pictures = new Dictionary<string, Bitmap>();

        int[] x_food_spawnpoints = new int[20];
        int[] y_food_spawnpoints = new int[10];

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            highscore = LoadHighscore();

            pictures.Add("head_right", new Bitmap("obr/hlava_doprava1.bmp"));
            pictures.Add("head_left", new Bitmap("obr/hlava_doleva.bmp"));
            pictures.Add("head_up", new Bitmap("obr/hlava_nahoru.bmp"));
            pictures.Add("head_down", new Bitmap("obr/hlava_dolu.bmp"));
            pictures.Add("body", new Bitmap("obr/body1.bmp"));

            for (int i = 0; i < x_food_spawnpoints.Length; i++)
            {
                x_food_spawnpoints[i] = i * 30;

                if (i < y_food_spawnpoints.Length)
                    y_food_spawnpoints[i] = i * 30;
            }
        }

        private ulong LoadHighscore()
        {
            if (File.Exists("highscore.txt"))
                return Convert.ToUInt64(File.ReadAllText("highscore.txt"));
            else
            {
                StreamWriter sw = new StreamWriter("highscore.txt", false);
                sw.WriteLine("0");
                sw.Close();
            }
            return 0;
        }

        private void NacistObrazek(string key, PictureBox pictureBox)
        {
            pictureBox.Image = pictures[key];
        }

        public void NovaHra()//Inicializace výchozích hodnot + start nové hry
        {
            pcbHlava.Location = new Point(300, 120);//Výchozí pozice hlavy
            NacistObrazek("head_right", pcbHlava);
            smer = "doprava";

            score = 0;
            labelScore.Text = "SCORE: " + score.ToString();
            labelHs.Text = "HIGHSCORE: " + highscore.ToString();

            GenerovatJidlo();

            pictureBoxes = new List<PictureBox>();
            x_souradnice = new List<int>();
            y_souradnice = new List<int>();

            panelGame.Controls.Clear();
            panelGame.Controls.Add(pcbFood);
            panelGame.Controls.Add(pcbHlava);

            delka_hada = 1;//První dílek těla ve výchozí pozici za hlavou
            x_souradnice.Add(270);
            y_souradnice.Add(120);
            GenerovatTelo();
            
            timer1.Interval = (trackBar1.Value + 10) * 15;
            score_rate = (uint)Math.Floor((40.0 - (double)trackBar1.Value * 1.88));
            timer1.Start();
        }

        private void KonecHry()
        {
            timer1.Stop();
            panelKonecHry.Visible = true;
            if (score > highscore)
            {
                highscore = score;
                StreamWriter File = new StreamWriter("highscore.txt");
                File.Write(score.ToString());
                File.Close();
                labelKonecScore.Text = "Nové nejvyšší skóre: " + score.ToString();
            }
            else labelKonecScore.Text = "Vaše skóre: " + score.ToString();

            buttonKonecAno.Focus();
        }

        private bool JidloOK(int xs, int ys)
        {
            for (int i = 0; i < x_souradnice.Count(); i++)
            {
                if ((xs == x_souradnice[i] && ys == y_souradnice[i]) || (xs == pcbHlava.Location.X && ys == pcbHlava.Location.Y))
                    return false;
            }
            return true;
        }

        private void GenerovatJidlo()
        {
            do {
                y_food = y_food_spawnpoints[random.Next(0, 10)];
                x_food = x_food_spawnpoints[random.Next(0, 20)];
            }
            while (!JidloOK(x_food, y_food));
            pcbFood.Location = new Point(x_food, y_food);
        }

        private void GenerovatTelo()
        {
            pictureBoxes.Add(new PictureBox());
            int i = delka_hada - 1;
            pictureBoxes[i].Anchor = (AnchorStyles.Top);
            pictureBoxes[i].Location = new Point(x_souradnice[x_souradnice.Count() - 1], y_souradnice[x_souradnice.Count() - 1]);
            pictureBoxes[i].SizeMode = PictureBoxSizeMode.Zoom;
            NacistObrazek("body", pictureBoxes[i]);
            pictureBoxes[i].Size = pcbHlava.Size;
            pictureBoxes[i].TabIndex = 1;
            pictureBoxes[i].TabStop = true;
            panelGame.Controls.Add(pictureBoxes[i]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pcbHlava.Location.X;
            int y = pcbHlava.Location.Y;

            if (delka_hada > 0)//Pohyb těla hada
            {
                pictureBoxes[delka_hada - 1].Location = pcbHlava.Location;
                pictureBoxes.Insert(0, pictureBoxes.Last());
                pictureBoxes.RemoveAt(delka_hada);
            }

            x_souradnice.Add(x);
            y_souradnice.Add(y);

            switch (smer)
            {
                case "doprava":
                    if (zmena_smeru) NacistObrazek("head_right", pcbHlava);
                    x += 30;
                    break;
                case "doleva":
                    if (zmena_smeru) NacistObrazek("head_left", pcbHlava);
                    x -= 30;
                    break;
                case "nahoru":
                    if (zmena_smeru) NacistObrazek("head_up", pcbHlava);
                    y -= 30;
                    break;
                case "dolu":
                    if (zmena_smeru) NacistObrazek("head_down", pcbHlava);
                    y += 30;
                    break;
                default:
                    break;
            }

            if (x >= 600 || x < 0 || y >= 300 || y < 0) KonecHry();//Náraz do stěny
            else pcbHlava.Location = new Point(x, y);//Pohyb hlavy hada

            foreach (PictureBox item in pictureBoxes)
            {
                if (item.Location.X == x && item.Location.Y == y) KonecHry();//Náraz do těla hada
            }

            if (x == x_food && y == y_food)//Spolnutí sousta
            {
                score += score_rate;
                labelScore.Text = "SCORE: " + score.ToString();
                delka_hada++;
                GenerovatTelo();
                GenerovatJidlo();
            }

            while (x_souradnice.Count() > delka_hada)
            {
                x_souradnice.Remove(x_souradnice.First());
                y_souradnice.Remove(y_souradnice.First());
            }

            zmena_smeru = false;
        }

        private void buttonNovaHra_Click(object sender, EventArgs e)//Tlačítko "Nová hra"
        {
            panelMenu.Visible = false;
            NovaHra();
        }

        private void buttonKonec_Click(object sender, EventArgs e)//Tlačítko "Konec"
        {
            Close();
        }

        private void buttonJakHrat_Click(object sender, EventArgs e)//Tlačítko "Jak hrát?"
        {
            Process.Start("Snake.pdf");
        }

        private void buttonKonecAno_Click(object sender, EventArgs e)//Tlačítko "Nová hra" při konci hry
        {
            panelKonecHry.Visible = false;
            NovaHra();
        }

        private void buttonKonecNe_Click(object sender, EventArgs e)//Tlačítko "Zpět do menu" při konci hry
        {
            panelKonecHry.Visible = false;
            panelMenu.Visible = true;
            buttonNovaHra.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) && smer != "doleva" && !zmena_smeru)
            {
                zmena_smeru = true;
                smer = "doprava";
            }
            else if ((e.KeyCode == Keys.A || e.KeyCode == Keys.Left) && smer != "doprava" && !zmena_smeru)
            {
                zmena_smeru = true;
                smer = "doleva";
            }
            else if ((e.KeyCode == Keys.W || e.KeyCode == Keys.Up) && smer != "dolu" && !zmena_smeru)
            {
                zmena_smeru = true;
                smer = "nahoru";
            }
            else if ((e.KeyCode == Keys.S || e.KeyCode == Keys.Down) && smer != "nahoru" && !zmena_smeru)
            {
                zmena_smeru = true;
                smer = "dolu";
            }
        }
    }
}
