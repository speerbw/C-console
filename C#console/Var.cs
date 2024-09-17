
class Var
{
    public static void MyVar()
    {
        string myName = "Brian";
        Console.WriteLine(myName);
    }

    public static void DataType()
    {
        string firstName = "Brian";
        string lastName = "Speer";
        firstName = "Sam";
        string wholeName = firstName + " " + lastName;
        int age = 51;
        float gpa = 3.2f;
        double height = 6.2;
        decimal dollar = 100.95m;
        bool is_Teacher = true;
        char grade = 'F';
        
         
        //Staticly typed language 
        //Strongly Typed language

        Console.WriteLine(firstName);
        //Console.WriteLine(lastName);
        Console.WriteLine(wholeName);
        Console.WriteLine(age);
        Console.WriteLine(gpa);
        Console.WriteLine(dollar);
        Console.WriteLine(height);
        Console.WriteLine(is_Teacher);
        Console.WriteLine(grade);   
    }
}
