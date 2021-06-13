using AbastracaoFaculdade1.Model;
using AbastracaoFaculdade1.Model.HerancaPessoa;
using AbastracaoFaculdade1.Model.PastaUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastracaoFaculdade1
{
    class Program
    {
        public static void Main(string[] args)
        {

            // faculdade
            Faculdade f = new Faculdade();
             f.setCod(1);
            f.setNome("univel");
            f.setEstado("parana");
            f.setCidade("cascavel");
            


            // curso 
            Curso c = new Curso();
            c.setCodCurso(1);
            c.setTituloCurso("TADS");


            //orientador
            Orientador o = new Orientador();
            o.setId(1);
            o.setEmail("PAULO@GMAIL.COM");


            //ALUNO

            Aluno a = new Aluno();
            a.setId(1);
            a.setEmail("leonardoecker@gmail.com");


           
            //trabalho
            Trabalho t = new Trabalho();
            t.setFaculdade(f);
            t.setCurso(c);
            t.setOrientador(o);
            t.setAluno(a);
            t.setId(1);
            t.setTituloTrabalho("abstracao");
            t.setDataConclusao(DateTime.Now);
            t.setLocalArquivo("AVA");
            t.setQuantidadeDeVotos(35);


            
          Console.WriteLine(
                              $" faculdade:\n Codigo:{t.getFaculdade().getCod()} \n"+
                              $" Nome:{ t.getFaculdade().getNome()} \n"+
                              $" Estado:{ t.getFaculdade().getEstado()} \n"+
                              $" Cidade: {t.getFaculdade().getCidade()} \n");

            Console.WriteLine("----------------------");

            Console.WriteLine($" curso: \n" +
                $"Codigo do curso : {t.getCurso().getCodCurso()} \n" +
                              $" Nome do curso : {t.getCurso().getTituloCurso()}\n " );

            Console.WriteLine("----------------------");

            Console.WriteLine($" orientador \n"+
                              $" Codigo do orientador :{t.getOrientador().getId()}\n " +
                              $" email : {t.getOrientador().getEmail()} \n"
                              );

            Console.WriteLine("----------------------");

            Console.WriteLine($" \n" +
                              $"Codigo do aluno :{t.getAluno().getId()} \n" +
                              $" email : {t.getAluno().getEmail()} \n"
                              );

            Console.WriteLine("----------------------");

            Console.WriteLine($"\n " +
                              $"trabalho: id {t.getId()} \n" +
                              $" titulo : {t.getTituloTrabalho()} \n" +
                              $" DATA DE CONCLUSAO :{t.getDataConclusao()} \n" +
                              $" local do arquivo : {t.getLocalArquivo()} \n" +
                              $" quantidade de votos: {t.getQuantidadeDeVotos()} \n");



            Console.ReadLine();







}
    } }