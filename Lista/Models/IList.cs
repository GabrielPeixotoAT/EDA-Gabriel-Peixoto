using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDA_Gabriel_Peixoto.Lista.Models
{
    public interface IList
    {
        void Add(INode ellement);
        void Remove(INode ellement);
        void ConsolePrint();
    }

    public interface IList<T>
    {
        void Add(T ellement);
        void Remove(T ellement);
        void ConsolePrint();
    }
}