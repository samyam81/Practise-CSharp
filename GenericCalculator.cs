using System;

public class GenericCalculator<T>
{
    public void Calculate(T x, T y, IMathOperation<T> mathOperation)
    {
        T result = mathOperation.Perform(x, y);
        Console.WriteLine("Result: " + result);
    }

    public interface IMathOperation<T>
    {
        T Perform(T a, T b);
    }

    public class Addition : IMathOperation<T>
    {
        public T Perform(T a, T b)
        {
            dynamic aa = a;
            dynamic bb = b;
            return aa + bb;
        }
    }

    public class Subtraction : IMathOperation<T>
    {
        public T Perform(T a, T b)
        {
            dynamic aa = a;
            dynamic bb = b;
            return aa - bb;
        }
    }

    public class Multiplication : IMathOperation<T>
    {
        public T Perform(T a, T b)
        {
            dynamic aa = a;
            dynamic bb = b;
            return aa * bb;
        }
    }

    public class Division : IMathOperation<T>
    {
        public T Perform(T a, T b)
        {
            dynamic aa = a;
            dynamic bb = b;
            if (bb == 0)
            {
                throw new ArgumentException("Division by zero is not allowed");
            }
            return aa / bb;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        GenericCalculator<double> calculator = new GenericCalculator<double>();
        calculator.Calculate(10.0, 2.0, new GenericCalculator<double>.Addition());
        calculator.Calculate(10.0, 2.0, new GenericCalculator<double>.Subtraction());
        calculator.Calculate(10.0, 2.0, new GenericCalculator<double>.Multiplication());
        calculator.Calculate(10.0, 2.0, new GenericCalculator<double>.Division());
    }
}
