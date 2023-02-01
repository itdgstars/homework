Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

int current_num = 1;

while (current_num < N)
{
if ((current_num%2) == 0)
{
  Console.WriteLine(current_num);
  current_num++ ;
}
else
{
    current_num++ ;
}
};