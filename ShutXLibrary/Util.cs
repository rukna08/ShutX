using System.Diagnostics;

using System;

namespace ShutXLibrary {
    
    public class Util {

        private string Command;

        public string GetCommand() {

            return Command;

        }

        public void SetCommand(string Command) {
        
            this.Command = Command;
            
        }

        public void ExecuteCommand() {

            var processInfo = new ProcessStartInfo("cmd.exe", "/c " + Command);
            
            processInfo.CreateNoWindow = true;
            
            processInfo.UseShellExecute = false;
            
            processInfo.RedirectStandardError = true;
            
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);

            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) => Console.WriteLine("output>>" + e.Data);
            
            process.BeginOutputReadLine();

            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) => Console.WriteLine("error>>" + e.Data);
            
            process.BeginErrorReadLine();

            process.WaitForExit();
            
            Console.WriteLine("ExitCode: {0}", process.ExitCode);
            
            process.Close();
        
        }

    }

}
