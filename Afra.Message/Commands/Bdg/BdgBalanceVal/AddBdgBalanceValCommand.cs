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
    public class AddBdgBalanceValCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgBalanceValId { get; set; }  
 
		public Nullable<Int32> BBVType { get; set; }  
 
		public String BBVSLRef { get; set; }  
 
		public String BBVDLRef { get; set; }  
 
		public String BBVDL5Ref { get; set; }  
 
		public String BBVDL6Ref { get; set; }  
 
		public String BBVDL7Ref { get; set; }  
 
		public Nullable<Double> BBVAmount { get; set; }  
 
		public Int32 BBVPeriodRef { get; set; }  
 
		public Nullable<Int32> BBVCurRef { get; set; } 

        public void Validate()
        {
            new AddBdgBalanceValCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
