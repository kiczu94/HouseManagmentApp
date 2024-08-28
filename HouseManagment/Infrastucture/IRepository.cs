namespace HouseManagment.Infrastucture;

public interface IRepository<T>
{
    Task<T> Get(Guid id);

    Task<IReadOnlyCollection<T>> GetAll();

    Task Delete(Guid id);

    Task Add(T entity);

    Task Update(T entity);

    Task<IReadOnlyCollection<T>> GetPaged(int pageNumber, int pageSize);
}
