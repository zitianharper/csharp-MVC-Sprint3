namespace MVC3
{
    public interface IUtils
    {
       public string GetPath(string fileYouWant)
        {
            string pathTo = Path.Combine(AppContext.BaseDirectory, "Resources", $"{fileYouWant}.json");
            string item = File.ReadAllText(pathTo);
            return item;
        }
    }
}
