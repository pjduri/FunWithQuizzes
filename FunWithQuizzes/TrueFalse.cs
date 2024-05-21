namespace FunWithQuizzes;

public class TrueFalse : Question
{
    public TrueFalse(string question, int pointValue, List<string> correctAnswers) : base(question, pointValue, correctAnswers)
    {
    }

    public bool GetUserAnswer()
    {
        Console.WriteLine("Your answer (type true or false): ");
        string? userAnswer = Console.ReadLine();
        return userAnswer == CorrectAnswers[0];
    }

    public override int ScoreQuestion()
    {
        return GetUserAnswer() ? PointValue : 0;
    }

}
