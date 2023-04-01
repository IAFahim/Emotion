using Emotion.Interface;

namespace Emotion.LongTerm;

public abstract class Feeling : IEmotion
{
    public float State { get; set; }
    public float DownRate { get; set; }

    protected Feeling(float value, float downRate)
    {
        State = value;
        DownRate = downRate;
    }


    public void Add(float value)
    {
        State += value;
    }

    public void Tick()
    {
        State -= DownRate;
        if (State < 0) State = 0;
    }
}