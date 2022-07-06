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
    public class EditQcsTestDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 QcsTestDetId { get; set; }  
 
		public Int32 QTDTestRef { get; set; }  
 
		public Int32 QTDPropRef { get; set; }  
 
		public String QTDName { get; set; }  
 
		public Int32 QTUnitRef { get; set; }  
 
		public Nullable<Double> QTDMinVal { get; set; }  
 
		public Nullable<Double> QTDMaxVal { get; set; }  
 
		public String QTDCheck { get; set; }  
 
		public String QTDTestType { get; set; }  
 
		public String QTDMachine { get; set; }  
 
		public String QTDDescr { get; set; } 

        public void Validate()
        {
            new EditQcsTestDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
