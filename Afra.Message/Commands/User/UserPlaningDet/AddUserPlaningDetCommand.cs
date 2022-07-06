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
    public class AddUserPlaningDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UserPlaningDetId { get; set; }  
 
		public Int32 UPDPlanRef { get; set; }  
 
		public Nullable<Int32> UPDUserRef { get; set; }  
 
		public String UPDDescr { get; set; }  
 
		public DateTime UPDEndDate { get; set; }  
 
		public Nullable<Double> UPDProgress { get; set; } 

        public void Validate()
        {
            new AddUserPlaningDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
