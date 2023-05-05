using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDA_Gabriel_Peixoto.Lista.Models
{
    public class Ellement : INode
    {
        public string Value { get; set; }
        public Ellement? Next { get; set; }
        public Ellement? Prev { get; set; }

        public Ellement(string value)
        {
            Value = value;
            Next = null;
        }

        public override string ToString()
        {
            return Value;
        }
    }

    public class Ellement<T> : INode<T>
    {
        public T Value { get; set; }
        public Ellement<T>? Next { get; set; }
        public Ellement<T>? Prev { get; set; }

        public Ellement(T value)
        {
            Value = value;
            Next = null;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}