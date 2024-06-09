using Data.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.API
{

    public interface IDataRepository
    {
        static IDataRepository CreateDatabase(IDataContext? dataContext = null)
        {
            return new DataRepository(dataContext ?? new DataContext());
        }


        // User CRUD
        Task AddUserAsync(string id, string email, string phone, string name);

        Task<IUser> GetUserAsync(string id);

        Task UpdateUserAsync(string id, string email, string phone, string name);

        Task DeleteUserAsync(string id);

        Task<Dictionary<string, IUser>> GetAllUsersAsync();

        Task<string> GetUsersCountAsync();

        // Book CRUD
        Task AddBookAsync(string id, string title, string author, BookGenres genre);

        Task<IBook> GetBookAsync(string id);

        Task UpdateBookAsync(string id, string title, string author, BookGenres genre);

        Task DeleteBookAsync(string id);

        Task<Dictionary<string, IBook>> GetAllBooksAsync();

        Task<string> GetBooksCountAsync();

        // State CRUD
        Task AddStateAsync(string id, IBook book, StateType availability);

        Task<IState> GetStateAsync(string id);

        Task UpdateStateAsync(int id, int productId, int productQuantity);

        Task DeleteStateAsync(string id);

        Task<Dictionary<string, IState>> GetAllStatesAsync();

        Task<string> GetStatesCountAsync();


        // Event CRUD
        Task AddEventAsync(string id );

        Task<IEvent> GetEventAsync(string id);

        Task UpdateEventAsync(string id, DateTime eventdate);

        Task DeleteEventAsync(string id);

        Task<Dictionary<string, IEvent>> GetAllEventsAsync();

        Task<string> GetEventsCountAsync();

        
    }
}
