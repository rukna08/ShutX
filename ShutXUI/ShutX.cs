using System.Windows.Forms;

namespace ShutXUI {

    public partial class ShutX : Form {
    
        public ShutX() {
        
            InitializeComponent();
        
        }

        private void hoursTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            
            // 13 -> Enter/Return ASCII

            if (e.KeyChar == (char)13) {

                
                
            }

        }

    }

}
