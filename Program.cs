using System;
using System.Threading;

namespace HoraData
{
    class Program
    {
        static void Main(string[] args)
        {
            VariaveisHourDate hourDate = new VariaveisHourDate();

            Console.WriteLine($"Hora e Data - Versão {hourDate.version}");
            Console.WriteLine("-------------");
            Console.WriteLine("Para parar, pressione CTRL + C para sair do programa!\n");

            while(true) 
            {
                switch ((int)DateTime.Now.DayOfWeek)
                {
                    case 0:
                       hourDate.diaSemana = "Domingo";
                       break;
                    case 1: 
                       hourDate.diaSemana = "Segunda-Feira";
                       break;
                    case  2:
                       hourDate.diaSemana = "Terça-Feira";
                       break;
                    case 3: 
                       hourDate.diaSemana = "Quarta-Feira";
                       break;
                    case 4:
                       hourDate.diaSemana = "Quinta-Feira";
                       break;
                    case 5: 
                       hourDate.diaSemana = "Sexta-Feira";
                       break;
                    case 6: 
                       hourDate.diaSemana = "Sábado";
                       break;
                default: 
                    hourDate.diaSemana = "Não se Aplica";
                    break;
                }

                switch((int)DateTime.Now.Month)
                {
                    case 1: 
                       hourDate.mes = "Janeiro";
                       break;
                    case 2: 
                       hourDate.mes = "Fevereiro";
                       break;
                    case 3: 
                       hourDate.mes = "Março";
                       break;
                    case 4: 
                       hourDate.mes = "Abril";
                       break;
                    case 5: 
                       hourDate.mes = "Maio";
                       break;
                    case 6: 
                       hourDate.mes = "Junho";
                       break;
                    case 7: 
                       hourDate.mes = "Julho";
                       break;
                    case 8: 
                       hourDate.mes = "Agosto";
                       break;
                    case 9: 
                       hourDate.mes = "Setembro";
                       break;
                    case 10: 
                       hourDate.mes = "Outubro";
                       break;
                    case 11: 
                       hourDate.mes = "Novembro";
                       break;
                    case 12: 
                       hourDate.mes = "Dezembro";
                       break;
                    default:
                       hourDate.mes = "Não se aplica.";
                       break;
                }

            Console.WriteLine("\r{0} - {1} de {2} de {3} - {4}", 
                hourDate.diaSemana, DateTime.Now.ToString("dd"),
                hourDate.mes, DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("HH:mm:ss"));

                Thread.Sleep(1000);    
            }
        }
    }
}
