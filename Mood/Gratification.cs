using Emotion.Base;
using Emotion.LongTerm;

namespace Emotion.Mood;

public class Gratification : Base.Mood
{
    public float State => Feelings.Sum(f => f.State);
    public float DownRate => Feelings.Sum(f => f.DownRate);

    public Gratification()
    {
        Feelings = new List<Feeling>
        {
            new Joy(1, 0.01f),
            new Thrill(1, 0.1f),
        };
    }

    public void Tick()
    {
        Feelings.ForEach(f => f.Tick());
    }

    public string CurrentMood()
    {
        return State switch
        {
            > 600 => "Very Happy",
            > 500 => "Content",
            > 400 => "Gloomy",
            _ => "Sad"
        };
    }

    public override string ToString()
    {
        return $"Gratification: {State} - {CurrentMood()}";
    }
}