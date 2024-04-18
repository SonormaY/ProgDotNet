class MyException : Exception
{
    public MyException(string message) : base(message)
    {
    }
}

class MyClass<T>
{
    public void MyMethod(T value)
    {
        if (value == null)
        {
            throw new MyException("Value cannot be null");
        }
    }
}