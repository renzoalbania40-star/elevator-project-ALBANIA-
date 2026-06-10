using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace elevatorController4Floor
{
    public partial class Form1 : Form
    {
        List<int> requests = new List<int>();

        int currentFloor = 1;
        int targetFloor = 1;

        bool moving = false;

        int[] floorY = { 420, 320, 220, 120 };

        public Form1()
        {
            InitializeComponent();

            panelElevator.Top = floorY[0];

            timerMove.Interval = 20;
            timerDoorOpen.Interval = 20;
            timerDoorClose.Interval = 20;

            btn1.Click += btn1_Click;
            btn2.Click += btn2_Click;
            btn3.Click += btn3_Click;
            btn4.Click += btn4_Click;

            timerMove.Tick += timerMove_Tick;
            timerDoorOpen.Tick += timerDoorOpen_Tick;
            timerDoorClose.Tick += timerDoorClose_Tick;
        }

        private void AddRequest(int floor)
        {
            if (!requests.Contains(floor))
                requests.Add(floor);

            if (!moving)
                ProcessNext();
        }

        private void ProcessNext()
        {
            if (requests.Count == 0)
                return;

            targetFloor = requests[0];
            moving = true;

            timerMove.Start();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AddRequest(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AddRequest(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AddRequest(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AddRequest(4);
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            int targetY = floorY[targetFloor - 1];

            if (panelElevator.Top > targetY)
            {
                panelElevator.Top -= 2;
            }
            else if (panelElevator.Top < targetY)
            {
                panelElevator.Top += 2;
            }
            else
            {
                timerMove.Stop();

                currentFloor = targetFloor;
                lblFloor.Text = "Floor " + currentFloor;

                timerDoorOpen.Start();
            }
        }

        private void timerDoorOpen_Tick(object sender, EventArgs e)
        {
            if (panelDoorLeft.Width > 5)
            {
                panelDoorLeft.Width -= 2;

                panelDoorRight.Left += 2;
                panelDoorRight.Width -= 2;
            }
            else
            {
                timerDoorOpen.Stop();

                requests.RemoveAt(0);

                moving = false;

                timerDoorClose.Start();
            }
        }

        private void timerDoorClose_Tick(object sender, EventArgs e)
        {
            if (panelDoorLeft.Width < 50)
            {
                panelDoorLeft.Width += 2;

                panelDoorRight.Left -= 2;
                panelDoorRight.Width += 2;
            }
            else
            {
                timerDoorClose.Stop();

                ProcessNext();
            }
        }

        private void labelFloor4_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click_1(object sender, EventArgs e)
        {

        }
    }
}