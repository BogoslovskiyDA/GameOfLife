using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;
        private GameEngine gameEngine;
        Statistic statistic;
        public Form1()
        {
            InitializeComponent();
            BPause.Enabled = false;
            BStop.Enabled = false;
        }

        private void StartGame()
        {
            //if (Timer.Enabled)
            //    return;

            nudResolution.Enabled = false;
            nudDensity.Enabled = false;
            resolution = (int)nudResolution.Value;
            BPause.Enabled = true;
            BStop.Enabled = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            gameEngine = new GameEngine
            (
                rows: pictureBox.Height / resolution,
                cols: pictureBox.Width / resolution,
                density: (int)(nudDensity.Minimum) + (int)(nudDensity.Maximum) - (int)(nudDensity.Value)
            );

            Text = $"Generation {gameEngine.CurrentGeneration}";

            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(pictureBox.Image);
            label3.Text = "Living Cells : " + gameEngine.LivingCells();
            label4.Text = "Generation : " + gameEngine.CurrentGeneration;
            Timer.Start();
        }

        private void DrawNextGeneration()
        {
            graphics.Clear(Color.Black);

            //Brush brushes = new SolidBrush(Color.FromArgb(255, 255, 255, 255));

            var field = gameEngine.GetCurrentGeneration();

            for (int x = 0; x < field.GetLength(0); x++)
            {
                for (int y = 0; y < field.GetLength(1); y++)
                {
                    if (field[x, y])
                        graphics.FillRectangle(Brushes.White, x * resolution, y * resolution, resolution - 1, resolution - 1);
                }
            }

            pictureBox.Refresh();
            Text = $"Generation {gameEngine.CurrentGeneration}";
            label3.Text = "Living Cells : " + gameEngine.LivingCells();
            label4.Text = "Generation : " + gameEngine.CurrentGeneration;
            gameEngine.NextGeneration();
        }

        private void StopGame()
        {
            //if (!Timer.Enabled)
            //    return;
            Timer.Stop();
            nudResolution.Enabled = true;
            nudDensity.Enabled = true;
            BStart.Enabled = true;
            BPause.Enabled = false;
            FormBorderStyle = FormBorderStyle.Sizable;

            gameEngine.RemoveField();
            graphics.Clear(SystemColors.Control);
            Text = "GameOfLife";
            label3.Text = "Generation : 0";
            label4.Text = "Living Cell : 0";
            GetStatistic();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DrawNextGeneration();
            GetStatistic();
        }

        private void BStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void BStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Timer.Enabled)
                return;

            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                gameEngine.AddCell(x, y);
            }
            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                gameEngine.RemoveCell(x, y);
            }
        }

        private void ShowStatistic_Click(object sender, EventArgs e)
        {
            statistic = new Statistic();
            statistic.Show();
        }

        private void GetStatistic()
        {
            if (statistic == null)
                return;
            statistic.LCells = gameEngine.LivingCells();
        }

        private void BPause_Click(object sender, EventArgs e)
        {
            BPause.Width = 37;
            if (Timer.Enabled)
            {
                Timer.Stop();
                //BStart.Enabled = true;
                BPause.Text = "▶️";
            }
            else
            {
                Timer.Start();
                BPause.Text = "⏸️";
            }
        }
    }
}
