// See https://aka.ms/new-console-template for more information
using System.Collections;


Console.Write("Cümle Giriniz : ");
string cumle = Console.ReadLine();


VowelsSort(cumle);


static void VowelsSort(string cumle)
{
  cumle.ToLower();
    ArrayList vowelsList = new ArrayList();

    char[] vowels = { 'a', 'e', 'i', 'o', 'u','ı','ö','ü' };
  for (int i = 0; i < cumle.Length; i++)
  {
      if (vowels.Contains(cumle[i]))
      {
          vowelsList.Add(cumle[i]);
      }
     
  }


  foreach (var item in vowelsList)
  {
    Console.Write(item+" ");
  }
  
  Console.WriteLine($"\n Eleman Sayisi : {vowelsList.Count}");
}