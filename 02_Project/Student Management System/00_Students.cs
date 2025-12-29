class Student
{
    public int id { get; private set; }
    public string name { get; private set; }
    public int age { get; private set; }
    public string department { get; private set; }
    public double cgpa { get; private set; }
    public string email { get; private set; }
    public void Setter(int i, string n, int a, string d, double cg, string m, int pass)
    {
        if (pass == 1010)
        {
            this.id = i;
            this.name = n;
            this.age = a;
            this.department = d;
            this.cgpa = cg;
            this.email = m;
        }
    }

}