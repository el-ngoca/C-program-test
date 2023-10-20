using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public string? Apelido { get; set; }
        public int Idade { get; set; }

        public double Altura { get; set; }
        public decimal Saldo { get; set; }

        readonly DateTime dataHoje = DateTime.Now;
        //PAra adcionar dias as datas so colocar (.) frente ao Now e o numero de dias/horas/ano que se pretende
        //Para representar a data em outros formatos como dias mes e ano usamos o metodo (".ToString()" ou".ToShortDayString")
        readonly DateTime dataProgram = DateTime.Now.AddDays(7);
        public void Apresentar()
        {
            Console.WriteLine($"MAputo, aos {dataHoje}: Ola, meu nome e {Nome} {Apelido}, e Tenho {Idade} anos de idade\n E {Altura} de altura, o meu saldo corrente e de {Saldo}Mt\n Tenho o dia {dataProgram.ToShortDateString()} diasponivel");
        }
    }
}

