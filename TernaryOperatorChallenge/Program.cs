namespace TernaryOperatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputTemperature = 0;
            string temperatureMessage = string.Empty;
            string inputValue = string.Empty;

            // takes input from console
            Console.Write("Enter the current temperature : ");
            inputValue = Console.ReadLine();

            // validate the input as valid input integer value
            bool validInteger = int.TryParse(inputValue, out inputTemperature);

            if (validInteger )
            {   // condition ? iftrue : iffalse
                // if it's valid integer then it will check for the conditions using nested ternary operator
                temperatureMessage = inputTemperature <= 15 ?
                    // true
                    "it is too cold here" :
                    // false
                    (inputTemperature >= 16 && inputTemperature <= 28) ?
                    // true
                    "It is okay" :
                    // false
                    inputTemperature > 28 ? 
                    // true
                    "It is so hot" :
                    //false
                    "";
                Console.WriteLine(temperatureMessage);
            }
            else
            {
                Console.WriteLine("Not a valid temperature");
            }
            Console.ReadKey();
        }
    }
}
