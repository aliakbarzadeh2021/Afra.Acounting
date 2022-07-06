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
    public class AddHrmWorkGroupsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmWorkGroupId { get; set; }  
 
		public String HWGTitle { get; set; }  
 
		public Nullable<Int32> HWGType { get; set; }  
 
		public Nullable<Int32> HWGCalndRef { get; set; }  
 
		public DateTime HWGDayPrDelay { get; set; }  
 
		public DateTime HWGDayPrPost { get; set; }  
 
		public DateTime HWGMonPityDelay { get; set; }  
 
		public Nullable<Int32> HWGMonPrDelayCnt { get; set; }  
 
		public Nullable<Int32> HWGCalcDelaySit { get; set; }  
 
		public DateTime HWGYrMinResrvVac { get; set; }  
 
		public DateTime HWGYrMaxResrvVac { get; set; }  
 
		public DateTime HWGMonMinResrvVac { get; set; }  
 
		public DateTime HWGMonMaxResrvVac { get; set; }  
 
		public DateTime HWGTmEmpMinHour { get; set; }  
 
		public DateTime HWGTmEmpMaxHour { get; set; }  
 
		public DateTime HWGDcTimeFromOvrTime { get; set; }  
 
		public DateTime HWGDcTimeFromVac { get; set; }  
 
		public DateTime HWGOvrTimeMinBfr { get; set; }  
 
		public DateTime HWGOvrTimeMinAftr { get; set; }  
 
		public Nullable<Int32> HWGOvrTimeNeedPrm { get; set; }  
 
		public Nullable<Int32> HWGAccPrdRef { get; set; } 

        public void Validate()
        {
            new AddHrmWorkGroupsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
