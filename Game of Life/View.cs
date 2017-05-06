using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Timers;


namespace Game_of_Life
{
    public partial class View : Form
    {
        Model mod;
        bool running = false;
        int durchläufe = 0;

        // neuer timer
        private static System.Timers.Timer gameTimer;

        public View()
        {
            InitializeComponent();
            mod = new Model();
            gameTimer = new System.Timers.Timer(500);
            gameTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            gameTimer.Enabled = true;
        }
      
        // wird aufgerufen, wenn Timer tickt
        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            durchläufe++;
            lbl_durchläufe.Text = durchläufe.ToString();

            panelShow.Invalidate(); //panel clear
            Graphics g = panelShow.CreateGraphics();
            Pen black = new Pen(Color.Black);


            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (mod.gridArray[i, j] == true)
                    {
                        // Create rectangle.
                        Rectangle rect = new Rectangle(i * 5, j * 5, 5, 5); //Gridfelder 5x5 groß ; 
                                                                            //Rust: Viereck blinkt, weil Zeile in Schleife
                        g.DrawRectangle(black, rect);
                        g.FillRectangle(Brushes.Black, rect);
                    }
                }
            }

            if (running)
            {
                mod.survive();
            }
        }



        private void panelShow_Paint(object sender, MouseEventArgs e)
        {
            var relativePoint = this.PointToClient(Cursor.Position);
            int xPos = relativePoint.X;
            int yPos = relativePoint.Y;

            Point gridPoint = mod.getGridPosition(xPos, yPos);


        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (running)
            {
                running = false;
                btn_start.Text = "Start";
            }
            else
            {
                running = true;
                btn_start.Text = "Pause";
            }
        }



        private void btn_blinker_Click(object sender, EventArgs e)
        {
            mod.gridArray[50, 50] = true;
            mod.gridArray[50, 49] = true;
            mod.gridArray[50, 51] = true;
        }

        private void panelShow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var relativePoint = this.PointToClient(Cursor.Position);
                int xPos = relativePoint.X;
                int yPos = relativePoint.Y;

                Point gridPoint = mod.getGridPosition(xPos, yPos);
            }
        }
    }
}
