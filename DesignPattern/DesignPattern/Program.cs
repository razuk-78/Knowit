using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public interface Iterator
    {
         bool hasNext();
         Object next();
    }
    public interface IContainer
    {
         Iterator getIterator();
    }
    public class NameRepository : IContainer
    {
        public string[] names = { "Robert", "John", "Julie", "Lora" };

        public Iterator getIterator()
        {
            throw new NotImplementedException();
        }
    }
   
    public class User
    {
        List<string> addresses = new List<string>() { "a","b","c"};
        public IEnumerator<string> GetAddress()
        {
            return addresses.GetEnumerator();
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
          User  user = new User();
            var itr = user.GetAddress();
            while (itr.MoveNext())
            {
                Console.WriteLine(itr.Current);
            }
            Console.Read();
        }
    }
}
