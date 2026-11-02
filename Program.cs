
using SistemaAcademico.Models;
using SistemaAcademico.Services;
using SistemaAcademico.Factories;
using SistemaAcademico.Strategies;

var alunos = new AlunoService();
var professores = new ProfessorService();
var disciplinas = new DisciplinaService();
var matriculas = new MatriculaService();

bool executando = true;

while (executando)
{
    Console.Clear();

    // MENU PRINCIPAL
    Console.WriteLine("========================================");
    Console.WriteLine("           SISTEMA ACADÊMICO");
    Console.WriteLine("========================================");
    Console.WriteLine();
    Console.WriteLine("  1 - Cadastrar aluno");
    Console.WriteLine("  2 - Listar alunos");
    Console.WriteLine("  3 - Cadastrar professor");
    Console.WriteLine("  4 - Listar professores");
    Console.WriteLine("  5 - Cadastrar disciplina");
    Console.WriteLine("  6 - Listar disciplinas");
    Console.WriteLine("  7 - Realizar matrícula");
    Console.WriteLine("  8 - Listar matrículas");
    Console.WriteLine("  9 - Registrar nota");
    Console.WriteLine("  0 - Sair");
    Console.WriteLine();
    Console.Write("Escolha uma opção: ");

    string? opcao = Console.ReadLine();

    try
    {
        switch (opcao)
        {
            // CADASTRAR ALUNO
            case "1":
                Console.WriteLine("\n========================================");
                Console.WriteLine("             CADASTRO DE ALUNO");
                Console.WriteLine("========================================\n");

                Console.Write("ID: ");
                int idAluno = int.Parse(Console.ReadLine()!);

                Console.Write("Nome: ");
                string nomeAluno = Console.ReadLine()!;

                Console.Write("E-mail: ");
                string emailAluno = Console.ReadLine()!;

                Console.Write("Matrícula: ");
                string numeroMatricula = Console.ReadLine()!;

                var aluno = (Aluno)PessoaFactory.CriarAluno(
                    idAluno, nomeAluno, emailAluno, numeroMatricula);

                alunos.Adicionar(aluno);

                Console.WriteLine("\nAluno cadastrado com sucesso!");
                break;

            // LISTAR ALUNOS
            case "2":
                var listaAlunos = alunos.Listar();

                Console.WriteLine("\n========================================");
                Console.WriteLine("               LISTA DE ALUNOS");
                Console.WriteLine("========================================\n");

                if (listaAlunos.Count == 0)
                {
                    Console.WriteLine("Nenhum aluno cadastrado.");
                }
                else
                {
                    foreach (var a in listaAlunos)
                    {
                        Console.WriteLine($"ID: {a.Id}");
                        Console.WriteLine($"Nome: {a.Nome}");
                        Console.WriteLine($"E-mail: {a.Email}");
                        Console.WriteLine($"Matrícula: {a.Matricula}");
                        Console.WriteLine("----------------------------------------");
                    }
                }
                break;

            // CADASTRAR PROFESSOR
            case "3":
                Console.WriteLine("\n========================================");
                Console.WriteLine("           CADASTRO DE PROFESSOR");
                Console.WriteLine("========================================\n");

                Console.Write("ID: ");
                int idProfessor = int.Parse(Console.ReadLine()!);

                Console.Write("Nome: ");
                string nomeProfessor = Console.ReadLine()!;

                Console.Write("E-mail: ");
                string emailProfessor = Console.ReadLine()!;

                Console.Write("Especialidade: ");
                string especialidade = Console.ReadLine()!;

                var professor = (Professor)PessoaFactory.CriarProfessor(
                    idProfessor, nomeProfessor, emailProfessor, especialidade);

                professores.Adicionar(professor);

                Console.WriteLine("\nProfessor cadastrado com sucesso!");
                break;

            // LISTAR PROFESSORES
            case "4":
                var listaProfessores = professores.Listar();

                Console.WriteLine("\n========================================");
                Console.WriteLine("            LISTA DE PROFESSORES");
                Console.WriteLine("========================================\n");

                if (listaProfessores.Count == 0)
                {
                    Console.WriteLine("Nenhum professor cadastrado.");
                }
                else
                {
                    foreach (var p in listaProfessores)
                    {
                        Console.WriteLine($"ID: {p.Id}");
                        Console.WriteLine($"Nome: {p.Nome}");
                        Console.WriteLine($"E-mail: {p.Email}");
                        Console.WriteLine($"Especialidade: {p.Especialidade}");
                        Console.WriteLine("----------------------------------------");
                    }
                }
                break;

            // CADASTRAR DISCIPLINA
            case "5":
                Console.WriteLine("\n========================================");
                Console.WriteLine("           CADASTRO DE DISCIPLINA");
                Console.WriteLine("========================================\n");

                Console.Write("ID: ");
                int idDisciplina = int.Parse(Console.ReadLine()!);

                Console.Write("Nome: ");
                string nomeDisciplina = Console.ReadLine()!;

                Console.Write("Carga horária: ");
                int carga = int.Parse(Console.ReadLine()!);

                disciplinas.Adicionar(
                    new Disciplina(idDisciplina, nomeDisciplina, carga));

                Console.WriteLine("\nDisciplina cadastrada com sucesso!");
                break;

            // LISTAR DISCIPLINAS
            case "6":
                var listaDisciplinas = disciplinas.Listar();

                Console.WriteLine("\n========================================");
                Console.WriteLine("            LISTA DE DISCIPLINAS");
                Console.WriteLine("========================================\n");

                if (listaDisciplinas.Count == 0)
                {
                    Console.WriteLine("Nenhuma disciplina cadastrada.");
                }
                else
                {
                    foreach (var d in listaDisciplinas)
                    {
                        Console.WriteLine($"ID: {d.Id}");
                        Console.WriteLine($"Nome: {d.Nome}");
                        Console.WriteLine($"Carga horária: {d.CargaHoraria} horas");
                        Console.WriteLine("----------------------------------------");
                    }
                }
                break;

            // REALIZAR MATRÍCULA
            case "7":
                Console.WriteLine("\n========================================");
                Console.WriteLine("             REALIZAR MATRÍCULA");
                Console.WriteLine("========================================\n");

                Console.Write("ID da matrícula: ");
                int idMatricula = int.Parse(Console.ReadLine()!);

                Console.Write("ID do aluno: ");
                int idBuscaAluno = int.Parse(Console.ReadLine()!);

                Console.Write("ID da disciplina: ");
                int idBuscaDisciplina = int.Parse(Console.ReadLine()!);

                var alunoEncontrado = alunos.Listar()
                    .FirstOrDefault(a => a.Id == idBuscaAluno);

                var disciplinaEncontrada = disciplinas.Listar()
                    .FirstOrDefault(d => d.Id == idBuscaDisciplina);

                if (alunoEncontrado == null || disciplinaEncontrada == null)
                    throw new ArgumentException(
                        "Aluno ou disciplina não encontrados.");

                matriculas.Adicionar(new Matricula(
                    idMatricula, alunoEncontrado, disciplinaEncontrada));

                Console.WriteLine("\nMatrícula realizada com sucesso!");
                break;

            // LISTAR MATRÍCULAS
            case "8":
                var listaMatriculas = matriculas.Listar();

                Console.WriteLine("\n========================================");
                Console.WriteLine("             LISTA DE MATRÍCULAS");
                Console.WriteLine("========================================\n");

                if (listaMatriculas.Count == 0)
                {
                    Console.WriteLine("Nenhuma matrícula cadastrada.");
                }
                else
                {
                    foreach (var m in listaMatriculas)
                    {
                        Console.WriteLine($"ID: {m.Id}");
                        Console.WriteLine($"Aluno: {m.Aluno.Nome}");
                        Console.WriteLine($"Disciplina: {m.Disciplina.Nome}");
                        Console.WriteLine($"Nota: {m.Nota}");
                        Console.WriteLine("----------------------------------------");
                    }
                }
                break;

            // REGISTRAR NOTA
            case "9":
                Console.WriteLine("\n========================================");
                Console.WriteLine("              REGISTRAR NOTA");
                Console.WriteLine("========================================\n");

                Console.Write("ID da matrícula: ");
                int idNota = int.Parse(Console.ReadLine()!);

                var matriculaEncontrada = matriculas.Listar()
                    .FirstOrDefault(m => m.Id == idNota);

                if (matriculaEncontrada == null)
                    throw new ArgumentException("Matrícula não encontrada.");

                Console.Write("Nota: ");
                double nota = double.Parse(
                    Console.ReadLine()!,
                    System.Globalization.CultureInfo.InvariantCulture);

                var estrategia = new MediaAritmeticaStrategy();

                matriculaEncontrada.RegistrarNota(
                    estrategia.Calcular(nota));

                Console.WriteLine("\nNota registrada com sucesso!");
                break;

            // SAIR
            case "0":
                executando = false;
                Console.WriteLine("\nSistema encerrado.");
                break;

            default:
                Console.WriteLine("\nOpção inválida!");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nErro: {ex.Message}");
    }

    if (executando)
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}
