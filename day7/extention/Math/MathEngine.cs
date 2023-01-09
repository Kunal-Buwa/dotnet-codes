namespace Math;


public sealed class MathEngine
{
    public int result {get;set;}
    public MathEngine(){

    }

    public void Addition(int num1,int num2)
    {
        int add= num1+num2;
        Console.WriteLine("addition is" +add);

    }
    public int Substraction(int num1,int num2)
    {
        return num1-num2;
    }
}
