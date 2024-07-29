using MyBook.Application.Results.Dtos;

namespace MyBook.Api.Models
{
    public class SalteType

    {
        public string Description { get; set; }
        public float Value { get; set; }
        public int BookId { get; set; }

        public static implicit operator SaleTypeDto(SalteType salesType)
        {

            return new SaleTypeDto() { Description = salesType.Description,  Value = salesType.Value , BookId = salesType .BookId};
 ;
        }
    }
}
