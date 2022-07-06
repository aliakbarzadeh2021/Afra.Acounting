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
    public class EditUsrProdRcvCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public Nullable<Int32> CostRef { get; set; }  
 
		public Nullable<Int32> PartRef { get; set; }  
 
		public Nullable<Int32> Qty { get; set; } 

        public void Validate()
        {
            new EditUsrProdRcvCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
