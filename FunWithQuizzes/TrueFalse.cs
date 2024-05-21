namespace FunWithQuizzes;

public class TrueFalse : Question
{
    public TrueFalse(string question, int pointValue, List<string> correctAnswers) : base(question, pointValue, correctAnswers)
    {
    }

    public override bool GetUserAnswer()
    {
        Console.WriteLine("Your answer (1 for true, 2 for false): ");
        string? userAnswer = Console.ReadLine();
        return userAnswer == "1";
    }

}
