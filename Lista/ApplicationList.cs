using EDA_Gabriel_Peixoto.Applications;
using EDA_Gabriel_Peixoto.Lista.Models;

namespace EDA_Gabriel_Peixoto.Lista
{
    public class ApplicationList : IApplication
    {
        public void Run()
        {
            List list = new List();

            list.Add(new Ellement("A"));
            list.Add(new Ellement("C"));
            list.Add(new Ellement("B"));

            list.ConsolePrint();
        }
    }
}