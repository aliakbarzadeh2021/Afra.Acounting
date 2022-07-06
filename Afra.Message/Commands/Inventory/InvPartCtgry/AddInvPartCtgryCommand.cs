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
    public class AddInvPartCtgryCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvPartCtgryId { get; set; }  
 
		public String IPCCode { get; set; }  
 
		public String IPCName { get; set; }  
 
		public Int32 IPCPricingType { get; set; }  
 
		public String IPCSLRef { get; set; }  
 
		public Nullable<Int32> IPCDL4Type { get; set; }  
 
		public String IPCDL4Code { get; set; }  
 
		public Nullable<Int32> IPCDL5Type { get; set; }  
 
		public String IPCDL5Code { get; set; }  
 
		public Nullable<Int32> IPCDL6Type { get; set; }  
 
		public String IPCDL6Code { get; set; } 

        public void Validate()
        {
            new AddInvPartCtgryCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
