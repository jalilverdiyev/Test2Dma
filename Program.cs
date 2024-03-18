#region Lesson

//bool sual = true;

//if (sual)
//{
//    Console.WriteLine("If serti dogrudur");
//}
//else
//{
//    Console.WriteLine("If serti yanlisdir");
//}


//if (false)
//{
//    //das
//}
//else if (false)
//{

//}
//else if(true)
//{ }
//else { }


//int secim = 1;

//switch (secim)
//{
//    case 1:
//        Console.WriteLine("Birinci qapi secildi");
//        break;
//    case 2:
//        Console.WriteLine("Ikinci qapi secildi");
//        break;
//    case 3:
//        Console.WriteLine("Ucuncu qapi secildi");
//        break;
//    default:
//        Console.WriteLine("Bele bir qapi yoxdur");
//        break;
//}

//string ad = "Dsa";

//switch (ad)
//{
//    case "1":
//        Console.WriteLine("Salam, Jalil");
//        break;
//    case "Rovsen":
//        Console.WriteLine("dsad");
//        break;
//    default:
//        Console.WriteLine("default");
//        break;
//}

//string status;
//int maas = 800;

//if (maas > 1000)
//{
//    status = "Varli";
//}
//else
//{
//    status = "Kasib";
//}

//status = (maas > 1000) ? "Varli" : "Kasib"; 
//bool besBoyukdurmuAltidan = 5 > 6;

//Console.WriteLine(besBoyukdurmuAltidan);
//Console.WriteLine(5 < 6);
//Console.WriteLine(5 <= 6);
//Console.WriteLine(5 >= 6);

//int a = 15;
//int b = 19;

//string ad1 = "Jalil";
//string ad2 = "jalil";

//Console.WriteLine(ad1 == ad2);
//Console.WriteLine(ad1 != ad2);

//if(str1 == str2)
//{
//    Console.WriteLine("A B-den boyukdur");
//}
//else
//{
//    Console.WriteLine("A B-den boyuk deyil");
//}

//bool val = true;

//Console.WriteLine(val);
//Console.WriteLine(!val);
//Console.WriteLine(!!val);

// AND -> *

// OR -> +

//if ()
//{

//}


//double a = 0;

//double b = 0;

// AND
//if(b == 0 && a == 0)
//{
//    Console.WriteLine("Ededler sifirdir");
//}
//else if (b == 0)
//{
//    Console.WriteLine("Sifira bolmek olmaz");
//}
//else
//{
//    Console.WriteLine(a / b);
//}

//double a = 10;

//double b = 0;
// OR
//if (b == 0 || a == 0)
//{
//    Console.WriteLine("Ededler sifirdir");
//}
//else if (b == 0)
//{
//    Console.WriteLine("Sifira bolmek olmaz");
//}
//else
//{
//    Console.WriteLine(a / b);
//}


//int age = 8;
//double salary = 5000;

//Console.WriteLine(age > 18 && salary > 2000);
//if (age > 18 && salary > 2000)
//{
//    Console.WriteLine("Adamin yasi ya 18den boyukdur ya da maasi 2000den yuxaridir");
//}

//else
//{
//    Console.WriteLine("Adamin yasi ne 18den boyukdur ne de maasi 2000den yuxaridir");
//}

//if(age > 18 && salary > 2000)
//{
//    Console.WriteLine("Babat yasayirsan");
//}

//Console.WriteLine("Adinizi daxil edin: ");
//string ad = Console.ReadLine();
//Console.WriteLine("Soyadinizi daxil edin: ");
//string soyad = Console.ReadLine();
//Console.WriteLine("Adinizi daxil edin: ");
//string ad = Console.ReadLine();
//Console.WriteLine("Adinizi daxil edin: ");
//string ad = Console.ReadLine();

//Console.WriteLine($"Salam, {soyad} {ad}");

//Console.WriteLine("Yasinizi daxil edin: ");
//int yas = Console.ReadLine();


//Console.WriteLine(yas.GetType());

//int a = 5;

//double d = a;

// Moterize cevirmesi
//double d1 = 5.6;

//int a1 = (int)d1;

//Console.WriteLine(a1);

// Error
//string str = "1";

//int a = (int)str;

//string str = "1";

//int a = Convert.ToInt32(5.4);

//Console.WriteLine(a);


//string num = "12.7";

//double d1 = double.Parse(num);

//Console.WriteLine(d1);

//Console.WriteLine("Yasinizi daxil edin");
//int yas = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Sizin yasiniz: {yas}");

//Console.WriteLine("Manati daxil edin: ");
//string manatStr = Console.ReadLine();
//double manat = Convert.ToDouble(manatStr);
//double dollar = manat / 1.7;

//Console.WriteLine($"Manatiniz dollar qarsiligi: {dollar}");

//unchecked
//{
//    int a = int.MaxValue;
//    Console.WriteLine(a + 2);
//}

#endregion


#region Practice

/*
 1.
    Iki deyisen teyin edin ve birinci deyisenin ikinciye tam bolunub bolunmemesini ekranda gosterin:
    eger tam bolunurse eded1 eded2-ye tam bolunur yazin (elece de edelerin deyerlerini gosterin)
    eger bolunmurse eded1 eded2-ye tam bolunmur yazin
    Meselen:
    Input: 10, 5
    Output: 10 5-e tam bolunur cixir
 */

// ctrl + k, c
// ctrl + k, u
// ctrl + k, d

//Console.WriteLine("Eded1-i daxil edin: ");
//int eded1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Eded2-ni daxil edin: ");
//int eded2 = Convert.ToInt32(Console.ReadLine());

//// Qaliq sifira beraber olmalidir
//if(eded2 == 0)
//{
//    Console.WriteLine("Sifira bolmek mumkun deyil");
//}
//else if(eded1 % eded2 == 0 ) 
//{
//    Console.WriteLine($"{eded1}, {eded2}-ye tam bolunur, netice: {eded1 / eded2}");
//}
//else
//{
//    Console.WriteLine($"{eded1}, {eded2}-ye tam bolunmur");
//}

/*
 
  3 dene deyisen teyin edin bunlar mekteblinin qiymetlerini temsil etsin(0-100 arasi) ve mekteblinin ortalamasini hesabliyin.
    IPUCU: Ortalama hesablamaq ucun ededleri toplayib sayina bolmek lazimdir
    Ekrana ise istifadecinin ortlamasi ile onun herf sisteminde qiymetini cixardin
    Eger ortalama:
    90-100(90 daxil deyil) arasi ise: A
    80-90(80 daxil deyil) arasi ise: B
    70-80(70 daxil deyil) arasi ise: C
    60-70(60 daxil deyil) arasi ise: D
    60-dan asagi arasi ise: F
    Misal ucun:
    85, 76, 92 daxil edilir
    ekrana ise : Ortalama: 84.33 - dur ve herf qiymetiniz B-dir
 
 */
//Console.WriteLine("Qiymet1-i daxil edin: ");
//double qiymet1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Qiymet2-i daxil edin: ");
//double qiymet2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Qiymet3-i daxil edin: ");
//double qiymet3 = Convert.ToDouble(Console.ReadLine());

//double ortalama = (qiymet1 + qiymet2 + qiymet3) / 3;

//if (ortalama <= 100 && ortalama > 90)
//{
//    Console.WriteLine("A");
//}
//else if (ortalama <= 90 && ortalama > 80)
//{
//    Console.WriteLine("B");
//}
//else if (ortalama <= 80 && ortalama > 70)
//{
//    Console.WriteLine("C");
//}
//else if (ortalama <= 70 && ortalama > 60)
//{
//    Console.WriteLine("D");
//}
//else
//{
//    Console.WriteLine("F");
//}

/*
 
    Bir alverci dusunun, o mueyyen qiymete mehsulu alir ve mueyyen qiymete satir. Bezen qazanc elde
    edir, eger 1000 manata aldigi mehsulu 1000den boyuk qiymete satarsa, eksine daha ucuza satarsa onda itkide olur.
    Alvercinin mehsulu aldigi qiymeti deyisende saxlayin elece de satdigi qiymeti.
    Ve qazancda yoxsa ziyanda oldugunu soyleyin, elece de eger qazancdadirsa ne qeder qazandigini ziyandadirsa ne qeder
    ziyan etdiyini soyleyin
 
 
 */

//double almaQiymet = 1000;
//double satmaQiymet = 2000;

//if (satmaQiymet - almaQiymet > 0)
//{
//    Console.WriteLine("Qazancdasiz");
//}
//else
//{
//    Console.WriteLine("Ziyanda");
//}


/*
  1-12 araliginda(ikisi de daxildir) ededi deyisende saxlayin ve hemin edede uygun ayi soz kimi ekrana cixarin
    Meselen:
    Input: 5
    Output: May
 */


//if(eded == 1)
//{
//    Console.WriteLine("Yanvar");
//}
//else if(eded == 2) { 
//}
//int eded = 2;
//string ay = "";
//switch (eded)
//{
//    case 1:
//        ay = "Yanvar";
//        break;
//    case 2:
//        ay = "Fevral";
//        break;
//    default:
//        ay = "Bele bir ay yoxdur";
//        break;
//}

//Console.WriteLine(ay);

/*
 
  Istifadeciden, ilk once hesablama emelini input kimi alin(+,-,*,/). Sonra ondan 1-ci ve 2-ci terefler ucun 2 eded alin
 Daha sonra switch case islederek istenilen hesablama emelini yerine yetirin
 Meselen:
 Input: +
 5, 9
 Output: 5+9=14
 
 */

//Console.WriteLine("Her hansi hesablama emeli daxil edin(*, /, +, -): ");
//string emel = Console.ReadLine();

//Console.WriteLine("Eded1 i daxil edin: ");
//int eded1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Eded2 i daxil edin: ");
//int eded2 = Convert.ToInt32(Console.ReadLine());

//switch (emel) 
//{
//    case "*":
//        Console.WriteLine($"Eded1 ve Eded2-nin hasili: {eded1 * eded2}");
//        break;
//    case "/":
//        if(eded2 == 0)
//        {
//            Console.WriteLine("Sifira bolmek olmaz");
//            break;
//        }
//        Console.WriteLine($"Eded1 ve Eded2-nin nisbeti: {eded1 / eded2}");
//        break;
//    case "+":
//        Console.WriteLine($"Eded1 ve Eded2-nin cemi: {eded1 + eded2}");
//        break;
//    case "-":
//        Console.WriteLine($"Eded1 ve Eded2-nin ferqi: {eded1 - eded2}");
//        break;
//    default:
//        Console.WriteLine("Bele bir emeliyyat yoxdur");
//        break;
//}

#endregion