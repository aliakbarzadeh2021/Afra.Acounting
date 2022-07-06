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
    public class AddGnrUserFieldCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrUserFieldId { get; set; }  
 
		public Int32 GUFdFormRef { get; set; }  
 
		public Nullable<Int32> GUFdGroupRef { get; set; }  
 
		public String GUFdTitle { get; set; }  
 
		public String GUFdName { get; set; }  
 
		public Int32 GUFdType { get; set; }  
 
		public Nullable<Int32> GUFdShDir { get; set; }  
 
		public Nullable<Int32> GUFdShPrv { get; set; }  
 
		public Nullable<Int32> GUFdSize { get; set; }  
 
		public Nullable<Int32> GUFdShInList { get; set; }  
 
		public Nullable<Int32> GUFdForce { get; set; }  
 
		public Nullable<Int32> GUFdEditAble { get; set; }  
 
		public Nullable<Int32> GUFdIsCalcField { get; set; }  
 
		public String GUFdValids { get; set; }  
 
		public Nullable<Int32> GUFdRefrence { get; set; }  
 
		public Nullable<Int32> GUOrder { get; set; }  
 
		public String GUFdCalcStr { get; set; } 

        public void Validate()
        {
            new AddGnrUserFieldCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
