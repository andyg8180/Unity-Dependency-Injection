using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityRnD.Core;

namespace UnityRnD.Michael
{
    public class ChattyKathy : IGreeting
    {
        public string GetGreeting()
        {
            return "Hi I'm Mike and I like pizza. Lets talk about pizza for a moment.";
        }
    }
}
