﻿using System;

namespace Open_Lab_03._05
{
    public class Comparator
    {
        public bool MatchCaseInsensitive(string str1, string str2) => str1.ToLower() == str2.ToLower();
        
    }
}
