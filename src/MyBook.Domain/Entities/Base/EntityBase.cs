namespace MyBook.Domain.Entities.Base
{
    public abstract class EntityBase<T> where T : class
    {
        public int Id { get; set; }
    }
}
