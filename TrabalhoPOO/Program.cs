using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using TrabalhoPOO;
using Sobrecargas;
using Unidirecional;
using Bidirecional;


namespace TrabalhoPOO
{
  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{Atributo e Propriedade}");
            Aluno aluno1 = new Aluno(123, "Nanda", 999141405, 80);
            aluno1.Matricula = 123;
            aluno1.Nome = "Ana";
            aluno1.Telefone = 999141405;
            aluno1.Nota = 80;

            Console.WriteLine("Matrícula do aluno: "+aluno1.Matricula+"\n"+ "Nome do aluno: "
                +aluno1.Nome+"\n"+"Telefone do aluno: "+aluno1.Telefone+"\n"+"Nota do aluno: "
                +aluno1.Nota+"\n");

            Console.WriteLine("{Método}");
            aluno1.Estado(80);


            Console.WriteLine("\n{Sobrecargas}");
            Turma turma = new Turma();
            turma.Numero = 1001;
            turma.NumeroT = 2001;

            Console.WriteLine("A sala 1 no turno da manhã pertence a turma: " + turma.Numero 
                + ", já na parte da tarde, essa sala pertence a turma: " + turma.NumeroT+ "\n");

            Console.WriteLine("{Associação Unidirecional}");
            Professor professor = new Professor("Rosenclever", "POO");
            
            Aluno1 aluno = new Aluno1("Arthur", 5, professor);

            aluno.Informacoes();


            Console.WriteLine("{Associação Bidirecional}");
                Disciplina progMob = new Disciplina("Programação Mobile");
                Disciplina redes = new Disciplina("Redes");

                Aluno2 kananda = new Aluno2("Kananda");
                Aluno2 larissa = new Aluno2("Larissa");
                Aluno2 maira = new Aluno2("Maíra");
                Aluno2 sarah = new Aluno2("Sarah");

                kananda.Matricular(redes);
                larissa.Matricular(progMob);
                maira.Matricular(progMob);
                sarah.Matricular(redes);

                kananda.Informacoes1();
                Console.WriteLine();
                larissa.Informacoes1();
                Console.WriteLine();
                maira.Informacoes1();
                Console.WriteLine();
                sarah.Informacoes1();
                Console.WriteLine();

                progMob.Informacoes1();
                Console.WriteLine();
                redes.Informacoes1();
                Console.WriteLine();
            }

    }
}
    
         