using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_ASSIGNMENT_BUILDER.Engine.AssignmentBuilder;
using Xunit;

namespace C_ASSIGNMENT_BUILDER.Assignment
{
    public class DumbTest : AssignmentBase
    {
        public string Dummy(string lol)
        {
            return lol;
            throw new NotImplementedException();
        }


        [Assignment(1)]
        public void ReturnDummy()
        {
            string dummy = "im like so smart";
            Assert.Equal(Dummy(dummy), dummy);
        }

    }
}