/*  Andrew Macy
                */
using System;


namespace SchoolRPG
{
    abstract class State
    {
        public abstract State transition();
    }
}
