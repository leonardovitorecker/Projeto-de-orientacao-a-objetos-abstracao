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
            Faculdade f = new Faculdade();
             f.setCod(1);
            f.setNome("univel");
            f.setEstado("parana");
            f.setCidade("cascavel");
            Trabalho t = new Trabalho();
      
            t.setId(1);
            t.setFaculdade(f);
     
            f.setCod(1);
            
            Console.WriteLine($"id :{t.getId()}" +
                              $" faculdade:{t.getFaculdade()} ");



            Console.ReadLine();







}
    } }