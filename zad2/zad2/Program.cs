class Program
{
    public static void Main(string[] args)
    {
        // java: addStudent(Student stud){}
        // c#: AddStudent(Student stud){}
        //string nie String
        
        
        ////
        
        Console.WriteLine("Hello, World!");

        int[] tab = { 1, 2, 3, 4 };
        
        int srednia = 0;
        
        foreach (int num in tab)
        {
            srednia += num;
        }

        srednia = srednia / tab.Length;
        
        Console.WriteLine(srednia);
    }
}

