using EDA_Gabriel_Peixoto.Lista.Models;
using System.Xml.Linq;

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
            if (ValueIsValid(value))
            {
                if (IsEmpyt())
                {
                    AddEllementAtFirstPosition(new Ellement<T>(value));
                }
                else
                {
                    AddEllementAtLastPosition(new Ellement<T>(value));
                }
            }
        }

        public void Remove(T value)
        {
            if (ValueIsValid(value))
            {
                if (!IsEmpyt())
                {
                    Ellement<T>? ellement = Find(value) as Ellement<T>;

                    RemoveEllement(ellement);
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
                PrintList();
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
                    Ellement<T>? finded = null;

                    while (ellementAux.Next != null)
                    {
                        if (ellementAux.Value.Equals(value))
                        {
                            finded = ellementAux;
                            break;
                        }

                        ellementAux = ellementAux.Next;
                        
                    }

                    return finded;
                }
            }
        }

        void PrintList()
        {
            Ellement<T>? ellement = head;

            while (ellement != null)
            {
                Console.Write(ellement.ToString());
                ellement = ellement.Next;
            }
            Console.WriteLine();
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

        void RemoveEllement(Ellement<T>? ellement)
        {
            if (ellement != null)
            {
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

        void AddEllementAtFirstPosition(Ellement<T> ellement)
        {
            if (IsEmpyt())
            {
                head = ellement;
            }
            else
            {
                ellement.Next = head;
                head.Prev = ellement;
                head = ellement;
            }
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

        bool ValueIsValid(T value)
        {
            if (value != null)
                return true;

            return false;
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