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
    public class AddBdgProjectDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgProjectDetId { get; set; }  
 
		public Int32 BPDHdrRef { get; set; }  
 
		public String BPDDescr { get; set; }  
 
		public Nullable<Double> BPDQty { get; set; }  
 
		public Nullable<Int32> BPDUnit { get; set; }  
 
		public Nullable<Int32> BPDCurRef { get; set; }  
 
		public Nullable<Double> BPDRate { get; set; }  
 
		public String BPDSLRef { get; set; } 

        public void Validate()
        {
            new AddBdgProjectDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
