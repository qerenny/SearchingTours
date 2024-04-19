using Microsoft.EntityFrameworkCore;
using SearchingTours.Application.Models;
using SearchingTours.Infrastructure.Persistence.Contexts;
using SearchingTours.Infrastructure.Persistence.Entity;
using SearchingTours.Infrastructure.Persistence.Repositories.Interfaces;


namespace SearchingTours.Infrastructure.Persistence.Repositories;

public class UserRepository : BaseRepository<UserEntity, UserModel>, IUserRepository
{
    public UserRepository(DbContext context) : base(context)
    {
    }

    protected override DbSet<UserModel> DbSet => ((ApplicationDbContext)Context).Users;

    public UserModel? GetUser(Guid id)
    {
        return GetEntry(new UserEntity { Id = id })?.Entity;
    }

    public void AddUser(UserEntity user)
    {
        Add(user);
    }

    public void UpdateUser(UserEntity user)
    {
        Update(user);
    }

    public bool DeleteUser(UserEntity user)
    {
        Remove(user);
        return true; // Возвращает true, предполагая успешное удаление, но на практике следует проверить статус операции.
    }

    protected override UserModel MapFrom(UserEntity entity)
    {
        return new UserModel
        {
            Id = entity.Id,
            Username = entity.Username,
            Email = entity.Email,
            Password = entity.Password,
            City = entity.City,
            Phone = entity.Phone,
        };
    }

    protected override bool Equal(UserEntity entity, UserModel model)
    {
        return entity.Id == model.Id;
    }

    protected override void UpdateModel(UserModel model, UserEntity entity)
    {
        model.Username = entity.Username;
        model.Email = entity.Email;
        model.Password = entity.Password;
        model.City = entity.City;
        model.Phone = entity.Phone;
    }
}
