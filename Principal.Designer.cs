
namespace Elevator_Simulator
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbx_building = new System.Windows.Forms.PictureBox();
            this.pbx_control = new System.Windows.Forms.PictureBox();
            this.pbx_elevator = new System.Windows.Forms.PictureBox();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_building)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_elevator)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_building
            // 
            this.pbx_building.Image = global::Elevator_Simulator.Properties.Resources.Building;
            this.pbx_building.Location = new System.Drawing.Point(428, 12);
            this.pbx_building.Name = "pbx_building";
            this.pbx_building.Size = new System.Drawing.Size(344, 537);
            this.pbx_building.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_building.TabIndex = 0;
            this.pbx_building.TabStop = false;
            // 
            // pbx_control
            // 
            this.pbx_control.Image = global::Elevator_Simulator.Properties.Resources.control;
            this.pbx_control.Location = new System.Drawing.Point(12, 12);
            this.pbx_control.Name = "pbx_control";
            this.pbx_control.Size = new System.Drawing.Size(344, 537);
            this.pbx_control.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_control.TabIndex = 1;
            this.pbx_control.TabStop = false;
            // 
            // pbx_elevator
            // 
            this.pbx_elevator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_elevator.Image = global::Elevator_Simulator.Properties.Resources.elevator;
            this.pbx_elevator.Location = new System.Drawing.Point(572, 45);
            this.pbx_elevator.Name = "pbx_elevator";
            this.pbx_elevator.Size = new System.Drawing.Size(36, 56);
            this.pbx_elevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_elevator.TabIndex = 2;
            this.pbx_elevator.TabStop = false;
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(362, 25);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(60, 23);
            this.btn_up.TabIndex = 3;
            this.btn_up.Text = "Up";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(362, 54);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(60, 23);
            this.btn_down.TabIndex = 4;
            this.btn_down.Text = "Down";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.pbx_elevator);
            this.Controls.Add(this.pbx_control);
            this.Controls.Add(this.pbx_building);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elevator Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_building)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_elevator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_building;
        private System.Windows.Forms.PictureBox pbx_control;
        private System.Windows.Forms.PictureBox pbx_elevator;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
    }
}

