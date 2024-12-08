public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        //Error: Incorrect assignment
        this = new ExampleClass(value); 
    }
}