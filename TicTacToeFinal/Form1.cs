using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TicTacToeFinal
{
    public partial class Form1 : MaterialForm
    {

        //
        Player currentplayer = Player.X;
        public enum Player
        {
            X,
            O
        }
        //
        public Form1()
        {
            InitializeComponent();
            var skinmenager = MaterialSkinManager.Instance;
            skinmenager.AddFormToManage(this);
            skinmenager.Theme = MaterialSkinManager.Themes.DARK;
            skinmenager.ColorScheme = new ColorScheme(Primary.BlueGrey600,Primary.BlueGrey800,
                Primary.BlueGrey700,Accent.Amber200,TextShade.WHITE);
            button1.Click += Button_Click;
            button2.Click += Button_Click;
            button3.Click += Button_Click;
            button4.Click += Button_Click;
            button5.Click += Button_Click;
            button6.Click += Button_Click;
            button7.Click += Button_Click;
            button8.Click += Button_Click;
            button9.Click += Button_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (currentplayer==Player.X)
            {
                currentplayer = Player.X;
            }
            else
            {
                currentplayer = Player.O;
            }
        }
       private void Button_Click(object sender,EventArgs e)
        {       
            var button = (Button)sender;
            button.Text = currentplayer.ToString();
            currentplayer = currentplayer == Player.X ? Player.O : Player.X;
            button.Enabled = false;
            check();
        }
        public void check()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text=="X")
            {
                materialSingleLineTextField1.Text = "Player X wins";
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Click += Button_Click;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            //panel1.Visible = false;
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Do you realy want to Quit?","",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rez==DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }
    }
}
