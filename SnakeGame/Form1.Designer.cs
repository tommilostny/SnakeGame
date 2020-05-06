using SnakeGame.Properties;
using System.Drawing;

namespace SnakeGame
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelScore = new System.Windows.Forms.Label();
            this.panelGame = new System.Windows.Forms.Panel();
            this.pcbFood = new System.Windows.Forms.PictureBox();
            this.pcbHead = new System.Windows.Forms.PictureBox();
            this.labelHs = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panelGameOver = new System.Windows.Forms.Panel();
            this.labelKonecScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKonecNe = new System.Windows.Forms.Button();
            this.buttonKonecAno = new System.Windows.Forms.Button();
            this.buttonJakHrat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonKonec = new System.Windows.Forms.Button();
            this.buttonNovaHra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHead)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panelGameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelScore.Location = new System.Drawing.Point(18, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(141, 31);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "SCORE: 0";
            // 
            // panelGame
            // 
            this.panelGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelGame.BackColor = System.Drawing.Color.Transparent;
            this.panelGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGame.Controls.Add(this.pcbFood);
            this.panelGame.Controls.Add(this.pcbHead);
            this.panelGame.Location = new System.Drawing.Point(22, 46);
            this.panelGame.Margin = new System.Windows.Forms.Padding(13);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(600, 300);
            this.panelGame.TabIndex = 2;
            // 
            // pcbFood
            // 
            this.pcbFood.BackColor = System.Drawing.Color.Transparent;
            this.pcbFood.Image = new Bitmap(Resources.apple);
            this.pcbFood.Location = new System.Drawing.Point(0, 0);
            this.pcbFood.Margin = new System.Windows.Forms.Padding(0);
            this.pcbFood.Name = "pcbFood";
            this.pcbFood.Size = new System.Drawing.Size(30, 30);
            this.pcbFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbFood.TabIndex = 3;
            this.pcbFood.TabStop = false;
            // 
            // pcbHlava
            // 
            this.pcbHead.Image = ((System.Drawing.Image)(resources.GetObject("pcbHlava.Image")));
            this.pcbHead.Location = new System.Drawing.Point(300, 120);
            this.pcbHead.Name = "pcbHlava";
            this.pcbHead.Size = new System.Drawing.Size(30, 30);
            this.pcbHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbHead.TabIndex = 1;
            this.pcbHead.TabStop = false;
            // 
            // labelHs
            // 
            this.labelHs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHs.BackColor = System.Drawing.Color.Transparent;
            this.labelHs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelHs.Location = new System.Drawing.Point(226, 9);
            this.labelHs.Name = "labelHs";
            this.labelHs.Size = new System.Drawing.Size(396, 24);
            this.labelHs.TabIndex = 3;
            this.labelHs.Text = "HIGHSCORE:";
            this.labelHs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.buttonJakHrat);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.groupBox1);
            this.panelMenu.Controls.Add(this.buttonKonec);
            this.panelMenu.Controls.Add(this.buttonNovaHra);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Location = new System.Drawing.Point(12, 12);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(620, 343);
            this.panelMenu.TabIndex = 4;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Green;
            this.trackBar1.Location = new System.Drawing.Point(6, 50);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar1.Size = new System.Drawing.Size(210, 56);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 5;
            // 
            // panelKonecHry
            // 
            this.panelGameOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelGameOver.BackColor = System.Drawing.Color.Transparent;
            this.panelGameOver.Controls.Add(this.labelKonecScore);
            this.panelGameOver.Controls.Add(this.label2);
            this.panelGameOver.Controls.Add(this.buttonKonecNe);
            this.panelGameOver.Controls.Add(this.buttonKonecAno);
            this.panelGameOver.Location = new System.Drawing.Point(2, 7);
            this.panelGameOver.Name = "panelKonecHry";
            this.panelGameOver.Size = new System.Drawing.Size(642, 343);
            this.panelGameOver.TabIndex = 6;
            this.panelGameOver.Visible = false;
            // 
            // labelKonecScore
            // 
            this.labelKonecScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelKonecScore.Location = new System.Drawing.Point(0, 147);
            this.labelKonecScore.Name = "labelKonecScore";
            this.labelKonecScore.Size = new System.Drawing.Size(642, 31);
            this.labelKonecScore.TabIndex = 6;
            this.labelKonecScore.Text = "Vaše skóre:";
            this.labelKonecScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label2.Location = new System.Drawing.Point(124, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 95);
            this.label2.TabIndex = 4;
            this.label2.Text = "Konec hry";
            // 
            // buttonKonecNe
            // 
            this.buttonKonecNe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonKonecNe.BackColor = System.Drawing.Color.Green;
            this.buttonKonecNe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKonecNe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.buttonKonecNe.ForeColor = System.Drawing.Color.Lime;
            this.buttonKonecNe.Location = new System.Drawing.Point(329, 205);
            this.buttonKonecNe.Name = "buttonKonecNe";
            this.buttonKonecNe.Size = new System.Drawing.Size(216, 38);
            this.buttonKonecNe.TabIndex = 3;
            this.buttonKonecNe.Text = "Zpět do menu";
            this.buttonKonecNe.UseVisualStyleBackColor = false;
            this.buttonKonecNe.Click += new System.EventHandler(this.buttonKonecNe_Click);
            // 
            // buttonKonecAno
            // 
            this.buttonKonecAno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonKonecAno.BackColor = System.Drawing.Color.Green;
            this.buttonKonecAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKonecAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.buttonKonecAno.ForeColor = System.Drawing.Color.Lime;
            this.buttonKonecAno.Location = new System.Drawing.Point(107, 205);
            this.buttonKonecAno.Name = "buttonKonecAno";
            this.buttonKonecAno.Size = new System.Drawing.Size(216, 38);
            this.buttonKonecAno.TabIndex = 2;
            this.buttonKonecAno.Text = "Nová hra";
            this.buttonKonecAno.UseVisualStyleBackColor = false;
            this.buttonKonecAno.Click += new System.EventHandler(this.buttonKonecAno_Click);
            // 
            // buttonJakHrat
            // 
            this.buttonJakHrat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonJakHrat.BackColor = System.Drawing.Color.Green;
            this.buttonJakHrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJakHrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.buttonJakHrat.ForeColor = System.Drawing.Color.Lime;
            this.buttonJakHrat.Location = new System.Drawing.Point(79, 248);
            this.buttonJakHrat.Name = "buttonJakHrat";
            this.buttonJakHrat.Size = new System.Drawing.Size(197, 38);
            this.buttonJakHrat.TabIndex = 5;
            this.buttonJakHrat.Text = "Konec";
            this.buttonJakHrat.UseVisualStyleBackColor = false;
            this.buttonJakHrat.Click += new System.EventHandler(this.buttonKonec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(312, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 112);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Výběr obtížnosti";
            // 
            // buttonKonec
            // 
            this.buttonKonec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonKonec.BackColor = System.Drawing.Color.Green;
            this.buttonKonec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKonec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.buttonKonec.ForeColor = System.Drawing.Color.Lime;
            this.buttonKonec.Location = new System.Drawing.Point(79, 204);
            this.buttonKonec.Name = "buttonKonec";
            this.buttonKonec.Size = new System.Drawing.Size(197, 38);
            this.buttonKonec.TabIndex = 2;
            this.buttonKonec.Text = "Jak hrát?";
            this.buttonKonec.UseVisualStyleBackColor = false;
            this.buttonKonec.Click += new System.EventHandler(this.buttonJakHrat_Click);
            // 
            // buttonNovaHra
            // 
            this.buttonNovaHra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonNovaHra.BackColor = System.Drawing.Color.Green;
            this.buttonNovaHra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovaHra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.buttonNovaHra.ForeColor = System.Drawing.Color.Lime;
            this.buttonNovaHra.Location = new System.Drawing.Point(79, 160);
            this.buttonNovaHra.Name = "buttonNovaHra";
            this.buttonNovaHra.Size = new System.Drawing.Size(197, 38);
            this.buttonNovaHra.TabIndex = 1;
            this.buttonNovaHra.Text = "Nová hra";
            this.buttonNovaHra.UseVisualStyleBackColor = false;
            this.buttonNovaHra.Click += new System.EventHandler(this.buttonNovaHra_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 189);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snake";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Snadná";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.Location = new System.Drawing.Point(175, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Těžká";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = global::SnakeGame.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(644, 367);
            this.Controls.Add(this.panelGameOver);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.labelHs);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.labelScore);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(660, 406);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake - Tomáš Milostný, PSA3";
            this.panelGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHead)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panelGameOver.ResumeLayout(false);
            this.panelGameOver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.PictureBox pcbHead;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox pcbFood;
        private System.Windows.Forms.Label labelHs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonKonec;
        private System.Windows.Forms.Button buttonNovaHra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonJakHrat;
        private System.Windows.Forms.Panel panelGameOver;
        private System.Windows.Forms.Label labelKonecScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonKonecNe;
        private System.Windows.Forms.Button buttonKonecAno;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

