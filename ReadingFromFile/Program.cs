try
{
    string fileContent = File.ReadAllText("/Users/mylaptop/Projects/py4e/romeo.txt");
    
    char[] charactersInString = fileContent.ToLower().ToCharArray();

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


}
catch(Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally
{
    Console.WriteLine("Executing finally block");
}
