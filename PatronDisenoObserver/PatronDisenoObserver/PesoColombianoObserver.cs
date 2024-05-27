using System;

public class PesoColombianoObserver : IObserver
{
    private readonly Subject _subject;

    public PesoColombianoObserver(Subject subject)
    {
        _subject = subject;
        _subject.Attach(this);
    }

    public void Update()
    {
        Console.WriteLine($"El tipo de cambio en Pesos Colombianos es: {_subject.ExchangeRate * 3800}");
    }
}
