﻿using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.Author.Create
{
    public class CreateAuthorCommand : Command<CreateAuthorCommand>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CreateAuthorCommand()
        {
                
        }

        public CreateAuthorCommand(string name)
        {
            Name = name;
        }
    }
}
