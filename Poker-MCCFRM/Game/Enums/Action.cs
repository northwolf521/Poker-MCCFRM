﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_MCCFRM
{
    public enum ACTION
    {
        NONE,
        FOLD,
        //CHECK, combined with CALL, basically calling a 0 raise
        CALL,
        RAISE,
        RAISE1,
        RAISE2,
        RAISE3,
        ALLIN
    }
}
