

Console.WriteLine("Hej spelare du är fast i en Maze och ditt mål är att komma ut genom att svara vilken väg du vill gå hoppas du klarar det...");
Console.WriteLine("anyways so du trillar in i mazen från taket och allt du kan se i rummet är tre vägar vänster höger och frammot ");
Console.WriteLine("vilket går du igenom");


String val1 = Console.ReadLine();

if (val1 == ("frammot"))
{
    Console.WriteLine("---");
    Console.WriteLine("du gick frammot");
    Console.WriteLine("efter ett tag så kommer du fram till en dörr där det står en skylt som säger att du har klarat spelet");
    Console.WriteLine("grattis man du klara de wooooooooooooooooooooooooooooooooooo");
}



else if (val1 ==("höger"))
{
    Console.WriteLine("---");
    Console.WriteLine("du gick höger");
    Console.WriteLine("efter ett tag så kommer du till ett nytt rumm där du ännu en gång faller ner i ett anant rumm");
    Console.WriteLine("framför dig finns det två dörrar halvt öppnade Höger och Vänster vilket vill du gå igenom");
    
    string val12 = Console.ReadLine();
    if (val12 == ("höger"))
    {
        Console.WriteLine("---");
        Console.WriteLine("du valde höger så du smyger dig framm till dörren och sticker in huvet för att se vad som finns");
        Console.WriteLine("HELT PLÖTSLIGT KOMMER EN FUCKING BJÖRN OCH ÄTER upp DIG DU DOG!!! ");
        Console.WriteLine("de här va tydligen inte vägen frammot.");
    }
    else if (val12 == ("vänster"))
    {
        Console.WriteLine("---");
        Console.WriteLine("du grå fram till dörren men trillar rakt framför dörren och slår huvet i en spik damn");
        Console.WriteLine("de synd asså trodde du skulle klara det men många vägar bort men bara en frammot");
    }
    else 
    {
        Console.WriteLine("---");
        Console.WriteLine("kom igen du vill inte köra eller så lowkey du ba inte skrev med små bokstäver lol.");
    }
}



else if (val1 ==("vänster"))
{
    Console.WriteLine("---");
    Console.WriteLine("du gick vänster");
    Console.WriteLine("...");
    Console.WriteLine("men oj vad är det här du dog för du gick fel de finns bara en väg frammot");
}



else 
{
    Console.WriteLine("---");
    Console.WriteLine("va gör du bete dig skriv rätt");
}



Console.ReadLine();