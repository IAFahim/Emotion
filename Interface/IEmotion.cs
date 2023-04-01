namespace Emotion.Interface;

public interface IEmotion
{
    public float State { get; set; }
    public float DownRate { get; set; }
    public void Add(float value);
    public void Tick();
}