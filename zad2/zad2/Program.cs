class Program
{
    public static void Main(string[] args)
    {
        // java: addStudent(Student stud){}
        // c#: AddStudent(Student stud){}
        //string nie String
        
        Console.WriteLine("Hello, World!");

        int[] tab = { 1, 2, 3, 4 };
        
        //sr arytm i max w tablicy


        /*for (int i = 0; i < tab.Length; i++)
        {
            Console.WriteLine(i);
        }*/
        
        
        //////////////

        //////////////
        ///
        ///
        ///
        ///
        ///
        ///
        /// 
        int srednia = 0;
        
        foreach (int num in tab)
        {
            srednia += num;
        }

        srednia = srednia / tab.Length;
        
        Console.WriteLine("Hello, World!");
    }
}

