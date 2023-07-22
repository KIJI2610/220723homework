System.Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = a;

for(int i = 1; i < b; i++){
    a = a * c;
}
System.Console.WriteLine(a);
