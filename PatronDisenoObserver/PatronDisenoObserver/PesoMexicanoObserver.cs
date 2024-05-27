using System;

public class PesoMexicanoObserver : IObserver
{
    private readonly Subject _subject;

    public PesoMexicanoObserver(Subject subject)
    {
        _subject = subject;
        _subject.Attach(this);
    }

    public void Update()
    {
        Console.WriteLine($"El tipo de cambio en Pesos Mexicanos es: {_subject.ExchangeRate * 20}");
    }
}
