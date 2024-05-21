using System.Formats.Asn1;
using Microsoft.VisualBasic;

namespace FunWithQuizzes;

public class MultipleChoice : Question
{
    public List<string> PossibleAnswers {get;set;}

    public MultipleChoice(int pointValue,
    string text,  List<string> correctAnswer,  List<string> possibleAnswers): base (text, pointValue, correctAnswer)
    {
        PossibleAnswers = possibleAnswers;
        PointValue = 1;
    }

    public override int ScoreQuestion()
    {
        return PointValue;
    }
    public void  DisplayOptions(){
        DisplayQuestion();
        int increment=1;
        foreach(string answer in PossibleAnswers){
            System.Console.WriteLine($"{increment}:{answer}");
            increment+=1;
        }
    }
}
