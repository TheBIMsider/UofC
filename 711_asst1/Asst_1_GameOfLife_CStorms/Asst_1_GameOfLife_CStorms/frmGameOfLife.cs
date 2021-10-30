/*****************************************************************************************************************************
*  
*  Author:     Carl G Storms - All Rights Reserved
*              July 2019
*
*  Purpose:    Class Assigment - University of Calgary
*                                Continuing Education
*                                ICT 711 - Computer Programming Level 2
*
*  Description:    
*
*                  Expected Behaviour - Current Generation Group Box will display the current Game of Life world in grid
*                                       form (default is 30 rows x 30 columns, the defaul can by changed by the via constants
*                                     - Load Grid Button will load a file that contains the coordinates of live
*                                       (green) creatures, the defaul file type will be .gol
*                                     - Save Grid Button will save the current generation of alive creatures (green cells)
*                                       out do a file, the defaul file type will be .gol
*                                     - Reset All Cells Button will set all kill all creatures and set the Game of Life world
*                                       (grid) back to the start of time (all cells will be white) The bool array will also
*                                       all be set back to false (dead / white)
*                                     - Next Button will caclulate the next generation of creatures
*                                     - Generations Text box will allow user input for calculate n generations
*                                     - Last Grid Location Text box give a readout for the row and column of the last cell
*                                       clicked on              
*
*****************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  //added IO system program

namespace Asst_1_GameOfLife_CStorms
{

    public partial class frmGameOfLife : Form
    {
        private const int ROW_GRID_SIZE = 30; //row constant
        private const int COLUMN_GRID_SIZE = 30; //column constant
        private Label[,] theGrid = new Label[ROW_GRID_SIZE, COLUMN_GRID_SIZE];
        private bool[,] currentGeneration = new bool[ROW_GRID_SIZE, COLUMN_GRID_SIZE];


        public frmGameOfLife()
        {
            InitializeComponent();
        }


        private void birthCreature(int row, int column) // method to turn cell green and changes bool to true
        {
            theGrid[row, column].BackColor = Color.LimeGreen;
            currentGeneration[row, column] = true;
        }


        private void killCreature(int row, int column) // method to turn cell white and changes bool to falce
        {
            theGrid[row, column].BackColor = Color.White;
            currentGeneration[row, column] = false;
        }


        private void labelClickEventHandler(object sender, EventArgs e)
        {
            Label gs = (Label)sender; // gs is short for grid squares

            int row = (int)gs.Tag / 1000;
            int column = (int)gs.Tag % 1000;

            if (gs.BackColor == Color.White) // if dead (white) make alive (green)
            {
                gs.BackColor = Color.LimeGreen;
                currentGeneration[row, column] = true;
            }

            else // if alive (green) make dead (white)
            {
                currentGeneration[row, column] = false;
                gs.BackColor = Color.White;
            }

            txtStatusTextBox.Text = $"Last location selected was row {row}, column {column}";

        }


        private void MakeGrid(object sender, EventArgs e)
        {
            Label gs;  // gs is short for grid squares

            for (int row = 0; row < ROW_GRID_SIZE; row ++)
            {
                for (int column = 0; column < COLUMN_GRID_SIZE; column++)
                {
                    gs = new System.Windows.Forms.Label();
                    gs.Tag = (row + 1) * 1000 + (column + 1); //adds cell location to tag
                    gs.Location = new System.Drawing.Point(25 + 24 * column, 25 + 24 * row);
                    gs.Size = new System.Drawing.Size(25, 25);
                    gs.BackColor = System.Drawing.Color.White;
                    gs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    gs.Click += new System.EventHandler(labelClickEventHandler);
                    grpGenerationGroupBox.Controls.Add(gs);
                    theGrid[row, column] = gs;
                }
            }
        }


        private void loadGeneration(StreamReader file)
        {
            // reads and imports coordinate file
            string lineOfInput;
            char[] delimiters = { ' ', ',', '\t' };
            string[] tokens;
            int row = 0;
            int column = 0;

            while (!file.EndOfStream)
            {
                lineOfInput = file.ReadLine();
                tokens = lineOfInput.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                row = int.Parse(tokens[0]);
                column = int.Parse(tokens[1]);

                birthCreature(row, column); //makes cells green based on imported coordinates
            }
        }


        private void btnLoadGrid_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogIn = new OpenFileDialog();    // reference to the open file dialog

            dialogIn.Title = "Load Grid File";
            dialogIn.Filter = "All Files|*.*|Game of Life Files (*.gol)|*.gol"; // set .gol as default file type with option for all files
            dialogIn.FilterIndex = 2;

            DialogResult result = dialogIn.ShowDialog();

            try
            {
                StreamReader myDataFile = new StreamReader(dialogIn.FileName);
                loadGeneration(myDataFile);

                myDataFile.Close();
            }
          
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message); //output message if an exception is caught by the try-catch
            }

        }


        private void btnSaveGrid_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogOut = new SaveFileDialog();       // reference to the SaveFileDialog object.
            dialogOut.Title = "Save Grid Loacton";
            dialogOut.Filter = "All Files|*.*|Game of Life Files (*.gol)|*.gol";  // set .gol as default file type with option for all files
            dialogOut.FilterIndex = 2;

            DialogResult result = dialogOut.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            try
            {
                // create the file of just the alive (green) cells, the file is just row, 
                // column coordinates for the green cells of current generation
                StreamWriter myOutputFile = new StreamWriter(dialogOut.FileName);

                for (int row = 0; row < ROW_GRID_SIZE; row++)
                {
                    for (int column = 0; column < COLUMN_GRID_SIZE; column++)
                    {
                        if (currentGeneration[row, column] == true)
                        {
                            myOutputFile.WriteLine($"{row}, { column}");
                        }
                    }
                }

                myOutputFile.Close();

                MessageBox.Show($"File '{dialogOut.FileName} written.");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message); //output message if an exception is caught by the try-catch
            }
        }


        private void btnResetAllCells_Click(object sender, EventArgs e)
        {
            var textboxes = grpLastGridLoaction.Controls.OfType<TextBox>();

            foreach (TextBox tb in textboxes) // resets the Last Grid Location text box back to blank (empty)
            {
                tb.Text = "";
            }

            // resets all the cells back to white be killing any alive creatures (green cells) with the killCreature method
            for (int row = 0; row < ROW_GRID_SIZE; row++)     
            {
                for (int column = 0; column < COLUMN_GRID_SIZE; column++)
                {
                    killCreature(row, column);
                }
            }
        }


        //// work in progress
        //private void calculateNextGeneration()
        //{
        //    int row;
        //    int column;
        //    int[,] neighbourCounts = new int[ROW_GRID_SIZE, COLUMN_GRID_SIZE];

        //    for (row = 0; row < ROW_GRID_SIZE; row++)
        //    {
        //        for (column = 0; column < COLUMN_GRID_SIZE; column++)
        //        {
        //            // need info from countTheNeighbours Method
        //        }
        //    }
        //}


        //// Work in Progress
        //private void countTheNeigbours(int[,] numberOfNeighbours)
        //{
        //    int row;
        //    int column;
        //    int count = 0;

        //    for (row = 0; row < ROW_GRID_SIZE; row++)
        //    {
        //        for (column = 0; column < COLUMN_GRID_SIZE; column++)
        //        {
        //            numberOfNeighbours[row, column] = - currentGeneration[row, column];
        //            // need info from neighbourCount
        //        }
        //    }
        //}


        private void neighbourCount(int row, int column)
        {
            int count = 0;

            if (currentGeneration[row - 1, column - 1] == true)
                count++;
            if (currentGeneration[row, column] == true)
                count++;
            if (currentGeneration[row - 1, column + 1] == true)
                count++;
            if (currentGeneration[row, column - 1] == true)
                count++;
            if (currentGeneration[row, column + 1] == true)
                count++;
            if (currentGeneration[row + 1, column - 1] == true)
                count++;
            if (currentGeneration[row + 1, column] == true)
                count++;
            if (currentGeneration[row + 1, column + 1] == true)
                count++;

            //return count;
        }

        //// Work in Progress
        private void btnNext_Click(object sender, EventArgs e)
        {
        //    bool gridChanged = false;

        //    int generationCount = int.Parse(txtGenertionsCount.Text);

        //    for (int i = 0; i < generationCount; i++)
        //    {
        //        gridChanged = calculateNextGeneration();
        //        if (!gridChanged)
        //        {
        //            break;
        //        }
        //    }
        //    //display changes to UI somehow?

        //    if (!gridChanged)
        //    {
        //        MessageBox.Show("The Game of Life world is now stable!");
        //        btnNext.Enabled = false;
        //    }
        }


         //Work in Progress
        private void txtGenertionsCount_TextChanged(object sender, EventArgs e)
        {
            // this is where I get the input from the user for n generation
            // this input will then be used to figure out the births and deaths for each of the n generations
            // once the all gerations are calculated the final (last) generation will be displayed
            // need to find the right way to display the final generation
        }


        private void btnQuit_Click(object sender, EventArgs e)
        {
            // the Game of Life will close when the "Quit" button on is clicked, with a pop-up to confirm your choice
            DialogResult quitDialog = MessageBox.Show("Do you really want to quit the Game of Life?",
                                                      "Quit", MessageBoxButtons.YesNo);

            if (quitDialog == DialogResult.Yes)
            {
                Application.Exit();
            }

            else if (quitDialog == DialogResult.No)
            {
                return;
            }
        }


        private void frmGameOfLife_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // the Game of Life will close when the red "X" button on the form is clicked
        }
    }
}
