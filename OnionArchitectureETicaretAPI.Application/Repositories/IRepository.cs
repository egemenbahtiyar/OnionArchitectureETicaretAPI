using Microsoft.EntityFrameworkCore;
using OnionArchitectureETicaretAPI.Domain.Entities.Common;

namespace OnionArchitectureETicaretAPI.Application.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    DbSet<T> Table { get; }
}