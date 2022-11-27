using System.Drawing;

using System.Windows.Forms;

namespace ShutXUI {

    public partial class ShutXUI : Form {

        //readonly ShutXLibrary.Time time;

        //readonly ShutXLibrary.Util util;

        public ShutXUI() {
        
            InitializeComponent();

            //time = new ShutXLibrary.Time();

            //util = new ShutXLibrary.Util();

            this.BackColor = Color.FromArgb(20, 20, 20);
        
        }

        //private void HoursTextBox_KeyPress(object sender, KeyPressEventArgs e) {

        //    if (e.KeyChar == (char) 13) {

        //        time.SetHours(int.Parse(hoursTextBox.Text));

        //        time.CalculateSeconds();

        //        string Command = "shutdown -s -t " + time.GetSeconds().ToString();

        //        util.SetCommand(Command);

        //        util.ExecuteCommand();

        //        Application.Exit();

        //    }

        //}

        private void hourIncrementButton_Click(object sender, System.EventArgs e) {

            if (int.Parse(hourLabel.Text) != 99) {

                if (int.Parse(hourLabel.Text) + 1 <= 9) {

                    hourLabel.Text = "0" + (int.Parse(hourLabel.Text) + 1).ToString();

                } else {

                    hourLabel.Text = (int.Parse(hourLabel.Text) + 1).ToString();

                }

            } else {

                hourLabel.Text = "00";
                
            }

        }

        private void hourDecrementButton_Click(object sender, System.EventArgs e) {

            if (int.Parse(hourLabel.Text) != 0) {

                if (int.Parse(hourLabel.Text) + 1 <= 9) {

                    hourLabel.Text = "0" + (int.Parse(hourLabel.Text) - 1).ToString();

                } else {

                    hourLabel.Text = (int.Parse(hourLabel.Text) - 1).ToString();

                }

            } else {

                hourLabel.Text = "99";

            }

        }

        private void minuteIncrementButton_Click(object sender, System.EventArgs e) {

            if (int.Parse(minuteLabel.Text) != 60) {

                if (int.Parse(minuteLabel.Text) + 1 <= 9) {

                    minuteLabel.Text = "0" + (int.Parse(minuteLabel.Text) + 1).ToString();

                } else {

                    minuteLabel.Text = (int.Parse(minuteLabel.Text) + 1).ToString();

                }

            } else {

                minuteLabel.Text = "00";

            }

        }

        private void minuteDecrementButton_Click(object sender, System.EventArgs e) {

            if (int.Parse(minuteLabel.Text) != 0) {

                if (int.Parse(minuteLabel.Text) + 1 <= 9) {

                    minuteLabel.Text = "0" + (int.Parse(minuteLabel.Text) - 1).ToString();

                } else {

                    minuteLabel.Text = (int.Parse(minuteLabel.Text) - 1).ToString();

                }

            } else {

                minuteLabel.Text = "60";

            }

        }
    }

}
