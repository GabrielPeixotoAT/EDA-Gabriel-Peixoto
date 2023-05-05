using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDA_Gabriel_Peixoto.Lista.Models
{
    public class List //: IList
    {
        public INode? head { get; set; }

        public List()
        {
            head = null;
        }
        /*
        public void Add(INode ellement)
        {
            if (head == null)
            {
                head = ellement;
            }
            else
            {
                INode ellementAux = head;

                while (ellementAux.Next != null)
                {
                    ellementAux = ellementAux.Next;
                }
                ellement.Prev = ellementAux;
                ellementAux.Next = ellement;
            }
        }

        public void AddOrdered(INode ellement)
        {
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (head == null)
            {
                head = ellement;
            }
            else if (comparer.Compare(ellement.ToString(), head.ToString()) < 0)
            {
                ellement.Next = head;
                head.Prev = ellement;
                head = ellement;
            }
            else
            {
                INode ellementAux = head;

                while (ellementAux.Next != null &&
                 comparer.Compare(ellement.ToString(), ellementAux.Next.ToString()) > 0)
                {
                    ellementAux = ellementAux.Next;
                }

                if (ellementAux.Next != null)
                {
                    ellement.Prev = ellementAux;
                    ellement.Next = ellementAux.Next;
                    ellementAux.Next.Prev = ellement;
                    ellementAux.Next = ellement;
                }
                else
                {
                    ellement.Prev = ellementAux;
                    ellementAux.Next = ellement;
                }
            }
        }

        public void Remove(INode ellement)
        {
            if (head != null)
            {
                if (head.Value == ellement.Value)
                {
                    head = head.Next;
                }
                else
                {
                    INode? ellementAux = head.Next;
                    INode ellementAuxPrev = head;

                    while (ellementAux != null)
                    {
                        if (ellement.Value == ellementAux.Value)
                        {
                            ellementAuxPrev.Next = ellementAux.Next;
                        }
                        ellementAuxPrev = ellementAux;
                        ellementAux = ellementAux.Next;
                    }
                }
            }
        }

        public void ConsolePrintReverse()
        {
            if(head == null)
            {
                Console.Write("The List is Empty");
            }
            else 
            {
                INode? ellement = head;

                while(ellement.Next != null)
                {
                    ellement = ellement.Next;
                }

                
                do {
                    Console.Write(ellement.ToString());
                    ellement = ellement.Prev;
                } while(ellement != null);
                
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
                INode? ellement = head;

                while (ellement != null)
                {
                    Console.Write(ellement.ToString());
                    ellement = ellement.Next;
                }
                Console.WriteLine();
            }
        }*/
    }
}