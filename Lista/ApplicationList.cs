using EDA_Gabriel_Peixoto.Applications;
using EDA_Gabriel_Peixoto.Lista.Models;

namespace EDA_Gabriel_Peixoto.Lista
{
    public class ApplicationList : IApplication
    {
        public void Run()
        {
            RunGeneric();

            IList list = new List();

            list.Add(new Ellement("A"));
            list.Add(new Ellement("B"));
            list.Add(new Ellement("C"));
            list.Add(new Ellement("D"));
            list.Add(new Ellement("E"));

            list.ConsolePrint();

            list.Remove(new Ellement("A"));

            list.ConsolePrint();

            list.Remove(new Ellement("E"));

            list.ConsolePrint();

            list.Remove(new Ellement("C"));

            list.ConsolePrint();

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