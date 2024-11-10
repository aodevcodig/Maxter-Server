using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxterServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sbStatusBar.RectColor = Color.FromArgb(255, 128, 0);
            sbStatusBar.Text = "A processar...";
            ShowSystemInfoAsync();
        }

        // Caminho absoluto do diret�rio raiz do projeto
        private string GetProjectRootPath()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Subir pelas pastas at� encontrar o diret�rio que cont�m o arquivo .sln
            DirectoryInfo dirInfo = new DirectoryInfo(currentDirectory);
            while (dirInfo.Parent != null && !File.Exists(Path.Combine(dirInfo.FullName, $"{dirInfo.Name}.sln")))
            {
                dirInfo = dirInfo.Parent;
            }

            // Retorna o diret�rio raiz do projeto
            return dirInfo.FullName;
        }

        // Caminho para o Apache dentro do diret�rio raiz do seu projeto
        private string GetApachePath()
        {
            string projectRootPath = GetProjectRootPath();
            return Path.Combine(projectRootPath, "apps", "apache", "httpd-2.4.57-win64-VS16", "bin", "httpd.exe");
        }

        private string GetApacheConfigPath()
        {
            string projectRootPath = GetProjectRootPath();
            return Path.Combine(projectRootPath, "apps", "apache", "httpd-2.4.57-win64-VS16", "conf", "httpd.conf");
        }

        #region Resolvendo o Apache
        private void StartApache()
        {
            string apachePath = GetApachePath();
            string apacheConfigPath = GetApacheConfigPath();

            if (File.Exists(apachePath))
            {
                try
                {
                    // Inicia o Apache usando httpd.exe
                    Process apacheProcess = new Process();
                    apacheProcess.StartInfo.FileName = apachePath;
                    apacheProcess.StartInfo.Arguments = "-f \"" + apacheConfigPath + "\""; // Passa o caminho do arquivo de configura��o (httpd.conf)
                    apacheProcess.StartInfo.UseShellExecute = false;
                    apacheProcess.StartInfo.RedirectStandardOutput = true;
                    apacheProcess.StartInfo.RedirectStandardError = true;

                    apacheProcess.OutputDataReceived += (sender, e) => AppendLog(e.Data); // Captura a sa�da do Apache
                    apacheProcess.ErrorDataReceived += (sender, e) => AppendLog(e.Data); // Captura erros do Apache

                    apacheProcess.Start();
                    apacheProcess.BeginOutputReadLine();
                    apacheProcess.BeginErrorReadLine();

                    AppendLog("Apache iniciado com sucesso!");
                }
                catch (Exception ex)
                {
                    AppendLog("Erro ao iniciar o Apache: " + ex.Message);
                }
            }
            else
            {
                AppendLog($"N�o foi poss�vel encontrar o arquivo {apachePath}.");
            }
        }

        private void StopApache()
        {
            // Aqui voc� pode parar o Apache, se necess�rio
            // Por exemplo, ao matar o processo do Apache
            Process[] processes = Process.GetProcessesByName("httpd");
            foreach (Process process in processes)
            {
                process.Kill();
            }
            AppendLog("Apache parado.");
        }

        // M�todo para simular a digita��o no TextBox
        private async void AppendLog(string logMessage)
        {
            foreach (char c in logMessage)
            {
                // Atualizar o TextBox na thread da interface do usu�rio
                if (tbAppLogs.InvokeRequired)
                {
                    tbAppLogs.Invoke(new Action(() =>
                    {
                        tbAppLogs.AppendText(c.ToString());
                        tbAppLogs.ScrollToCaret();
                    }));
                }
                else
                {
                    tbAppLogs.AppendText(c.ToString());
                    tbAppLogs.ScrollToCaret();
                }

                await Task.Delay(50); // Atraso para simular digita��o
            }

            // Nova linha ap�s a mensagem
            if (tbAppLogs.InvokeRequired)
            {
                tbAppLogs.Invoke(new Action(() =>
                {
                    tbAppLogs.AppendText(Environment.NewLine);
                    tbAppLogs.ScrollToCaret();
                }));
            }
            else
            {
                tbAppLogs.AppendText(Environment.NewLine);
                tbAppLogs.ScrollToCaret();
            }
        }
        #endregion

        private async void ShowSystemInfoAsync()
        {
            sbStatusBar.Text = "A ler informa��es do sistema...";
            // Adiciona as informa��es do sistema gradualmente
            await SimulateTypingAsync("Sistema Operacional: " + Environment.OSVersion);
            await SimulateTypingAsync("Arquitetura do Sistema: " + (Environment.Is64BitOperatingSystem ? "64 bits" : "32 bits"));
            await SimulateTypingAsync("Usu�rio: " + Environment.UserName);
            await SimulateTypingAsync("Nome do Computador: " + Environment.MachineName);

            sbStatusBar.RectColor = Color.FromArgb(128, 255, 255);
            sbStatusBar.Text = "A verificar o Apache...";
            // Verificar Apache, PHP e MySQL
            await SimulateTypingAsync("Verificando Apache...");
            await SimulateTypingAsync("Apache Instalado: " + (await IsServiceRunningAsync("Apache2.4") ? "Sim" : "N�o"));

            sbStatusBar.Text = "A verificar o PHP...";
            await SimulateTypingAsync("Verificando PHP...");
            await SimulateTypingAsync("PHP Instalado: " + (await IsPHPInstalledAsync() ? "Sim" : "N�o"));

            sbStatusBar.Text = "A verificar o MySQL...";
            await SimulateTypingAsync("Verificando MySQL...");
            await SimulateTypingAsync("MySQL Instalado: " + (await IsServiceRunningAsync("MySQL") ? "Sim" : "N�o"));

            sbStatusBar.RectColor = Color.FromArgb(35, 168, 109);
            sbStatusBar.Text = "Online";
        }

        // Cores React do StatusBar
        // 35; 168; 109 Verde
        // 255; 128; 0 Laranja
        // 

        // M�todo para simular a digita��o de logs
        private async Task SimulateTypingAsync(string logMessage)
        {
            foreach (char c in logMessage)
            {
                // Atualizar o TextBox na thread da interface do usu�rio
                if (tbAppLogs.InvokeRequired)
                {
                    tbAppLogs.Invoke(new Action(() =>
                    {
                        tbAppLogs.AppendText(c.ToString());
                        tbAppLogs.ScrollToCaret(); // Faz o TextBox rolar para o final
                    }));
                }
                else
                {
                    tbAppLogs.AppendText(c.ToString());
                    tbAppLogs.ScrollToCaret();
                }

                // Atraso entre cada caractere (simula a digita��o)
                await Task.Delay(50); // 50 ms de delay por caractere (ajuste conforme necess�rio)
            }

            // Adiciona uma nova linha ap�s o texto completo
            if (tbAppLogs.InvokeRequired)
            {
                tbAppLogs1.Invoke(new Action(() =>
                {
                    tbAppLogs.AppendText(Environment.NewLine);
                    tbAppLogs.ScrollToCaret(); // Faz o TextBox rolar para o final
                }));
            }
            else
            {
                tbAppLogs.AppendText(Environment.NewLine);
                tbAppLogs.ScrollToCaret();
            }
        }

        private async Task<bool> IsServiceRunningAsync(string serviceName)
        {
            return await Task.Run(() =>
            {
                try
                {
                    ServiceController service = new ServiceController(serviceName);
                    return service.Status == ServiceControllerStatus.Running;
                }
                catch (InvalidOperationException)
                {
                    return false;
                }
            });
        }

        private async Task<bool> IsPHPInstalledAsync()
        {
            return await Task.Run(() =>
            {
                try
                {
                    // Verifica se o PHP est� dispon�vel no PATH do sistema executando `php -v`
                    var process = new Process();
                    process.StartInfo.FileName = "php";
                    process.StartInfo.Arguments = "-v";
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.UseShellExecute = false;
                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    // Se a sa�da contiver "PHP", significa que o PHP est� instalado
                    return output.Contains("PHP");
                }
                catch
                {
                    return false;
                }
            });
        }

        private void cbApache_CheckedChanged(object sender, EventArgs e)
        {
            if (cbApache.Checked)
            {
                StartApache();
            }else if (!cbApache.Checked)
            {
                StopApache();
            }
        }
    }
}
