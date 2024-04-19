using DoctorsHelp.Application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace SearchingTours.Infrastructure.Persistence.Repositories;

public abstract class BaseRepository<TEntity, TModel>
    where TEntity : IEntity
    where TModel : class, IEntity
{
    private readonly DbContext _context;

    protected DbContext Context => _context;

    protected BaseRepository(DbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    protected abstract DbSet<TModel> DbSet { get; }

    public virtual void Add(TEntity entity)
    {
        if (entity is null) 
            throw new ArgumentNullException(nameof(entity));

        TModel model = MapFrom(entity);
        DbSet.Add(model);
        _context.SaveChanges();
    }

    public virtual void AddRange(IEnumerable<TEntity> entities)
    {
        if (entities is null) 
            throw new ArgumentNullException(nameof(entities));

        var models = entities.Select(MapFrom).ToList(); 
        DbSet.AddRange(models);
        _context.SaveChanges();
    }

    public virtual void Update(TEntity entity)
    {
        if (entity is null) 
            throw new ArgumentNullException(nameof(entity));

        var entry = GetEntry(entity);
        if (entry is null)
        {
            throw new InvalidOperationException("Entity not found.");
        }

        UpdateModel(entry.Entity, entity);
        entry.State = EntityState.Modified;
        _context.SaveChanges();
    }

    public virtual void Remove(TEntity entity)
    {
        if (entity is null) 
            throw new ArgumentNullException(nameof(entity));

        var entry = GetEntry(entity);
        if (entry is null)
        {
            throw new InvalidOperationException("Entity not found.");
        }

        entry.State = entry.State == EntityState.Added ? EntityState.Detached : EntityState.Deleted;
        _context.SaveChanges();
    }

    protected abstract TModel MapFrom(TEntity entity);
    
    protected abstract bool Equal(TEntity entity, TModel model);

    protected abstract void UpdateModel(TModel model, TEntity entity);

    protected EntityEntry<TModel>? GetEntry(TEntity entity)
    {
        TModel? existing = DbSet.Find(entity.Id); 

        return existing != null ? _context.Entry(existing) : null;
    }
}
