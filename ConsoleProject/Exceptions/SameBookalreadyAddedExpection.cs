﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Exceptions
{
    class SameBookalreadyAddedExpection : Exception
    {
        public SameBookalreadyAddedExpection(string message):base(message)
        {

        }
        public SameBookalreadyAddedExpection(string message,SameBookalreadyAddedExpection sameBookalreadyAddedExpection):base(message,sameBookalreadyAddedExpection)
        {

        }
    }
}
