using System;

class Program
{
    static void Main(string[] args)
    {
        Subject subject = new Subject();

        var pesoColombianoObserver = new PesoColombianoObserver(subject);
        var pesoMexicanoObserver = new PesoMexicanoObserver(subject);
        var pesoArgentinoObserver = new PesoArgentinoObserver(subject);

        subject.ExchangeRate = 1.0;
        subject.ExchangeRate = 10;
    }
}
