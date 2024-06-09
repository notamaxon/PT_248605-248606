using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.API
{
    public interface IDataRepository
    {
        // Customer CRUD
        Task AddCustomerAsync(IUser customer);
        Task DeleteCustomerAsync(string id);
        Task<IUser> GetCustomerAsync(string id);
        Task<List<IUser>> GetAllCustomersAsync();
        Task<int> GetCustomersCountAsync();

        // Book CRUD
        Task AddBookAsync(IBook book);
        Task DeleteBookAsync(string id);
        Task<IBook> GetBookAsync(string id);
        Task<Dictionary<string, IBook>> GetAllBooksAsync();
        Task<int> GetBooksCountAsync();

        // State CRUD
        Task AddStateAsync(IState state);
        Task DeleteStateAsync(string id);
        Task<IState> GetStateAsync(string id);
        Task<List<IState>> GetAllStatesAsync();
        Task<int> GetStatesCountAsync();

        // Event CRUD
        Task AddEventAsync(IEvent eventAbstract);
        Task DeleteEventAsync(string id);
        Task<IEvent> GetEventAsync(string id);
        Task<List<IEvent>> GetAllEventsAsync();
        Task<int> GetEventsCountAsync();

        // Utils
        Task<bool> CheckIfCustomerExistsAsync(string id);
        Task<bool> CheckIfBookExistsAsync(string id);
        Task<bool> CheckIfStateExistsAsync(string id);
        Task<bool> CheckIfEventExistsAsync(string id);
    }
}
