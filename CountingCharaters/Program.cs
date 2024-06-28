
//Loop through the string one character at a time
//Store and update the count for each character
//Loop through the data structure to pring the results

using System.Reflection.PortableExecutable;
Console.WriteLine("Enter a sentence or paragraph to count the characters ");
string sentence = (Console.ReadLine());


char[] charactersInString = sentence.ToLower().ToCharArray();
Dictionary<char, int> characters = new Dictionary<char, int>();


//Loop through charactersInString using foreach? and store in characters dictionary
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
