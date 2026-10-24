namespace homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Random random = new Random();
            //    int number = random.Next(1, 101);
            //    int attempts = 0;
            //    bool guessed = false;


            //    for (int i = 0; i <= 7; i++)
            //    {
            //        Console.WriteLine("enter your guess: ");
            //        string inputs = Console.ReadLine();

            //        if (!int.TryParse(inputs, out int guess))
            //        {
            //            Console.WriteLine("invalid input. please enter a valid number.");
            //            i--; 
            //            continue;
            //        }
            //        if (guess<number)
            //        {
            //            Console.WriteLine("too low. try again.");
            //        }
            //        else if (guess>number)
            //        {
            //            Console.WriteLine("too high. try again.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("congratulations! you guessed the number.");
            //            guessed = true;
            //            break;
            //        }
            //        Console.WriteLine($"attempts left: {i}/7");
            //    }
            //    if (!guessed)
            //    {
            //        Console.WriteLine($"you lost. the number was {number}");

            //    }




            //int studentsCount;

            //Console.Write("შეიყვანეთ სტუდენტების რაოდენობა: ");

            //for (; !int.TryParse(Console.ReadLine(), out studentsCount) || studentsCount <= 0;)
            //{
            //    Console.Write("არასწორია! შეიყვანეთ დადებითი რაოდენობა: ");
            //}

            //int passed = 0;
            //int failed = 0;

            //for (int i = 1; i <= studentsCount; i++)
            //{
            //    int score;

            //    Console.Write($"შეიყვანეთ {i}-ე სტუდენტის ქულა: ");

            //    for (; !int.TryParse(Console.ReadLine(), out score) || score < 0 || score > 100;)
            //    {
            //        Console.Write("არასწორი ქულაა! შეიყვანეთ 0-დან 100-მდე: ");
            //    }

            //    string grade;

            //    if (score >= 90)
            //        grade = "A";
            //    else if (score >= 80)
            //        grade = "B";
            //    else if (score >= 70)
            //        grade = "C";
            //    else if (score >= 60)
            //        grade = "D";
            //    else
            //        grade = "F";

            //    Console.WriteLine($"ქულა: {score}, შეფასება: {grade}");

            //    if (score >= 60)
            //        passed++;
            //    else
            //        failed++;
            //}

            //Console.WriteLine("\n--- საბოლოო შედეგი ---");
            //Console.WriteLine($"ჩააბარა: {passed}");
            //Console.WriteLine($"ვერ ჩააბარა: {failed}");
        }
    }
}
