using Elevator_Simulator.Enums;
using Elevator_Simulator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Elevator_Simulator
{
    public partial class Principal : Form
    {
        #region properties
        const int ELEVATORSHAFT = 572;
        const int FIRSTFLOOR = 0;
        const int LASTFLOOR = 6;
        public int ElevatorBreak { get; set; }

        public List<KeyValuePair<int, Point>> Floors { get; set; }
        #endregion

        #region events
        private void btn_up_Click(object sender, EventArgs e)
        {
            MoveElevator(ElevatorAction.MoveUp);
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            MoveElevator(ElevatorAction.MoveDown);
        }
        #endregion

        #region constructors

        public Principal()
        {
            InitializeComponent();
            Floors = GetFloors();
            ElevatorBreak = FIRSTFLOOR;
            pbx_elevator.Location = Floors.FirstOrDefault().Value;
            BuildButtons();

        }

        #endregion

        #region private methods

        private void BuildButtons()
        {
            BuildButton(pbx_Floor0);
            BuildButton(pbx_Floor1);
            BuildButton(pbx_Floor2);
            BuildButton(pbx_Floor3);
            BuildButton(pbx_Floor4);
            BuildButton(pbx_Floor5);
            BuildButton(pbx_Floor6);
            BuildButton(ptb_emergency);
        }

        private void BuildButton(PictureBox pictureBox)
        {
            System.Drawing.Drawing2D.GraphicsPath graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            graphicsPath.AddEllipse(0, 0, pictureBox.Width - 3, pictureBox.Height - 3);
            Region region = new Region(graphicsPath);
            pictureBox.Region = region;
        }

        private List<KeyValuePair<int,Point>> GetFloors()
        {
            var floors = new List<KeyValuePair<int, Point>>();
            floors.Add(new KeyValuePair<int, Point>(0, new Point(ELEVATORSHAFT, (int)EFloors.Floor0)));
            floors.Add(new KeyValuePair<int, Point>(1, new Point(ELEVATORSHAFT, (int)EFloors.Floor1)));
            floors.Add(new KeyValuePair<int, Point>(2, new Point(ELEVATORSHAFT, (int)EFloors.Floor2)));
            floors.Add(new KeyValuePair<int, Point>(3, new Point(ELEVATORSHAFT, (int)EFloors.Floor3)));
            floors.Add(new KeyValuePair<int, Point>(4, new Point(ELEVATORSHAFT, (int)EFloors.Floor4)));
            floors.Add(new KeyValuePair<int, Point>(5, new Point(ELEVATORSHAFT, (int)EFloors.Floor5)));
            floors.Add(new KeyValuePair<int, Point>(6, new Point(ELEVATORSHAFT, (int)EFloors.Floor6)));

            return floors;
        }

        private void MoveElevator(ElevatorAction actions)
        {
            var current = Floors.Where(obj => obj.Key == ElevatorBreak).FirstOrDefault().Value;
            var next = Floors.Where(obj => obj.Key == ElevatorBreak + (actions == ElevatorAction.MoveUp ? +1 : -1)).FirstOrDefault().Value;

            switch (actions)
            {
                case ElevatorAction.MoveUp:
                    if (ElevatorBreak == LASTFLOOR)
                       break;
                    Animation(current, next);
                    ElevatorBreak++;
                    break;
                case ElevatorAction.MoveDown:
                    if (ElevatorBreak == FIRSTFLOOR)
                        break;
                    Animation(current, next);
                    ElevatorBreak--;
                    break;
                default:
                    break;
            }
        }

        private void Animation(Point current, Point next)
        {
            var movimentationTime = 5;

            var action = current.Y < next.Y ? ElevatorAction.MoveDown : ElevatorAction.MoveUp;

            if (action == ElevatorAction.MoveUp)
            {
                for (int yAxis = current.Y; yAxis >= next.Y; yAxis--)
                {
                    pbx_building.Refresh();
                    Thread.Sleep(movimentationTime);
                    pbx_elevator.Location = new Point(current.X, yAxis);
                }
            }

            if (action == ElevatorAction.MoveDown)
            {
                for (int yAxis = current.Y; yAxis <= next.Y; yAxis++)
                {
                    pbx_building.Refresh();
                    Thread.Sleep(movimentationTime);
                    pbx_elevator.Location = new Point(current.X, yAxis);
                }
            }
        }
        #endregion

    }
}
