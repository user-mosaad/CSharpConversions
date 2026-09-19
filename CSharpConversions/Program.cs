namespace CSharpConversions;

class Program
{
    static void Main()
    {
        int itemCount = 42;
        long widened = itemCount; // Implicit conversion

        double average = 19.75;
        int truncated = (int)average; // Explicit cast

        int temperature = 72;
        object boxedTemperature = temperature; // Boxing
        int unboxedTemperature = (int)boxedTemperature; // Unboxing

        // Parsing text using 'Parse' and 'TryParse'
        string textValue = "512";
        int parsed = int.Parse(textValue);

        string userInput = "12x";
        bool parsedSuccessfully = int.TryParse(userInput, out int safeValue);

        Console.WriteLine(parsed);
        Console.WriteLine(parsedSuccessfully ? $"safe value: {safeValue}" : "Input is not a valid number.");
    }
}
