﻿namespace MyBook.Domain.Interfaces.Base
{
    public interface IRepositoryBase<T> : IDisposable
    {
        T Add(T entidade);

        void Remove(T entidade);

        T Find(int Id);

        IEnumerable<T> GetAll();

        void Update(T entidade);

        new void Dispose();
    }
}
