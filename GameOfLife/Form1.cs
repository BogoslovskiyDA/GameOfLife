using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;
        private GameEngine gameEngine;
        Statistic statistic;
        OptionForm optionForm;
        public MyBrushColor myBrush = new MyBrushColor(255, 255, 255);
        Brush brush;
        public Form1()
        {
            InitializeComponent();
            BPause.Enabled = false;
            BStop.Enabled = false;
            MSSaveGame.Enabled = false;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void StartGame()
        {
            BPause.Enabled = true;
            BStop.Enabled = true;
            MSSaveGame.Enabled = false;
            BPause.Text = "⏸️";
            FormBorderStyle = FormBorderStyle.FixedSingle;

            NewGameEngine();

            brush = new SolidBrush(Color.FromArgb(255, myBrush.Red, myBrush.Green, myBrush.Blue));

            LivingCellsText.Text = "Living Cells : " + gameEngine.LivingCells();
            GenerationText.Text = "Generation : " + gameEngine.CurrentGeneration;
            Timer.Start();
        }

        private void DrawNextGeneration()
        {
            graphics.Clear(Color.Black);
            brush = new SolidBrush(Color.FromArgb(255, myBrush.Red, myBrush.Green, myBrush.Blue));

            var field = gameEngine.GetCurrentGeneration();

            for (int x = 0; x < field.GetLength(0); x++)
            {
                for (int y = 0; y < field.GetLength(1); y++)
                {
                    if (field[x, y])
                        graphics.FillRectangle(brush, x * resolution, y * resolution, resolution - 1, resolution - 1);
                }
            }

            pictureBox.Refresh();
            LivingCellsText.Text = "Living Cells : " + gameEngine.LivingCells();
            GenerationText.Text = "Generation : " + gameEngine.CurrentGeneration;
            gameEngine.NextGeneration();
        }

        private void StopGame()
        {
            Timer.Stop();
            nudResolution.Enabled = true;
            nudDensity.Enabled = true;
            BStart.Enabled = true;
            BPause.Enabled = false;
            MSSaveGame.Enabled = false;
            BPause.Text = "⏸️";
            FormBorderStyle = FormBorderStyle.Sizable;

            gameEngine.RemoveField();
            graphics.Clear(SystemColors.Control);
            Text = "GameOfLife";
            LivingCellsText.Text = "Living Cells :";
            GenerationText.Text = "Generation :";
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            if (Timer.Enabled)
            {
                Timer.Stop();
                BPause.Text = "▶️";
                MSSaveGame.Enabled = true;
            }
            else
            {
                Timer.Start();
                BPause.Text = "⏸️";
                MSSaveGame.Enabled = false;
            }
        }

        private void MSSaveGame_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.InitialDirectory = @"D:\";
                save.RestoreDirectory = true;
                save.FileName = "*.gol";
                save.DefaultExt = "GOL";
                save.Filter = "gol filter (*.gol)|*.gol";

                if (save.ShowDialog() == DialogResult.OK)
                    gameEngine.SaveGame(save.OpenFile(), (int)nudResolution.Value, (int)nudDensity.Value,this.Width, this.Height);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Saving error.\n" + ex.Message);
            }
        }

        private void MSLoadGame_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (Timer.Enabled)
                        BPause_Click(sender, e);
                    else
                        BPause.Text = "▶️";

                    if (gameEngine == null)
                    {
                        NewGameEngine();
                    }

                    int with = Width;
                    int height = Height;
                    int density = (int)nudDensity.Value;
                    gameEngine.LoadGame(open.OpenFile(), ref resolution, ref density, ref with, ref height);

                    if (with != Width)
                    {
                        Width = with;
                        Height = height;
                        MessageBox.Show($"The game was saved in a different resolution {with}X{height}.\nForced permission change.");
                    }

                    nudResolution.Value = resolution;
                    nudDensity.Value = density;
                    DrawNextGeneration();
                    BPause.Enabled = true;
                    BStop.Enabled = true;

                    GetStatistic();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loading error.\n" + ex.Message);
            }
        }

        private void NewGameEngine()
        {
            nudResolution.Enabled = false;
            nudDensity.Enabled = false;
            resolution = (int)nudResolution.Value;
            gameEngine = new GameEngine
            (
                rows: pictureBox.Height / resolution,
                cols: pictureBox.Width / resolution,
                density: (int)(nudDensity.Minimum) + (int)(nudDensity.Maximum) - (int)(nudDensity.Value)
            );
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(pictureBox.Image);
        }

        private void MSOption_Click(object sender, EventArgs e)
        {
            optionForm = new OptionForm(this, Timer, myBrush);
            optionForm.Show();
        }
    }
}
