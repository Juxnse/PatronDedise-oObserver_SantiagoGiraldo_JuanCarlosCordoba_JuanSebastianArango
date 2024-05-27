using System;

public class PesoArgentinoObserver : IObserver
{
    private readonly Subject _subject;

    public PesoArgentinoObserver(Subject subject)
    {
        _subject = subject;
        _subject.Attach(this);
    }

    public void Update()
    {
        Console.WriteLine($"El tipo de cambio en Pesos Argentinos es: {_subject.ExchangeRate * 100}");
    }
}
