namespace MethodsExercise
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            CreateStory();
            Console.WriteLine(Sum(1, 1, 1, 1));
            Console.WriteLine(Subtract(10,1,1,1));
            Console.WriteLine(Multiply(2, 2, 2));
            Console.WriteLine(Divide(12, 3, 2));
        }

        public static void CreateStory()
        {
            Console.WriteLine("Hello! Please input some information for me.");

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string userFavColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string userFavAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite sport?");
            string userFavSport = Console.ReadLine();

            Console.WriteLine($"Once there was a person named {userName} and they visited a zoo. At the zoo they saw a {userFavColor} {userFavAnimal}! The {userFavAnimal} was playing {userFavSport} and having a good time. ");
        }

        //Syntax and logic is very similiar to Javascript which I already know
        
        public static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers) {
                total += number;
            }
            return total;
        }
       
        public static int Subtract(params int[] numbers)
        {
            int total = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                total -= numbers[i];
            }
            return total;
        }
        public static int Multiply(params int[] numbers)
        {
            int total = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                total *= numbers[i];
            }
            return total;
        }
        public static int Divide(params int[] numbers)
        {
            int total = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                total /= numbers[i];
            }
            return total;
        }
    }          
}
