﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KnuOopLab2
{
    interface IDormitorySearchStrategy
    {
        public Inmate[] searchByName(string namePattern);
    }
}