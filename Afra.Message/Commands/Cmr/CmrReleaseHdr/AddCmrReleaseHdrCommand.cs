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
    public class AddCmrReleaseHdrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrReleaseHdrId { get; set; }  
 
		public Int32 CRHNum { get; set; }  
 
		public Nullable<Int32> CRHLocalNum { get; set; }  
 
		public DateTime CRHDate { get; set; }  
 
		public Int32 CRHCrsRef { get; set; }  
 
		public Nullable<Int32> CRHDlvrRef { get; set; }  
 
		public Nullable<Int32> CRHEnCustoms { get; set; }  
 
		public Nullable<Int32> CRHRLCustoms { get; set; }  
 
		public Nullable<Double> CRHAmount { get; set; }  
 
		public String CRHGreenInf { get; set; }  
 
		public String CRHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> CRHState { get; set; }  
 
		public Nullable<Int32> CAccPrdRef { get; set; }  
 
		public Nullable<Int32> CRHRefID { get; set; }  
 
		public Nullable<Int32> CRHRefType { get; set; } 

        public void Validate()
        {
            new AddCmrReleaseHdrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
