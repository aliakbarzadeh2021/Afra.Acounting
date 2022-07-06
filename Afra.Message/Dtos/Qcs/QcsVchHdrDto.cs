using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class QcsVchHdrDto
    {
          
 
		public Int32 QcsVchHdrId { get; set; }  
 
		public Int32 QVHNum { get; set; }  
 
		public Nullable<Int32> QVHLocalNum { get; set; }  
 
		public DateTime QVHDate { get; set; }  
 
		public Int32 QVHProdRef { get; set; }  
 
		public String QVHStepRef { get; set; }  
 
		public Nullable<Int32> QVHMenRef { get; set; }  
 
		public Nullable<Int32> QVHTestRef { get; set; }  
 
		public Nullable<Int32> QVHLabRef { get; set; }  
 
		public Nullable<Double> QVHAllQty { get; set; }  
 
		public Nullable<Double> QVHTestQty { get; set; }  
 
		public Nullable<Double> QVHOKQty { get; set; }  
 
		public String QVHDescr { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> QVHState { get; set; }  
 
		public Nullable<Int32> QAccPrdRef { get; set; }  
 
		public Nullable<Int32> QVHRefID { get; set; }  
 
		public Nullable<Int32> QVHRefType { get; set; } 
    }
}


