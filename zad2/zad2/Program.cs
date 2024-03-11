class Program
{
    public static void Main(string[] args)
    {
        // java: addStudent(Student stud){}
        // c#: AddStudent(Student stud){}
        //string nie String

        
        int[] tab = { 1, 2, 3, 4 };


        //Console.WriteLine(Maksymalna(tab));
        
        
    }
    
    static float Srednia(int[] tab)
    {
        float sred = 0;
        
        foreach (int num in tab)
        {
            sred += num;
        }
        
        sred = sred / tab.Length;

        return sred;
    }
    
    
    static float Maksymalna(int[] tab)
    {
        int max = tab[0];
        
        for(int i= 0; i < tab.Length - 1;i++)
        {
            if (tab[i] < tab[i+1])
            {
                max = tab[i+1];
            }
        }
        return max;

    } 
}

