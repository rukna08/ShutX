using System.Drawing;

using System.Windows.Forms;

namespace ShutXUI {

    public partial class ShutXUI : Form {

        readonly ShutXLibrary.Time time;

        readonly ShutXLibrary.Util util;

        public ShutXUI() {
        
            InitializeComponent();

            time = new ShutXLibrary.Time();

            util = new ShutXLibrary.Util();

            this.BackColor = Color.FromArgb(20, 20, 20);
        
        }

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

        private void secondIncrementButton_Click(object sender, System.EventArgs e) {

            if (int.Parse(secondLabel.Text) != 60) {

                if (int.Parse(secondLabel.Text) + 1 <= 9) {

                    secondLabel.Text = "0" + (int.Parse(secondLabel.Text) + 1).ToString();

                } else {

                    secondLabel.Text = (int.Parse(secondLabel.Text) + 1).ToString();

                }

            } else {

                secondLabel.Text = "00";

            }

        }

        private void secondDecrementButton_Click(object sender, System.EventArgs e) {

            if (int.Parse(secondLabel.Text) != 0) {

                if (int.Parse(secondLabel.Text) + 1 <= 9) {

                    secondLabel.Text = "0" + (int.Parse(secondLabel.Text) - 1).ToString();

                } else {

                    secondLabel.Text = (int.Parse(secondLabel.Text) - 1).ToString();

                }

            } else {

                secondLabel.Text = "60";

            }

        }

        private void hourLabel_KeyPress(object sender, KeyPressEventArgs e) {

            if (e.KeyChar == (int)13) {

                if (int.Parse(hourLabel.Text) <= 9) {

                    hourLabel.Text = "0" + hourLabel.Text;
                
                }

            }

        }

        private void minuteLabel_KeyPress(object sender, KeyPressEventArgs e) {

            if (e.KeyChar == (int)13) {

                if (int.Parse(minuteLabel.Text) <= 9) {

                    minuteLabel.Text = "0" + minuteLabel.Text;

                }

            }

        }

        private void secondLabel_KeyPress(object sender, KeyPressEventArgs e) {

            if (e.KeyChar == (int)13) {

                if (int.Parse(secondLabel.Text) <= 9) {

                    secondLabel.Text = "0" + secondLabel.Text;

                }

            }

        }

        private void launchButton_Click(object sender, System.EventArgs e) {

            time.SetHours(int.Parse(hourLabel.Text));

            time.SetMinutes(int.Parse(minuteLabel.Text));

            time.SetSeconds(int.Parse(secondLabel.Text));

            string Command = "shutdown -s -t " + time.CalculateFinalSeconds().ToString();

            util.SetCommand(Command);

            util.ExecuteCommand();

            Application.Exit();

        }

    }

}
