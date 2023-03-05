namespace EDA_Gabriel_Peixoto.Pilha.Models
{
    internal interface IStack
    {
        void ConsolePrint();
        bool Pop();
        bool Push(string value);
    }
}