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
    public class AddPrdOprDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdOprDetId { get; set; }  
 
		public Int32 PrdOperationRef { get; set; }  
 
		public Int32 PODSeq { get; set; }  
 
		public Int32 PODSchRef { get; set; }  
 
		public DateTime PODRSTime { get; set; }  
 
		public DateTime PODRETime { get; set; }  
 
		public Double PODProdQty { get; set; }  
 
		public Double PODWastQty { get; set; }  
 
		public Double PODUnQty { get; set; } 

        public void Validate()
        {
            new AddPrdOprDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
