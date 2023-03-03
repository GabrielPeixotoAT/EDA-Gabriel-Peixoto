using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDA_Gabriel_Peixoto.Lista.Models
{
    public class Ellement
    {
        public string Value { get; set; }
        public Ellement? Next { get; set; }

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
}