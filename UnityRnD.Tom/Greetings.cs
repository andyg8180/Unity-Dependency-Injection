using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityRnD.Core;

namespace UnityRnD.Tom
{
    public class Greetings : IGreeting
    {
        public string GetGreeting()
        {
            return "Hi, my name is Tom.";
        }
    }
}
