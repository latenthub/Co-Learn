//// See https://aka.ms/new-console-template for more information
//using CSharpTutor.Animal;

//decimal A = 7.0M;
//decimal B = 3.0M;

//decimal C = A / B;
//Console.WriteLine("Addition => " + (A + B));
//Console.WriteLine("Subtraction => " + (A - B));
//Console.WriteLine("Multiplication => " + (A * B));
//Console.WriteLine("Division => " + C);
//Console.WriteLine("Modulus => " + (A % B));

//int studentMark = 40;

//if (studentMark >= 41)
//    Console.WriteLine("P");
//else
//    Console.WriteLine("F");

/////Check for this range
/////0 to 39 =f
/////40 to 49 = E
/////50 to 59 = D
/////60 to 69 = C
/////70 to 79 = B
/////80 and above = A
/////Study Else if

//if(studentMark >=0 && studentMark <= 39)
//    Console.WriteLine("Fail");
//else 
//    Console.WriteLine("Pass");

//if (studentMark >= 0 || studentMark <= 39)
//    Console.WriteLine("Fail");
//else
//    Console.WriteLine("Pass");

//if (studentMark != 0)
//    Console.WriteLine("Fail");
//else
//    Console.WriteLine("Pass");

//int age = 40;

//switch(age)
//{
//    case < 40:
//     Console.WriteLine("Teneger");
//        break;
//    case >= 40:

//        Console.WriteLine("Adult");
//        break;

//    default:
//        Console.WriteLine("Unknown");
//        break;

//}

//string lbl = "";

//lbl = (age >= 40) ? "Adult" : "Teneger";



//if (age >= 40)
//    lbl = "Adult";
//else
//    lbl = "Teneger";

//Console.WriteLine(lbl);

//int sum = 10 - 2 / 5;

//int counter = 10;

//for(int i=0; i < counter; i++)
//{
//    if (i > 0 && i <= 2)
//        continue;

//    if (i > 5)
//        break;

//    Console.WriteLine("[FOR LOOP] - Current Index is " + i.ToString());
//    Console.WriteLine("[FOR LOOP] - Current Index + 1 is " + (i + 1).ToString());
//}

//int x = 0; //Initialisation


//while(x < counter) // Consition
//{
//    x++; //Increment
//    if (x > 0 && x <= 2)
//        continue;

//    if (x > 7)
//        break;
//    Console.WriteLine("[WHILE LOOP] - Current Index is " + x.ToString());
//    Console.WriteLine("[WHILE LOOP] - Current Index + 1 is " + (x + 1).ToString());

//}

using CSharpTutor.Animal;
using CSharpTutor.Array;

public partial class Program
{
    public static void Main(string[] args)
    {
        //Dog dog = new Dog();
        //Console.WriteLine("No of Legs" + dog.legs.ToString());

        Goat goat = new Goat();

        ArrayLecture arrayLecture = new ArrayLecture();

        Console.WriteLine(arrayLecture.GetArrayDataAge().Length.ToString());
    }
}