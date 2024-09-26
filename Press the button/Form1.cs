using System;

namespace Press_the_button
{
    public partial class Form1 : Form
    {
        int i = 0;
        int cycle1 = 0;
        int cycle2 = 0;
        int StageLable = 0;
        int cycle3 = 0;
        public bool Zamceno = false;

        public Form1()
        {
            Random random = new Random();

            InitializeComponent();
            if (Zamceno == true)
            {
               button1.ForeColor = Color.Black;
            }
        }
        
        private void Title_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Stage.Value == Stage.Maximum)
            {
                MessageBox.Show("vyhral si, gratuluji");
                return;
            }
            switch (i)
            {
                case 0:
                    stage1();
                    break;
                case 1:
                    stage2();
                    break;
                case 2:
                    stage3();
                    break;
                case 3:
                    stage4();
                    break;


            }

            int stage1()
            {
                if (cycle1 >= 2)
                {
                    i++;
                }
                if (cycle1 == 0 || cycle1 == 1)
                {


                    if (Stage.Value == 9)
                    {
                        if (cycle1 == 0)
                        {
                            MessageBox.Show("zmáčkl jsi ho 10krát, necitil jsem skvěle? co takhle znova");

                        }
                        if (cycle1 == 1)
                        {
                            MessageBox.Show("dobra prace, zmáčkl jsi to znova 10krát");
                        }

                        Stage.Value = 0;
                        StageLabel.Text = Stage.Value.ToString() + "/100";
                        cycle1++;
                    }
                    else
                    {
                        Stage.Value++;
                        StageLabel.Text = Stage.Value.ToString() + "/100";
                    }
                }
                return i;
            }
            int stage2()
            {
                if (cycle2 == 0)
                {
                    MessageBox.Show("Daří se ti skvělě,přičtu ti 10");
                    Stage.Value = 10;
                    cycle2++;
                }
                if (Stage.Value == 38 && cycle2 == 1)
                {
                    i++;
                }
                Stage.Value++;
                Stage.Maximum = 100;
                StageLabel.Text = Stage.Value.ToString() + "/100";

                return i;
            }
            int stage3()
            {
                if (Stage.Value == 99 && cycle3 == 60)
                {
                    MessageBox.Show("šlo ti to skvěle,tak si to zopakujeme,ale tentokrát to bude těžší");

                    Stage.Value = 0;
                    StageLabel.Text = Stage.Value.ToString() + "/100";
                    i++;
                }
                cycle3++;
                Stage.Value++;
                StageLabel.Text = Stage.Value.ToString() + "/100";
                MessageBox.Show("nespamuj ");
                label2.Text = cycle3.ToString();
                return i;


            }
            int stage4()
            {
                Zamceno = true;
              
                //int formWidth = this.ClientSize.Width;
                //int formHeight = this.ClientSize.Height;


                //int buttonWidth = Button.Width;
                //int buttonHeight = Button.Height;


                ////int x = random.Next(0, formWidth - buttonWidth);
                ////int y = random.Next(0, formHeight - buttonHeight);


                ////btnRandomPosition.Location = new Point(x, y);
                return i;
            }
            int stage5()// schovane zamcene tlacitko
            {
                return i;
            }
            int stage6()//  vložte file (přes FileSystémWatcher)
            {
                return i;
            }
            int stage7()// pes vám jí stage! musíte mačkat rychleji (timer)
            {
                    return i;   
            }       
            int stage8()//  Vložte obrázek (maybye)
            {
                return i;
            }
        }

        private void RestartButton_Click_1(object sender, EventArgs e)
        {
            Stage.Value = 0;
            cycle1 = 0;
            i = 0;
            StageLabel.Text = Stage.Value.ToString() + "/100";
            cycle2 = 0;
            cycle3 = 0;
            label2.Text = cycle3.ToString();
        }
    }
}


//libor was here ;) :* :P