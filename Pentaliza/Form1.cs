using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pentaliza
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        bool pcplays = false;
        int yo2 = 0;
        public Form1()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }
        int Checker = 1;  //metavliti pou metraw gia to pote tha vazw x kai pote O

        private void Button_Click(object sender, EventArgs e) //xrisimopoiw to idio event gia ola ta koumpia
        {
            Button Bttn = sender as Button;  //apothikeuw se mia metavliti Button to koumpi pou patithike
            if (pcplays == false) //elenxw an exei epileksei to P1vsP2
            {
                if (Bttn.Text != "X" && Bttn.Text != "O" && (yo2 != 1))  //eksasfalizw oti to bttn einai keno wste na min mporei na ksanapatithei
                {
                    Checker = Checker + 1;
                    if (Checker % 2 == 0)   //o 1os ksekinaei me X
                    {
                        Bttn.ForeColor = Color.Blue;
                        Bttn.Text = "X";
                    }
                    else
                        Bttn.Text = "O";
                   Winner();
                }
            }
            else //an exei epileksei to P1vsPC
            {
                Button[] Buttons = new Button[25] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25 };
                if (Bttn.Text != "X" && Bttn.Text != "O" && (yo2 != 1))
                {
                    Checker = Checker + 1;
                    Bttn.Text = "X";
                    if (Checker < 14) //wste na mporw sto teleutaio koutaki stin peritwsi pou den uparxei nikitis na grapsw xwris na kanei apeira loop gia na vrei adio koutaki gia to pc
                    {
                        int numbers = rnd.Next(0, 25); //random arithmous
                        while (Buttons[numbers].Text != " ") //elgxos wste na paiksei se button pou einai keno
                        {
                            numbers = rnd.Next(0, 25);
                        }
                        Bttn.ForeColor = Color.Blue;
                        Buttons[numbers].Text = "O";
                        Winner();
                    }
                    else
                        Bttn.ForeColor = Color.Blue;
                        Winner();
                }
            }
        }
        private void Winner() //klasi pou elegxw gia nikiti
        {
            bool Winner1 = false; //bool gia to an uparxei nikitis
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (button3.Text == button4.Text) && (button4.Text == button5.Text)
                && (button1.Text != " "))//an vrethei nikitis(to idio kai gia ta upolipa)
            {
                button1.ForeColor = Color.Red; button2.ForeColor = Color.Red; button3.ForeColor = Color.Red; button4.ForeColor = Color.Red; button5.ForeColor = Color.Red;//kokkino xrwma sta button pou kerdizoun
                yo2 = 1;
                Winner1 = true; 
                if (button1.Text == "X") //elenxei an kerdise autos me to X
                    MessageBox.Show("Winner is P1(user of 'x')");
                else if (button1.Text == "O") //elenxei an kerdise autos me to O
                    if (pcplays)
                        MessageBox.Show("Winner is PC(user of 'O'");
                    else
                        MessageBox.Show("Winner is P2(user of 'O')");
            }
            if ((button6.Text == button7.Text) && (button7.Text == button8.Text) && (button8.Text == button9.Text) && (button9.Text == button10.Text)
                && (button6.Text != " "))
            {
                button6.ForeColor = Color.Red; button7.ForeColor = Color.Red; button8.ForeColor = Color.Red; button9.ForeColor = Color.Red; button10.ForeColor = Color.Red;
                yo2 = 1;
                Winner1 = true;
                if (button6.Text == "X")
                    MessageBox.Show("Winner is P1(user of 'x')");
                else if (button6.Text == "O")
                    if (pcplays)
                        MessageBox.Show("Winner is PC(user of 'O'");
                    else
                        MessageBox.Show("Winner is P2(user of 'O')");
            }
            if ((button11.Text == button12.Text) && (button12.Text == button13.Text) && (button13.Text == button14.Text) && (button14.Text == button15.Text)
                && (button11.Text != " "))
            {
                button11.ForeColor = Color.Red; button12.ForeColor = Color.Red; button13.ForeColor = Color.Red; button14.ForeColor = Color.Red; button15.ForeColor = Color.Red;
                yo2 = 1;
                Winner1 = true;
                if (button11.Text == "X")
                    MessageBox.Show("Winner is P1(user of 'x')");
                else if (button11.Text == "O")
                    if (pcplays)
                        MessageBox.Show("Winner is PC(user of 'O'");
                    else
                        MessageBox.Show("Winner is P2(user of 'O')");
            }
            if ((button16.Text == button17.Text) && (button17.Text == button18.Text) && (button18.Text == button19.Text) && (button19.Text == button20.Text)
                && (button16.Text != " "))
            {
                button16.ForeColor = Color.Red; button17.ForeColor = Color.Red; button18.ForeColor = Color.Red; button19.ForeColor = Color.Red; button20.ForeColor = Color.Red;
                yo2 = 1;
                Winner1 = true;
                if (button16.Text == "X")
                    MessageBox.Show("Winner is P1(user of 'x')");
                else if (button16.Text == "O")
                    if (pcplays)
                        MessageBox.Show("Winner is PC(user of 'O'");
                    else
                        MessageBox.Show("Winner is P2(user of 'O')");
            }
            if ((button21.Text == button22.Text) && (button22.Text == button23.Text) && (button23.Text == button24.Text) && (button24.Text == button25.Text)
                && (button21.Text != " "))
            {
                button21.ForeColor = Color.Red; button22.ForeColor = Color.Red; button23.ForeColor = Color.Red; button24.ForeColor = Color.Red; button25.ForeColor = Color.Red;
                yo2 = 1;
                Winner1 = true;
                if (button21.Text == "X")
                    MessageBox.Show("Winner is P1(user of 'x')");
                else if (button21.Text == "O")
                    if (pcplays)
                        MessageBox.Show("Winner is PC(user of 'O'");
                    else
                        MessageBox.Show("Winner is P2(user of 'O')");
            }
            if ((button1.Text == button6.Text) && (button6.Text == button11.Text) && (button11.Text == button16.Text) && (button16.Text == button21.Text)
                && (button1.Text != " "))
            {
                button1.ForeColor = Color.Red; button6.ForeColor = Color.Red; button11.ForeColor = Color.Red; button16.ForeColor = Color.Red; button21.ForeColor = Color.Red;
                yo2 = 1;
                Winner1 = true;
                if (button1.Text == "X")
                    MessageBox.Show("Winner is P1(user of 'x')");
                else if (button1.Text == "O")
                    if (pcplays)
                        MessageBox.Show("Winner is PC(user of 'O'");
                    else
                        MessageBox.Show("Winner is P2(user of 'O')");
            }
            if ((button2.Text == button7.Text) && (button7.Text == button12.Text) && (button12.Text == button17.Text) && (button17.Text == button22.Text)
                && (button2.Text != " "))
            {
                button2.ForeColor = Color.Red; button7.ForeColor = Color.Red; button12.ForeColor = Color.Red; button17.ForeColor = Color.Red; button22.ForeColor = Color.Red;
                yo2 = 1;
                Winner1 = true;
                if (button2.Text == "X")
                    MessageBox.Show("Winner is P1(user of 'x')");
                else if (button2.Text == "O")
                    if (pcplays)
                        MessageBox.Show("Winner is PC(user of 'O'");
                    else
                        MessageBox.Show("Winner is P2(user of 'O')");
            }
            if ((button3.Text == button8.Text) && (button8.Text == button13.Text) && (button13.Text == button18.Text) && (button18.Text == button23.Text)
                && (button3.Text != " "))
            {
                button3.ForeColor = Color.Red; button8.ForeColor = Color.Red; button13.ForeColor = Color.Red; button18.ForeColor = Color.Red; button23.ForeColor = Color.Red;
                yo2 = 1;
                Winner1 = true;
                if (button3.Text == "X")
                    MessageBox.Show("Winner is P1(user of 'x')");
                else if (button3.Text == "O")
                    if (pcplays)
                        MessageBox.Show("Winner is PC(user of 'O'");
                    else
                        MessageBox.Show("Winner is P2(user of 'O')");
            }
            if ((button4.Text == button9.Text) && (button9.Text == button14.Text) && (button14.Text == button19.Text) && (button19.Text == button24.Text)
                && (button4.Text != " "))
            {
                button4.ForeColor = Color.Red; button9.ForeColor = Color.Red; button14.ForeColor = Color.Red; button19.ForeColor = Color.Red; button24.ForeColor = Color.Red;
                yo2 = 1;
                Winner1 = true;
                if (button4.Text == "X")
                    MessageBox.Show("Winner is P1(user of 'x')");
                else if (button4.Text == "O")
                    if (pcplays)
                        MessageBox.Show("Winner is PC(user of 'O'");
                    else
                        MessageBox.Show("Winner is P2(user of 'O')");
            }
            if ((button5.Text == button10.Text) && (button10.Text == button15.Text) && (button15.Text == button20.Text) && (button20.Text == button25.Text)
                && (button5.Text != " "))
            {
                button5.ForeColor = Color.Red; button10.ForeColor = Color.Red; button15.ForeColor = Color.Red; button20.ForeColor = Color.Red; button25.ForeColor = Color.Red;
                yo2 = 1;
                Winner1 = true;
                if (button5.Text == "X")
                    MessageBox.Show("Winner is P1(user of 'x')");
                else if (button5.Text == "O")
                    if (pcplays)
                        MessageBox.Show("Winner is PC(user of 'O'");
                    else
                        MessageBox.Show("Winner is P2(user of 'O')");
            }
            if ((button1.Text == button7.Text) && (button7.Text == button13.Text) && (button13.Text == button19.Text) && (button19.Text == button25.Text)
                && (button1.Text != " "))
            {
                button1.ForeColor = Color.Red; button7.ForeColor = Color.Red; button13.ForeColor = Color.Red; button19.ForeColor = Color.Red; button25.ForeColor = Color.Red;
                yo2 = 1;
                Winner1 = true;
                if (button1.Text == "X")
                    MessageBox.Show("Winner is P1(user of 'x')");
                else if (button1.Text == "O")
                    if (pcplays)
                        MessageBox.Show("Winner is PC(user of 'O'");
                    else
                        MessageBox.Show("Winner is P2(user of 'O')");
            }
            if ((button5.Text == button9.Text) && (button9.Text == button13.Text) && (button13.Text == button17.Text) && (button17.Text == button21.Text)
                && (button5.Text != " "))
            {
                button5.ForeColor = Color.Red; button9.ForeColor = Color.Red; button13.ForeColor = Color.Red; button17.ForeColor = Color.Red; button21.ForeColor = Color.Red;
                yo2 = 1;
                Winner1 = true;
                if (button5.Text == "X")
                    MessageBox.Show("Winner is P1(user of 'x')");
                else if (button5.Text == "O")
                    if (pcplays)
                        MessageBox.Show("Winner is PC(user of 'O'");
                    else
                        MessageBox.Show("Winner is P2(user of 'O')");
            }
            if ((Checker == 26) && (Winner1 == false) && (pcplays==false)) //den uparxei nikitis sto P1vsP2 ara vgazw minima
            {
                MessageBox.Show("No Winner");
            }
            if ((Checker == 14) && (Winner1 == false) && (pcplays == true)) //den uparxei nikitis sto P1vsPC ara vgazw minima
            {
                MessageBox.Show("No Winner");
            }
        }

        private void p1VsP2ToolStripMenuItem_Click(object sender, EventArgs e) //otan pataei to newgame-->P1vsP2 adeiazw ta koumpia kai vazw ton checker=1 wste o 1os na ksekinisei palu me X.kanw kai to xrwma olwn twn button mauro
        {
            pcplays = false;
            yo2 = 0;
            Checker = 1;
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            button10.Text = " ";
            button11.Text = " ";
            button12.Text = " ";
            button13.Text = " ";
            button14.Text = " ";
            button15.Text = " ";
            button16.Text = " ";
            button17.Text = " ";
            button18.Text = " ";
            button19.Text = " ";
            button20.Text = " ";
            button21.Text = " ";
            button22.Text = " ";
            button23.Text = " ";
            button24.Text = " ";
            button25.Text = " ";
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
            button7.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;
            button9.ForeColor = Color.Black;
            button10.ForeColor = Color.Black;
            button11.ForeColor = Color.Black;
            button12.ForeColor = Color.Black;
            button13.ForeColor = Color.Black;
            button14.ForeColor = Color.Black;
            button15.ForeColor = Color.Black;
            button16.ForeColor = Color.Black;
            button17.ForeColor = Color.Black;
            button18.ForeColor = Color.Black;
            button19.ForeColor = Color.Black;
            button20.ForeColor = Color.Black;
            button21.ForeColor = Color.Black;
            button22.ForeColor = Color.Black;
            button23.ForeColor = Color.Black;
            button24.ForeColor = Color.Black;
            button25.ForeColor = Color.Black;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Iwanna-Giwrgos-Stathis");
        }

        private void p1VsPCToolStripMenuItem_Click(object sender, EventArgs e) //otan pataei to newgame-->P1vsPC adeiazw ta koumpia kai vazw ton checker=1 wste o 1os na ksekinisei palu me X.kanw kai to xrwma olwn ton button mauro
        {
            pcplays = true;
            yo2 = 0;
            Checker = 1;
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            button10.Text = " ";
            button11.Text = " ";
            button12.Text = " ";
            button13.Text = " ";
            button14.Text = " ";
            button15.Text = " ";
            button16.Text = " ";
            button17.Text = " ";
            button18.Text = " ";
            button19.Text = " ";
            button20.Text = " ";
            button21.Text = " ";
            button22.Text = " ";
            button23.Text = " ";
            button24.Text = " ";
            button25.Text = " ";
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
            button7.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;
            button9.ForeColor = Color.Black;
            button10.ForeColor = Color.Black;
            button11.ForeColor = Color.Black;
            button12.ForeColor = Color.Black;
            button13.ForeColor = Color.Black;
            button14.ForeColor = Color.Black;
            button15.ForeColor = Color.Black;
            button16.ForeColor = Color.Black;
            button17.ForeColor = Color.Black;
            button18.ForeColor = Color.Black;
            button19.ForeColor = Color.Black;
            button20.ForeColor = Color.Black;
            button21.ForeColor = Color.Black;
            button22.ForeColor = Color.Black;
            button23.ForeColor = Color.Black;
            button24.ForeColor = Color.Black;
            button25.ForeColor = Color.Black;
        }
    }
}
