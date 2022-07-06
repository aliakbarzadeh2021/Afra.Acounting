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
    public class AddSleServicesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleServicesID { get; set; }  
 
		public String SSTitle { get; set; }  
 
		public Nullable<Int32> SSUnitRef { get; set; }  
 
		public String SSSLRef { get; set; }  
 
		public String SSDLRef { get; set; }  
 
		public String SSCode { get; set; }  
 
		public Nullable<Int32> SSGrpRef { get; set; }  
 
		public Nullable<Int32> SCDL4Type { get; set; }  
 
		public Nullable<Int32> SCDL5Type { get; set; }  
 
		public Nullable<Int32> SCDL6Type { get; set; } 

        public void Validate()
        {
            new AddSleServicesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
