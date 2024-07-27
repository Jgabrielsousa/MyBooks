namespace MyBook.Application.UseCases.Author.Create
{
    public  class CreateAuthorDto
    {

        public int Id { get; set; }
        public string Name { get; set; }


        public CreateAuthorDto(int id, string name)
        {
            Id = id;
            Name = name;
        }

   


    }
}
