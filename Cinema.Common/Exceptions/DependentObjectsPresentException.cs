﻿using System;

namespace Cinema.Common.Exceptions
{
    public class DependentObjectsPresentException : Exception
    {
        public DependentObjectsPresentException() :
            base("Object cannot be deleted while depentent objects are in the database")
        { }
    }
}
