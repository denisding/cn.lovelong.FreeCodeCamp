using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.lovelong.FreeCodeCamp.BLL
{
    public interface IFamousQuotesView
    {
        Model.FamousQuotesView GetRandom();
    }
}
