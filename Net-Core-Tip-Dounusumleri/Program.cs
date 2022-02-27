// See https://aka.ms/new-console-template for more information


    // Implicit Conversion (Bilinçsiz Tür Dönüşümleri)

    Console.WriteLine("Implicit Conversion");

        int a=5;
        sbyte b=30;
        short c=10;

        int d=a+b+c;
        Console.WriteLine($"d : {d}");

        long h=d;
        Console.WriteLine($"h : {h}");


        float i=h;
        Console.WriteLine($" i : {i}");

        string str="Şükrü";

        char f='k';


        object obj=str+f+d;
        Console.WriteLine($"obj : {obj}");




    // Explicit Conversion (Bilinçli Tür Dönüşümleri)

    Console.WriteLine("Explicit Conversion");

        int x=5;
        byte y=(byte)x;
        Console.WriteLine($"y : {y}");

        int z=100;
        byte t=(byte)z;
        Console.WriteLine($"t : {t}");

        float w=10.5f;
        byte v=(byte)w;
        Console.WriteLine($"v : {v}");

        // ToString() Methodu ile Stringe Çevirme

        Console.WriteLine("ToString() Methodu ile Stringe Çevirme");

            int sayi1=6;
            string str1=sayi1.ToString();
            Console.WriteLine($"str1 : {str1}");
            
            
            string str2=12.5f.ToString();
            Console.WriteLine($"str2 : {str2}");



        // Convert Sınıfı Methodları 

            Console.WriteLine("Convert Sınıfı Methodları");

            string str3="10", str4="20";
            int sayi2,sayi3;
            int toplam;

            sayi2=Convert.ToInt32(str3);
            sayi3=Convert.ToInt32(str4);
            toplam=sayi2+sayi3;
            Console.WriteLine($"toplam : {toplam}");



        // Parse Sınıfı Methodları

         Console.WriteLine("Parse Sınıfı Methodları");

        ParseMethod();


     static void ParseMethod()
    {

        string metin1="10";
        string metin2="10.25";
        int rakam1;
        double double1;
        
        rakam1=int.Parse(metin1);
        Console.WriteLine($"rakam1 : {rakam1}");

        double1=double.Parse(metin2);
        Console.WriteLine($"double1 : {double1}");}

        
