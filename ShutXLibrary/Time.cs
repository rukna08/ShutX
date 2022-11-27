using System.Runtime.CompilerServices;

namespace ShutXLibrary {

    public class Time {

        private int Hours;

        private int Seconds;

        public int GetHours() {

            return Hours;

        }

        public int GetSeconds() {

            return Seconds;

        }

        public void SetHours(int Hours) {
            
            this.Hours = Hours;

        }

        public void SetSeconds(int Seconds) {

            this.Seconds = Seconds;

        }

        public void CalculateSeconds() {

            SetSeconds(Hours * 3600);

        }

    }

}
