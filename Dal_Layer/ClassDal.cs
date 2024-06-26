using System.Text.Json;


namespace Dal
{
    public class ClassDal
    {
       public string GetTanachText()
        {          
            try
            {
                string path = """C:\Users\noaka\Documents\c#\TanachSearch\TanachSearch\Dal_Layer\bin\Debug\net7.0\tora.txt""";
                string tanachTxt = File.ReadAllText(path);
                return tanachTxt;
            }
            catch(FileNotFoundException e)
            {
                throw new Exception(e+"The path is not existing");
            }           
        }
        public string[][] ReadNumDictJSONFile()
        {
            try
            {
                string path= """C:\Users\noaka\Documents\c#\TanachSearch\TanachSearch\Dal_Layer\bin\Debug\net7.0\tanach.json""";
                string jsonContent = File.ReadAllText(path);
                string[][] numDict = JsonSerializer.Deserialize<string[][]>(jsonContent);
                return numDict;
            }
            catch
            {
                throw new Exception("The path is not existing");
            }
        }
    }
}