namespace FunWithQuizzes;

public class TrueFalse : Question
{
    public bool CorrectAnswer { get; set; }

    public TrueFalse(string question, int pointValue, bool correctAnswer) : base(question, pointValue)
    {
        CorrectAnswer = correctAnswer;
    }

    public override bool GetUserAnswer()
    {
        Console.WriteLine("Your answer (1 for true, 2 for false): ");
        string? userAnswer = Console.ReadLine();
        return userAnswer == "1";
    }

    public override double ScoreQuestion()
    {
        return GetUserAnswer() == CorrectAnswer ? PointValue : 0;
    }
}
