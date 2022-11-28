using IntermediaryLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CheckersGameGP
{
    internal partial class CheckersGameForm : Form
    {
        public CheckersGameForm()
        {
            InitializeComponent();
        }

        //enums to show names along with value for no:of checkers lost
        private enum MoveNames
        {
            Score = 0,
            GoodStart = 1,
            Great = 2,
            Trey = 3,
            LittleJoe = 4,
            Fever = 5,
            JimmieHicks = 6,
            Seven = 7,
            SquarePair = 8,
            Nina = 9,
            PuppyPaws = 10,
            Excellent = 11,
            Terrible = 12
        }//end enum


        CheckerIntermediaryClass checkerIntermediaryClass;
        private static CheckersGameForm CheckersGameInstance;
        //Declaring local variables
        private int n;
        //b=black color, w=white color, bb=blue color
        private string color = "b", k = "", B1 = "", B2 = "", k2 = "", Crt = "";
        private int black = 0, white = 0;
        PictureBox[,] pictureBox;
        DataSet data;
        private bool makeMove = false;
        public string winnnerName;


        //Play Again Button
        private void PlayAgainLabel_Click(object sender, EventArgs e)
        {
            winPanel.Visible = false;
            //Arranging the picture Box
            for (int h = 0; h < n; h++)
                for (int l = 0; l < n; l++)
                {
                    if (h < (n / 2) - 1 && pictureBox[h, l].BackColor == Color.Black) { pictureBox[h, l].Image = Properties.Resources.BlackPiece; pictureBox[h, l].Name = h + " " + l + " b"; }
                    else if (h > (n / 2) && pictureBox[h, l].BackColor == Color.Black)
                    {
                        pictureBox[h, l].Image = Properties.Resources.WhitePiece; pictureBox[h, l].Name = h + " " + l + " w";
                    }
                    if (h == ((n / 2) - 1) || h == (n / 2)) pictureBox[h, l].Image = null;
                }

            //Making values blank to play again
            p1ScoreLabel.Text = "0";
            p2ScoreLabel.Text = "0";
            white = 0;
            black = 0;
        }//Play Again Button Ends


        //Start Label click
        private void startLabel_Click(object sender, EventArgs e)
        {
            //validations for textboxex
            if (p1FNTextBox.Text == "" || p1LNTextBox == null)
            {
                errorLabel.Text = "Player First Name is Required";
                return;
            }

            if (p2FNTextBox.Text == "" || p2LNTextBox == null)
            {
                errorLabel.Text = "Players Last Name is Required";
                return;
            }

            if (p1GenderComboBox.SelectedIndex == -1 || p2GenderComboBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Players Gender is Required";
                return;
            }

            if (p1AgeTextBox.Text == "" || p2AgeTextBox == null)
            {
                errorLabel.Text = "Players Age is Required";
                return;
            }

            //converting string to int
            Int32.TryParse(p1AgeTextBox.Text, out int age1);
            Int32.TryParse(p2AgeTextBox.Text, out int age2);

            //Declaring array object and storeing Player1 and player2 info
            object[] P1Info = { "P1", p1FNTextBox.Text, p1LNTextBox.Text, p1GenderComboBox.SelectedItem.ToString(), age1 };
            object[] P2Info = { "P2", p2FNTextBox.Text, p2LNTextBox.Text, p2GenderComboBox.SelectedItem.ToString(), age2 };

            //Displaying Players Name in textboxes
            p1NameLabel.Text = p1FNTextBox.Text + " " + p1LNTextBox.Text;
            p2NameLabel.Text = p2FNTextBox.Text + " " + p2LNTextBox.Text;
            checkerIntermediaryClass = new CheckerIntermediaryClass();

            //calling intermediaryclass and passing objects
            int response1 = checkerIntermediaryClass.AddRegistration(P1Info);
            int response2 = checkerIntermediaryClass.AddRegistration(P2Info);
            if (response2 != 0) playPanel.Hide();//closing panel 
        }


        //FeedBack Buuton
        private void fdbButton_Click(object sender, EventArgs e)
        {

            //Singleton form
            FeedBackForm feedBackForm = FeedBackForm.FeedBackFormInstance();
            feedBackForm.MdiParent = CheckersMain.ActiveForm;
            feedBackForm.Show();

        }



        internal static CheckersGameForm CheckersGameFormInstance()
        {
            //Singleton Form
            if (CheckersGameInstance == null)
                CheckersGameInstance = new CheckersGameForm();
            return CheckersGameInstance;
        }


        //Game form load
        private void CheckersGameForm_Load(object sender, EventArgs e)
        {
            playPanel.Parent = this;
            playPanel.BringToFront();
            n = 8;
            //Creating picture box of 8*8 resolution
            pictureBox = new PictureBox[n, n];
            int left = 2, top = 2;
            Color[] colors = new Color[] { Color.White, Color.Black };
            for (int i = 0; i < n; i++)
            {
                left = 2;
                //Setting colors alternately for picturebox.
                if (i % 2 == 0) { colors[0] = Color.White; colors[1] = Color.Black; }
                else { colors[1] = Color.White; colors[0] = Color.Black; }

                //creating the board 
                for (int j = 0; j < n; j++)
                {

                    pictureBox[i, j] = new PictureBox();
                    pictureBox[i, j].Size = new Size(60, 60);
                    pictureBox[i, j].BackColor = colors[(j % 2 == 0) ? 1 : 0];
                    pictureBox[i, j].Location = new Point(left, top);
                    left += 60;// moving right by 60 resolution to add next pixturebox of resolution 60*60
                    pictureBox[i, j].Name = i + " " + j;

                    //Placinng white and black checkers based on the picturebox color
                    if (i < (n / 2) - 1 && pictureBox[i, j].BackColor == Color.Black)
                    { pictureBox[i, j].Image = Properties.Resources.BlackPiece; pictureBox[i, j].Name += " b"; }
                    else if (i > (n / 2) && pictureBox[i, j].BackColor == Color.Black)
                    { pictureBox[i, j].Image = Properties.Resources.WhitePiece; pictureBox[i, j].Name += " w"; }

                    pictureBox[i, j].SizeMode = PictureBoxSizeMode.CenterImage;
                    panel1.Controls.Add(pictureBox[i, j]);
                    GetQuestions();//Gets questions from database

                    //Events to capture picturebox click
                    pictureBox[i, j].Click += (sender3, e3) =>
                    {
                        //b for black color
                        //w for white color
                        //bb for blue color
                        //B1 for blue checker on right 
                        //B2 for blue checker on left
                        //k current slected checker
                        if (makeMove == true)
                        {
                            PictureBox p = sender3 as PictureBox;//Object is send
                            if (p.Image != null)
                            {
                                int c = -1, x, y;
                                F();
                                if (p.Name.Split(' ')[2] == "bb")
                                {
                                    if (color == "b") color = "w";
                                    else color = "b";
                                    x = Convert.ToInt32(k.Split(' ')[0]);//X-axis value
                                    y = Convert.ToInt32(k.Split(' ')[1]);//y-axis value
                                    B1 = "";
                                    B2 = "";
                                    if (k.Split(' ')[2] == "b")
                                    {
                                        p.Image = Properties.Resources.BlackPiece;//setting image 
                                        p.Name = p.Name.Replace("bb", "b");
                                        makeMove = false;
                                    }
                                    else
                                    if (k.Split(' ')[2] == "w")
                                    {
                                        p.Image = Properties.Resources.WhitePiece;
                                        p.Name = p.Name.Replace("bb", "w");
                                        makeMove = false;
                                    }
                                    pictureBox[x, y].Image = null;
                                    if (k2 != "")
                                    {
                                        x = Convert.ToInt32(k2.Split(' ')[0]);
                                        y = Convert.ToInt32(k2.Split(' ')[1]);
                                        pictureBox[x, y].Image = null;
                                        if (k2.Split(' ')[2] == "b") black++;
                                        else white++;
                                        p1ScoreLabel.Text = black + " " + (MoveNames)black;// using enums along with score
                                        p2ScoreLabel.Text = white + " " + (MoveNames)white;
                                        if (black >= 10)
                                        {
                                            winLabel.Text = "You won " + p1NameLabel.Text;
                                            FeedBackForm feedBackForm = new FeedBackForm(winLabel.Text);
                                            winPanel.Visible = true;
                                        }
                                        else
                                        if (white >= 10)
                                        {
                                            winLabel.Text = "You won " + p2NameLabel.Text;
                                            FeedBackForm feedBackForm = new FeedBackForm(winLabel.Text);
                                            winPanel.Visible = true;
                                        }
                                        k2 = "";
                                    }

                                }
                                else
                                if (p.Name.Split(' ')[2] == color)
                                {
                                    x = Convert.ToInt32(p.Name.Split(' ')[0]);
                                    y = Convert.ToInt32(p.Name.Split(' ')[1]);
                                    k = p.Name;
                                    if (p.Name.Split(' ')[2] == "b") c = 1;
                                    try//try and catch block
                                    {
                                        if (pictureBox[x + c, y + 1].Image == null)//checking right digonal box for any checker
                                        {
                                            pictureBox[x + c, y + 1].Image = Properties.Resources.BluePiece;
                                            pictureBox[x + c, y + 1].Name = (x + c) + " " + (y + 1) + " bb";
                                            B1 = (x + c) + " " + (y + 1);
                                        }
                                        else
                                            if (pictureBox[x + c, y + 1].Name.Split(' ')[2] != p.Name.Split(' ')[2] && pictureBox[x + (c * 2), y + 2].Image == null)
                                        {
                                            pictureBox[x + (c * 2), y + 2].Image = Properties.Resources.BluePiece;
                                            pictureBox[x + (c * 2), y + 2].Name = (x + (c * 2)) + " " + (y + 2) + " bb";
                                            B1 = (x + (c * 2)) + " " + (y + 2);
                                            k2 = (x + c) + " " + (y + 1) + " " + pictureBox[x + c, y + 1].Name.Split(' ')[2];
                                        }

                                    }
                                    catch { }
                                    try
                                    {
                                        if (pictureBox[x + c, y - 1].Image == null)//checking left diagonal box for any checker
                                        {
                                            pictureBox[x + c, y - 1].Image = Properties.Resources.BluePiece;
                                            pictureBox[x + c, y - 1].Name = (x + c) + " " + (y - 1) + " bb";
                                            B2 = (x + c) + " " + (y - 1);
                                        }
                                        else
                                            if (pictureBox[x + c, y - 1].Name.Split(' ')[2] != p.Name.Split(' ')[2] && pictureBox[x + (c * 2), y - 2].Image == null)
                                        {
                                            pictureBox[x + (c * 2), y - 2].Image = Properties.Resources.BluePiece;
                                            pictureBox[x + (c * 2), y - 2].Name = (x + (c * 2)) + " " + (y - 2) + " bb";
                                            B2 = (x + (c * 2)) + " " + (y - 2);
                                            k2 = (x + c) + " " + (y - 1) + " " + pictureBox[x + c, y - 1].Name.Split(' ')[2];
                                        }

                                    }
                                    catch { }
                                }
                            }

                        }
                        else
                        {
                            GetQuestions();
                        }

                    };

                }
                top += 60;//moving down by 60 resolutions to add next row of picture boxes of resolution 60*60            }


                //option B CLick event
                optionBLabel.Click += (sender4, e4) =>
            {
                if (optionBLabel.Text == Crt)
                {
                    optionBLabel.BackColor = Color.Green;
                    makeMove = true;
                }
                else
                {
                    optionBLabel.BackColor = Color.Red;
                    // Thread.Sleep(5000);
                    //  GetQuestions();
                    makeMove = false;
                    if (color == "b") color = "w";
                    else if (color == "w") color = "b";
                }
            };


                //option A CLick Event
                optionALabel.Click += (sender5, e5) =>
                {
                    if (optionALabel.Text == Crt)
                    {
                        optionALabel.BackColor = Color.Green;
                        makeMove = true;
                    }
                    else
                    {
                        makeMove = false;
                        optionALabel.BackColor = Color.Red;
                        if (color == "b") color = "w";
                        else if (color == "w") color = "b";
                    }
                };
            }
        }
        private void CheckersGameForm_FormClosing(object sender3, FormClosingEventArgs e3)
        {
            CheckersGameInstance = null;
        }//Closing form


        private void F()
        {
            if (B1 != "")
            {
                int x, y;
                x = Convert.ToInt32(B1.Split(' ')[0]);
                y = Convert.ToInt32(B1.Split(' ')[1]);
                pictureBox[x, y].Image = null;
            }
            if (B2 != "")
            {
                int x, y;
                x = Convert.ToInt32(B2.Split(' ')[0]);
                y = Convert.ToInt32(B2.Split(' ')[1]);
                pictureBox[x, y].Image = null;
            }
        }

        //Get questions from DB
        private void GetQuestions()
        {
            optionBLabel.BackColor = Color.White;
            optionALabel.BackColor = Color.White;
            if (data == null)
            {
                checkerIntermediaryClass = new CheckerIntermediaryClass();
                data = checkerIntermediaryClass.GetQuestions();
            }
            Random rand = new Random();
            int random = rand.Next(0, 15);
            questionsLabel.Text = data.Tables[0].Rows[random]["Question"].ToString();
            optionALabel.Text = data.Tables[0].Rows[random]["OptionA"].ToString();
            optionBLabel.Text = data.Tables[0].Rows[random]["OptionB"].ToString();
            Crt = data.Tables[0].Rows[random]["CorrectAnswer"].ToString();
        }//End GetQuestions


    }
}
