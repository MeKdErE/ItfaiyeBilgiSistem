using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.BusinessRules
{
    public class BusinessRules
    {
        public static List<IResult> Run (params IResult[] logics)           
        {         
            List<IResult> errorResults = new List<IResult>();
            foreach (var logic in logics) 
            {
                if (!logic.Success) 
                {
                    errorResults.Add(logic);
                }
                
            }            
            return errorResults;
        }
        
    }
}
