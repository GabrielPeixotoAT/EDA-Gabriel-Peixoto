namespace EDA_Gabriel_Peixoto.Pilha.Models
{
    internal class Stack : IStack
    {
        string[] ellements;
        int top;
        int size;

        public Stack(string[] ellements, int size)
        {
            this.ellements = ellements;
            top = -1;
            this.size = size;
        }

        public bool Push(string value)
        {
            if (top < size - 1)
            {
                ellements[++top] = value;
                return true;
            }

            return false;
        }

        public bool Pop()
        {
            if (top >= 0)
            {
                ellements[top--] = " ";
                return true;
            }

            return false;
        }

        public void ConsolePrint()
        {
            Console.WriteLine("Stack: \n");

            for (int i = size - 1; i >= 0; i--)
            {
                Console.WriteLine($" [ {ellements[i]} ]");
            }

            Console.ReadKey();
        }
    }
}
