using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CoffeeFactoryContainer
    {
        private Dictionary<string, ICoffeeFactory> factories = new Dictionary<string, ICoffeeFactory>();

        public void Register(string name, ICoffeeFactory factory)
        {
            factories.Add(name, factory);
        }

        public ICoffeeFactory GetFactory(string name)
        {
           return factories.ContainsKey(name) ? factories[name] :  null;
        }
    }


}
