using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class AstPitchsDto
    {
          
 
		public Int32 AstPitchId { get; set; }  
 
		public Nullable<Int32> AstPitchParent { get; set; }  
 
		public String AstPitchCode { get; set; }  
 
		public String AstPitchTitle { get; set; }  
 
		public Nullable<Int32> APMainRoot { get; set; } 
    }
}


