using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PrdOperationDto
    {
          
 
		public Int32 PrdOperationId { get; set; }  
 
		public Int32 PONum { get; set; }  
 
		public DateTime PODate { get; set; }  
 
		public Int32 POStationRef { get; set; }  
 
		public String PODescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> POState { get; set; }  
 
		public Nullable<Int32> POYear { get; set; } 
    }
}


