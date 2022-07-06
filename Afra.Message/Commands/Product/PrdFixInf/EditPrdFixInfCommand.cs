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
    public class EditPrdFixInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdFixInfID { get; set; }  
 
		public Nullable<Int32> PFIProdVchType { get; set; }  
 
		public Nullable<Int32> PFIExpnsVchType { get; set; }  
 
		public Nullable<Int32> PFIMatStkRef { get; set; }  
 
		public Nullable<Int32> PFIPrdStkRef { get; set; }  
 
		public Nullable<Int32> PFISemiStkRef { get; set; }  
 
		public Nullable<Int32> PFIBaseVchType { get; set; } 

        public void Validate()
        {
            new EditPrdFixInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
