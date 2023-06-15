using System.Runtime.CompilerServices;

string someString = "Luis";
string actualString = someString;

Verify verify = new();
verify.IsTrue(actualString, someString == "TEST");

public class Verify
{
    public void IsTrue(string actualString, bool someString, [CallerArgumentExpression("someString")] string expression = null)
    {
        if (!someString)
        {
            Console.WriteLine($"{expression} must be True, but was False. The actual string values is: {actualString}");
        }
        else 
        {
            Console.WriteLine($"Correct the string value is: {expression}");
        }
    }
}
