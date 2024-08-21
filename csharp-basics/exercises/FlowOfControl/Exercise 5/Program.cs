namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            var input = Console.ReadLine();
            var resultUsingIf = ConvertTextToNumbersUsingIf(input);
            var resultUsingSwitch = ConvertTextToNumbersUsingSwitch(input);

            Console.WriteLine("Using nested-if: " + resultUsingIf);
            Console.WriteLine("Using switch: " + resultUsingSwitch);
        }


        private static string ConvertTextToNumbersUsingIf(string text) {


            var result = "";
            foreach (var symbol in text.ToLower())
            {
                
                if (symbol == 'a' || symbol == 'b' || symbol == 'c')
                {
                    result += 2;
                }
                else if (symbol == 'd' || symbol == 'e' || symbol == 'f')
                {
                    result += 3;
                }
                else if (symbol == 'g' || symbol == 'h' || symbol == 'i')
                {
                    result += 4;
                }
                else if (symbol == 'j' || symbol == 'k' || symbol == 'l')
                {
                    result += 5;
                }
                else if (symbol == 'm' || symbol == 'n' || symbol == 'o')
                {
                    result += 6;
                }
                else if (symbol == 'p' || symbol == 'q' || symbol == 'r' || symbol == 's')
                {
                    result += 7;
                }
                else if (symbol == 't' || symbol == 'u' || symbol == 'v')
                {
                    result += 8;
                }
                else if (symbol == 'w' || symbol == 'x' || symbol == 'y' || symbol == 'z')
                {
                    result += 9;
                }
                else if (symbol == ' ')
                {
                    result += 0;
                }
            }

            return result;
        }

        private static string ConvertTextToNumbersUsingSwitch(string text)
        {
            var result = "";
            foreach (var symbol in text.ToLower())
            {
                
                switch (symbol)
                {
                    case 'a': case 'b': case 'c':
                        result += 2;
                        break;
                    case 'd': case 'e': case 'f':
                        result += 3;
                        break;
                    case 'g': case 'h': case 'i':
                        result += 4;
                        break;
                    case 'j': case 'k': case 'l':
                        result += 5;
                        break;
                    case 'm': case 'n': case 'o':
                        result += 6;
                        break;
                    case 'p': case 'q': case 'r': case 's':
                        result += 7;
                        break;
                    case 't': case 'u': case 'v':
                        result += 8;
                        break;
                    case 'w': case 'x': case 'y': case 'z':
                        result += 9;
                        break;
                    case ' ':
                        result += 0;
                        break;
                    default:
                        result += symbol;
                        break;


                        
                        
                }
            }
            return result;
        }
    }
}
