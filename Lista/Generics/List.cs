using EDA_Gabriel_Peixoto.Lista.Models;

namespace EDA_Gabriel_Peixoto.Lista.Generics
{
    public class List<T> : Models.IList<T>
    {
        private Ellement<T>? head { get; set; }
        
        public List()
        {
            head = null;
        }

        public void Add(T value)
        {
            if (!IsEmpyt())
            {
                Ellement<T> ellement = new Ellement<T>(value);

                if (head == null)
                {
                    head = ellement;
                }
                else
                {
                    Ellement<T> ellementAux = head;

                    while (ellementAux.Next != null)
                    {
                        ellementAux = ellementAux.Next;
                    }

                    ellementAux.Next = ellement;
                }
            }
        }

        public void Remove(T value)
        {
            if(value != null)
            {
                Ellement<T> ellement = new Ellement<T>(value);

                if (!IsEmpyt())
                {
                    if (ellement.Equals(head.Value))
                    {
                        head = head.Next;
                    }
                    else
                    {
                        Ellement<T>? ellementAux = head.Next;
                        Ellement<T> ellementAuxPrev = head;

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
        }

        public void ConsolePrint()
        {
            if (IsEmpyt())
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Ellement<T>? ellement = head;

                while (ellement != null)
                {
                    Console.Write(ellement.ToString());
                    ellement = ellement.Next;
                }
                Console.WriteLine();
            }
        }

        Ellement<T>? GetLastIten()
        {
            if (IsEmpyt())
            {
                return head;
            }
            else
            {
                Ellement<T> ellementAux = head;

                while (ellementAux.Next != null)
                {
                    ellementAux = ellementAux.Next;
                }

                return ellementAux;
            }
        }

        bool IsEmpyt()
        {
            if (head == null)
                return true;

            return false;
        }

        void InterateUntilTheEnd()
        {

        }
    }
}