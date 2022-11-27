using System.Windows.Forms;

namespace ShutXUI {

    public partial class ShutXUI : Form {

        ShutXLibrary.Time time;

        public ShutXUI() {
        
            InitializeComponent();

            time = new ShutXLibrary.Time();
        
        }

        private void hoursTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            
            // 13 -> Enter/Return ASCII

            if (e.KeyChar == (char) 13) {

                time.SetHours(int.Parse(hoursTextBox.Text));
                
            }

        }

    }

}
