public abstract class Question{
    public string QuestionText {get;}
    public int PointValue{get;set;}
    public List<string> CorrectAnswers{get;set;}

    public Question(string questionText, int pointValue, List<string> correctAnswers)
    {
        QuestionText=questionText;
        PointValue = pointValue;
        CorrectAnswers = correctAnswers;
    }

    public void DisplayQuestion()
    {
        System.Console.WriteLine(QuestionText);
    }

    public abstract int ScoreQuestion();

    public abstract List<string> GetCorrectAnswers();
}