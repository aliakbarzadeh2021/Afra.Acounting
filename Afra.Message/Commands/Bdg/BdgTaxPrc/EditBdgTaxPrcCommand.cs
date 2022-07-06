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
    public class EditBdgTaxPrcCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgTaxPrcId { get; set; }  
 
		public Int32 BTPElmnt { get; set; }  
 
		public Int32 BTPType { get; set; }  
 
		public String BTPSLRef { get; set; }  
 
		public String BTPDLRef { get; set; }  
 
		public String BTPDL5Ref { get; set; }  
 
		public String BTPDL6Ref { get; set; }  
 
		public String BTPDL7Ref { get; set; }  
 
		public Nullable<Double> BTPPercent { get; set; }  
 
		public Nullable<Int32> BTPPeriodRef { get; set; } 

        public void Validate()
        {
            new EditBdgTaxPrcCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
