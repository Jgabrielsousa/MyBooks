namespace MyBook.Application.Results.Dtos
{
    public  class BookDto
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public string PublishingCompany { get; set; }
        public int Edition { get; set; }
        public string PublicationDate { get; set; }
        public IEnumerable<SubjectDto> Subjects { get; set; }
        public BookDto()
        {
                
        }
    }
}
