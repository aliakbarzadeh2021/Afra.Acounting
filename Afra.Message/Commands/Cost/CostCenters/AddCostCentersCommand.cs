using Afra.Message.Base;
using Afra.Message.Extentions;
using Afra.Message.Validators;
using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Commands
{
    /// <summary>
    ///  
    /// </summary>
    public class AddCostCentersCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CostCenterID { get; set; }  
 
		public String CstCode { get; set; }  
 
		public String CstName { get; set; }  
 
		public String CstDLRef { get; set; }  
 
		public Nullable<Int32> CstType { get; set; } 

        public void Validate()
        {
            new AddCostCentersCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
