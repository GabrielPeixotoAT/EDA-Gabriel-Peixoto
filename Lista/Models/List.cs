using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDA_Gabriel_Peixoto.Lista.Models
{
    public class List
    {
        private Ellement? head { get; set; }

        public List()
        {
            head = null;
        }

        public void Add(Ellement ellement)
        {
            if (head == null)
            {
                head = ellement;
            }
            else
            {
                Ellement ellementAux = head;

                while (ellementAux.Next != null)
                {
                    ellementAux = ellementAux.Next;
                }

                ellementAux.Next = ellement;
            }
        }

        public void Remove(Ellement ellement)
        {

        }

        public void ConsolePrint()
        {
            if (head == null)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Ellement? ellement = head;

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