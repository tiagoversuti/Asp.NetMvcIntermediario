using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Asp.NetMvcIntermediario.Models
{
    public class InicializarBanco : DropCreateDatabaseAlways<BancoContexto>
    {
        protected override void Seed(BancoContexto context)
        {
            // Criar alguns dados no banco
            new List<Professor>
            {
                new Professor
                {
                    Nome = "Renato Haddad",
                    Materia = "ASP.NET MVC",
                    Salario = 4000,
                    Telefone = "315466",
                    TwitterBlog = "https://weblogs.asp.net/renatohaddah",
                    Disponivel = true,
                    Admissao = new DateTime(2012, 05, 01),
                    Alunos =  new List<Aluno> {
                        new Aluno
                        {
                            NomeAluno = "Bruno",
                            Email = "bruno@msn.com",
                            Aprovado = false,
                            Ano = 2011,
                            Inscricao = new DateTime(2011,8,12)
                        },
                        new Aluno
                        {
                            NomeAluno = "Rafael",
                            Email = "rafael@msn.com",
                            Aprovado = false,
                            Ano = 2011,
                            Inscricao = new DateTime(2011,7,12)
                        }
                    },
                    Topicos = new List<Topico> {
                        new Topico { Descricao = "Tópico 1" },
                        new Topico { Descricao = "Tópico 2" }
                    }
                },
                new Professor
                {
                    Nome = "Claudemir Andrade",
                    Materia = "Linguagem C#",
                    Salario = 6000,
                    Telefone = "34327845",
                    TwitterBlog = "@claudemir",
                    Disponivel = true,
                    Admissao = new DateTime(2012, 02, 18),
                    Alunos =  new List<Aluno> {
                        new Aluno
                        {
                            NomeAluno = "Letícia",
                            Email = "leticia@msn.com",
                            Aprovado = false,
                            Ano = 2011,
                            Inscricao = new DateTime(2011,8,13)
                        },
                        new Aluno
                        {
                            NomeAluno = "Julien",
                            Email = "julien@msn.com",
                            Aprovado = false,
                            Ano = 2011,
                            Inscricao = new DateTime(2011,7,15)
                        },
                        new Aluno
                        {
                            NomeAluno = "Maurice",
                            Email = "maurice@msn.com",
                            Aprovado = false,
                            Ano = 2012,
                            Inscricao = new DateTime(2011,8,22)
                        }
                    },
                    Topicos = new List<Topico> {
                        new Topico { Descricao = "Orientação a Objetos" },
                        new Topico { Descricao = "Estrutura de Dados" }
                    }
                }
            }.ForEach(p => context.Professores.Add(p));

            base.Seed(context);
        }
    }
}