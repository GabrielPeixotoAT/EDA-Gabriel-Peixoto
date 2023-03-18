using EDA_Gabriel_Peixoto.Applications;
using EDA_Gabriel_Peixoto.Lista.Models;

namespace EDA_Gabriel_Peixoto.Lista
{
    public class ApplicationList : IApplication
    {
        public void Run()
        {
            //RunGeneric();

            IList list = new List();

            list.Add(new Ellement("B"));
            list.Add(new Ellement("C"));
            list.Add(new Ellement("E"));
            list.Add(new Ellement("F"));
            list.Add(new Ellement("H"));

            list.AddOrdered(new Ellement("A"));
            list.AddOrdered(new Ellement("D"));
            list.AddOrdered(new Ellement("G"));
            list.AddOrdered(new Ellement("I"));

            list.ConsolePrint();

            list.ConsolePrintReverse();

            Console.ReadKey();
        }

        public void RunGeneric()
        {
            Generics.List<string> listGeneric = new Generics.List<string>();

            listGeneric.Add(new Ellement<string>("X"));
            listGeneric.Add(new Ellement<string>("Y"));
            listGeneric.Add(new Ellement<string>("Z"));

            listGeneric.ConsolePrint();
        }
    }
}