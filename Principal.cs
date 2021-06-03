﻿using Elevator_Simulator.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        #endregion

        #region private methods

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
            switch (actions)
            {
                case ElevatorAction.MoveUp:
                    if (ElevatorBreak == LASTFLOOR)
                        break;
                    pbx_elevator.Location = Floors.Where(obj => obj.Key == ElevatorBreak + 1).FirstOrDefault().Value;
                    ElevatorBreak++;
                    break;
                case ElevatorAction.MoveDown:
                    if (ElevatorBreak == FIRSTFLOOR)
                        break;
                    pbx_elevator.Location = Floors.Where(obj => obj.Key == ElevatorBreak - 1).FirstOrDefault().Value;
                    ElevatorBreak--;
                    break;
                default:
                    break;
            }
        }
        #endregion

    }
}