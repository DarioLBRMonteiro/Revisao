using System;


namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Aluno[] alunos = new Aluno[5]; 
            var indiceAluno = 0;

            var opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");
                        
                        if (decimal.TryParse(Console.ReadLine(),out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal"); 
                        } 

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":

                        foreach (var a in alunos)
                        {
                            if (a != null)
                            {
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota} "); 
                            }
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        decimal media = 0;
                        var qtdAlunos = 0;
                        Conceito conceitoGeral = Conceito.E;
                        int mediaAproximada = 0;

                        for(int i=0; i < (alunos.Length-1); i++)
                        {
                            if (alunos[i] != null)
                            {
                               notaTotal += alunos[i].Nota;
                               qtdAlunos++;
                            }                            
                        }

                        if (qtdAlunos > 0){
                            media = notaTotal / qtdAlunos;
                        }

                        mediaAproximada = Convert.ToInt32(media);

                        switch (mediaAproximada)
                        {
                            case 10:
                                conceitoGeral = Conceito.A ;
                                break;

                            case 9:
                                conceitoGeral = Conceito.A ;
                                break;

                            case 8:
                                conceitoGeral = Conceito.B ;
                                break;

                            case 7:
                                conceitoGeral = Conceito.B ;
                                break;
                            case 6:
                                conceitoGeral = Conceito.C ;
                                break;
                            case 5:
                                conceitoGeral = Conceito.C ;
                                break;
                            case 4:
                                conceitoGeral = Conceito.E ;
                                break;
                            case 3:
                                conceitoGeral = Conceito.E ;
                                break;
                            case 2:
                                conceitoGeral = Conceito.E ;
                                break;
                            case 1:
                                conceitoGeral = Conceito.E ;
                                break;
                            case 0:
                                conceitoGeral = Conceito.E ;
                                break;
                        }

                        Console.WriteLine(value: $"MÉDIA GERAL : {media} CONCEITO GERAL : {conceitoGeral} ");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Você informou uma opção inválida.");

                }
                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.Clear();
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();

            return opcaoUsuario;

        }
    }
}
