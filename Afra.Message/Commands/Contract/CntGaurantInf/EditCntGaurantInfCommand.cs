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
    public class EditCntGaurantInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntGaurantInfId { get; set; }  
 
		public Int32 CGIBaseItm { get; set; }  
 
		public Int32 CGIBaseType { get; set; }  
 
		public DateTime CGIFromDate { get; set; }  
 
		public String CGIDur { get; set; }  
 
		public String CGIDescr { get; set; }  
 
		public Nullable<Double> CGIAmount { get; set; } 

        public void Validate()
        {
            new EditCntGaurantInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
