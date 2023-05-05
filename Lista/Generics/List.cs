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
            if (value != null)
            {
                Ellement<T> ellement = new Ellement<T>(value);

                if (IsEmpyt())
                {
                    head = ellement;
                }
                else
                {
                    AddEllementAtLastPosition(ellement);
                }
            }
        }

        public void Remove(T value)
        {
            if(value != null)
            {
                if (!IsEmpyt())
                {
                    Ellement<T>? ellement = Find(value) as Ellement<T>;

                    if (IsTheLastEllement(ellement))
                    {
                        RemoveLast(ellement);
                    }
                    else
                    {
                        RemoveBetween(ellement);
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

        public INode<T>? Find(T value)
        {
            if (IsEmpyt())
            {
                return null;
            }
            else
            {
                if (value.Equals(head.Value))
                {
                    return head;
                }
                else
                {
                    Ellement<T> ellementAux = head;

                    while (ellementAux.Next != null)
                    {
                        if (ellementAux.Value.Equals(value))
                            break;

                        ellementAux = ellementAux.Next;
                    }

                    return ellementAux;
                }
            }
        }

        void RemoveBetween(Ellement<T> ellement)
        {
            ellement.Next.Prev = ellement.Prev;
            ellement.Prev.Next = ellement.Next;
        }

        void RemoveLast(Ellement<T> ellement)
        {
            ellement.Prev.Next = null;
        }

        void AddEllementAtLastPosition(Ellement<T> ellement)
        {
            Ellement<T>? lastEllement = GetLastEllement();

            if (lastEllement != null)
            {
                ellement.Prev = lastEllement;
                lastEllement.Next = ellement;
            }
            else
                head = ellement;
        }

        Ellement<T>? GetLastEllement()
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

        bool IsTheLastEllement(Ellement<T> ellement)
        {
            if (ellement.Equals(GetLastEllement()))
                return true;

            return false;
        }

        void InterateUntilTheEnd()
        {

        }
    }
}