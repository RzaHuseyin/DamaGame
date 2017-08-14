using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaGame
{
    public partial class Form1 : Form
    {
        List<Label> LabelList = new List<Label>();
        List<Label> LabelListClick = new List<Label>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDama();
            Element(); 
        }
        public void CreateDama()
        {
            int Top = 0;
            

            for (int i = 0; i < 8; i++)
            {
                int Left = 0;
                if (i % 2 == 01) { Left+=50;}
                for (int j= 0; j < 4; j++)
                {
                    Label lbl = new Label();
                    lbl.Name = "";
                    lbl.Text = lbl.Name;
                    lbl.Size = new Size(50, 50);
                    lbl.BackColor = Color.Brown;
                    lbl.ForeColor = Color.Brown;
                    lbl.Font = new Font("Serif", 30, FontStyle.Bold );
                    lbl.Left = Left;
                    lbl.Top = Top;
                    lbl.Click += Play;
                    lbl.MouseMove += mouseMove;
                    lbl.MouseLeave += mouseLeave;

                    this.Controls.Add(lbl);
                    LabelList.Add(lbl);
                    Left += 100;
                }
                Top += 50;
            }
        }
        public void Element()
        {
            for (int i = 0; i < 12; i++)
            {
                LabelList[i].Text = "O";
                LabelList[i].ForeColor = Color.White;

            }
            for (int i = 20; i < 32; i++)
            {
                LabelList[i].Text = "O";
                LabelList[i].ForeColor = Color.Black;

            }
        }
        bool t = true;
        public void Play(object sender , EventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl.Text == "O")
            {
                LabelListClick.Add(lbl);
                if (lbl.ForeColor == Color.White)
                {

                }
                else if (lbl.ForeColor == Color.Black)
                {

                }
                t = true;
            }

            else
            {
                if (LabelListClick[LabelListClick.Count-1].ForeColor ==Color.Black )
                {
                    if ((LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left -50==lbl.Left && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Top - 50 == lbl.Top) || (LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left + 50 == lbl.Left && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Top - 50 == lbl.Top))
                    {
                        LabelListClick[LabelListClick.Count - 1].Text = "";
                        LabelListClick[LabelListClick.Count - 1].ForeColor = Color.Brown;
                        lbl.ForeColor = Color.Black;
                        lbl.Text = "O";
                    }
                    else if ((LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left - 100 == lbl.Left && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Top - 100 == lbl.Top) || (LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left + 100 == lbl.Left && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Top - 100 == lbl.Top))

                    {
                        if ((lbl.Top % 100 == 0 && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left > lbl.Left) || (lbl.Top % 100 != 0 && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left < lbl.Left))
                        {
                            if(LabelList[LabelList.IndexOf(lbl) + 4].ForeColor == Color.White)
                            {
                                One(label3);
                                LabelList[LabelList.IndexOf(lbl) + 4].Text = "";
                                LabelList[LabelList.IndexOf(lbl) + 4].ForeColor = Color.Brown;
                                lbl.ForeColor = Color.Black;
                                lbl.Text = "O";
                            }
                            
                        }
                        else if (lbl.Top % 100 == 0 && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left < lbl.Left)
                        {
                            if (LabelList[LabelList.IndexOf(lbl) + 3].ForeColor == Color.White)
                            {
                                One(label3);
                                LabelList[LabelList.IndexOf(lbl) + 3].Text = "";
                                LabelList[LabelList.IndexOf(lbl) + 3].ForeColor = Color.Brown;
                                lbl.ForeColor = Color.Black;
                                lbl.Text = "O";
                            }
                        }
                        else if (lbl.Top % 100 != 0 && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left > lbl.Left)
                        {
                            if (LabelList[LabelList.IndexOf(lbl) + 5].ForeColor == Color.White)
                            {
                                One(label3);
                                LabelList[LabelList.IndexOf(lbl) + 5].Text = "";
                                LabelList[LabelList.IndexOf(lbl) + 5].ForeColor = Color.Brown;
                                lbl.ForeColor = Color.Black;
                                lbl.Text = "O";
                            }
                        }
                    }
                    else if ((LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left - 100 == lbl.Left && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Top + 100 == lbl.Top) || (LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left + 100 == lbl.Left && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Top + 100 == lbl.Top))

                    {
                        if ((lbl.Top % 100 == 0 && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left > lbl.Left) || (lbl.Top % 100 != 0 && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left < lbl.Left))
                        {
                            if (LabelList[LabelList.IndexOf(lbl) - 4].ForeColor == Color.White)
                            {
                                One(label3);
                                LabelList[LabelList.IndexOf(lbl) - 4].Text = "";
                                LabelList[LabelList.IndexOf(lbl) - 4].ForeColor = Color.Brown;
                                lbl.ForeColor = Color.Black;
                                lbl.Text = "O";
                            }
                        }
                        else if (lbl.Top % 100 == 0 && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left < lbl.Left)
                        {
                            if (LabelList[LabelList.IndexOf(lbl) - 5].ForeColor == Color.White)
                            {
                                One(label3);
                                LabelList[LabelList.IndexOf(lbl) - 5].Text = "";
                                LabelList[LabelList.IndexOf(lbl) - 5].ForeColor = Color.Brown;
                                lbl.ForeColor = Color.Black;
                                lbl.Text = "O";
                            }
                        }
                        else if (lbl.Top % 100 != 0 && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left > lbl.Left)
                        {
                            if (LabelList[LabelList.IndexOf(lbl) - 3].ForeColor == Color.White)
                            {
                                One(label3);
                                LabelList[LabelList.IndexOf(lbl) - 3].Text = "";
                                LabelList[LabelList.IndexOf(lbl) - 3].ForeColor = Color.Brown;
                                lbl.ForeColor = Color.Black;
                                lbl.Text = "O";
                            }
                        }
                    }

                }
                else if (LabelListClick[LabelListClick.Count - 1].ForeColor == Color.White)
                {
                    if ((LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left + 50 == lbl.Left && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Top + 50 == lbl.Top) || (LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left - 50 == lbl.Left && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Top + 50 == lbl.Top))
                    {
                        LabelListClick[LabelListClick.Count - 1].Text = "";
                        LabelListClick[LabelListClick.Count - 1].ForeColor = Color.Brown;
                        lbl.ForeColor = Color.White;
                        lbl.Text = "O";
                    }
                    else if ((LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left - 100 == lbl.Left && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Top + 100 == lbl.Top) || (LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left + 100 == lbl.Left && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Top + 100 == lbl.Top))

                    {
                        if ((lbl.Top % 100 == 0 && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left > lbl.Left) || (lbl.Top % 100 != 0 && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left < lbl.Left))
                        {
                            if (LabelList[LabelList.IndexOf(lbl) -4].ForeColor == Color.Black)
                            {
                                One(label2);
                                LabelList[LabelList.IndexOf(lbl) - 4].Text = "";
                                LabelList[LabelList.IndexOf(lbl) - 4].ForeColor = Color.Brown;
                                lbl.ForeColor = Color.White;
                                lbl.Text = "O";
                            }

                        }
                        else if (lbl.Top % 100 == 0 && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left < lbl.Left)

                        {
                            if (LabelList[LabelList.IndexOf(lbl) -5 ].ForeColor == Color.Black)
                            {
                                One(label2);
                                LabelList[LabelList.IndexOf(lbl) - 5].Text = "";
                                LabelList[LabelList.IndexOf(lbl) - 5].ForeColor = Color.Brown;
                                lbl.ForeColor = Color.White;
                                lbl.Text = "O";
                            }
                        }
                        else if (lbl.Top % 100 != 0 && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left > lbl.Left)
                        {
                            if (LabelList[LabelList.IndexOf(lbl) - 3].ForeColor == Color.Black)
                            {
                                One(label2);
                                LabelList[LabelList.IndexOf(lbl) - 3].Text = "";
                                LabelList[LabelList.IndexOf(lbl) - 3].ForeColor = Color.Brown;
                                lbl.ForeColor = Color.White;
                                lbl.Text = "O";
                            }
                        }
                    }
                    else if ((LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left - 100 == lbl.Left && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Top - 100 == lbl.Top) || (LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left + 100 == lbl.Left && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Top - 100 == lbl.Top))

                    {
                        if ((lbl.Top % 100 == 0 && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left > lbl.Left) || (lbl.Top % 100 != 0 && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left < lbl.Left))
                        {
                            if (LabelList[LabelList.IndexOf(lbl) +4].ForeColor == Color.Black)
                            {
                                One(label2);
                                LabelList[LabelList.IndexOf(lbl) + 4].Text = "";
                                LabelList[LabelList.IndexOf(lbl) + 4].ForeColor = Color.Brown;
                                lbl.ForeColor = Color.White;
                                lbl.Text = "O";
                            }

                        }
                        else if (lbl.Top % 100 == 0 && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left < lbl.Left)
                        {
                            if (LabelList[LabelList.IndexOf(lbl) +3].ForeColor == Color.Black)
                            {
                                One(label2);
                                LabelList[LabelList.IndexOf(lbl) + 3].Text = "";
                                LabelList[LabelList.IndexOf(lbl) + 3].ForeColor = Color.Brown;
                                lbl.ForeColor = Color.White;
                                lbl.Text = "O";
                            }
                        }
                        else if (lbl.Top % 100 != 0 && LabelList[LabelList.IndexOf(LabelListClick[LabelListClick.Count - 1])].Left > lbl.Left)
                        {
                            if (LabelList[LabelList.IndexOf(lbl) + 5].ForeColor == Color.Black)
                            {
                                One(label2);
                                LabelList[LabelList.IndexOf(lbl) + 5].Text = "";
                                LabelList[LabelList.IndexOf(lbl) + 5].ForeColor = Color.Brown;
                                lbl.ForeColor = Color.White;
                                lbl.Text = "O";
                            }
                        }
                    }
                }
                
                t = false;
            }
            Check();
        }
        public void mouseMove(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.BackColor = Color.Aqua;
            
        }
        public void mouseLeave(object sender, EventArgs e)
        {
            foreach (var item in LabelList)
            {
                item.BackColor = Color.Brown;
            }
        }
        public void Check()
        {
            if ( label2.Text=="12" )
            {
                this.BackColor = Color.Silver;
                MessageBox.Show("Ag xanali oyuncu qazandi. Tebrikler");
            }
            else if (label3.Text == "12")
            {
                this.BackColor = Color.Gold;
                MessageBox.Show("Qara xanali oyuncu qazandi. Tebrikler");

            }
        }
        public void One( Label lbl)
        {
            LabelListClick[LabelListClick.Count - 1].Text = "";
            LabelListClick[LabelListClick.Count - 1].ForeColor = Color.Brown;
            lbl.Text = (Convert.ToInt32(lbl.Text) + 1).ToString();

        }
    }
}
