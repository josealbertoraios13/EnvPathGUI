using System;
using System.Diagnostics;
using System.IO;

namespace core
{
    public class PathManager
    {
        public static string[] GetLocalPaths()
        {
            try
            {
                var process = new ProcessStartInfo()
                {
                    FileName = "/bin/zsh",
                    Arguments = "-c \"printenv PATH\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using var proc = Process.Start(process);

                if (proc == null)
                    throw new Exception("proc is null");

                string output = proc.StandardOutput.ReadToEnd().Trim();
                proc.WaitForExit();

                return SplitPaths(output);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao pegar as váriavéis locais Paths.\n Error: {e}");
                return Array.Empty<string>();
            }

        }
        

        public static string[] GetGlobalPaths()
        {
            try
            {
                var paths = Environment.GetEnvironmentVariable("PATH");

                if(paths == null)
                {
                    throw new Exception("paths is null");
                }

                return SplitPaths(paths);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao pegar as variáveis globais Paths. \n Error: {e}");
                return Array.Empty<string>();
            }
        }

        private static string[] SplitPaths(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return Array.Empty<string>();
            }

            return path.Split(":", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
