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
}using System;
using System.Collections.Generic;

namespace SistemaVeterinario
{
    // Classe para representar um animal doméstico
    public class Animal
    {
        public string Nome { get; set; }
        public string Espécie { get; set; }
        public string Raça { get; set; }
        public int Idade { get; set; }
        // Outros atributos podem ser adicionados conforme necessário
    }

    // Classe para representar um produto
    public class Produto
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        // Outros atributos podem ser adicionados conforme necessário
    }

    // Classe principal do programa
    class Program
    {
        static List<Animal> listaAnimais = new List<Animal>();
        static List<Produto> listaProdutos = new List<Produto>();

        static void Main(string[] args)
        {
            // Exemplo de utilização: adicionar um novo animal
            AdicionarAnimal("Rex", "Cachorro", "Labrador", 5);

            // Exemplo de utilização: adicionar um novo produto
            AdicionarProduto("Vacina", "Medicamento", 50.00, 100);
        }

        // Método para adicionar um novo animal à lista
        static void AdicionarAnimal(string nome, string especie, string raca, int idade)
        {
            Animal novoAnimal = new Animal
            {
                Nome = nome,
                Espécie = especie,
                Raça = raca,
                Idade = idade
            };
            listaAnimais.Add(novoAnimal);
            Console.WriteLine("Novo animal adicionado: " + novoAnimal.Nome);
        }

        // Método para adicionar um novo produto à lista
        static void AdicionarProduto(string nome, string categoria, double preco, int quantidade)
        {
            Produto novoProduto = new Produto
            {
                Nome = nome,
                Categoria = categoria,
                Preco = preco,
                QuantidadeEmEstoque = quantidade
            };
            listaProdutos.Add(novoProduto);
            Console.WriteLine("Novo produto adicionado: " + novoProduto.Nome);
        }
    }
}
using System;
using System.Collections.Generic;

namespace SistemaVeterinario
{
    // Classe para representar um animal doméstico
    public class Animal
    {
        private static int proximoId = 1;

        public int Id { get; private set; }
        public string NomeDono { get; set; }
        public string ContatoDono { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataUltimaConsulta { get; set; }
        public string Tipo { get; set; }
        public string Raça { get; set; }
        public string Sexo { get; set; }
        public double Peso { get; set; }
        // Outros atributos podem ser adicionados conforme necessário

        public bool Ativo { get; set; }

        public Animal(string nomeDono, string contatoDono, DateTime dataNascimento, string tipo, string raça, string sexo, double peso)
        {
            Id = proximoId++;
            NomeDono = nomeDono;
            ContatoDono = contatoDono;
            DataNascimento = dataNascimento;
            Tipo = tipo;
            Raça = raça;
            Sexo = sexo;
            Peso = peso;
            DataUltimaConsulta = DateTime.MinValue;
            Ativo = true;
        }

        // Método para desativar o animal (em vez de excluir permanentemente)
        public void Desativar()
        {
            Ativo = false;
        }
    }

    // Classe principal do programa
    class Program
    {
        static List<Animal> listaAnimais = new List<Animal>();

        static void Main(string[] args)
        {
            // Exemplo de utilização: adicionar um novo animal
            AdicionarAnimal("João", "123456789", new DateTime(2019, 5, 10), "Cão", "Labrador", "Macho", 10.5);

            // Exemplo de utilização: consultar os animais cadastrados
            ConsultarAnimais();
        }

        // Método para adicionar um novo animal à lista
        static void AdicionarAnimal(string nomeDono, string contatoDono, DateTime dataNascimento, string tipo, string raça, string sexo, double peso)
        {
            Animal novoAnimal = new Animal(nomeDono, contatoDono, dataNascimento, tipo, raça, sexo, peso);
            listaAnimais.Add(novoAnimal);
            Console.WriteLine("Novo animal adicionado: " + novoAnimal.Id);
        }

        // Método para consultar os animais cadastrados
        static void ConsultarAnimais()
        {
            Console.WriteLine("Animais cadastrados:");
            foreach (var animal in listaAnimais)
            {
                Console.WriteLine($"ID: {animal.Id}, Nome do Dono: {animal.NomeDono}, Tipo: {animal.Tipo}, Raça: {animal.Raça}, Ativo: {animal.Ativo}");
            }
        }

        // Método para alterar os dados de um animal
        static void AlterarAnimal(int id, string novoNomeDono, string novoContatoDono, DateTime novaDataNascimento, string novoTipo, string novaRaça, string novoSexo, double novoPeso)
        {
            Animal animal = listaAnimais.Find(a => a.Id == id);
            if (animal != null)
            {
                animal.NomeDono = novoNomeDono;
                animal.ContatoDono = novoContatoDono;
                animal.DataNascimento = novaDataNascimento;
                animal.Tipo = novoTipo;
                animal.Raça = novaRaça;
                animal.Sexo = novoSexo;
                animal.Peso = novoPeso;
                Console.WriteLine($"Animal com ID {id} alterado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Animal com ID {id} não encontrado.");
            }
        }

        // Método para desativar um animal (marcar como inativo)
        static void DesativarAnimal(int id)
        {
            Animal animal = listaAnimais.Find(a => a.Id == id);
            if (animal != null)
            {
                animal.Desativar();
                Console.WriteLine($"Animal com ID {id} desativado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Animal com ID {id} não encontrado.");
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace SistemaVeterinario
{
    // Classe para representar um produto
    public class Produto
    {
        private static int proximoCodigo = 1;

        public int Codigo { get; private set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeEmArmazem { get; set; }
        public double PrecoUnitario { get; set; }
        // Outros atributos podem ser adicionados conforme necessário

        public bool Ativo { get; set; }

        public Produto(string tipo, string descricao, int quantidadeEmArmazem, double precoUnitario)
        {
            Codigo = proximoCodigo++;
            Tipo = tipo;
            Descricao = descricao;
            QuantidadeEmArmazem = quantidadeEmArmazem;
            PrecoUnitario = precoUnitario;
            Ativo = true;
        }

        // Método para desativar o produto (em vez de excluir permanentemente)
        public void Desativar()
        {
            Ativo = false;
        }

        // Método para atualizar a quantidade em armazém
        public void AtualizarQuantidade(int quantidade)
        {
            QuantidadeEmArmazem += quantidade;
        }
    }

    // Classe principal do programa
    class Program
    {
        static List<Produto> listaProdutos = new List<Produto>();

        static void Main(string[] args)
        {
            // Exemplo de utilização: adicionar um novo produto
            AdicionarProduto("Fármaco", "Vacina para Cães", 50, 20.0);

            // Exemplo de utilização: consultar os produtos cadastrados
            ConsultarProdutos();
        }

        // Método para adicionar um novo produto à lista
        static void AdicionarProduto(string tipo, string descricao, int quantidadeEmArmazem, double precoUnitario)
        {
            Produto novoProduto = new Produto(tipo, descricao, quantidadeEmArmazem, precoUnitario);
            listaProdutos.Add(novoProduto);
            Console.WriteLine("Novo produto adicionado: " + novoProduto.Codigo);
        }

        // Método para consultar os produtos cadastrados
        static void ConsultarProdutos()
        {
            Console.WriteLine("Produtos cadastrados:");
            foreach (var produto in listaProdutos)
            {
                Console.WriteLine($"Código: {produto.Codigo}, Tipo: {produto.Tipo}, Descrição: {produto.Descricao}, Quantidade em Armazém: {produto.QuantidadeEmArmazem}, Preço Unitário: {produto.PrecoUnitario}, Ativo: {produto.Ativo}");
            }
        }

        // Método para alterar os dados de um produto
        static void AlterarProduto(int codigo, string novoTipo, string novaDescricao, int novaQuantidadeEmArmazem, double novoPrecoUnitario)
        {
            Produto produto = listaProdutos.Find(p => p.Codigo == codigo);
            if (produto != null)
            {
                produto.Tipo = novoTipo;
                produto.Descricao = novaDescricao;
                produto.QuantidadeEmArmazem = novaQuantidadeEmArmazem;
                produto.PrecoUnitario = novoPrecoUnitario;
                Console.WriteLine($"Produto com código {codigo} alterado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Produto com código {codigo} não encontrado.");
            }
        }

        // Método para desativar um produto (marcar como inativo)
        static void DesativarProduto(int codigo)
        {
            Produto produto = listaProdutos.Find(p => p.Codigo == codigo);
            if (produto != null)
            {
                produto.Desativar();
                Console.WriteLine($"Produto com código {codigo} desativado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Produto com código {codigo} não encontrado.");
            }
        }

        // Método para atualizar a quantidade em armazém de um produto
        static void AtualizarQuantidadeEmArmazem(int codigo, int quantidade)
        {
            Produto produto = listaProdutos.Find(p => p.Codigo == codigo);
            if (produto != null)
            {
                produto.AtualizarQuantidade(quantidade);
                Console.WriteLine($"Quantidade em armazém do produto com código {codigo} atualizada com sucesso.");
            }
            else
            {
                Console.WriteLine($"Produto com código {codigo} não encontrado.");
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace SistemaVeterinario
{
    // Classe para representar um ato médico
    public class AtoMedico
    {
        private static int proximoId = 1;

        public int Id { get; private set; }
        public string NomeAto { get; set; }
        public string Descricao { get; set; }
        public double CustoUnitario { get; set; }
        public DateTime DataInsercao { get; private set; }
        public DateTime DataUltimaAlteracao { get; set; }
        // Outros atributos podem ser adicionados conforme necessário

        public bool Ativo { get; set; }

        public AtoMedico(string nomeAto, string descricao, double custoUnitario)
        {
            Id = proximoId++;
            NomeAto = nomeAto;
            Descricao = descricao;
            CustoUnitario = custoUnitario;
            DataInsercao = DateTime.Now;
            DataUltimaAlteracao = DateTime.MinValue;
            Ativo = true;
        }

        // Método para desativar o ato médico (em vez de excluir permanentemente)
        public void Desativar()
        {
            Ativo = false;
        }

        // Método para atualizar o custo unitário do ato médico
        public void AtualizarCusto(double novoCusto)
        {
            CustoUnitario = novoCusto;
            DataUltimaAlteracao = DateTime.Now;
        }
    }

    // Classe principal do programa
    class Program
    {
        static List<AtoMedico> listaAtosMedicos = new List<AtoMedico>();

        static void Main(string[] args)
        {
            // Exemplo de utilização: adicionar um novo ato médico
            AdicionarAtoMedico("Consulta", "Consulta de rotina", 50.0);

            // Exemplo de utilização: consultar os atos médicos cadastrados
            ConsultarAtosMedicos();
        }

        // Método para adicionar um novo ato médico à lista
        static void AdicionarAtoMedico(string nomeAto, string descricao, double custoUnitario)
        {
            AtoMedico novoAtoMedico = new AtoMedico(nomeAto, descricao, custoUnitario);
            listaAtosMedicos.Add(novoAtoMedico);
            Console.WriteLine("Novo ato médico adicionado: " + novoAtoMedico.Id);
        }

        // Método para consultar os atos médicos cadastrados
        static void ConsultarAtosMedicos()
        {
            Console.WriteLine("Atos médicos cadastrados:");
            foreach (var atoMedico in listaAtosMedicos)
            {
                Console.WriteLine($"ID: {atoMedico.Id}, Nome do Ato: {atoMedico.NomeAto}, Descrição: {atoMedico.Descricao}, Custo Unitário: {atoMedico.CustoUnitario}, Data de Inserção: {atoMedico.DataInsercao}, Data da Última Alteração: {atoMedico.DataUltimaAlteracao}, Ativo: {atoMedico.Ativo}");
            }
        }

        // Método para alterar os dados de um ato médico
        static void AlterarAtoMedico(int id, string novoNomeAto, string novaDescricao, double novoCustoUnitario)
        {
            AtoMedico atoMedico = listaAtosMedicos.Find(a => a.Id == id);
            if (atoMedico != null)
            {
                atoMedico.NomeAto = novoNomeAto;
                atoMedico.Descricao = novaDescricao;
                atoMedico.CustoUnitario = novoCustoUnitario;
                Console.WriteLine($"Ato médico com ID {id} alterado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Ato médico com ID {id} não encontrado.");
            }
        }

        // Método para desativar um ato médico (marcar como inativo)
        static void DesativarAtoMedico(int id)
        {
            AtoMedico atoMedico = listaAtosMedicos.Find(a => a.Id == id);
            if (atoMedico != null)
            {
                atoMedico.Desativar();
                Console.WriteLine($"Ato médico com ID {id} desativado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Ato médico com ID {id} não encontrado.");
            }
        }

        // Método para atualizar o custo unitário de um ato médico
        static void AtualizarCustoAtoMedico(int id, double novoCusto)
        {
            AtoMedico atoMedico = listaAtosMedicos.Find(a => a.Id == id);
            if (atoMedico != null)
            {
                atoMedico.AtualizarCusto(novoCusto);
                Console.WriteLine($"Custo do ato médico com ID {id} atualizado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Ato médico com ID {id} não encontrado.");
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace SistemaVeterinario
{
    // Classe para representar um ato médico na ficha médica do animal
    public class AtoMedicoFicha
    {
        private static int proximoId = 1;

        public int Id { get; private set; }
        public int CodigoAnimal { get; set; }
        public DateTime DataAto { get; set; }
        public string TipoConsulta { get; set; }
        public string Colaborador { get; set; }
        public string Diagnostico { get; set; }
        public string AtoMedico { get; set; }
        public double Peso { get; set; }
        public string Observacoes { get; set; }
        public string PrescricaoMedica { get; set; }
        public DateTime ProximaVisita { get; set; }
        // Outros atributos podem ser adicionados conforme necessário

        public AtoMedicoFicha(int codigoAnimal, DateTime dataAto, string tipoConsulta, string colaborador, string diagnostico, string atoMedico, double peso, string observacoes, string prescricaoMedica, DateTime proximaVisita)
        {
            Id = proximoId++;
            CodigoAnimal = codigoAnimal;
            DataAto = dataAto;
            TipoConsulta = tipoConsulta;
            Colaborador = colaborador;
            Diagnostico = diagnostico;
            AtoMedico = atoMedico;
            Peso = peso;
            Observacoes = observacoes;
            PrescricaoMedica = prescricaoMedica;
            ProximaVisita = proximaVisita;
        }
    }

    // Classe principal do programa
    class Program
    {
        static List<AtoMedicoFicha> listaAtosMedicosFicha = new List<AtoMedicoFicha>();

        static void Main(string[] args)
        {
            // Exemplo de utilização: adicionar um novo ato médico na ficha do animal
            AdicionarAtoMedicoFicha(1, DateTime.Now, "Consulta de Rotina", "Dr. João", "Febre", "Consulta de Rotina", 10.5, "Observações sobre o estado do animal", "Prescrição de medicamento X", DateTime.Now.AddDays(7));

            // Exemplo de utilização: consultar os atos médicos na ficha do animal
            ConsultarAtosMedicosFicha();
        }

        // Método para adicionar um novo ato médico na ficha do animal
        static void AdicionarAtoMedicoFicha(int codigoAnimal, DateTime dataAto, string tipoConsulta, string colaborador, string diagnostico, string atoMedico, double peso, string observacoes, string prescricaoMedica, DateTime proximaVisita)
        {
            AtoMedicoFicha novoAtoMedicoFicha = new AtoMedicoFicha(codigoAnimal, dataAto, tipoConsulta, colaborador, diagnostico, atoMedico, peso, observacoes, prescricaoMedica, proximaVisita);
            listaAtosMedicosFicha.Add(novoAtoMedicoFicha);
            Console.WriteLine("Novo ato médico adicionado na ficha do animal.");
        }

        // Método para consultar os atos médicos na ficha do animal
        static void ConsultarAtosMedicosFicha()
        {
            Console.WriteLine("Atos médicos na ficha do animal:");
            foreach (var atoMedicoFicha in listaAtosMedicosFicha)
            {
                Console.WriteLine($"ID: {atoMedicoFicha.Id}, Código do Animal: {atoMedicoFicha.CodigoAnimal}, Data do Ato: {atoMedicoFicha.DataAto}, Tipo de Consulta: {atoMedicoFicha.TipoConsulta}, Colaborador: {atoMedicoFicha.Colaborador}, Diagnóstico: {atoMedicoFicha.Diagnostico}, Ato Médico: {atoMedicoFicha.AtoMedico}, Peso: {atoMedicoFicha.Peso}, Observações: {atoMedicoFicha.Observacoes}, Prescrição Médica: {atoMedicoFicha.PrescricaoMedica}, Próxima Visita: {atoMedicoFicha.ProximaVisita}");
            }
        }
    }
}


