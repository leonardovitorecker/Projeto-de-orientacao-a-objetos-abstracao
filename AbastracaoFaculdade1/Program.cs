using AbastracaoFaculdade1.Model;
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

            Trabalho t = new Trabalho();
      
            t.setId(1);
            t.setFaculdade();
            f.setCod(1);
            f.setNome("univel");
            f.setEstado("PARANA");
            f.setCidade("cascavel");


          


            Console.WriteLine($"id :{t.getId()}" +
                              $" faculdade:{t.getFaculdade()} ");



            Console.ReadLine();







}
    } }