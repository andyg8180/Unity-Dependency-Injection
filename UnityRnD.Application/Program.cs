using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Configuration;
using UnityRnD.Core;

namespace UnityRnD.Application
{
    class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("DoSingleLineRun");
            DoSingleLineRun();
            Console.WriteLine();

            Console.WriteLine("DoSingleLineRunWithName");
            DoSingleLineRunWithName();
            Console.WriteLine();

            Console.WriteLine("DoMultiNamed");
            DoMultiNamed();
            Console.WriteLine();

            Console.WriteLine("DoMultiNamedWithResolveAll");
            DoMultiNamedWithResolveAll();
            Console.WriteLine();

        }

        private static void DoSingleLineRun()
        {

            var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unitySingleLine");
            IUnityContainer container = new UnityContainer();
            container.LoadConfiguration(section);

            var letsTalk = container.Resolve<IGreeting>();
            Console.WriteLine(letsTalk.GetGreeting());
        }

        private static void DoSingleLineRunWithName()
        {

            var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unitySingleNamed");
            IUnityContainer container = new UnityContainer();
            container.LoadConfiguration(section);

            var letsTalk = container.Resolve<IGreeting>("tom");
            Console.WriteLine(letsTalk.GetGreeting());
        }

        private static void DoMultiNamed()
        {
            var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unityMultiNamed");

            IUnityContainer container = new UnityContainer();
            container.LoadConfiguration(section);

            var letsTalk = container.Resolve<IGreeting>("michael");
            Console.WriteLine(letsTalk.GetGreeting());

            letsTalk = container.Resolve<IGreeting>("stacey");
            Console.WriteLine(letsTalk.GetGreeting());

            letsTalk = container.Resolve<IGreeting>("tom");
            Console.WriteLine(letsTalk.GetGreeting());

        }

        private static void DoMultiNamedWithResolveAll()
        {
            var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unityMultiNamed");

            IUnityContainer container = new UnityContainer();
            container.LoadConfiguration(section);

            var items = container.ResolveAll<IGreeting>();
         
            foreach (var greeting in items)
            {
                Console.WriteLine(greeting.GetGreeting());
            }
        }


    }
}
