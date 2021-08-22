using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTips
{
    class CSharpLists
    {


        internal static List<Tip> variableTypes = new List<Tip>()
        {
            new Tip("Value Type Variables", 
                "The following are value type variables:\nbool, char, int, decimal, enum, byte, sbyte, short, uint, ushort, long, ulong, double, float", 
                "Value type variables are stored in a location called the stack.\nThe stack is used for static memory allocation, and utilizes a 'Last In, First Out' procedure.\nValue type variables are not automatically nullable however you can make them nullable when declaring them with the ? syntax. Example:\nint? exampleInt = null;"),
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
        internal static List<Tip> operatorTypes = new List<Tip>()
        {
            new Tip("Operators:",
                "Examples of Operators:\n+, -, *, /, %, ++, --, ==, !=, >, >=, <, <=, &&, ||, !, =, +=, -=, *=, /=, %=",
                "Operators are calculations that take in at least one Operand (variable to work with) and one operator (like the '+' sign that tells us to add)."),
            new Tip("Binary Arithmetic Operators:",
                "Examples of Binary Arithmetic Operators:\n+, -, *, /, %\nint x = 1 + 2;\n In the example above, 1 and 2 are Operands and '+' is the operator",
                "Binary Operators are calculations that must take in at least two operands. Above are the Arithmetic Operators that are binary. "),
            new Tip("Unary Arithmetic Operators:",
                "Examples of Unary Arithmetic Operators:\n++, --\nint x = 3;\n++x;   <-- Example",
                "Unary Operators are calculations that can be run with only one Operand. In the example above, the x is the Operand and the ++ is the Unary Operator.\nDid you know that changing where the operator is will change the outcome? for example, if we switched the above example to show x++ we would use the value, and then increase it after its been used."),
            new Tip("Relational Operators:",
                "Examples of Relational Operators:\n==, !=, >, >=, <, <=\nif(x != y)   <-- Example: Will return true if x is not equal to y.",
                "Relational Operators must take in two Opperands and are used to compare two values."),
            new Tip("Logical Operators:",
                "Examples of Logical Operators:\n&&, ||, !\nif(x > 3 && x < 5)   <-- Example: Will return true if both conditions are true.\nif(x > 3 || x < 5)   <-- Example: Will return true if at least one condition is true.\nif(!x > 3)   <-- Example: Will return the opposite so if this x was 5 it would return false.",
                "Logical Operators are used to combine two or more conditions or to complement the evaluation of the original condition in consideration."),
            new Tip("Assiginment Operator",
                "Examples of Assignment Operators:\n=, +=, -=, *=, /=, %=\nint x = 5;\nx*=5;   <-- Example: This is the same as typing x = x * 5;",
                "Assignment operators are used to assign a value to a variable. The operand on the left side of the assignment operator is a variable and the operand on the right is a value. The value must be the same data-type as the operand."),
            new Tip("Ternary Operator:",
                "Example of the Ternary Operator:\ncondition ? outcomeIfTrue : outcomeIfFalse;\nbool isEvenNumber ? true : false;   <-- this example will return true if isEvenNumber is true.",
                "Ternary Operators, also known as the \"Inline-if\"and is syntax sugar, is a shorthand verrsion of if-else statement. The word ternary means composed of three parts, so this operator must always have three operands. It will return one of two values, and should be used to assign values."),
        };

        internal static List<Tip> selectionStatements = new List<Tip>()
        { new Tip ("Selection Statements:",
            "Examples of Selection Statements:\n if ( condition ){ Code Ran if True }\nelse if ( secondCondition ){ Code Ran if condition false but secondCondition true }\nelse { Code Ran if Above is False }",
            "The above examples cover If, ElseIf, and Else statements. You can also use a switch statement to compare a variable against multiple \"cases\""),
            new Tip ("If Statement:",
            "",
            ""),
            new Tip ("",
            "",
            ""),
            new Tip ("",
            "",
            ""),
            new Tip ("",
            "",
            ""),
            new Tip ("",
            "",
            ""),
            new Tip ("",
            "",
            "")

        };
    }

}
