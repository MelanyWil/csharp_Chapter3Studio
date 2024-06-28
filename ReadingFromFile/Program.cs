try
{
    StreamReader sr = new StreamReader("/Users/mylaptop/Projects/py4e/romeo.txt");
    string line = sr.ReadLine();
    
    while (line != null) 
    {
        char[] charactersInString = line.ToLower().ToCharArray();
        Dictionary<char, int> characters = new Dictionary<char, int>();
        foreach (char character in charactersInString) {
            if(char.IsLetter(character)){
                if(characters.ContainsKey(character))
                {
                characters[character] ++;
                }
                else 
                {
                characters[character] = 1;
                }

        }
    
}

foreach (KeyValuePair<char, int> c in characters) {
    Console.WriteLine(c.Key + " : " + c.Value );
}
        line = sr.ReadLine();
    }
    sr.Close();
    Console.ReadLine();

}
catch(Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally
{
    Console.WriteLine("Executing finally block");
}
