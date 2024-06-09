using Data.API;
using Data.Database;
using Data.Implementations; 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Implementation
{
    internal class DataContext : IDataContext
    {
        private readonly string _connectionString;

        public DataContext(string? connectionString = null)
        {
            if (connectionString is null)
            {
                string _projectRootDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
                string _DBRelativePath = @"Data\Database\Database.mdf";
                string _DBPath = Path.Combine(_projectRootDir, _DBRelativePath);
                _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={_DBPath};Integrated Security=True;Connect Timeout=30;";
            }
            else
            {
                _connectionString = connectionString;
            }
        }

        #region Customer CRUD

        public async Task AddCustomerAsync(IUser customer)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                Database.User entity = new Database.User()
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    Email = customer.Email,
                    Phone = customer.Phone
                };

                context.Users.InsertOnSubmit(entity);

                await Task.Run(() => context.SubmitChanges());
            }
        }

        public async Task DeleteCustomerAsync(string id)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var toDelete = context.Users.FirstOrDefault(u => u.Id == id);

                if (toDelete != null)
                {
                    context.Users.DeleteOnSubmit(toDelete);
                    await Task.Run(() => context.SubmitChanges());
                }
            }
        }

        public async Task<IUser?> GetCustomerAsync(string id)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var user = await Task.Run(() => context.Users.FirstOrDefault(u => u.Id == id));
                return user is not null ? new Implementations.User(user.Name, user.Email, user.Phone) { Id = user.Id } : null;
            }
        }

        public async Task<List<IUser>> GetAllCustomersAsync()
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var users = await Task.Run(() => context.Users.Select(u => new Implementations.User(u.Name, u.Email, u.Phone) { Id = u.Id }).ToList());
                return users.Cast<IUser>().ToList();
            }
        }

        public async Task<int> GetCustomersCountAsync()
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                return await Task.Run(() => context.Users.Count());
            }
        }

        #endregion Customer CRUD

        #region Book CRUD

        public async Task AddBookAsync(IBook book)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                Database.Book entity = new Database.Book()
                {
                    Id = book.Id,
                    Title = book.Title,
                    Author = book.Author,
                    Genre = (int)book.Genre
                };

                context.Books.InsertOnSubmit(entity);

                await Task.Run(() => context.SubmitChanges());
            }
        }

        public async Task DeleteBookAsync(string id)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var toDelete = context.Books.FirstOrDefault(b => b.Id == id);

                if (toDelete != null)
                {
                    context.Books.DeleteOnSubmit(toDelete);
                    await Task.Run(() => context.SubmitChanges());
                }
            }
        }

        public async Task<IBook?> GetBookAsync(string id)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var book = await Task.Run(() => context.Books.FirstOrDefault(b => b.Id == id));
                return book is not null ? new Implementations.Book(book.Title, book.Author, (API.BookGenres)book.Genre) { Id = book.Id } : null;
            }
        }

        public async Task<Dictionary<string, IBook>> GetAllBooksAsync()
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var books = await Task.Run(() => context.Books.Select(b => new Implementations.Book(b.Title, b.Author, (API.BookGenres)b.Genre) { Id = b.Id }).ToList());
                return books.Cast<IBook>().ToDictionary(b => b.Id);
            }
        }

        public async Task<int> GetBooksCountAsync()
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                return await Task.Run(() => context.Books.Count());
            }
        }

        #endregion Book CRUD

        #region State CRUD

        public async Task AddStateAsync(IState state)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                Database.State entity = new Database.State()
                {
                    Id = state.Id,
                    Date = state.Date,
                    BookId = state.Book.Id,
                    Availability = (int)state.Availability
                };

                context.States.InsertOnSubmit(entity);

                await Task.Run(() => context.SubmitChanges());
            }
        }

        public async Task DeleteStateAsync(string id)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var toDelete = context.States.FirstOrDefault(s => s.Id == id);

                if (toDelete != null)
                {
                    context.States.DeleteOnSubmit(toDelete);
                    await Task.Run(() => context.SubmitChanges());
                }
            }
        }

        public async Task<IState?> GetStateAsync(string id)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var state = await Task.Run(() => context.States.FirstOrDefault(s => s.Id == id));
                return state is not null ? new Implementations.State(new Implementations.Book() { Id = state.BookId }, (API.StateType)state.Availability) { Id = state.Id, Date = state.Date } : null;
            }
        }

        public async Task<List<IState>> GetAllStatesAsync()
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var states = await Task.Run(() => context.States.Select(s => new Implementations.State(new Implementations.Book() { Id = s.BookId }, (API.StateType)s.Availability) { Id = s.Id, Date = s.Date }).ToList());
                return states.Cast<IState>().ToList();
            }
        }

        public async Task<int> GetStatesCountAsync()
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                return await Task.Run(() => context.States.Count());
            }
        }

        #endregion State CRUD

        #region Event CRUD

        public async Task AddEventAsync(IEvent eventAbstract)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                Database.Event entity = new Database.Event()
                {
                    Id = eventAbstract.Id,
                    EventDate = eventAbstract.EventDate,
                    StateId = eventAbstract.State.Id,
                    CustomerId = eventAbstract.Customer.Id
                };

                context.Events.InsertOnSubmit(entity);

                await Task.Run(() => context.SubmitChanges());
            }
        }

        public async Task DeleteEventAsync(string id)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var toDelete = context.Events.FirstOrDefault(e => e.Id == id);

                if (toDelete != null)
                {
                    context.Events.DeleteOnSubmit(toDelete);
                    await Task.Run(() => context.SubmitChanges());
                }
            }
        }

        public async Task<IEvent?> GetEventAsync(string id)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var even = await Task.Run(() => context.Events.FirstOrDefault(e => e.Id == id));
                return even is not null ? new Implementations.Event(
                    new Implementations.State(
                        new Implementations.Book() { Id = even.StateId },
                        API.StateType.Unknown
                    )
                    { Id = even.StateId }
                )
                { Id = even.Id, EventDate = even.EventDate } : null;
            }
        }

        public async Task<List<IEvent>> GetAllEventsAsync()
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var events = await Task.Run(() => context.Events.Select(e => new Implementations.Event(new Implementations.State(new Implementations.Book() { Id = e.StateId },API.StateType.Unknown)
    { Id = e.StateId }
)
                { Id = e.Id, EventDate = e.EventDate }).ToList()); return events.Cast<IEvent>().ToList();
            }
        }

        public async Task<int> GetEventsCountAsync()
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                return await Task.Run(() => context.Events.Count());
            }
        }

        #endregion Event CRUD
    }
}
