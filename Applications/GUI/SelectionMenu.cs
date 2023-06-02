using EDA_Gabriel_Peixoto.Shared;

namespace EDA_Gabriel_Peixoto.Applications.GUI
{
    internal class SelectionMenu : IGUIFactory
    {
        List<string> options;
        int optionLength;

        public SelectionMenu(List<string> options, int optionLength)
        {
            this.options = options;
            this.options.Add("exit");
            this.optionLength = optionLength;
        }

        public int BuildMenu()
        {
            List<string> sb = new List<string>();
            int index = 0;
            ConsoleKeyInfo aws;

            Console.WriteLine("OPTIONS: \n");

            foreach(string option in options)
            {
                string optionUpper = option.ToUpper();

                for (int i = optionUpper.Length; i < optionLength; i++)
                {
                    optionUpper += " ";
                }

                sb.Add($" {optionUpper}");
            }

            do
            {
                NonSelectedOption();

                Header();

                Console.WriteLine("OPTIONS: \n");

                for (int i = 0; i < sb.Count; i++)
                {
                    if (i == index)
                    {
                        SelectedOption();
                    }
                    else
                    {
                        NonSelectedOption();
                    }

                    Console.WriteLine(sb[i]);
                }

                aws = Console.ReadKey();

                switch (aws.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (index < sb.Count - 1)
                            index++;
                        break;
                }
            } while (aws.Key != ConsoleKey.Enter);
            
            NonSelectedOption();

            return index;
        }

        public void Header()
        {
            Console.Clear();
            Console.WriteLine($" ************* EDA V{ApplicationInfo.Version} ************* \n");
        }

        void SelectedOption()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        void NonSelectedOption()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
