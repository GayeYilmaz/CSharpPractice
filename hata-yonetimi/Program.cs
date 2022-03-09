// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

try{
    Console.WriteLine("Bir sayı giriniz :");
    int sayi =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girmiş olduğunuz sayi :"+sayi);


}catch(Exception e){
   Console.WriteLine("Hata "+e.Message.ToString());


}
//finally{
    //Console.WriteLine("İşlem tamamlandı.");


//}

try
{
    //int a = int.Parse(null);
    //int a = int.Parse("test");
    int a = int.Parse("-200000000000");

}
catch (ArgumentNullException e)
{
    Console.WriteLine("Null değer girdiniz.");
    Console.WriteLine(e);


}catch(FormatException e){
    Console.WriteLine("Veri tipi uygun değil.");
    Console.WriteLine(e);
}
catch(OverflowException e){
    Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz.");
    Console.WriteLine(e);
}
finally{
    Console.WriteLine("İşlem tamamlandı.");


}
