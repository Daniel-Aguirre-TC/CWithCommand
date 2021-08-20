using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTips
{
    class CSharpLists
    {
        internal static List<Tip> variableTypes = new List<Tip>()
        {
            new Tip("Value Type Variables", "The following are value type variables:\nbool, char, int, decimal, enum, byte, sbyte, short, uint, ushort, long, ulong, double, float", "Value type variables are stored in a location called the stack.\nThe stack is used for static memory allocation, and utilizes a 'Last In, First Out' procedure.\nValue type variables are not automatically nullable however you can make them nullable when declaring them with the ? syntax. Example:\nint? exampleInt = null;"),
            new Tip("Signed vs Unsigned Variables", "Signed variables can be both positive or negative numbers. Examples:\nint, decimal, float, double, long, short, sbyte", "Unsigned integers are assumed to be positive since there is a lack of 'sign'. Examples:\nulong, ushort, uint, byte"),
            new Tip("Reference Type Variables", "The following are reference type variables:\nString, Array", "Reference type variables store a reference to the data instead of storing the data itself.\nBy default, reference type variables automatically support being set to null.\nThe heap is where reference type variables are stored, which unlike the stack allows elements to be removed in any order."),
            new Tip("Boolean", "bool exampleBool = true;", "The Boolean type is defined with the keyword: 'bool'. You can set the value to be 'true' or 'false'"),
            new Tip("Character", "char exampleChar = '$';", "The Character type is defined with the keyword: 'char'. You can set the value to any unicode character, surrounded by single quotes. Did you know you can even use characters from languages other than english?"),
            new Tip("Integer", "int exampleInt = 19;", "The Integer type is defined with the keyword: 'int'. The integer type is a 32-bit signed integer that can be set to any integer between -2,147,483,648 to 2,147,483,647."),
            new Tip("Decimal", "decimal exampleDecimal = 1234.567m;", "The Decimal type is defined with the keyword: 'decimal'. You can set the value to be any decimal within the range of (-7.9 x 1028 to 7.9 x 1028) / 100 to 28. Must always be appended with an 'm'. Did you know the Decimal type is preferred when doing financial calculations due to how precise it can be?"),
            new Tip("Enum", "public enum Weekday{Mon, Tues, Wed, Thurs, Fri};\nDay currentDay = Weekday.Wednesday;", "Enum is a distince type that allows you to limit the variables value to a fixed amount of options. You can also assign enum values with their position. Example:\ncurrentDay = Weekday.0; // This would assign the variable to the 'Monday' value."),
            new Tip("Byte", "byte exampleByte = 19;", "Byte type variables are an 8-bit unsigned integer that can accept a number from 0 - 255."),
            new Tip("sByte", "sbyte exampleSbyte = 19;", "sbyte type variables are an 8-bit signed integer that allows numbers from -128 to 127. "),
            new Tip("Short", "short exampleShort = 19;", "Variables of the type short are 16-bit signed integers that can hold numbers between -32,768 and 32,767."),
            new Tip("uShort", "ushort exampleUshort = 19;", "Variables declared as ushort will use a 16-bit unsigned integer that stores a value from 0 - 65,535."),
            new Tip("uInt", "uint exampleUint = 19;", "The uint variable type a 32-bit unsigned integer which allows numbers from 0 up to 4,294,967,295."),
            new Tip("Long", "long exampleLong = 19;", "long type variables hold 64-bit signed integers. They can store a number from -9,223,372,036,854,775,808 up to 9,223,372,036,854,775,807."),
            new Tip("uLong", "ulong exampleUlong = 19;", "The ulong variable is a 64-bit unsigned integer which can hold a number between 0 and 18,446,744,073,709,551,615."),
            new Tip("Double", "double exampleDouble = 19.19;", "Variables of the type double are signed decimals that can allow a number from (+/-) 5.0 x 10,324 - (+/-) 1.7 x 10308."),
            new Tip("Float", "float exampleFloat = 19.19f", "Float variables are another signed decimal however they only allow a value from -3.4 x 1038 - 3.4 x 1038."),
            new Tip("String", "string exampleString = \"String\";", "A String is a sequence of zero or more unicode characters surrounded by double quotes."),
            new Tip("Array", "string[] stringArray = new string[5];", "Arrays allow you to combine multiple evariables of the same type into one variable. Arrays are zero-based index so the first value is always stored at 0.")
        };

    }

}
