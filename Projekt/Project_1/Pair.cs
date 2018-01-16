﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    public class Pair<T, U>
    {
        #region Fields and Properties

        public T First { get; set; }
        public U Second { get; set; }

        #endregion

        #region Constructors

        public Pair()
        {
        }

        public Pair(T first, U second)
        {
            this.First = first;
            this.Second = second;
        }

        #endregion
    }
}
