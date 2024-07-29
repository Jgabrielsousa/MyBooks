namespace MyBook.Application.Results.Dtos
{
    public  class SaleTypeDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Value { get; set; }
        public int BookId { get; set; }
    }
}
