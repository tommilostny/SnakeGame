using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using SnakeGame.Properties;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        string direction = "right";
        bool change_direction = false;
        ulong score = 0;
        ulong highscore;
        uint score_rate;
        Random random = new Random();
        int x_food, y_food;

        List<PictureBox> pictureBoxes = new List<PictureBox>();
        PictureBox body_refPB = new PictureBox();
        List<int> x_body_points = new List<int>();
        List<int> y_body_points = new List<int>();

        Dictionary<string, Bitmap> pictures = new Dictionary<string, Bitmap>();

        int[] x_food_spawnpoints = new int[20];
        int[] y_food_spawnpoints = new int[10];

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += Form1_KeyDown;
            highscore = LoadHighscore();

            pictures.Add("head_right", new Bitmap(Resources.hlava_doprava));
            pictures.Add("head_left", new Bitmap(Resources.hlava_doleva));
            pictures.Add("head_up", new Bitmap(Resources.hlava_nahoru));
            pictures.Add("head_down", new Bitmap(Resources.hlava_dolu));
            pictures.Add("body", new Bitmap(Resources.body));

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

        public void NewGame()//Inicializace výchozích hodnot + start nové hry
        {
            pcbHead.Location = new Point(300, 120);//Výchozí pozice hlavy
            pcbHead.Image = pictures["head_right"];
            direction = "right";

            score = 0;
            labelScore.Text = "SCORE: " + score.ToString();
            labelHs.Text = "HIGHSCORE: " + highscore.ToString();

            GenerateFood();

            pictureBoxes = new List<PictureBox>();
            x_body_points = new List<int>();
            y_body_points = new List<int>();

            panelGame.Controls.Clear();
            panelGame.Controls.Add(pcbFood);
            panelGame.Controls.Add(pcbHead);

            //První dílek těla ve výchozí pozici za hlavou
            x_body_points.Add(270);
            y_body_points.Add(120);
            GenerateBodyPart();
            
            timer1.Interval = (trackBar1.Value + 10) * 15;
            score_rate = (uint)Math.Floor((40.0 - (double)trackBar1.Value * 1.88));
            timer1.Start();
        }

        private void GameOver()
        {
            timer1.Stop();
            panelGameOver.Visible = true;
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

        private bool Food_OK(int xs, int ys)
        {
            for (int i = 0; i < x_body_points.Count(); i++)
            {
                if ((xs == x_body_points[i] && ys == y_body_points[i]) || (xs == pcbHead.Location.X && ys == pcbHead.Location.Y))
                    return false;
            }
            return true;
        }

        private void GenerateFood()
        {
            do {
                y_food = y_food_spawnpoints[random.Next(0, 10)];
                x_food = x_food_spawnpoints[random.Next(0, 20)];
            }
            while (!Food_OK(x_food, y_food));
            pcbFood.Location = new Point(x_food, y_food);
        }

        private void GenerateBodyPart()
        {
            PictureBox pb = new PictureBox();

            pb.Location = new Point(x_body_points[x_body_points.Count() - 1], y_body_points[x_body_points.Count() - 1]);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Image = pictures["body"];
            pb.Size = pcbHead.Size;
            panelGame.Controls.Add(pb);

            pictureBoxes.Add(pb);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pcbHead.Location.X;
            int y = pcbHead.Location.Y;

            if (pictureBoxes.Count > 0)//Pohyb těla hada
            {
                pictureBoxes.Last().Location = pcbHead.Location;
                pictureBoxes.Insert(0, pictureBoxes.Last());
                pictureBoxes.RemoveAt(pictureBoxes.Count - 1);
            }

            x_body_points.Add(x);
            y_body_points.Add(y);

            switch (direction)
            {
                case "right":
                    if (change_direction)
                        pcbHead.Image = pictures["head_right"];
                    x += 30;
                    break;
                case "left":
                    if (change_direction)
                            pcbHead.Image = pictures["head_left"];
                    x -= 30;
                    break;
                case "up":
                    if (change_direction)
                            pcbHead.Image = pictures["head_up"];
                    y -= 30;
                    break;
                case "down":
                    if (change_direction)
                            pcbHead.Image = pictures["head_down"];
                    y += 30;
                    break;
                default:
                    break;
            }

            if (x >= 600 || x < 0 || y >= 300 || y < 0) GameOver();//Náraz do stěny
            else pcbHead.Location = new Point(x, y);//Pohyb hlavy hada

            if (x == x_food && y == y_food)//Spolnutí sousta
            {
                score += score_rate;
                labelScore.Text = "SCORE: " + score.ToString();
                GenerateBodyPart();
                GenerateFood();
            }
            else
            {
                foreach (PictureBox item in pictureBoxes)
                {
                    if (item.Location.X == x && item.Location.Y == y) GameOver();//Náraz do těla hada
                }
            }

            while (x_body_points.Count > pictureBoxes.Count)
            {
                x_body_points.Remove(x_body_points.First());
                y_body_points.Remove(y_body_points.First());
            }

            change_direction = false;
        }

        private void buttonNovaHra_Click(object sender, EventArgs e)//Tlačítko "Nová hra"
        {
            panelMenu.Visible = false;
            NewGame();
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
            panelGameOver.Visible = false;
            NewGame();
        }

        private void buttonKonecNe_Click(object sender, EventArgs e)//Tlačítko "Zpět do menu" při konci hry
        {
            panelGameOver.Visible = false;
            panelMenu.Visible = true;
            buttonNovaHra.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) && direction != "left" && !change_direction)
            {
                change_direction = true;
                direction = "right";
            }
            else if ((e.KeyCode == Keys.A || e.KeyCode == Keys.Left) && direction != "right" && !change_direction)
            {
                change_direction = true;
                direction = "left";
            }
            else if ((e.KeyCode == Keys.W || e.KeyCode == Keys.Up) && direction != "down" && !change_direction)
            {
                change_direction = true;
                direction = "up";
            }
            else if ((e.KeyCode == Keys.S || e.KeyCode == Keys.Down) && direction != "up" && !change_direction)
            {
                change_direction = true;
                direction = "down";
            }
        }
    }
}
