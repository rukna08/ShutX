using System.Windows.Forms;

namespace ShutXUI {

    public partial class ShutXUI : Form {

        readonly ShutXLibrary.Time time;

        readonly ShutXLibrary.Util util;

        public ShutXUI() {
        
            InitializeComponent();

            time = new ShutXLibrary.Time();

            util = new ShutXLibrary.Util();
        
        }

        private void HoursTextBox_KeyPress(object sender, KeyPressEventArgs e) {

            if (e.KeyChar == (char) 13) {

                time.SetHours(int.Parse(hoursTextBox.Text));

                time.CalculateSeconds();

                string Command = "shutdown -s -t " + time.GetSeconds().ToString();

                util.SetCommand(Command);

                util.ExecuteCommand();

                Application.Exit();

            }

        }

    }

}
