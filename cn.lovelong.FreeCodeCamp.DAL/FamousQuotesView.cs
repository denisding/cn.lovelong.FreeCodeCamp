using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace cn.lovelong.FreeCodeCamp.DAL
{
    public class FamousQuotesView: BaseDAL, IFamousQuotesView
    {
        public Model.FamousQuotesView GetRandom()
        {
            using (Conn)
            {
                string query = @"SELECT TOP 1 FQ.Id,FQ.QuotesContent,FQ.PersonCode,Per.PName
                                FROM [dbo].[CP_FamousQuotes] FQ JOIN [dbo].[SYS_Person] Per ON FQ.PersonCode = Per.PCode
                                ORDER BY NEWID()";
                return Conn.Query<Model.FamousQuotesView>(query).FirstOrDefault();
            }
        }
    }
}
