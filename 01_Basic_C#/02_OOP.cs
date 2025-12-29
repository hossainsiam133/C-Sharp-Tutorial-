class Person
{
    public string name;
    public int age;
    public void setValue(string n, int a)
    {
        this.name = n;
        this.age = a;
    }
    public void getValue()
    {
        System.Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
class Worker : Person
{
    public Worker(string name)
    {
        this.name = name + "Hossain";
        this.age = 18;
    }
}
class Test_OOP
{
    public void oop()
    {
        // Console.WriteLine("Hello");
        Person p1 = new Person();
        p1.setValue("Siam", 23);
        //    p1.getValue();
        Worker w1 = new Worker("Siam");
        Worker w2 = w1;
        w2.name = "Hanif";
        // w1.age = 20;
        Console.WriteLine(w1.name);
    }
}