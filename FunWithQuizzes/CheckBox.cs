namespace FunWithQuizzes;

public class CheckBox : Question
{

    public List<string> PossibleAnswers { get; set; }

    public CheckBox(string questionText, int pointValue = PossibleAnswers.Count, List<string> possibleAnswers, List<string> correctAnswers) : base(questionText, pointValue, correctAnswers)
    {
        PossibleAnswers = possibleAnswers;
    }

    public override int ScoreQuestion()
    {
        int numCorrect = 0;
        for (int i=0; i<possibleAnswers.Count; i++)
        {
            if (possibleAnswers[i] == CorrectAnswers[i])
            {
                numCorrect++;
            }
        }
        return numCorrect / PointValue;
    }
}
