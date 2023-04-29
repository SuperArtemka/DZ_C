// Палиндром
Console.WriteLine("Введите что угодно: ");
string symbol = Console.ReadLine();
char[] symbolArray = symbol.ToCharArray();
Array.Reverse(symbolArray);
string symbolRevers = new string(symbolArray);
if(symbol == symbolRevers){
    System.Console.WriteLine("Супер! Это палиндром!");
}
else{
    System.Console.WriteLine("Это не палиндром.");
}
