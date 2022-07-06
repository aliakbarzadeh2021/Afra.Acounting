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
    public class AddCntMasterFactorCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntMasterFactorId { get; set; }  
 
		public Nullable<Int32> CMFSerial { get; set; }  
 
		public Nullable<Int32> CMFNum { get; set; }  
 
		public DateTime CMFDate { get; set; }  
 
		public Int32 CMFContRef { get; set; }  
 
		public Double CMFAmount { get; set; }  
 
		public String CMFDescr { get; set; }  
 
		public Int32 CMFPrdRef { get; set; }  
 
		public Nullable<Int32> CMFState { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; } 

        public void Validate()
        {
            new AddCntMasterFactorCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
