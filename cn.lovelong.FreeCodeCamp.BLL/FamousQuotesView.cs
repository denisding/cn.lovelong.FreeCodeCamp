using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.lovelong.FreeCodeCamp.BLL
{
    public class FamousQuotesView: IFamousQuotesView
    {
        public Model.FamousQuotesView GetRandom()
        {
            DAL.IFamousQuotesView dal = new DAL.FamousQuotesView();
            return dal.GetRandom();
        }
    }
}
