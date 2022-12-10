int N = Convert.ToInt32(Console.ReadLine());
//1
int [] array = new int [N];

//2
for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(1, 11);
        Console.WriteLine(array[i]);
    }
//Name, retutn value, parameters

int sum = 0;
float result = 0;
int countOfEvens = 0;
for (int i = 0; i < N; i++)
{
    //1) Обратиться к четному элементу
    //2) Прибавить его к сумме
    //3) Вести подсчет четных элементов
    if (array[i] % 2 == 0) 
    {
        //sum = sum + array[i]
        sum += array[i];
        countOfEvens++;
    }
}
result = (float)sum / countOfEvens;
Console.WriteLine(result);