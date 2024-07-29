namespace MyBook.Application.Results.Dtos
{
    public class AuthorDto
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<BookDto> Books { get; set; }


        public AuthorDto(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
