using Data.API;
using Data.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Implementation
{
    internal class DataContext : IDataContext
    {
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

        private readonly string _connectionString;

        #region User CRUD

        public async Task AddUserAsync(IUser user)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var entity = new Database.User()
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email,
                    Phone = user.Phone,
                };

                context.Users.InsertOnSubmit(entity);
                await Task.Run(() => context.SubmitChanges());
            }
        }

        public async Task<IUser> GetUserAsync(string id)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var user = await Task.Run(() => context.Users.FirstOrDefault(u => u.Id == id));
                return user is not null ? new User(user.Name, user.Email, user.Phone) { Id = user.Id } : null;
            }
        }

        public async Task UpdateUserAsync(IUser user)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var toUpdate = context.Users.FirstOrDefault(u => u.Id == user.Id);
                if (toUpdate is not null)
                {
                    toUpdate.Name = user.Name;
                    toUpdate.Email = user.Email;
                    toUpdate.Phone = user.Phone;
                    await Task.Run(() => context.SubmitChanges());
                }
            }
        }

        public async Task DeleteUserAsync(string id)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var toDelete = context.Users.FirstOrDefault(u => u.Id == id);
                if (toDelete is not null)
                {
                    context.Users.DeleteOnSubmit(toDelete);
                    await Task.Run(() => context.SubmitChanges());
                }
            }
        }

        public async Task<Dictionary<string, IUser>> GetAllUsersAsync()
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var usersQuery = from u in context.Users
                                 select new User(u.Name, u.Email, u.Phone) { Id = u.Id } as IUser;

                return await Task.Run(() => usersQuery.ToDictionary(k => k.Id));
            }
        }

        public async Task<string> GetUsersCountAsync()
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                return await Task.Run(() => context.Users.Count().ToString());
            }
        }

        #endregion User CRUD


        #region Book CRUD

        public async Task AddBookAsync(IBook book)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var entity = new Database.Book()
                {
                    Id = book.Id,
                    Title = book.Title,
                    Author = book.Author,
                    Genre = (int)book.Genre,
                };

                context.Books.InsertOnSubmit(entity);
                await Task.Run(() => context.SubmitChanges());
            }
        }

        public async Task<IBook> GetBookAsync(string id)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var book = await Task.Run(() => context.Books.FirstOrDefault(b => b.Id == id));
                return book is not null ? new Book(book.Title, book.Author, (API.BookGenres)book.Genre) { Id = book.Id } : null;
            }
        }

        public async Task UpdateBookAsync(IBook book)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var toUpdate = context.Books.FirstOrDefault(b => b.Id == book.Id);
                if (toUpdate is not null)
                {
                    toUpdate.Title = book.Title;
                    toUpdate.Author = book.Author;
                    toUpdate.Genre = (int)book.Genre;
                    await Task.Run(() => context.SubmitChanges());
                }
            }
        }

        public async Task DeleteBookAsync(string id)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var toDelete = context.Books.FirstOrDefault(b => b.Id == id);
                if (toDelete is not null)
                {
                    context.Books.DeleteOnSubmit(toDelete);
                    await Task.Run(() => context.SubmitChanges());
                }
            }
        }

        public async Task<Dictionary<string, IBook>> GetAllBooksAsync()
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var booksQuery = from b in context.Books
                                 select new Book(b.Title, b.Author, (API.BookGenres)b.Genre) { Id = b.Id } as IBook;

                return await Task.Run(() => booksQuery.ToDictionary(k => k.Id));
            }
        }

        public async Task<string> GetBooksCountAsync()
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                return await Task.Run(() => context.Books.Count().ToString());
            }
        }

        #endregion Book CRUD


        #region State CRUD

        public async Task AddStateAsync(IState state)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var entity = new Database.State()
                {
                    Id = state.Id,
                    Date = state.Date,
                    BookId = state.Book.Id,
                    Availability = (int)state.Availability,
                };

                context.States.InsertOnSubmit(entity);
                await Task.Run(() => context.SubmitChanges());
            }
        }

        public async Task<IState> GetStateAsync(string id)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var state = await Task.Run(() => context.States.FirstOrDefault(s => s.Id == id));
                if (state != null)
                {
                    var book = await GetBookAsync(state.BookId);
                    return new State(book, (API.StateType)state.Availability) { Id = state.Id, Date = state.Date };
                }
                return null;
            }
        }

        public async Task UpdateStateAsync(IState state)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var toUpdate = context.States.FirstOrDefault(s => s.Id == state.Id);
                if (toUpdate != null)
                {
                    toUpdate.Date = state.Date;
                    toUpdate.BookId = state.Book.Id;
                    toUpdate.Availability = (int)state.Availability;
                    await Task.Run(() => context.SubmitChanges());
                }
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

        public async Task<Dictionary<string, IState>> GetAllStatesAsync()
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var statesQuery = from s in context.States
                                  let book = GetBookAsync(s.BookId).Result
                                  select new State(book, (API.StateType)s.Availability) { Id = s.Id, Date = s.Date } as IState;

                return await Task.Run(() => statesQuery.ToDictionary(k => k.Id));
            }
        }

        public async Task<string> GetStatesCountAsync()
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                return await Task.Run(() => context.States.Count().ToString());
            }
        }

        #endregion State CRUD


        #region Event CRUD

        public async Task AddEventAsync(IEvent even)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var entity = new Database.Event()
                {
                    Id = even.Id,
                    EventDate = even.EventDate,
                    StateId = even.State.Id,
                    CustomerId = even.Customer.Id,
                };

                context.Events.InsertOnSubmit(entity);
                await Task.Run(() => context.SubmitChanges());
            }
        }

        public async Task<IEvent> GetEventAsync(string id)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var even = await Task.Run(() => context.Events.FirstOrDefault(e => e.Id == id));
                if (even != null)
                {
                    var state = await GetStateAsync(even.StateId);
                    var customer = await GetUserAsync(even.CustomerId);
                    return new Event(state) { Id = even.Id, EventDate = even.EventDate, Customer = customer };
                }
                return null;
            }
        }

        public async Task UpdateEventAsync(IEvent even)
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var toUpdate = context.Events.FirstOrDefault(e => e.Id == even.Id);
                if (toUpdate != null)
                {
                    toUpdate.EventDate = even.EventDate;
                    toUpdate.StateId = even.State.Id;
                    toUpdate.CustomerId = even.Customer.Id;
                    await Task.Run(() => context.SubmitChanges());
                }
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

        public async Task<Dictionary<string, IEvent>> GetAllEventsAsync()
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                var eventsQuery = from e in context.Events
                                  let state = GetStateAsync(e.StateId).Result
                                  let customer = GetUserAsync(e.CustomerId).Result
                                  select new Event(state) { Id = e.Id, EventDate = e.EventDate, Customer = customer } as IEvent;

                return await Task.Run(() => eventsQuery.ToDictionary(k => k.Id));
            }
        }

        public async Task<string> GetEventsCountAsync()
        {
            using (DatabaseDataContext context = new DatabaseDataContext(_connectionString))
            {
                return await Task.Run(() => context.Events.Count().ToString());
            }
        }

        #endregion Event CRUD


        #region Utils

        public async Task<bool> CheckIfUserExistsAsync(string id)
        {
            return (await GetUserAsync(id)) != null;
        }

        public async Task<bool> CheckIfBookExistsAsync(string id)
        {
            return (await GetBookAsync(id)) != null;
        }

        public async Task<bool> CheckIfStateExistsAsync(string id)
        {
            return (await GetStateAsync(id)) != null;
        }

        public async Task<bool> CheckIfEventExistsAsync(string id)
        {
            return (await GetEventAsync(id)) != null;
        }

        #endregion Utils
    }
}
