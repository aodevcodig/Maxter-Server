using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MaxterServer.Core
{
    internal class Init
    {
        //public async string ShowSystemInfo()
        //{
        //    StringBuilder info = new StringBuilder();

        //    // Adiciona as informações do sistema gradualmente
        //    await AppendLogAsync("Sistema Operacional: " + Environment.OSVersion);
        //    await AppendLogAsync("Arquitetura do Sistema: " + (Environment.Is64BitOperatingSystem ? "64 bits" : "32 bits"));
        //    await AppendLogAsync("Usuário: " + Environment.UserName);
        //    await AppendLogAsync("Nome do Computador: " + Environment.MachineName);

        //    // Verificar Apache, PHP e MySQL
        //    await AppendLogAsync("Verificando Apache...");
        //    await AppendLogAsync("Apache Instalado: " + (await IsServiceRunningAsync("Apache2.4") ? "Sim" : "Não"));

        //    await AppendLogAsync("Verificando PHP...");
        //    await AppendLogAsync("PHP Instalado: " + (await IsPHPInstalledAsync() ? "Sim" : "Não"));

        //    await AppendLogAsync("Verificando MySQL...");
        //    await AppendLogAsync("MySQL Instalado: " + (await IsServiceRunningAsync("MySQL") ? "Sim" : "Não"));

        //    // Exibir as informações no TextBox
        //    return info.ToString();
        //}

        //// Método assíncrono para adicionar logs ao TextBox com a atualização da UI
        //private Task AppendLogAsync(string logMessage)
        //{
        //    return Task.Run(() =>
        //    {
        //        // Atualizar o TextBox na thread da interface do usuário
        //        Dispatcher.Invoke(() =>
        //        {
        //            tbAppLogs.AppendText(logMessage + Environment.NewLine);
        //            tbAppLogs.ScrollToEnd(); // Faz o TextBox rolar para o final para mostrar o log mais recente
        //        });
        //    });
        //}

        //private async Task<bool> IsServiceRunningAsync(string serviceName)
        //{
        //    return await Task.Run(() =>
        //    {
        //        try
        //        {
        //            ServiceController service = new ServiceController(serviceName);
        //            return service.Status == ServiceControllerStatus.Running;
        //        }
        //        catch (InvalidOperationException)
        //        {
        //            return false;
        //        }
        //    });
        //}

        //private async Task<bool> IsPHPInstalledAsync()
        //{
        //    return await Task.Run(() =>
        //    {
        //        try
        //        {
        //            // Verifica se o PHP está disponível no PATH do sistema executando `php -v`
        //            var process = new Process();
        //            process.StartInfo.FileName = "php";
        //            process.StartInfo.Arguments = "-v";
        //            process.StartInfo.RedirectStandardOutput = true;
        //            process.StartInfo.UseShellExecute = false;
        //            process.Start();

        //            string output = process.StandardOutput.ReadToEnd();
        //            process.WaitForExit();

        //            // Se a saída contiver "PHP", significa que o PHP está instalado
        //            return output.Contains("PHP");
        //        }
        //        catch
        //        {
        //            return false;
        //        }
        //    });
        //}

        //private bool IsServiceRunning(string serviceName)
        //{
        //    try
        //    {
        //        ServiceController service = new ServiceController(serviceName);
        //        return service.Status == ServiceControllerStatus.Running;
        //    }
        //    catch (InvalidOperationException)
        //    {
        //        return false;
        //    }
        //}

        //private bool IsPHPInstalled()
        //{
        //    try
        //    {
        //        // Verifica se o PHP está disponível no PATH do sistema executando `php -v`
        //        var process = new Process();
        //        process.StartInfo.FileName = "php";
        //        process.StartInfo.Arguments = "-v";
        //        process.StartInfo.RedirectStandardOutput = true;
        //        process.StartInfo.UseShellExecute = false;
        //        process.Start();

        //        string output = process.StandardOutput.ReadToEnd();
        //        process.WaitForExit();

        //        // Se a saída contiver "PHP", significa que o PHP está instalado
        //        return output.Contains("PHP");
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
    }
}
