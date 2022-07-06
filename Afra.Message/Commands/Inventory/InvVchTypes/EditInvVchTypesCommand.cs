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
    public class EditInvVchTypesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvVchTypeId { get; set; }  
 
		public String IVTDescr { get; set; }  
 
		public String IVTDLType { get; set; }  
 
		public Nullable<Int32> IVTPricingType { get; set; }  
 
		public Nullable<Int32> IVTOpsAutoVch { get; set; }  
 
		public Nullable<Int32> IVTOAVStockRef { get; set; }  
 
		public Nullable<Int32> IVTOAVDLRef { get; set; }  
 
		public Nullable<Int32> IVTPartLimit { get; set; }  
 
		public Nullable<Int32> IVTBaseLimit { get; set; }  
 
		public Nullable<Int32> IVTShopRel { get; set; } 

        public void Validate()
        {
            new EditInvVchTypesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
