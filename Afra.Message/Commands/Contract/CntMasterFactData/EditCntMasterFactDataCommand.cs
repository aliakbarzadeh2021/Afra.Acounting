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
    public class EditCntMasterFactDataCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntMasterFactDataID { get; set; }  
 
		public Int32 CMFDFactRef { get; set; }  
 
		public Nullable<Int32> CMFDFldRef { get; set; }  
 
		public Nullable<Double> CMFDAmount { get; set; } 

        public void Validate()
        {
            new EditCntMasterFactDataCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
