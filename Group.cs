/*  Andrew Macy
                */
using System;
using System.Collections.Generic;

namespace SchoolRPG
{
    abstract class Group : IEnumerable<iNPC>
    {
        List<iNPC> group;

        public Group()
        {
            this.group = new List<iNPC>();
        }

        public IEnumerator<iNPC> GetEnumerator()
        {
            return group.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return group.GetEnumerator();
        }
    }
}
