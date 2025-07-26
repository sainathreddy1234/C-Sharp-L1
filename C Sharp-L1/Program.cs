#region Default
////See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");

#endregion


#region Nullable 
//string? a = null;

//Console.WriteLine(a);

//string x= Guid.NewGuid().ToString();
//Console.WriteLine(x);   

//Console.Beep(); 
#endregion


#region var

//Var means take int or string any data types

//var a = "Dell";
//var b = 15;
//int? c = null;
//var? d = null;      //it will throw an error for var values
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);
//Console.WriteLine(d as string);
#endregion

#region dynamic
//dynamic can also take null values; but var can not take null values

//dynamic a = "Dell";
//dynamic b = 15;
////dynamic? c = null;
//dynamic d = null;      //it will throw an error for var values
//Console.WriteLine(a);
//Console.WriteLine(b);
////Console.WriteLine(c);
//Console.WriteLine(d as string); 
#endregion

#region If else
//int a = 20;
//int b = 30;
//if (a >= b)
//{
//    Console.WriteLine($"{a} is greater than {b}");
//}
//else
//{
//    Console.WriteLine($"{b} is greater that {a}");
//} 
#endregion


//Switch
#region Switch case
//Console.WriteLine("\nEnter a And b Values: ");
//int? a = int.Parse(Console.ReadLine()),
//     b = int.Parse(Console.ReadLine());
//l1: Console.WriteLine("Choose 1. Add 2.sub 3.mul 4.div");
//dynamic option = Console.ReadLine();

//switch (option)
//{
//    case "add":
//        Console.WriteLine(a + b);
//        break;
//    case "sub":
//        Console.WriteLine(a - b);
//        break;
//    case "mul":
//        Console.WriteLine(a * b);
//        break;
//    case "div":
//        Console.WriteLine(a / b);
//        break;
//    default:
//        Console.WriteLine("Invalid Option");
//        goto l1;
//}
//Console.WriteLine("To perform more actions Y/N");
//dynamic ans = Console.ReadLine();

//if (ans == "y" || ans == "Y")
//{
//    goto l1;
//}
//else
//{
//    Console.WriteLine("tq");
//} 
#endregion



dynamic role = Console.ReadLine();
bool isActive = (role == "Admin")? true : false;
Console.WriteLine("Admin is: "+isActive);

