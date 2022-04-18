// Source Code starts  
using System.Text.RegularExpressions;  
using System;  
/* 
<HowToCompile> 
csc /r:System.Text.RegularExpressions.dll,System.dll Validation.cs  
</HowToComplie> 
*/  
class Validation  
{  
    public static void Main()  
    {  
        String strToTest;  
        Validation objValidate = new Validation();  
        Console.Write("Enter a String to Test for Alphabets:");  
        strToTest = Console.ReadLine();  
        if (objValidate.IsAlpha(strToTest))  
        {  
            Console.WriteLine("{0} is Valid Alpha String", strToTest);  
        }  
        else  
        {  
            Console.WriteLine("{0} is not a Valid Alpha String", strToTest);  
        }  
    }  
    // Function to test for Positive Integers.   
    public bool IsNaturalNumber(String strNumber)  
    {  
        Regex objNotNaturalPattern = new Regex("[^0-9]");  
        Regex objNaturalPattern = new Regex("0*[1-9][0-9]*");  
        return !objNotNaturalPattern.IsMatch(strNumber) &&  
        objNaturalPattern.IsMatch(strNumber);  
    }  
    // Function to test for Positive Integers with zero inclusive   
    public bool IsWholeNumber(String strNumber)  
    {  
        Regex objNotWholePattern = new Regex("[^0-9]");  
        return !objNotWholePattern.IsMatch(strNumber);  
    }  
    // Function to Test for Integers both Positive & Negative   
    public bool IsInteger(String strNumber)  
    {  
        Regex objNotIntPattern = new Regex("[^0-9-]");  
        Regex objIntPattern = new Regex("^-[0-9]+$|^[0-9]+$");  
        return !objNotIntPattern.IsMatch(strNumber) && objIntPattern.IsMatch(strNumber);  
    }  
    // Function to Test for Positive Number both Integer & Real   
    public bool IsPositiveNumber(String strNumber)  
    {  
        Regex objNotPositivePattern = new Regex("[^0-9.]");  
        Regex objPositivePattern = new Regex("^[.][0-9]+$|[0-9]*[.]*[0-9]+$");  
        Regex objTwoDotPattern = new Regex("[0-9]*[.][0-9]*[.][0-9]*");  
        return !objNotPositivePattern.IsMatch(strNumber) &&  
        objPositivePattern.IsMatch(strNumber) &&  
        !objTwoDotPattern.IsMatch(strNumber);  
    }  
    // Function to test whether the string is valid number or not  
    public bool IsNumber(String strNumber)  
    {  
        Regex objNotNumberPattern = new Regex("[^0-9.-]");  
        Regex objTwoDotPattern = new Regex("[0-9]*[.][0-9]*[.][0-9]*");  
        Regex objTwoMinusPattern = new Regex("[0-9]*[-][0-9]*[-][0-9]*");  
        String strValidRealPattern = "^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$";  
        String strValidIntegerPattern = "^([-]|[0-9])[0-9]*$";  
        Regex objNumberPattern = new Regex("(" + strValidRealPattern + ")|(" + strValidIntegerPattern + ")");  
        return !objNotNumberPattern.IsMatch(strNumber) &&  
        !objTwoDotPattern.IsMatch(strNumber) &&  
        !objTwoMinusPattern.IsMatch(strNumber) &&  
        objNumberPattern.IsMatch(strNumber);  
    }  
    // Function To test for Alphabets.   
    public bool IsAlpha(String strToCheck)  
    {  
        Regex objAlphaPattern = new Regex("[^a-zA-Z]");  
        return !objAlphaPattern.IsMatch(strToCheck);  
    }  
    // Function to Check for AlphaNumeric.  
    public bool IsAlphaNumeric(String strToCheck)  
    {  
        Regex objAlphaNumericPattern = new Regex("[^a-zA-Z0-9]");  
        return !objAlphaNumericPattern.IsMatch(strToCheck);  
    }  
}  
// Source Code End 