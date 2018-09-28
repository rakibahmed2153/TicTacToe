using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatchingCardgame.Properties;

namespace MatchingCardgame
{
    public partial class Form1 : Form
    {
       
        Random location = new Random();
        List<Point> points = new List<Point>();
     
       PictureBox PendingImage1;
       PictureBox PendingImage2;
       

        public Form1()
        {
            InitializeComponent();
            NewGameButton.Enabled = false;
            ShowAll.Enabled = false;
            button2.Hide();
            button3.Hide();
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Resources.Cover;
            }
        }

        private void Card1_Click(object sender, EventArgs e)
        {
            Card1.Image = Resources.Card1;
            Card1.Enabled = false;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card1;
            }
             else if (PendingImage1 != null && PendingImage2 == null)
            {
               
                PendingImage2 = Card1;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                Card1.Enabled = true;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    //Card1.Enabled = false;
                    //DubCard1.Enabled = false;
                    Card1.Visible = false;
                    DubCard1.Visible = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 1);
                    if (ScoreCounter.Text == "0")
                    {
                        MessageBox.Show("You Win The Game..", "Congratulation");
                       // New();
                        reset();
                    }
                }
                else
                {
                    
                    timer3.Start();
                }
               
            }
        }

        private void DubCard1_Click(object sender, EventArgs e)
        {
            DubCard1.Image = Resources.Card1;
            DubCard1.Enabled = false;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard1;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                
                PendingImage2 = DubCard1;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    //Card1.Enabled = false;
                    //DubCard1.Enabled = false;
                    Card1.Visible = false;
                    DubCard1.Visible = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 1);
                    if (ScoreCounter.Text == "0")
                    {
                        MessageBox.Show("You Win The Game", "Congratulation");
                        //New();
                        reset();
                    }
                }
                else
                {
                    
                    timer3.Start();
                }
                
            }
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            Card2.Image = Resources.Card2;
            Card2.Enabled = false;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    //Card2.Enabled = false;
                    //DubCard2.Enabled = false;
                    Card2.Visible = false;
                    DubCard2.Visible = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 1);
                    if (ScoreCounter.Text == "0")
                    {
                        MessageBox.Show("You Win The Game", "Congratulation");
                        //New();
                        reset();
                    }
                }
                else
                {
                    
                    timer3.Start();
                }
            }
        }

        private void DubCard2_Click(object sender, EventArgs e)
        {
            DubCard2.Image = Resources.Card2;
            DubCard2.Enabled = false;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    //Card2.Enabled = false;
                    //DubCard2.Enabled = false;
                    Card2.Visible = false;
                    DubCard2.Visible = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 1);
                    if (ScoreCounter.Text == "0")
                    {
                        MessageBox.Show("You Win The Game", "Congratulation");
                       
                        //New();
                        reset();
                        
                    }
                }
                else
                {
                    
                    timer3.Start();
                }
            }
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            Card3.Image = Resources.Card3;
            Card3.Enabled = false;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card3;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    //Card3.Enabled = false;
                    //DubCard3.Enabled = false;
                    Card3.Visible = false;
                    DubCard3.Visible = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 1);
                    if (ScoreCounter.Text == "0")
                    {
                        MessageBox.Show("You Win The Game", "Congratulation");
                       // New();
                        reset();
                    }
                }
                else
                {
                    
                    timer3.Start();
                }
            }
        }

        private void DubCard3_Click(object sender, EventArgs e)
        {
            DubCard3.Image = Resources.Card3;
            DubCard3.Enabled = false;
             if (PendingImage1 == null)
            {
                PendingImage1 = DubCard3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard3;
            }
             if (PendingImage1 != null && PendingImage2 != null)
             {
                 if (PendingImage1.Tag == PendingImage2.Tag)
                 {
                     PendingImage1 = null;
                     PendingImage2 = null;
                     //Card3.Enabled = false;
                     //DubCard3.Enabled = false;
                     Card3.Visible = false;
                     DubCard3.Visible = false;
                     ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 1);
                     if (ScoreCounter.Text == "0")
                     {
                         MessageBox.Show("You Win The Game", "Congratulation");
                        // New();
                         reset();
                     }
                 }
                 else
                 {
                    
                     timer3.Start();
                 }
             }
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            Card4.Image = Resources.Card4;
            Card4.Enabled = false;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    //Card4.Enabled = false;
                    //DubCard4.Enabled = false;
                    Card4.Visible = false;
                    DubCard4.Visible = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 1);
                    if (ScoreCounter.Text == "0")
                    {
                        MessageBox.Show("You Win The Game", "Congratulation");
                       // New();
                        reset();
                    }
                }
                else
                {
                   
                    timer3.Start();
                }
            }
        }

        private void DubCard4_Click(object sender, EventArgs e)
        {
            DubCard4.Image = Resources.Card4;
            DubCard4.Enabled = false;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    //Card4.Enabled = false;
                    //DubCard4.Enabled = false;
                    Card4.Visible = false;
                    DubCard4.Visible = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 1);
                    if (ScoreCounter.Text == "0")
                    {
                        MessageBox.Show("You Win The Game", "Congratulation");
                        //New();
                        reset();
                    }
                }
                else
                {
                 
                    timer3.Start();
                }
            }
        }

        private void Card5_Click(object sender, EventArgs e)
        {
            Card5.Image = Resources.Card5;
            Card5.Enabled = false;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    //Card5.Enabled = false;
                    //DubCard5.Enabled = false;
                    Card5.Visible = false;
                    DubCard5.Visible = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 1);
                    if (ScoreCounter.Text == "0")
                    {
                        MessageBox.Show("You Win The Game", "Congratulation");
                       // New();
                        reset();
                    }
                }
                else
                {
                   
                    timer3.Start();
                }
            }
        }

        private void DubCard5_Click(object sender, EventArgs e)
        {
            DubCard5.Image = Resources.Card5;
            DubCard5.Enabled = false;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    //Card5.Enabled = false;
                    //DubCard5.Enabled = false;
                    Card5.Visible = false;
                    DubCard5.Visible = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 1);
                    if (ScoreCounter.Text == "0")
                    {
                        MessageBox.Show("You Win The Game", "Congratulation");
                        //New();
                        reset();
                    }
                }
                else
                {
                  
                    timer3.Start();
                }
            }
        }

        private void Card6_Click(object sender, EventArgs e)
        {
            Card6.Image = Resources.Card6;
            Card6.Enabled = false;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    //Card6.Enabled = false;
                    //DubCard6.Enabled = false;
                    Card6.Visible = false;
                    DubCard6.Visible = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 1);
                    if (ScoreCounter.Text == "0")
                    {
                        MessageBox.Show("You Win The Game", "Congratulation");
                        //New();
                        reset();
                    }
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard6_Click(object sender, EventArgs e)
        {
            DubCard6.Image = Resources.Card6;
            DubCard6.Enabled = false;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                
                PendingImage2 = DubCard6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    //Card6.Enabled = false;
                    //DubCard6.Enabled = false;
                    Card6.Visible = false;
                    DubCard6.Visible = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 1);
                    if (ScoreCounter.Text == "0")
                    {
                        MessageBox.Show("You Win The Game", "Congratulation");
                        //New();
                        reset();
                    }
                }
                else
                {
                    
                    timer3.Start();
                }
            }
        }

        private void Card7_Click(object sender, EventArgs e)
        {
            Card7.Image = Resources.Card7;
            Card7.Enabled = false;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card7;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    //Card7.Enabled = false;
                    //DubCard7.Enabled = false;
                    Card7.Visible = false;
                    DubCard7.Visible = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 1);
                    if (ScoreCounter.Text == "0")
                    {
                        MessageBox.Show("You Win The Game", "Congratulation");
                        //New();
                        reset();
                    }
                }
                else
                {
                    
                    timer3.Start();
                }
            }
        }

        private void DubCard7_Click(object sender, EventArgs e)
        {
            DubCard7.Image = Resources.Card7;
            DubCard7.Enabled = false;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard7;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    //Card7.Enabled = false;
                    //DubCard7.Enabled = false;
                    Card7.Visible = false;
                    DubCard7.Visible = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 1);
                    if (ScoreCounter.Text == "0")
                    {
                        MessageBox.Show("You Win The Game", "Congratulation");
                        //New();
                        reset();
                    }
                }
                else
                {
                    
                    timer3.Start();
                }
            }
        }

        private void Card8_Click(object sender, EventArgs e)
        {
            Card8.Image = Resources.Card8;
            Card8.Enabled = false;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card8;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    //Card8.Enabled = false;
                    //DubCard8.Enabled = false;
                    Card8.Visible = false;
                    DubCard8.Visible = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 1);
                    if (ScoreCounter.Text == "0")
                    {
                        MessageBox.Show("You Win The Game", "Congratulation");
                        reset();
                    }
                }
                else
                {
                   
                    timer3.Start();
                }
            }
        }

        private void DubCard8_Click(object sender, EventArgs e)
        {
            DubCard8.Image = Resources.Card8;
            DubCard8.Enabled = false;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard8;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                   // Card8.Enabled = false;
                   // DubCard8.Enabled = false;
                    Card8.Visible = false;
                    DubCard8.Visible = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 1);
                    if (ScoreCounter.Text == "0")
                    {
                        MessageBox.Show("You Win The Game","Congratulation");
                       // New();
                        reset();
                    }
                }
                else
                {
                    
                    timer3.Start();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label5.Text);
            timer = timer - 1;
            label5.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer2.Stop();
                NewGameButton.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = true;

            }
            timer3.Stop();
            PendingImage1.Image = Properties.Resources.Cover;
            PendingImage2.Image = Properties.Resources.Cover;
            PendingImage1 = null;
            PendingImage2 = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                NewGameButton.Enabled = false;
                ShowAll.Enabled = true;
                timer4.Start();
                foreach (PictureBox picture in CardsHolder.Controls)
                {
                    picture.Enabled = false;
                    points.Add(picture.Location);
                }
                foreach (PictureBox picture in CardsHolder.Controls)
                {
                    int next = location.Next(points.Count);
                    Point p = points[next];
                    picture.Location = p;
                    points.Remove(p);
                }

                foreach (PictureBox picture in CardsHolder.Controls)
                {
                    picture.Enabled = true;
                    picture.Cursor = Cursors.Hand;
                    picture.Image = Resources.Cover;
                }

                
                
                NewGameButton.Enabled = true;
                ShowAll.Enabled = true;
                
                button1.Hide();
                button2.Show();
            
            

        }

        

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void New()
        {
            Time.Text = "60";
            ScoreCounter.Text = "8";
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = false;
                
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                int next = location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
              
               foreach (PictureBox picture1 in CardsHolder.Controls)
               { 
                   picture.Visible = true;
                   picture1.Enabled = true;
                   picture1.Cursor = Cursors.Hand;
                   picture1.Image = Resources.Cover;
               }
            }

            
            button1.Enabled = false;
            NewGameButton.Enabled = true;


                
           
            
        }

        

        private void NewGame_Button(object sender, EventArgs e)
        {
            New();
        }
        private void reset()
        {
            timer4.Stop();
            ShowAll.Enabled = false;
            New();
            button2.Hide();
            button1.Enabled = true;
            button1.Show();
            NewGameButton.Enabled = false;
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = false;

            }

        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(Time.Text);
            time = time - 1;
            Time.Text = Convert.ToString(time);
            if (time == 0)
            {
                timer4.Stop();
                MessageBox.Show("Play Again","TimeOut!!!");
                ShowAll.Enabled = false;
                New();
                button2.Hide();
                button1.Enabled = true;
                button1.Show();
                NewGameButton.Enabled = false;
                foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = false;
               
            }
                
            }
            
        }

        private void ShowAll_Button(object sender, EventArgs e)
        {

            
            label5.Text = "3";
            timer2.Start();
            timer1.Start();
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = false;

            }
            Card1.Image = Resources.Card1;
            DubCard1.Image = Resources.Card1;
            Card2.Image = Resources.Card2;
            DubCard2.Image = Resources.Card2;
            Card3.Image = Resources.Card3;
            DubCard3.Image = Resources.Card3;
            Card4.Image = Resources.Card4;
            DubCard4.Image = Resources.Card4;
            Card5.Image = Resources.Card5;
            DubCard5.Image = Resources.Card5;
            Card6.Image = Resources.Card6;
            DubCard6.Image = Resources.Card6;
            Card7.Image = Resources.Card7;
            DubCard7.Image = Resources.Card7;
            Card8.Image = Resources.Card8;
            DubCard8.Image = Resources.Card8;
            button1.Enabled = false;
            NewGameButton.Enabled = false;
            button2.Enabled = false;
            PendingImage1 = null;
            PendingImage2 = null;
        }

        private void Pause_Button(object sender, EventArgs e)
        {
            button2.Hide();
            button3.Show();
            NewGameButton.Enabled = false;
            ShowAll.Enabled = false;
            timer4.Stop();
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = false;
               
            }
            
        }

        private void Button_Resume(object sender, EventArgs e)
        {
            timer4.Start();
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = true;

            }
            button3.Hide();
            button2.Show();
            NewGameButton.Enabled = true;
            ShowAll.Enabled = true;

        }

       

        
    }
}
