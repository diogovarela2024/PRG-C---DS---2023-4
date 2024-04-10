using System;

public class Class1
{
	public Class1()
	{
	}
}using System;

namespace ClinicaVeterinaria
{
    // Enum para representar o status da consulta
    public enum StatusConsulta
    {
        Marcada,
        Realizada,
        Cancelada
    }

    public class ConsultaVeterinaria
    {
        // Propriedades da consulta
        public DateTime Data { get; set; }
        public string MedicoVeterinario { get; set; }
        public string Cliente { get; set; }
        public string Animal { get; set; }
        public StatusConsulta Status { get; set; }

        // Construtor da classe
        public ConsultaVeterinaria(DateTime data, string medicoVeterinario, string cliente, string animal)
        {
            Data = data;
            MedicoVeterinario = medicoVeterinario;
            Cliente = cliente;
            Animal = animal;
            Status = StatusConsulta.Marcada; // Por padrão, a consulta é marcada
        }

        // Método para realizar a consulta
        public void RealizarConsulta()
        {
            if (Status == StatusConsulta.Marcada)
            {
                Status = StatusConsulta.Realizada;
                Console.WriteLine($"Consulta realizada em {Data.ToShortDateString()} para o animal {Animal} com o médico {MedicoVeterinario}.");
            }
            else
            {
                Console.WriteLine("Esta consulta já foi realizada ou cancelada.");
            }
        }

        // Método para cancelar a consulta
        public void CancelarConsulta()
        {
            if (Status == StatusConsulta.Marcada)
            {
                Status = StatusConsulta.Cancelada;
                Console.WriteLine($"Consulta cancelada em {Data.ToShortDateString()} para o animal {Animal}.");
            }
            else
            {
                Console.WriteLine("Esta consulta já foi realizada ou cancelada.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de utilização da classe ConsultaVeterinaria
            ConsultaVeterinaria consulta = new ConsultaVeterinaria(new DateTime(2024, 4, 10), "Dr. Miguel", "Tiago", "Maria");
            consulta.RealizarConsulta();
            consulta.CancelarConsulta();
        }
    }
}

