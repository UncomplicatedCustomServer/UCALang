﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paganism.Lexer.Enums
{
    public enum TokenType
    {
        String = 1,
        Number = 2,
        Colon = 4,
        Semicolon = 5,
        Word = 6,
        Plus = 7,
        Minus = 8,
        Slash = 9,
        Star = 10,
        Assign = 11,
        LeftPar = 12,
        RightPar = 13,
        Function = 14,
        End = 15,
        Comma = 16,
        NumberType = 17,
        StringType = 18,
        And = 19,
        AnyType = 20,
        Return = 21,
        LeftBracket = 22,
        RightBracket = 23,
        NoneType = 24,
        EOF = 25,
        BooleanType = 26,
        True = 27,
        False = 28,
        If = 29,
        Elif = 30,
        Else = 31,
        Is = 32,
        Or = 33,
        Then = 34,
        Less = 35,
        More = 36,
        For = 37,
        Not = 38,
        Break = 39,
        Structure = 40,
        Show = 41,
        Hide = 42,
        Castable = 43,
        Point = 44,
        ArrayType = 45,
        ObjectType = 46,
        Char = 47
    }
}
