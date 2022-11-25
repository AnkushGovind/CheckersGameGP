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

namespace CheckersGameGP
{
    public partial class CheckersGameForm : Form
    {
        //Declaring local variables
        private static CheckersGameForm CheckersGameInstance;
        int n;   
        //b=black color, w=white color, bb=blue color
        string color = "b", k = "", B1 = "", B2 = "", k2 = "", Crt="";
        int black = 0, white = 0;   
        PictureBox[,] pictureBox;
        DataSet data;
        bool makeMove = false;
        CheckerIntermediaryClass checkerIntermediaryClass;

        private void PlayAgainLabel_Click(object sender, EventArgs e)
        {
            WinPanel.Visible = false;
            for (int h = 0; h < n; h++)
                for (int l = 0; l < n; l++)
                {
                    if (h < (n / 2) - 1 && pictureBox[h, l].BackColor == Color.Black) { pictureBox[h, l].Image = Properties.Resources.BlackPiece; pictureBox[h, l].Name = h + " " + l + " r"; }
                    else if (h > (n / 2) && pictureBox[h, l].BackColor == Color.Black)
                    {
                        pictureBox[h, l].Image = Properties.Resources.WhitePiece; pictureBox[h, l].Name = h + " " + l + " g";
                    }
                    if (h == ((n / 2) - 1) || h == (n / 2)) pictureBox[h, l].Image = null;
                }
            P1ScoreLabel.Text = "0";
            P2ScoreLabel.Text = "0";            
            P1NameLabel.Text = "";
            P2NameLabel.Text = "";           
            white = 0;
            black = 0;
        }

        public CheckersGameForm()
        {
            InitializeComponent();
        }

        internal static CheckersGameForm CheckersGameFormInstance()
        {
            if (CheckersGameInstance == null)
                CheckersGameInstance = new CheckersGameForm();
            return CheckersGameInstance;
        }

        private void CheckersGameForm_Load(object sender, EventArgs e)
        {
            PlayPanel.Parent = this;
            PlayPanel.BringToFront();
            startLabel.Click += (sender1, e1) =>
            {
                PlayPanel.Hide();
            };
            n = 8;
            pictureBox = new PictureBox[n, n];
            int left = 2, top = 2;
            Color[] colors = new Color[] { Color.White, Color.Black };
            for (int i = 0; i < n; i++)
            {
                left = 2;
                if (i % 2 == 0) { colors[0] = Color.White; colors[1] = Color.Black; }
                else { colors[1] = Color.White; colors[0] = Color.Black; }

                for (int j = 0; j < n; j++)
                {

                    pictureBox[i, j] = new PictureBox();
                    pictureBox[i, j].Size = new Size(60, 60);
                    pictureBox[i, j].BackColor = colors[(j % 2 == 0) ? 1 : 0];
                    pictureBox[i, j].Location = new Point(left, top);
                    left += 60;
                    pictureBox[i, j].Name = i + " " + j;
                    if (i < (n / 2) - 1 && pictureBox[i, j].BackColor == Color.Black) { pictureBox[i, j].Image = Properties.Resources.BlackPiece; pictureBox[i, j].Name += " b"; }
                    else if (i > (n / 2) && pictureBox[i, j].BackColor == Color.Black)
                    {
                        pictureBox[i, j].Image = Properties.Resources.WhitePiece; pictureBox[i, j].Name += " w";
                    }
                    pictureBox[i, j].SizeMode = PictureBoxSizeMode.CenterImage;
                    panel1.Controls.Add(pictureBox[i, j]);
                    GetQuestions();
                    pictureBox[i, j].Click += (sender3, e3) =>
                    {
                        if (makeMove == true)
                        {
                            PictureBox p = sender3 as PictureBox;
                            if (p.Image != null)
                            {
                                int c = -1, x, y;
                                F();
                                if (p.Name.Split(' ')[2] == "bb")
                                {
                                    if (color == "b") color = "w";
                                    else color = "b";
                                    x = Convert.ToInt32(k.Split(' ')[0]);
                                    y = Convert.ToInt32(k.Split(' ')[1]);
                                    B1 = "";
                                    B2 = "";
                                    if (k.Split(' ')[2] == "b")
                                    {
                                        p.Image = Properties.Resources.BlackPiece;
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
                                         P1ScoreLabel.Text = black + "";
                                        P2ScoreLabel.Text = white + "";
                                        if (black >= 12)
                                        {
                                            WinLabel.Text = "You win " + P1NameLabel.Text;
                                            WinPanel.Visible = true;
                                        }
                                        else
                                        if (white >= 12)
                                        {
                                            WinLabel.Text = "You win " + P2NameLabel.Text;
                                            WinPanel.Visible = true;
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
                                    try
                                    {
                                        if (pictureBox[x + c, y + 1].Image == null)
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
                                        if (pictureBox[x + c, y - 1].Image == null)
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
                top += 60;
            }

            OptionBLabel.Click += (sender4, e4) =>
            {
                if (OptionBLabel.Text == Crt)
                {
                    OptionBLabel.BackColor = Color.Green;
                    makeMove = true;
                }
                else
                {
                    OptionBLabel.BackColor = Color.Red;
                    // Thread.Sleep(5000);
                    //  GetQuestions();
                    makeMove = false;
                    if (color == "b") color = "w";
                    else if (color == "w") color = "b";
                }
            };

            OptionALabel.Click += (sender5, e5) =>
            {
                if (OptionALabel.Text == Crt)
                {
                    OptionALabel.BackColor = Color.Green;
                    makeMove = true;
                }
                else
                {
                    makeMove = false;
                    OptionALabel.BackColor = Color.Red;
                    if (color == "b") color = "w";
                    else if (color == "w") color = "b";
                }
            };
        }

        private void CheckersGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckersGameInstance = null;
        }


        public void F()
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
        public void GetQuestions()
        {
            OptionBLabel.BackColor = Color.White;
            OptionALabel.BackColor = Color.White;
            if (data == null)
            {
                checkerIntermediaryClass = new CheckerIntermediaryClass();
                data = checkerIntermediaryClass.GetQuestions();
            }
            Random rand = new Random();
            int random = rand.Next(0, 15);
            QuestionsLabel.Text = data.Tables[0].Rows[random]["Question"].ToString();
            OptionALabel.Text = data.Tables[0].Rows[random]["OptionA"].ToString();
            OptionBLabel.Text = data.Tables[0].Rows[random]["OptionB"].ToString();
            Crt = data.Tables[0].Rows[random]["CorrectAnswer"].ToString();

          
        }

    }
}
