using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Statistic : Form
    {
        private Graphics graphics;
        private float prevXposition;
        private float prevYposition;
        private float nowXposition;
        private float nowYposition;
        private const int Indent = 1;
        private const int Coef = 8;
        private readonly float HeightDiagram;
        public int LCells { get; set; }
        public Statistic()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            HeightDiagram = diagram.Height;
            DrawCanvas();
        }

        private void DrawCanvas()
        {
            Text = $"Living Cells {LCells}";
            prevXposition = 0;
            prevYposition = HeightDiagram - Indent;
            nowXposition = 1;
            nowYposition = HeightCalculation(LCells);
            diagram.Image = new Bitmap(diagram.Width, diagram.Height);
            graphics = Graphics.FromImage(diagram.Image);
            graphics.Clear(SystemColors.Control);
            DrawLines();        
            TimerForDiagram.Start();
        }

        private void DrawDiagram()
        {
            Text = $"Living Cells {LCells}";
            if (nowXposition >= diagram.Width)
            {
                graphics.Clear(SystemColors.Control);
                prevXposition = 0;
                nowXposition = 1;
                DrawLines();
            }
            graphics.DrawLine(Pens.Black, prevXposition, prevYposition, nowXposition, nowYposition);
            prevXposition = nowXposition;
            nowXposition += 1;
            prevYposition = nowYposition;
            nowYposition = HeightCalculation(LCells);
            diagram.Refresh();
        }

        private void TimerForDiagram_Tick(object sender, EventArgs e)
        {
            DrawDiagram();
        }

        private float HeightCalculation(int num)
        {
            return HeightDiagram - Indent - num / HeightDiagram * Coef;
        }

        private void DrawLines()
        {
            int heightIndent = 5000;
            for (int i = 0; i < 9; i++)
            {
                graphics.DrawLine(Pens.Brown, 0, HeightCalculation(heightIndent), diagram.Width, HeightCalculation(heightIndent));
                heightIndent += 5000;
            }
        }
    }
}
