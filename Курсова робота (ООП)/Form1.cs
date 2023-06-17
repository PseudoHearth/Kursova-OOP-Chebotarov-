using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Курсова_робота__ООП_.Wolf;

namespace Курсова_робота__ООП_
{
    public partial class Form1 : Form
    {
        private static Random rnd = new Random();
        private Wolf wolf;
        private WolfFemale wolffem;
        private Hare hare;
        private int activationCount = 0;
        public Form1()
        {
            InitializeComponent();
            wolf = new Wolf("BM", 0, 0, 30);
            wolffem = new WolfFemale("BF", 0, 0, 30);
            hare = new Hare("3", 0, 0);
        }
        private void IncrementActivationCount()
        {
            activationCount++;
            textBox3.Text = activationCount.ToString();
        }
        private void Form1_Load(object sender, EventArgs e) //Створення поля та додаткові моменти
        {
            dataGridView1.ColumnCount = 20;
            dataGridView1.RowCount = 20;
            btnRestart.Text = "Restart";
            btnTurn.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Оновлення поля
            btnTurn.Enabled = true;
            Random rnd = new Random();
            int rowMax = dataGridView1.Rows.Count;
            int colMax = dataGridView1.Columns.Count;
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = 20;

            //створення вовків та зайців

            if (rowMax > 0 && colMax > 0)
            {
                int wolfRow = rnd.Next(1, rowMax);
                int wolfColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[wolfRow].Cells[wolfColumn];
                dataGridView1.Rows[wolfRow].Cells[wolfColumn].Value = Wolf.ID;

                wolf.PositionX = wolfColumn;
                wolf.PositionY = wolfRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int wolfRow = rnd.Next(1, rowMax);
                int wolfColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[wolfRow].Cells[wolfColumn];
                dataGridView1.Rows[wolfRow].Cells[wolfColumn].Value = Wolf.ID;

                wolf.PositionX = wolfColumn;
                wolf.PositionY = wolfRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int wolfRow = rnd.Next(1, rowMax);
                int wolfColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[wolfRow].Cells[wolfColumn];
                dataGridView1.Rows[wolfRow].Cells[wolfColumn].Value = Wolf.ID;

                wolf.PositionX = wolfColumn;
                wolf.PositionY = wolfRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int wolfRow = rnd.Next(1, rowMax);
                int wolfColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[wolfRow].Cells[wolfColumn];
                dataGridView1.Rows[wolfRow].Cells[wolfColumn].Value = Wolf.ID;

                wolf.PositionX = wolfColumn;
                wolf.PositionY = wolfRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int wolfRow = rnd.Next(1, rowMax);
                int wolfColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[wolfRow].Cells[wolfColumn];
                dataGridView1.Rows[wolfRow].Cells[wolfColumn].Value = Wolf.ID;

                wolf.PositionX = wolfColumn;
                wolf.PositionY = wolfRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int wolffemRow = rnd.Next(1, rowMax);
                int wolffemColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[wolffemRow].Cells[wolffemColumn];
                dataGridView1.Rows[wolffemRow].Cells[wolffemColumn].Value = WolfFemale.ID;

                wolffem.PositionX = wolffemColumn;
                wolffem.PositionY = wolffemRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int wolffemRow = rnd.Next(1, rowMax);
                int wolffemColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[wolffemRow].Cells[wolffemColumn];
                dataGridView1.Rows[wolffemRow].Cells[wolffemColumn].Value = WolfFemale.ID;

                wolffem.PositionX = wolffemColumn;
                wolffem.PositionY = wolffemRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int wolffemRow = rnd.Next(1, rowMax);
                int wolffemColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[wolffemRow].Cells[wolffemColumn];
                dataGridView1.Rows[wolffemRow].Cells[wolffemColumn].Value = WolfFemale.ID;

                wolffem.PositionX = wolffemColumn;
                wolffem.PositionY = wolffemRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int wolffemRow = rnd.Next(1, rowMax);
                int wolffemColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[wolffemRow].Cells[wolffemColumn];
                dataGridView1.Rows[wolffemRow].Cells[wolffemColumn].Value = WolfFemale.ID;

                wolffem.PositionX = wolffemColumn;
                wolffem.PositionY = wolffemRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int wolffemRow = rnd.Next(1, rowMax);
                int wolffemColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[wolffemRow].Cells[wolffemColumn];
                dataGridView1.Rows[wolffemRow].Cells[wolffemColumn].Value = WolfFemale.ID;

                wolffem.PositionX = wolffemColumn;
                wolffem.PositionY = wolffemRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int wolfRow = rnd.Next(1, rowMax);
                int wolfColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[wolfRow].Cells[wolfColumn];
                dataGridView1.Rows[wolfRow].Cells[wolfColumn].Value = Wolf.ID;

                wolf.PositionX = wolfColumn;
                wolf.PositionY = wolfRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int wolfRow = rnd.Next(1, rowMax);
                int wolfColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[wolfRow].Cells[wolfColumn];
                dataGridView1.Rows[wolfRow].Cells[wolfColumn].Value = Wolf.ID;

                wolf.PositionX = wolfColumn;
                wolf.PositionY = wolfRow;
            }
    
            if (rowMax > 0 && colMax > 0)
            {
                int wolffemRow = rnd.Next(1, rowMax);
                int wolffemColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[wolffemRow].Cells[wolffemColumn];
                dataGridView1.Rows[wolffemRow].Cells[wolffemColumn].Value = WolfFemale.ID;

                wolffem.PositionX = wolffemColumn;
                wolffem.PositionY = wolffemRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int wolffemRow = rnd.Next(1, rowMax);
                int wolffemColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[wolffemRow].Cells[wolffemColumn];
                dataGridView1.Rows[wolffemRow].Cells[wolffemColumn].Value = WolfFemale.ID;

                wolffem.PositionX = wolffemColumn;
                wolffem.PositionY = wolffemRow;
            }
            







            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }

            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }






            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }
            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }

            if (rowMax > 0 && colMax > 0)
            {
                int hareRow = rnd.Next(1, rowMax);
                int hareColumn = rnd.Next(1, colMax);
                dataGridView1.CurrentCell = dataGridView1.Rows[hareRow].Cells[hareColumn];
                dataGridView1.Rows[hareRow].Cells[hareColumn].Value = Hare.ID;

                hare.PositionX = hareColumn;
                hare.PositionY = hareRow;
            }
            //підрахування кількості вовків та зайців
            int wolfcount = 0;

            for (int row = 0; row < dataGridView1.RowCount; row++)
            {
                for (int column = 0; column < dataGridView1.ColumnCount; column++)
                {
                    DataGridViewCell currentCell = dataGridView1.Rows[row].Cells[column];

                    if (currentCell.Value != null && currentCell.Value.ToString() == Wolf.ID)
                    {
                        wolfcount++;
                    }

                }
            }
            textBox1.Text = wolfcount.ToString();

            int wolffemcount = 0;

            for (int row = 0; row < dataGridView1.RowCount; row++)
            {
                for (int column = 0; column < dataGridView1.ColumnCount; column++)
                {
                    DataGridViewCell currentCell = dataGridView1.Rows[row].Cells[column];

                    if (currentCell.Value != null && currentCell.Value.ToString() == WolfFemale.ID)
                    {
                        wolffemcount++;
                    }

                }
            }
            textBox4.Text = wolffemcount.ToString();

            int harecount = 0;

            for (int row = 0; row < dataGridView1.RowCount; row++)
            {
                for (int column = 0; column < dataGridView1.ColumnCount; column++)
                {
                    DataGridViewCell currentCell = dataGridView1.Rows[row].Cells[column];

                    if (currentCell.Value != null && currentCell.Value.ToString() == Hare.ID)
                    {
                        harecount++;
                    }
                }
            }
            textBox2.Text = harecount.ToString();

            
        }

        
        private void btnTurn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            // Підрахунок активацій btnTurn_Click
            IncrementActivationCount();
            

            //пошук позиції вовка
            List<Tuple<int, int>> wolfPositions = new List<Tuple<int, int>>(GetWolfPositions());
            List<Tuple<int, int>> wolffemPositions = new List<Tuple<int, int>>(GetWolfFemPositions());
            List<Tuple<int, int>> harePositions = new List<Tuple<int, int>>(GetHarePositions());

            List<Tuple<int, int>> GetWolfPositions()
            {
                List<Tuple<int, int>> positions = new List<Tuple<int, int>>();

                for (int row = 0; row < dataGridView1.RowCount; row++)
                {
                    for (int column = 0; column < dataGridView1.ColumnCount; column++)
                    {
                        DataGridViewCell currentCell = dataGridView1.Rows[row].Cells[column];

                        if (currentCell.Value != null && currentCell.Value.ToString() == Wolf.ID)
                        {
                            positions.Add(new Tuple<int, int>(row, column));
                        }
                    }
                }

                return positions;
            }



            List<Tuple<int, int>> GetWolfFemPositions()
            {
                List<Tuple<int, int>> positions = new List<Tuple<int, int>>();

                for (int row = 0; row < dataGridView1.RowCount; row++)
                {
                    for (int column = 0; column < dataGridView1.ColumnCount; column++)
                    {
                        DataGridViewCell currentCell = dataGridView1.Rows[row].Cells[column];

                        if (currentCell.Value != null && currentCell.Value.ToString() == WolfFemale.ID)
                        {
                            positions.Add(new Tuple<int, int>(row, column));

                        }
                    }
                }

                return positions;
            }


            
            // пошук позиції зайця
            List<Tuple<int, int>> GetHarePositions()
            {
                List<Tuple<int, int>> positions = new List<Tuple<int, int>>();

                for (int row = 0; row < dataGridView1.RowCount; row++)
                {
                    for (int column = 0; column < dataGridView1.ColumnCount; column++)
                    {
                        DataGridViewCell currentCell = dataGridView1.Rows[row].Cells[column];

                        if (currentCell.Value != null && currentCell.Value.ToString() == Hare.ID)
                        {
                            positions.Add(new Tuple<int, int>(row, column));
                        }
                    }
                }

                return positions;
            }
            // "Полювання" вовка на зайця, якщо той знаходиться в 3 клітинках або ближче
            foreach (var wolfPosition in wolfPositions)
            {
                int wolfRow = wolfPosition.Item1;
                int wolfColumn = wolfPosition.Item2;

                // Перевірка наявності зайця на сусідніх клітинках
                bool hareFound = false;
                int targetRow = -1;
                int targetColumn = -1;

                for (int row = wolfRow - 3; row <= wolfRow + 3; row++)
                {
                    for (int column = wolfColumn - 3; column <= wolfColumn + 3; column++)
                    {
                        if (row >= 0 && row < dataGridView1.RowCount && column >= 0 && column < dataGridView1.ColumnCount)
                        {
                            DataGridViewCell cell = dataGridView1.Rows[row].Cells[column];
                            if (cell.Value != null && cell.Value.ToString() == Hare.ID)
                            {
                                targetRow = row;
                                targetColumn = column;
                                hareFound = true;
                                break;
                            }
                        }
                    }

                    if (hareFound)
                        break;
                }

                // Переслідування зайця
                if (hareFound && Math.Abs(wolfRow - targetRow) <= 1 && Math.Abs(wolfColumn - targetColumn) <= 1)
                {
                    // З'їдання зайця
                    dataGridView1.Rows[targetRow].Cells[targetColumn].Value = Wolf.ID;
                    dataGridView1.Rows[wolfRow].Cells[wolfColumn].Value = null;
                    wolf.Hunger += 10;
                }
                else
                {
                    // Випадковий рух вовка
                    int direction;
                    int newRow;
                    int newColumn;
                    bool foundEmptyCell = false;

                    while (!foundEmptyCell)
                    {
                        direction = random.Next(0, 4);

                        newRow = wolfRow;
                        newColumn = wolfColumn;

                        switch (direction)
                        {
                            case 0: // Up
                                newRow--;
                                break;
                            case 1: // Down
                                newRow++;
                                break;
                            case 2: // Left
                                newColumn--;
                                break;
                            case 3: // Right
                                newColumn++;
                                break;
                        }

                        if (newRow >= 0 && newRow < dataGridView1.RowCount && newColumn >= 0 && newColumn < dataGridView1.ColumnCount)
                        {
                            DataGridViewCell newCell = dataGridView1.Rows[newRow].Cells[newColumn];

                            if (newCell.Value == null || newCell.Value.ToString() != Wolf.ID && newCell.Value.ToString() != WolfFemale.ID)
                            {
                                dataGridView1.Rows[wolfRow].Cells[wolfColumn].Value = null;
                                dataGridView1.Rows[newRow].Cells[newColumn].Value = Wolf.ID;

                                foundEmptyCell = true;

                                wolf.Hunger--;
                                if (wolf.Hunger <= 0)
                                {
                                    if (rnd.Next(0, 100) <= 15)
                                    dataGridView1.Rows[newRow].Cells[newColumn].Value = null;
                                }
                            }
                        }
                    }
                }
            }
            

            // "Полювання" вовчиці на зайця, якщо той знаходиться в 3 клітинках або ближче
            foreach (var wolffemPosition in wolffemPositions)
            {
                int wolffemRow = wolffemPosition.Item1;
                int wolffemColumn = wolffemPosition.Item2;

                // Перевірка наявності зайця на сусідніх клітинках
                bool hareFound = false;
                int targetRow = -1;
                int targetColumn = -1;

                for (int row = wolffemRow - 3; row <= wolffemRow + 3; row++)
                {
                    for (int column = wolffemColumn - 3; column <= wolffemColumn + 3; column++)
                    {
                        if (row >= 0 && row < dataGridView1.RowCount && column >= 0 && column < dataGridView1.ColumnCount)
                        {
                            DataGridViewCell cell = dataGridView1.Rows[row].Cells[column];
                            if (cell.Value != null && cell.Value.ToString() == Hare.ID)
                            {
                                targetRow = row;
                                targetColumn = column;
                                hareFound = true;
                                break;
                            }
                        }
                    }

                    if (hareFound)
                        break;
                }

                // Переслідування зайця
                if (hareFound && Math.Abs(wolffemRow - targetRow) <= 1 && Math.Abs(wolffemColumn - targetColumn) <= 1)
                {
                    // З'їдання зайця
                    dataGridView1.Rows[targetRow].Cells[targetColumn].Value = WolfFemale.ID;
                    dataGridView1.Rows[wolffemRow].Cells[wolffemColumn].Value = null;
                    wolffem.Hunger += 10;
                }
                else
                {
                    // Випадковий рух вовчиці
                    int direction;
                    int newRow;
                    int newColumn;
                    bool foundEmptyCell = false;

                    while (!foundEmptyCell)
                    {
                        direction = random.Next(0, 4);

                        newRow = wolffemRow;
                        newColumn = wolffemColumn;

                        switch (direction)
                        {
                            case 0: // Up
                                newRow--;
                                break;
                            case 1: // Down
                                newRow++;
                                break;
                            case 2: // Left
                                newColumn--;
                                break;
                            case 3: // Right
                                newColumn++;
                                break;
                        }

                        if (newRow >= 0 && newRow < dataGridView1.RowCount && newColumn >= 0 && newColumn < dataGridView1.ColumnCount)
                        {
                            DataGridViewCell newCell = dataGridView1.Rows[newRow].Cells[newColumn];

                            if (newCell.Value == null || newCell.Value.ToString() != Wolf.ID && newCell.Value.ToString() != WolfFemale.ID)
                            {
                                dataGridView1.Rows[wolffemRow].Cells[wolffemColumn].Value = null;
                                dataGridView1.Rows[newRow].Cells[newColumn].Value = WolfFemale.ID;

                                foundEmptyCell = true;

                                wolffem.Hunger--;
                                if (rnd.Next(0, 100) <= 15)
                                {
                                    dataGridView1.Rows[newRow].Cells[newColumn].Value = null;
                                }
                            }
                            
                                for (int r = newRow - 1; r <= newRow + 1; r++)
                                {
                                    for (int c = newColumn - 1; c <= newColumn + 1; c++)
                                    {
                                        // Перевіряємо, чи сусідня клітинка знаходиться в межах сітки
                                        if (r >= 0 && r < dataGridView1.RowCount && c >= 0 && c < dataGridView1.ColumnCount)
                                        {
                                            // Перевіряємо, чи сусідня клітинка містить вовка
                                            DataGridViewCell neighborCell = dataGridView1.Rows[r].Cells[c];
                                            if (neighborCell.Value != null && neighborCell.Value.ToString() == Wolf.ID)
                                            {
                                                // Перевіряємо, чи сусідня клітинка вільна
                                                for (int i = r - 2; i <= r + 2; i++)
                                                {
                                                    for (int j = c - 2; j <= c + 2; j++)
                                                    {
                                                        if (i >= 0 && i < dataGridView1.RowCount && j >= 0 && j < dataGridView1.ColumnCount)
                                                        {
                                                            
                                                            DataGridViewCell offspringCell = dataGridView1.Rows[i].Cells[j];
                                                            if (offspringCell.Value == null)
                                                            {
                                                                // Імітуємо рандомний вибір статі потомства
                                                                bool isMale = new Random().Next(2) == 0;

                                                                // Додаємо нового вовка або вовчицю до сусідньої вільної клітинки
                                                                if (isMale)
                                                                {
                                                                    dataGridView1.Rows[i].Cells[j].Value = Wolf.ID;
                                                                }
                                                                else
                                                                {
                                                                    dataGridView1.Rows[i].Cells[j].Value = Wolf.ID;
                                                                }
                                                                return; // Виходимо з функції після додавання потомка

                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
                //Заєць рухається випадковим чином
                foreach (var harePosition in harePositions)
                {
                    int currentRow = harePosition.Item1;
                    int currentColumn = harePosition.Item2;

                    bool wolfNearby = false;

                    // Перевірка наявності вовка на сусідніх клітинках
                    for (int row = currentRow - 1; row <= currentRow + 1; row++)
                    {
                        for (int column = currentColumn - 1; column <= currentColumn + 1; column++)
                        {
                            if (row >= 0 && row < dataGridView1.RowCount && column >= 0 && column < dataGridView1.ColumnCount)
                            {
                                DataGridViewCell cell = dataGridView1.Rows[row].Cells[column];
                                if (cell.Value != null && cell.Value.ToString() == Wolf.ID)
                                {
                                    wolfNearby = true;
                                    break;
                                }
                                if (cell.Value != null && cell.Value.ToString() == WolfFemale.ID)
                                {
                                    wolfNearby = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (!wolfNearby)
                    {
                        int direction;
                        int newRow;
                        int newColumn;
                        bool foundEmptyCell = false;

                        while (!foundEmptyCell)
                        {
                            direction = random.Next(0, 4);

                            newRow = currentRow;
                            newColumn = currentColumn;

                            switch (direction)
                            {
                                case 0: // Up
                                    newRow--;
                                    break;
                                case 1: // Down
                                    newRow++;
                                    break;
                                case 2: // Left
                                    newColumn--;
                                    break;
                                case 3: // Right
                                    newColumn++;
                                    break;
                            }
                            if (newRow >= 0 && newRow < dataGridView1.RowCount && newColumn >= 0 && newColumn < dataGridView1.ColumnCount)
                            {
                                DataGridViewCell newCell = dataGridView1.Rows[newRow].Cells[newColumn];

                                if (newCell.Value == null)
                                {
                                    dataGridView1.Rows[currentRow].Cells[currentColumn].Value = null;
                                    dataGridView1.Rows[newRow].Cells[newColumn].Value = Hare.ID;

                                    foundEmptyCell = true;

                                    if (random.Next(0, 101) <= 20)
                                    {
                                        int newHareRow;
                                        int newHareColumn;
                                        bool foundEmptyCellForNewHare = false;

                                        while (!foundEmptyCellForNewHare)
                                        {
                                            newHareRow = newRow + random.Next(-1, 2);
                                            newHareColumn = newColumn + random.Next(-1, 2);

                                            if (newHareRow >= 0 && newHareRow < dataGridView1.RowCount &&
                                            newHareColumn >= 0 && newHareColumn < dataGridView1.ColumnCount)
                                            {
                                                DataGridViewCell newHareCell = dataGridView1.Rows[newHareRow].Cells[newHareColumn];

                                                if (newHareCell.Value == null)
                                                {
                                                    newHareCell.Value = Hare.ID;
                                                    foundEmptyCellForNewHare = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }


              



                //Підрахунок кількості вовків та зайців після активації btnTurn

                int wolfcount = 0;

                for (int row = 0; row < dataGridView1.RowCount; row++)
                {
                    for (int column = 0; column < dataGridView1.ColumnCount; column++)
                    {
                        DataGridViewCell currentCell = dataGridView1.Rows[row].Cells[column];

                        if (currentCell.Value != null && currentCell.Value.ToString() == Wolf.ID)
                        {
                            wolfcount++;
                        }

                    }
                }

                int wolffemcount = 0;

                for (int row = 0; row < dataGridView1.RowCount; row++)
                {
                    for (int column = 0; column < dataGridView1.ColumnCount; column++)
                    {
                        DataGridViewCell currentCell = dataGridView1.Rows[row].Cells[column];

                        if (currentCell.Value != null && currentCell.Value.ToString() == WolfFemale.ID)
                        {
                            wolffemcount++;
                        }

                    }
                }


                int harecount = 0;

                for (int row = 0; row < dataGridView1.RowCount; row++)
                {
                    for (int column = 0; column < dataGridView1.ColumnCount; column++)
                    {
                        DataGridViewCell currentCell = dataGridView1.Rows[row].Cells[column];

                        if (currentCell.Value != null && currentCell.Value.ToString() == Hare.ID)
                        {
                            harecount++;
                        }
                    }
                }
                textBox2.Text = harecount.ToString();
                textBox1.Text = wolfPositions.Count.ToString();
                textBox4.Text = wolffemPositions.Count.ToString();

                

            }


        }
    }


