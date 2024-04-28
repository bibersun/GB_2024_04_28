namespace lesson_5;

public class Calc : ICalc
{
    private Stack<double> LastRes { get; } = new();
    public double Result { get; set; }

    public void Sum(int x)
    {
        LastRes.Push(Result);
        Result += x;
        PrintRes();
    }

    public void Sub(int x)
    {
        LastRes.Push(Result);
        Result -= x;
        PrintRes();
    }

    public void Multy(int x)
    {
        LastRes.Push(Result);
        Result *= x;
        PrintRes();
    }

    public void Divide(int x)
    {
        LastRes.Push(Result);
        Result /= x;
        PrintRes();
    }

    public void CancelLast()
    {
        if (LastRes.TryPop(out var res))
        {
            Result = res;
            PrintRes();
        }
        else
        {
            Console.WriteLine("Не можем отменять последнее действие");
        }
    }

    public event EventHandler<EventArgs>? MyEventHandler;

    private void PrintRes()
    {
        Console.Write("Текущий результат ");
        MyEventHandler?.Invoke(this, EventArgs.Empty);
    }
}