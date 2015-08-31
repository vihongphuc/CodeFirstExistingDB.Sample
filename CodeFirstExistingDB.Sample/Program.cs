using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExistingDB.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogContext())
            {
                Console.WriteLine("Input new Blog name: ");
                string name = Console.ReadLine();

                var blog = new Blog { BlogName = name };
                context.Blogs.Add(blog);
                context.SaveChanges();

                var blogs = from a in context.Blogs
                            orderby a.BlogName
                            select a;
                foreach (var item in blogs)
                {
                    Console.WriteLine("Blog name: {0}", item.BlogName);

                }

                Console.ReadLine();
            }
        }
    }
}
///https://msdn.microsoft.com/en-us/data/jj200620
///