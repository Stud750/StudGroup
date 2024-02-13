namespace DataModels.Repositories;

public interface IBaseRepository<T> where T : class
{
    #region Read
    /// <summary>
    /// Перечисляет все сущности
    /// </summary>
    IList<T> Items { get; }

    /// <summary>
    /// ищет сущность по индексу
    /// </summary>
    /// <param name="id">индекс</param>
    /// <returns>сущность</returns>
    T? GetItemById(Guid id);
    #endregion

    #region Create Update
    /// <summary>
    /// Обновляет или создаёт новую сущность
    /// </summary>
    /// <param name="item">сущность</param>
    void Update(T item);
    #endregion
}