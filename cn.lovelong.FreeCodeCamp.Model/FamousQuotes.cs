using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.lovelong.FreeCodeCamp.Model
{
    public class FamousQuotes
    {
        public int Id { get; set; }
        public string QuotesContent { get; set; }
        public string PersonCode { get; set; }
        public string Creator { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
