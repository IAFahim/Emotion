namespace Emotion.Base;

public abstract class Feeling
{
    public float State;
    public float DownRate;

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