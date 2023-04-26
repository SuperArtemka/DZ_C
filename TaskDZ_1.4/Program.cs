//Вывод четных чисел в диапазоне от 1 до  N
Console.WriteLine("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());
int count = 1;

while(count <= N){
    if(count % 2 == 0 ){
        Console.Write($"{count},");
        count++;
    }
    else{
        count++;
    }
}

