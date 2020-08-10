using System;
using System.IO;

namespace GameOfLife
{
    public class GameEngine
    {
        public uint CurrentGeneration { get; private set; }
        private bool[,] field;
        private int rows;
        private int cols;

        public GameEngine(int rows, int cols, int density)
        {
            this.rows = rows;
            this.cols = cols;
            field = new bool[cols, rows];
            Random random = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next(density) == 0;
                }
            }
        }

        public void NextGeneration()
        {
            var newfield = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighboursCount = CountNeighbours(x, y);
                    var hasLife = field[x, y];

                    if (!hasLife && neighboursCount == 3)
                        newfield[x, y] = true;
                    else if (hasLife && (neighboursCount < 2 || neighboursCount > 3))
                        newfield[x, y] = false;
                    else
                        newfield[x, y] = field[x, y];
                }
            }
            field = newfield;
            CurrentGeneration++;
        }

        public bool[,] GetCurrentGeneration()
        {
            var result = new bool[cols, rows];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    result[x, y] = field[x, y];
                }
            }
            return result;
        }

        private int CountNeighbours(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;

                    var isSelfChecking = col == x && row == y;
                    var hasLife = field[col, row];

                    if (hasLife && !isSelfChecking)
                        count++;
                }
            }

            return count;
        }

        private bool ValidateCellPosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }

        private void UpdateCell(int x, int y, bool state)
        {
            if (ValidateCellPosition(x, y))
                field[x, y] = state;
        }

        public void AddCell(int x, int y)
        {
            UpdateCell(x, y, state: true);
        }

        public void RemoveCell(int x, int y)
        {
            UpdateCell(x, y, state: false);
        }

        public int LivingCells()
        {
            var lcells = 0;
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    if (field[x, y])
                        lcells++;
                }
            }
            return lcells;
        }

        public void RemoveField()
        {
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    if (field[x, y])
                        field[x, y] = false;
                }
            }
        }

        public void SaveGame(Stream stream, int resolution, int density, int with, int height)
        {
            using (var streamWriter = new StreamWriter(stream))
            {
                streamWriter.WriteLine(resolution);
                streamWriter.WriteLine(density);
                streamWriter.WriteLine($"{with}X{height}");
                for (int x = 0; x < cols; x++)
                {
                    for (int y = 0; y < rows; y++)
                    {
                        if (field[x, y])
                            streamWriter.Write(1);
                        else
                            streamWriter.Write(0);
                    }
                    streamWriter.WriteLine();
                }
            }
        }

        public void LoadGame(Stream stream, ref int resolution, ref int density, ref int with, ref int height)
        {
            using (var streamReader = new StreamReader(stream))
            {
                cols = 0;
                rows = 0;
                resolution = int.Parse(streamReader.ReadLine());
                density = int.Parse(streamReader.ReadLine());
                var size = streamReader.ReadLine().Split('X');
                with = int.Parse(size[0]);
                height = int.Parse(size[1]);
                while (!streamReader.EndOfStream)
                {
                    rows = streamReader.ReadLine().Length;
                    cols++;
                }
                streamReader.BaseStream.Position = 0;
                streamReader.ReadLine();
                streamReader.ReadLine();
                streamReader.ReadLine();

                field = new bool[cols, rows];

                for (int x = 0; x < cols; x++)
                {
                    var line = streamReader.ReadLine();
                    for (int y = 0; y < rows; y++)
                    {
                        if (line[y].Equals('0'))
                            field[x, y] = false;
                        else
                            field[x, y] = true;
                    }
                }
            }
        }
    }
}
