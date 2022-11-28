using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace HoraData
{
    public class VariaveisHourDate
    {
        public string mes { get; set; }
        public string diaSemana { get; set; }
        public string version = "1.0";

        public void ApresentacaoAplicacao() 
        {
            Console.WriteLine($"Hora e Data - Versão {version}");
            Console.WriteLine("-------------");
            Console.WriteLine("Para parar, pressione CTRL + C para sair do programa!\n");
        }

        public void DefinicaoDiaMesConsole() 
        {
            while(true) 
            {
                switch ((int)DateTime.Now.DayOfWeek)
                {
                    case 0:
                       diaSemana = "Domingo";
                       break;
                    case 1: 
                       diaSemana = "Segunda-Feira";
                       break;
                    case  2:
                       diaSemana = "Terça-Feira";
                       break;
                    case 3: 
                       diaSemana = "Quarta-Feira";
                       break;
                    case 4:
                       diaSemana = "Quinta-Feira";
                       break;
                    case 5: 
                       diaSemana = "Sexta-Feira";
                       break;
                    case 6: 
                       diaSemana = "Sábado";
                       break;
                    default: 
                       diaSemana = "Não se Aplica";
                       break;
                }

                switch((int)DateTime.Now.Month)
                {
                    case 1: 
                       mes = "Janeiro";
                       break;
                    case 2: 
                       mes = "Fevereiro";
                       break;
                    case 3: 
                       mes = "Março";
                       break;
                    case 4: 
                       mes = "Abril";
                       break;
                    case 5: 
                       mes = "Maio";
                       break;
                    case 6: 
                       mes = "Junho";
                       break;
                    case 7: 
                       mes = "Julho";
                       break;
                    case 8: 
                       mes = "Agosto";
                       break;
                    case 9: 
                       mes = "Setembro";
                       break;
                    case 10: 
                       mes = "Outubro";
                       break;
                    case 11: 
                       mes = "Novembro";
                       break;
                    case 12: 
                       mes = "Dezembro";
                       break;
                    default:
                       mes = "Não se aplica.";
                       break;
                }

            Console.WriteLine("\r{0} - {1} de {2} de {3} - {4}", 
                diaSemana, DateTime.Now.ToString("dd"),
                mes, DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("HH:mm:ss"));

                //método estático que sempre faz com que o thread atual entre no modo de suspensão.
                Thread.Sleep(1000);    
            }
        }
    }
}