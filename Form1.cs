using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
namespace WinFormsApp1

{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                string workingDirectory = AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar);

                string command = $"cd /d \"{workingDirectory}\" && cd && pip install -r requirements.txt";

                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {command}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = false,
                    WorkingDirectory = workingDirectory
                };

                var processStartInfo2 = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c python setup.py build_ext --inplace",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = false,
                    WorkingDirectory = workingDirectory
                };

                processStartInfo2.EnvironmentVariables["PYTHONWARNINGS"] = "ignore";

                using (var process = Process.Start(processStartInfo))
                {
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd().Trim();

                    this.Invoke((MethodInvoker)delegate
                    {
                        if (process.ExitCode != 0 || !string.IsNullOrEmpty(error))
                        {
                            MessageBox.Show($"Operation failed: {error}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            materialButton1.Enabled = true;
                            materialLabel10.Text = "Failed!";
                            materialLabel11.Text = error;
                        }
                        else
                        {
                            MessageBox.Show("Operation was successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            materialButton1.Enabled = false;
                            materialLabel10.Text = "Success!";
                            materialLabel11.Text = "";
                        }
                    });
                }
                using (var process = Process.Start(processStartInfo2))
                {
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd().Trim();

                    this.Invoke((MethodInvoker)delegate
                    {
                        if (process.ExitCode != 0 || !string.IsNullOrEmpty(error))
                        {
                            MessageBox.Show($"Operation failed: {error}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            materialButton1.Enabled = true;
                            materialLabel10.Text = "Failed!";
                            materialLabel11.Text = error;
                        }
                        else
                        {
                            MessageBox.Show("Operation was successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            materialButton1.Enabled = false;
                            materialLabel10.Text = "Success!";
                            materialLabel11.Text = "";
                        }
                    });
                }
            });
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                string workingDirectory = AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar);

                string command = "python elephantvalley.py";

                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {command}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = false,
                    WorkingDirectory = workingDirectory
                };

                using (var process = Process.Start(processStartInfo))
                {
                    process.WaitForExit();

                    string output = process.StandardOutput.ReadToEnd().Trim();
                    string error = process.StandardError.ReadToEnd().Trim();

                    this.Invoke((MethodInvoker)delegate
                    {
                        if (process.ExitCode == 0)
                        {
                        }
                        else
                        {
                        }
                    });
                }
            });
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                string workingDirectory = AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar);

                string command = "python flower.py";

                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {command}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = false,
                    WorkingDirectory = workingDirectory
                };

                using (var process = Process.Start(processStartInfo))
                {
                    process.WaitForExit();

                    string output = process.StandardOutput.ReadToEnd().Trim();
                    string error = process.StandardError.ReadToEnd().Trim();

                    this.Invoke((MethodInvoker)delegate
                    {
                        if (process.ExitCode == 0)
                        {
                        }
                        else
                        {
                        }
                    });
                }
            });
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                string workingDirectory = AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar);

                string command = "python galaxy.py";

                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {command}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = false,
                    WorkingDirectory = workingDirectory
                };

                using (var process = Process.Start(processStartInfo))
                {
                    process.WaitForExit();

                    string output = process.StandardOutput.ReadToEnd().Trim();
                    string error = process.StandardError.ReadToEnd().Trim();

                    this.Invoke((MethodInvoker)delegate
                    {
                        if (process.ExitCode == 0)
                        {
                        }
                        else
                        {
                        }
                    });
                }
            });
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                string workingDirectory = AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar);

                string command = "python juliaisland.py";

                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {command}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = false,
                    WorkingDirectory = workingDirectory
                };

                using (var process = Process.Start(processStartInfo))
                {
                    process.WaitForExit();

                    string output = process.StandardOutput.ReadToEnd().Trim();
                    string error = process.StandardError.ReadToEnd().Trim();

                    this.Invoke((MethodInvoker)delegate
                    {
                        if (process.ExitCode == 0)
                        {
                        }
                        else
                        {
                        }
                    });
                }
            });
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                string workingDirectory = AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar);

                string command = "python lightningbolt.py";

                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {command}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = false,
                    WorkingDirectory = workingDirectory
                };

                using (var process = Process.Start(processStartInfo))
                {
                    process.WaitForExit();

                    string output = process.StandardOutput.ReadToEnd().Trim();
                    string error = process.StandardError.ReadToEnd().Trim();

                    this.Invoke((MethodInvoker)delegate
                    {
                        if (process.ExitCode == 0)
                        {
                        }
                        else
                        {
                        }
                    });
                }
            });
        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                string workingDirectory = AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar);

                string command = "python satellite.py";

                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {command}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = false,
                    WorkingDirectory = workingDirectory
                };

                using (var process = Process.Start(processStartInfo))
                {
                    process.WaitForExit();

                    string output = process.StandardOutput.ReadToEnd().Trim();
                    string error = process.StandardError.ReadToEnd().Trim();

                    this.Invoke((MethodInvoker)delegate
                    {
                        if (process.ExitCode == 0)
                        {
                        }
                        else
                        {
                        }
                    });
                }
            });
        }

        private void materialButton8_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                string workingDirectory = AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar);

                string command = "python seahorsetail.py";

                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {command}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = false,
                    WorkingDirectory = workingDirectory
                };

                using (var process = Process.Start(processStartInfo))
                {
                    process.WaitForExit();


                    string output = process.StandardOutput.ReadToEnd().Trim();
                    string error = process.StandardError.ReadToEnd().Trim();

                    this.Invoke((MethodInvoker)delegate
                    {
                        if (process.ExitCode == 0)
                        {
                        }
                        else
                        {
                        }
                    });
                }
            });
        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                string workingDirectory = AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar);

                string command = "python seahorsevalley.py";

                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {command}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = false,
                    WorkingDirectory = workingDirectory
                };

                using (var process = Process.Start(processStartInfo))
                {
                    process.WaitForExit();

                    string output = process.StandardOutput.ReadToEnd().Trim();
                    string error = process.StandardError.ReadToEnd().Trim();

                    this.Invoke((MethodInvoker)delegate
                    {
                        if (process.ExitCode == 0)
                        {
                        }
                        else
                        {
                        }
                    });
                }
            });
        }

        private void materialButton10_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                string workingDirectory = AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar);

                string command = "python starfish.py";

                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {command}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = false,
                    WorkingDirectory = workingDirectory
                };

                using (var process = Process.Start(processStartInfo))
                {
                    process.WaitForExit();

                    string output = process.StandardOutput.ReadToEnd().Trim();
                    string error = process.StandardError.ReadToEnd().Trim();

                    this.Invoke((MethodInvoker)delegate
                    {
                        if (process.ExitCode == 0)
                        {
                        }
                        else
                        {
                        }
                    });
                }
            });
        }

        private void materialButton11_Click(object sender, EventArgs e)
        {
            string selectedFile = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectedFile))
            {
                MessageBox.Show("Please select a file.");
                return;
            }

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, selectedFile);

            string fileContent = File.ReadAllText(filePath);

            string maxIterValue = materialTextBox1.Text;
            if (!string.IsNullOrWhiteSpace(maxIterValue))
            {
                fileContent = Regex.Replace(fileContent, @"max_iter\s*=\s*\d+", $"max_iter = {maxIterValue}");
            }

            string resolution = comboBox2.SelectedItem?.ToString();
            if (!string.IsNullOrWhiteSpace(resolution))
            {
                fileContent = Regex.Replace(fileContent, @"width,\s*height\s*=\s*\d+\s*,\s*\d+", $"width, height = {resolution.Replace(", ", ",")}");
            }

            string cmapValue = comboBox3.SelectedItem?.ToString();
            if (!string.IsNullOrWhiteSpace(cmapValue))
            {
                fileContent = Regex.Replace(fileContent, @"cmap\s*=\s*'.*?'", $"cmap='{cmapValue}'");
            }

            File.WriteAllText(filePath, fileContent);

            RunPythonScript(filePath);
        }

        private void RunPythonScript(string filePath)
        {
            var processStartInfo = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = $"\"{filePath}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                WorkingDirectory = Path.GetDirectoryName(filePath)
            };

            using (var process = Process.Start(processStartInfo))
            {
                process.WaitForExit();

                string output = process.StandardOutput.ReadToEnd();
                if (!string.IsNullOrEmpty(output))
                {
                    MessageBox.Show(output, "Script Output", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (process.ExitCode != 0)
                {
                    MessageBox.Show("Script execution failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Script executed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void materialButton12_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/ssundeyt";

            try
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open the website: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButton13_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/måns-holmgren-7750b823a/";

            try
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open the website: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
