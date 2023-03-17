using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDA_Gabriel_Peixoto.Lista.Models
{
    public class List : IList
    {
        public INode? head { get; set; }

        public List()
        {
            head = null;
        }

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

                ellementAux.Next = ellement;
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

        public void ConsolePrintReverse(INode? node)
        {
            if(node != null)
            {
                ConsolePrintReverse(node.Next);
                Console.Write(node.Value);
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
        }
    }
}