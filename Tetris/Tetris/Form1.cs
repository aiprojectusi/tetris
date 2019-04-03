using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {

        Game game;

        public Form1()
        {
            InitializeComponent();
        }

        private void setupDataGridView(DataGridView grid)
        {
            grid.BackgroundColor = Color.Black;
            grid.ShowEditingIcon = false;
            grid.ShowCellToolTips = false;
            grid.RowHeadersVisible = false;
            grid.ColumnHeadersVisible = false;
            grid.AllowUserToResizeRows = false;
            grid.AllowUserToResizeColumns = false;
            grid.ShowCellToolTips = false;
        }

        private void addColumns(DataGridView grid, int columns)
        {
            grid.ColumnCount = columns;
            for (int i = 0; i < columns; i++)
            {
                grid.Columns[i].Width = 20;
            }
        }

        private void addRows(DataGridView grid, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                grid.Rows.Add();
                grid.Rows[i].Height = 20;
                for (int j = 0; j < grid.Rows[i].Cells.Count; j++)
                {
                    grid.Rows[i].Cells[j].Style.BackColor = Color.Black;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setupDataGridView(blocksDataGrid);
            addColumns(blocksDataGrid, 10);
            addRows(blocksDataGrid, 23);

            setupDataGridView(nextGridView);
            addColumns(nextGridView, 5);
            addRows(nextGridView, 5);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            game = new Game(blocksDataGrid);
            game.start();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            blocksDataGrid.CurrentCell = null;
            nextGridView.CurrentCell = null;
        }
    }
}
