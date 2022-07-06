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
    public class AddInvVchItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvVchItmId { get; set; }  
 
		public Nullable<Int32> InvVchHdrRef { get; set; }  
 
		public Nullable<Int32> IVISeq { get; set; }  
 
		public Int32 IVIPartRef { get; set; }  
 
		public Nullable<Int32> IVIUnitRef { get; set; }  
 
		public Double IVIMainQty { get; set; }  
 
		public Nullable<Double> IVIOthQty { get; set; }  
 
		public String IVIDescr { get; set; }  
 
		public String IVIDLRef { get; set; }  
 
		public String IVISLRef { get; set; }  
 
		public Nullable<Int32> IVIRefID { get; set; }  
 
		public Nullable<Int32> IVIRefType { get; set; }  
 
		public Nullable<Int32> IVIFormulRef { get; set; }  
 
		public String IVIDL5Ref { get; set; }  
 
		public String IVIDL6Ref { get; set; } 

        public void Validate()
        {
            new AddInvVchItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
