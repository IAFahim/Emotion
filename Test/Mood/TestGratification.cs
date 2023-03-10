using Emotion.Mood;

namespace Emotion.Test.Mood;

public class TestGratification
{
    Gratification _gratification = new Gratification();

    [Test]
    public void Init()
    {
        var value = _gratification.State;
        Assert.That(value, Is.EqualTo(200));
        _gratification.Tick();
        value = _gratification.State;
        Console.WriteLine(value + " " + _gratification.CurrentMood());
    }
}