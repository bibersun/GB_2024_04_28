namespace lesson_5;

public interface ICalc
{
    double Result { get; set; }
    void Sum(int x);
    void Sub(int x);
    void Multy(int x);
    void Divide(int x);
    void CancelLast();

    event EventHandler<EventArgs> MyEventHandler;
}