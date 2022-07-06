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
    public class EditCntContDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntContDetId { get; set; }  
 
		public Int32 CCDContRef { get; set; }  
 
		public Int32 CCDItmRef { get; set; }  
 
		public Nullable<Int32> CCDCostCenter { get; set; }  
 
		public Int32 CCDUnit { get; set; }  
 
		public Int32 CCDDur { get; set; }  
 
		public Double CCDQty { get; set; }  
 
		public Double CCDRate { get; set; } 

        public void Validate()
        {
            new EditCntContDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
