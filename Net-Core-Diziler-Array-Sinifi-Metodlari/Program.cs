// See https://aka.ms/new-console-template for more information
// Sort

int[] numbers = { 23,12,4,86,72,3,11,17};


Console.WriteLine("Sırasız liste : ");
foreach (var item in numbers)
{
    Console.WriteLine(item);
}

Console.WriteLine("Sıralı liste : ");
Array.Sort(numbers);

foreach (var item in numbers)
{
    Console.WriteLine(item);
}

// Clear

Console.WriteLine(" Array Clear");

// numbers dizisi elemanlarını kullanalarak 2. index den itibaren 2 tane elamanı 0'lar. 
Array.Clear(numbers,2,2);

foreach (var item in numbers)
{
    Console.WriteLine(item);
}

// Reverse

Console.WriteLine(" Array Reverse");

Array.Reverse(numbers);
foreach (var item in numbers)
{
    Console.WriteLine(item);
}

// IndexOf

Console.WriteLine(" Array IndexOf");

Console.WriteLine(Array.IndexOf(numbers,23));


// Resize

Console.WriteLine(" Array Resize");

Array.Resize<int>(ref numbers,9);
numbers[8] = 99;
foreach (var item in numbers)
{
    Console.WriteLine(item);
}
