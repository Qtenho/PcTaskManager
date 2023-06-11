using TaskManager.Shared.Models;

namespace TaskManager.Fronted.Repository
{
    public interface IRepository
    {
        Task<Response<T>> GetAsync<T>(string url);
    }
}
