using EDA_Gabriel_Peixoto.Lista.Models;

namespace EDA_Gabriel_Peixoto.Lista.Generics
{
    public class List<T> : Models.IList<T>
    {
        private INode<T>? head { get; set; }
        
        public List()
        {
            head = null;
        }

        public void Add(INode<T> ellement)
        {
            if (head == null)
            {
                head = ellement;
            }
            else
            {
                INode<T> ellementAux = head;

                while (ellementAux.Next != null)
                {
                    ellementAux = ellementAux.Next;
                }

                ellementAux.Next = ellement;
            }
        }

        public void Remove(INode<T> ellement)
        {
            if(ellement == null)
                throw new NullReferenceException();
            
            if (head != null)
            {
                if (ellement.Value.Equals(head.Value))
                {
                    head = head.Next;
                }
                else
                {
                    INode<T>? ellementAux = head.Next;
                    INode<T> ellementAuxPrev = head;

                    while (ellementAux != null)
                    {
                        if (ellement.Value.Equals(ellementAux.Value))
                        {
                            ellementAuxPrev.Next = ellementAux.Next;
                        }
                        ellementAuxPrev = ellementAux;
                        ellementAux = ellementAux.Next;
                    }
                }
            }
        }

        public void ConsolePrint()
        {
            if (head == null)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                INode<T>? ellement = head;

                while (ellement != null)
                {
                    Console.Write(ellement.ToString());
                    ellement = ellement.Next;
                }
                Console.WriteLine();
            }
        }
    }
}