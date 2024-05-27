using System.Collections.Generic;

public class Subject
{
    private List<IObserver> observers = new List<IObserver>();
    private double _exchangeRate;

    public double ExchangeRate
    {
        get { return _exchangeRate; }
        set
        {
            _exchangeRate = value;
            Notify();
        }
    }

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    private void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update();
        }
    }
}
