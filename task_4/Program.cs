Console.WriteLine ("Input three-digit number:  " );
int a = Convert.ToInt32(Console.ReadLine());
if (a<100||a>1000) {
    Console.WriteLine ("Only three digit number, please");
}
else
Console.WriteLine (a%10);

Console.WriteLine ("Input three-digit number:  " );// classmate version
int a = Convert.ToInt32(Console.ReadLine());//
if (a/100==0||a/100>9) {//
    Console.WriteLine ("Only three digit number, please");//
}//
else {//
    int result = a%10;//
    Console.WriteLine (a%10);//
}//

