class SampleGradeCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your mark to check the grade:");
        int mark = Convert.ToInt32(Console.ReadLine());

        if (mark < 50)
        {
            Console.WriteLine($"Mark: {mark}, Result: Fail");
        }
        else if(mark >= 50 && mark < 60)
        {
            Console.WriteLine($"Mark: {mark}, Result: Pass, Grade: D Grade");
        }
        else if (mark >= 60 && mark < 70)
        {
            Console.WriteLine($"Mark: {mark}, Result: Pass, Grade: C Grade");
        }
        else if (mark >= 70 && mark < 80)
        {
            Console.WriteLine($"Mark: {mark}, Result: Pass, Grade: B Grade");
        }
        else if (mark >= 80 && mark < 90)
        {
            Console.WriteLine($"Mark: {mark}, Result: Pass, Grade: A Grade");
        }
        else
        {
            Console.WriteLine($"Mark: {mark}, Result: Pass, Grade: A+ Grade");
        }
    }

}