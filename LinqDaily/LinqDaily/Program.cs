using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDaily
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager Manager1 = new Manager { Name = "Джон" };
            Manager Manager2 = new Manager { Name = "Коля", ParentId = Manager1.Id };
            Manager Manager3 = new Manager { Name = "Дима", ParentId = Manager1.Id };
            Manager Manager4 = new Manager { Name = "Вася" };
            Manager Manager5 = new Manager { Name = "Артём", ParentId = Manager4.Id };
            Manager Manager6 = new Manager { Name = "Сергей", ParentId = Manager4.Id };
            Manager Manager7 = new Manager { Name = "Петя" };
            Manager Manager8 = new Manager { Name = "Боря", ParentId = Manager7.Id };

            var managers = new List<Manager>() { Manager1, Manager2, Manager3, Manager4, Manager5, Manager6, Manager7, Manager8 };


            var result = (from manager in managers
                           where manager.ParentId == null
                           orderby manager.Name
                           join man in managers on manager.Id equals man.ParentId into g
                           from man in g.DefaultIfEmpty()
                           select new { NameTop = manager.Name, NameLow = man.Name });
  
                           


                          
        } 
    }
}
