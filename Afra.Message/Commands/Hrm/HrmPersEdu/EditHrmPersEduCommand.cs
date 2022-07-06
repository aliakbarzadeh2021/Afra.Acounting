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
    public class EditHrmPersEduCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PersEduId { get; set; }  
 
		public Nullable<Int32> PEdPersRef { get; set; }  
 
		public String PersEduDeg { get; set; }  
 
		public DateTime PersEduDate { get; set; }  
 
		public String PersEduField { get; set; }  
 
		public String PersEduUnv { get; set; }  
 
		public Nullable<Double> PersEduAvg { get; set; }  
 
		public String PersEduTrend { get; set; } 

        public void Validate()
        {
            new EditHrmPersEduCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
