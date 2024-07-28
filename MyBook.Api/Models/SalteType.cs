using MyBook.Application.Results.Dtos;

namespace MyBook.Api.Models
{
    public class SalteType

    {
        public string Description { get; set; }
        public float Value { get; set; }
        public static implicit operator SalteTypeDto(SalteType salesType)
        {

            return new SalteTypeDto() { Description = salesType.Description,  Value = salesType.Value };
 ;
        }
    }
}
