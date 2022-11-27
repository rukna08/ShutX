using System.Runtime.CompilerServices;

namespace ShutXLibrary {

    public class Time {

        private int Hours;

        private int Minutes;

        private int Seconds;

        public int GetHours() {

            return Hours;

        }

        public int GetSeconds() {

            return Seconds;

        }

        public int GetMinutes() {

            return Minutes;
            
        }

        public void SetHours(int Hours) {
            
            this.Hours = Hours;

        }

        public void SetMinutes(int Minutes) {

            this.Minutes = Minutes;
        
        }

        public void SetSeconds(int Seconds) {

            this.Seconds = Seconds;

        }

        public int CalculateFinalSeconds() {

            return (Hours * 3600) + (Minutes * 60) + Seconds;
        
        }

    }

}
