using EDA_Gabriel_Peixoto.Applications;
using EDA_Gabriel_Peixoto.Applications.GUI;
using EDA_Gabriel_Peixoto.Pilha.Models;

namespace EDA_Gabriel_Peixoto.Pilha
{
    public class ApplicationStack : IApplication
    {
        Stack stack;
        IGUIFactory guiFactory;

        public ApplicationStack()
        {
            stack = new Stack(new string[5], 5);

            guiFactory = new SelectionMenu(new List<string> { "Push", "Pop", "Print" }, 15);
        }

        public void Run()
        {
            int index = 0;

            do
            {
                index = guiFactory.BuildMenu();
                switch (index)
                {
                    case 0:
                        Push(stack);
                        break;
                    case 1:
                        Pop(stack);
                        break;
                    case 2:
                        Print(stack);
                        break;
                }
            } while (index != 3);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }

        void Push(Stack stack)
        {
            stack.Push(WriteRead("Enter the value to Push: "));
        }

        void Pop(Stack stack) 
        {
            stack.Pop();
        }

        void Print(Stack stack)
        {
            guiFactory.Header();
            stack.ConsolePrint();
        }

        string WriteRead(string message)
        {
            string? strAws;

            do
            {
                guiFactory.Header();

                Console.WriteLine(message);
                strAws = Console.ReadLine();
            } while(strAws == null || strAws == string.Empty || strAws.Length > 1);

            return strAws;
        }
    }
}
