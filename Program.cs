public class test2
{
public static void Main()
{
//1
string name = "aldanah alhazza";
Console.WriteLine(name);
//2
int num1=int.Parse(Console.ReadLine());
int num2 =2;
Console.WriteLine(num2*num1);

//3

int[]index = {1,2,3,4,5};
Console.WriteLine(index[0]);

 
//4

int con = int.Parse(Console.ReadLine());
int num = 10;
if(num >=con)
{
Console.WriteLine("good");
}
else
{
    Console.WriteLine("try agin");
}

//5
int massg = int.Parse(Console.ReadLine());
switch(massg){
case 1:
Console.WriteLine("hello");
break;
case 2:
Console.WriteLine("welcom");
break;
case 3:
Console.WriteLine("good");
break;
default:
{
    Console.WriteLine("tray agin");
}break;

}
}
}