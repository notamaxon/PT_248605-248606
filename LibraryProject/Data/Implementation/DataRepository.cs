using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.API;

namespace Data.Implementation
{
    internal class DataRepository : IDataRepository
    {
        private readonly IDataContext _context;

        public DataRepository(IDataContext context)
        {
            _context = context;
        }

        #region User CRUD

        public async Task AddUserAsync(string id, string email, string phone, string name)
        {
            IUser user = new User(name, email, phone) { Id = id };
            await _context.AddUserAsync(user);
        }

        public async Task<IUser> GetUserAsync(string id)
        {
            IUser? user = await _context.GetUserAsync(id);

            if (user is null)
                throw new Exception("This user does not exist!");

            return user;
        }

        public async Task UpdateUserAsync(string id, string email, string phone, string name)
        {
            IUser user = new User(name, email, phone) { Id = id };

            if (!await _context.CheckIfUserExistsAsync(user.Id))
                throw new Exception("This user does not exist");

            await _context.UpdateUserAsync(user);
        }

        public async Task DeleteUserAsync(string id)
        {
            if (!await _context.CheckIfUserExistsAsync(id))
                throw new Exception("This user does not exist");

            await _context.DeleteUserAsync(id);
        }

        public async Task<Dictionary<string, IUser>> GetAllUsersAsync()
        {
            return await _context.GetAllUsersAsync();
        }

        public async Task<string> GetUsersCountAsync()
        {
            return await _context.GetUsersCountAsync();
        }

        #endregion User CRUD

        #region Book CRUD

        public async Task AddBookAsync(string id, string title, string author, string genre)
        {
            IBook book = new Book(title, author, genre.ToString()) { Id = id };
            await _context.AddBookAsync(book);
        }

        public async Task<IBook> GetBookAsync(string id)
        {
            IBook? book = await _context.GetBookAsync(id);

            if (book is null)
                throw new Exception("This book does not exist!");

            return book;
        }

        public async Task UpdateBookAsync(string id, string title, string author, string genre)
        {
            IBook book = new Book(title, author, genre.ToString()) { Id = id };

            if (!await _context.CheckIfBookExistsAsync(book.Id))
                throw new Exception("This book does not exist");

            await _context.UpdateBookAsync(book);
        }

        public async Task DeleteBookAsync(string id)
        {
            if (!await _context.CheckIfBookExistsAsync(id))
                throw new Exception("This book does not exist");

            await _context.DeleteBookAsync(id);
        }

        public async Task<Dictionary<string, IBook>> GetAllBooksAsync()
        {
            return await _context.GetAllBooksAsync();
        }

        public async Task<string> GetBooksCountAsync()
        {
            return await _context.GetBooksCountAsync();
        }

        #endregion Book CRUD

        #region State CRUD

        public async Task AddStateAsync(string id, IBook book, bool availability)
        {
            if (!await _context.CheckIfBookExistsAsync(book.Id))
                throw new Exception("This book does not exist!");

            IState state = new State(book.Id, availability == true) { Id = id };
            await _context.AddStateAsync(state);
        }

        public async Task<IState> GetStateAsync(string id)
        {
            IState? state = await _context.GetStateAsync(id);

            if (state is null)
                throw new Exception("This state does not exist!");

            return state;
        }

        public async Task UpdateStateAsync(string id, IBook book, bool availability)
        {
            if (!await _context.CheckIfBookExistsAsync(book.Id))
                throw new Exception("This book does not exist!");

            IState state = new State(book.Id, availability == true) { Id = id };

            if (!await _context.CheckIfStateExistsAsync(state.Id))
                throw new Exception("This state does not exist");

            await _context.UpdateStateAsync(state);
        }

        public async Task DeleteStateAsync(string id)
        {
            if (!await _context.CheckIfStateExistsAsync(id))
                throw new Exception("This state does not exist");

            await _context.DeleteStateAsync(id);
        }

        public async Task<Dictionary<string, IState>> GetAllStatesAsync()
        {
            return await _context.GetAllStatesAsync();
        }

        public async Task<string> GetStatesCountAsync()
        {
            return await _context.GetStatesCountAsync();
        }

        #endregion State CRUD

        #region Event CRUD

        public async Task AddEventAsync(string id)
        {
            throw new NotImplementedException("This method is not implemented yet.");
        }

        public async Task<IEvent> GetEventAsync(string id)
        {
            IEvent? even = await _context.GetEventAsync(id);

            if (even is null)
                throw new Exception("This event does not exist!");

            return even;
        }

        public async Task UpdateEventAsync(string id, DateTime eventDate)
        {
            throw new NotImplementedException("This method is not implemented yet.");
        }

        public async Task DeleteEventAsync(string id)
        {
            if (!await _context.CheckIfEventExistsAsync(id))
                throw new Exception("This event does not exist");

            await _context.DeleteEventAsync(id);
        }

        public async Task<Dictionary<string, IEvent>> GetAllEventsAsync()
        {
            return await _context.GetAllEventsAsync();
        }

        public async Task<string> GetEventsCountAsync()
        {
            return await _context.GetEventsCountAsync();
        }

        #endregion Event CRUD

    }
}
