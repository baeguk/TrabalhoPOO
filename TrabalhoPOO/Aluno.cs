using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO;


namespace TrabalhoPOO
{
    //Declaração de atributos
    class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public float Nota { get; set; }

        public Aluno(int matricula, string nome, int telefone, float nota)
        {
            Matricula = matricula;
            Nome = nome;
            Telefone = telefone;   
            Nota = nota;
            
        }

        //Exemplo de Métodos

        public void Estado(float nota)
        {
            if ((nota >= 70) && (nota <=100))
            {
                Console.WriteLine("Aprovado");
            }
            else if ((nota >= 40) && (nota < 70))
            {
                Console.WriteLine("Recuperação");
            }
            else if (nota < 40)
            {
                Console.WriteLine("Reprovado");
            }
        }

        //Declaração de Propriedades
        /*  private int matricula;
            private string nome;
            private int telefone;
         
        public int Matricula
        {
            get 
            { 
                return matricula;
            }
            set { 
                matricula = value;
            }

        }
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            { 
                nome = value;
            }
        }
        public int Telefone
        {
            get
            {
                return telefone;
            }

            set
            { 
                telefone = value;
            }

        }*/
        
    }
}

//Exemplo de sobrecarga de Métodos
    namespace Sobrecargas
    {
    //Quando temos vários métodos com o mesmo nome e parâmetros diferente, ocorre a sobrecaga
    class Turma
    {
        public int Numero { get; set; }
        public float NumeroT { get; set; }

        public Turma(int numeroManha)
        {
            Numero = numeroManha;
        }

        public Turma(float numeroTarde)
        {
            NumeroT = numeroTarde;
        }

        //O comando abaixo, no C# já é definido de modo padrão
        public Turma()
        {
        }
    }
}


namespace Unidirecional
    {
    public class Professor
    {
        public string Nome { get; set; }
        public string Disciplina { get; set; }

        public Professor(string nome, string disciplina)
        {
            Nome = nome;
            Disciplina = disciplina;
        }

        public void Informacoes()
        {
            Console.WriteLine($"O professor {Nome}, é responsável pela disciplina: {Disciplina} \n");
        }
    }

    public class Aluno1
    {
        public string Nome { get; set; }
        public int Turma1 { get; set; }
        public Professor Prof { get; set; }

        public Aluno1 (string nome, int turma, Professor prof)
        {
            Nome = nome;
            Turma1 = turma;
            Prof = prof;
        }

        public void Informacoes()
        {
            Console.WriteLine($"O aluno {Nome}, da turma: {Turma1}, tem como professor responsável: {Prof.Nome} \n");
            Prof.Informacoes();
        }
      }

    }

    namespace Bidirecional
    {
        public class Disciplina
        {
            public string Nome { get; set; }
            public List<Aluno2> AlunosMatriculados { get; set; }

            public Disciplina(string nome)
            {
                Nome = nome;
                AlunosMatriculados = new List<Aluno2>();
            }

            public void NovoAluno(Aluno2 aluno)
            {
                AlunosMatriculados.Add(aluno);
            }

            public void Informacoes1()
            {
                Console.WriteLine($"\n Na disciplina {Nome}, estão matriculados os(as) alunos(as) ");
      
                foreach (var aluno in AlunosMatriculados)
                {
                    Console.WriteLine($"{aluno.Nome}");
                }
            }
        }

        public class Aluno2
        {
            public string Nome { get; set; }
            public List<Disciplina> Disciplinas { get; set; }

            public Aluno2(string nome)
            {
                Nome = nome;
                Disciplinas = new List<Disciplina>();
            }

            public void Matricular(Disciplina disciplina)
            {
                Disciplinas.Add(disciplina);
                disciplina.NovoAluno(this);
            }

            public void Informacoes1()
            {
                Console.WriteLine($"Aluno: {Nome}, está matriculado na disciplina");
                
                foreach (var disciplina in Disciplinas)
                {
                    Console.WriteLine($" {disciplina.Nome}");
                }
            }
        }

    }