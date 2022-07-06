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
    public class EditTrsFacilitiesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsFacilitiesId { get; set; }  
 
		public Int32 TFType { get; set; }  
 
		public Nullable<Int32> TFKind { get; set; }  
 
		public Nullable<Int32> TFContRef { get; set; }  
 
		public String TFNum { get; set; }  
 
		public DateTime TFDate { get; set; }  
 
		public Int32 TFSrcUseRef { get; set; }  
 
		public String TFDLRef { get; set; }  
 
		public String TFDescr { get; set; }  
 
		public Double TFAmount { get; set; }  
 
		public Int32 TFInstAmount { get; set; }  
 
		public DateTime TFInstDate { get; set; }  
 
		public Nullable<Double> TFShareAmnt { get; set; }  
 
		public Nullable<Double> TFSharePrc { get; set; }  
 
		public Nullable<Double> TFLatePrc { get; set; }  
 
		public Nullable<Int32> TFLateType { get; set; }  
 
		public Int32 TFPayDur { get; set; }  
 
		public Int32 TFAccPrdRef { get; set; }  
 
		public Nullable<Int32> TFState { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Double> TFTaxAmnt { get; set; }  
 
		public Nullable<Double> TFDutyAmnt { get; set; }  
 
		public String TFDLFive { get; set; }  
 
		public String TFDLSix { get; set; }  
 
		public Nullable<Int32> TFOpsType { get; set; }  
 
		public Nullable<Int32> TFIInstPayType { get; set; }  
 
		public String TFIWorkLoc { get; set; }  
 
		public String TFIComp { get; set; }  
 
		public String TFIPersCode { get; set; }  
 
		public String TFIOthCode { get; set; }  
 
		public String TFIBankInf { get; set; }  
 
		public String TFIAcnNo { get; set; }  
 
		public Nullable<Int32> TFIsLoan { get; set; }  
 
		public Nullable<Double> TFBlockAmnt { get; set; }  
 
		public Nullable<Int32> TFCreator { get; set; }  
 
		public Nullable<Int32> TFSit { get; set; }  
 
		public Nullable<Double> TFDelayShare { get; set; } 

        public void Validate()
        {
            new EditTrsFacilitiesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
