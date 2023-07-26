Console.Clear();
using (HttpClient client = new HttpClient())
{
    try
    {
        string respost = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(respost);
    }catch (Exception ex)
    {
        Console.WriteLine($"\n\nInfelizmente não funfou!!!\n\nMotivo: {ex.Message}");
    }
}