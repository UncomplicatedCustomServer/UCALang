﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paganism.PParser.AST.Enums;

namespace Paganism.PParser.Values
{
    public class NoneValue : Value
    {
        public override string Name => "None";

        public override TypesType Type => TypesType.None;

        public override string AsString()
        {
            return "None";
        }
    }
}
