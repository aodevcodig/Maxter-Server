using System;
using System.Diagnostics;
using System.ServiceProcess;
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
            ShowSystemInfoAsync();
        }

        private async void ShowSystemInfoAsync()
        {
            // Adiciona as informa��es do sistema gradualmente
            await SimulateTypingAsync("Sistema Operacional: " + Environment.OSVersion);
            await SimulateTypingAsync("Arquitetura do Sistema: " + (Environment.Is64BitOperatingSystem ? "64 bits" : "32 bits"));
            await SimulateTypingAsync("Usu�rio: " + Environment.UserName);
            await SimulateTypingAsync("Nome do Computador: " + Environment.MachineName);

            // Verificar Apache, PHP e MySQL
            await SimulateTypingAsync("Verificando Apache...");
            await SimulateTypingAsync("Apache Instalado: " + (await IsServiceRunningAsync("Apache2.4") ? "Sim" : "N�o"));

            await SimulateTypingAsync("Verificando PHP...");
            await SimulateTypingAsync("PHP Instalado: " + (await IsPHPInstalledAsync() ? "Sim" : "N�o"));

            await SimulateTypingAsync("Verificando MySQL...");
            await SimulateTypingAsync("MySQL Instalado: " + (await IsServiceRunningAsync("MySQL") ? "Sim" : "N�o"));
        }

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
    }
}
