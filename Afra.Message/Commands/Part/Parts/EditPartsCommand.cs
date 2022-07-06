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
    public class EditPartsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PartId { get; set; }  
 
		public String PartCode { get; set; }  
 
		public String PartName { get; set; }  
 
		public Int32 UnitRef { get; set; }  
 
		public Nullable<Int32> InvCtgryRef { get; set; }  
 
		public String PartECode { get; set; }  
 
		public String PartOInf { get; set; }  
 
		public String PartType { get; set; }  
 
		public String PBarcode { get; set; }  
 
		public Nullable<Int32> SleCtgryRef { get; set; }  
 
		public String PDLRef { get; set; }  
 
		public Nullable<Int32> PartSit { get; set; }  
 
		public Nullable<Int32> ProdType { get; set; } 

        public void Validate()
        {
            new EditPartsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
