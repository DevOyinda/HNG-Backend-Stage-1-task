using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Stage_1_task.Model
{
    public class Response
    {
        public string slackUsername { get; set; }

        public bool backend { get; set; }

        public int age { get; set; }

        public string bio { get; set; }
    }
}
