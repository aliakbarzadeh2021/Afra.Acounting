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
    public class EditCmrRegisterCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrRegisterId { get; set; }  
 
		public Int32 CRNum { get; set; }  
 
		public Int32 CRFactRef { get; set; }  
 
		public DateTime CRDate { get; set; }  
 
		public Double CRCharge { get; set; }  
 
		public Int32 CRBaseLoc { get; set; }  
 
		public String CRTransLoc { get; set; }  
 
		public Nullable<Int32> CREntBorder { get; set; }  
 
		public String CRCustoms { get; set; }  
 
		public Nullable<Int32> CRCanQtyTrans { get; set; }  
 
		public Nullable<Int32> CRTransQty { get; set; }  
 
		public String CRTransType { get; set; }  
 
		public Nullable<Int32> CRDeliveryDay { get; set; } 

        public void Validate()
        {
            new EditCmrRegisterCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
