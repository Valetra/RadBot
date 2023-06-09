﻿using RESTful_API.Data.Models.Base;
namespace RESTful_API.Data.Repositories.Interfaces;

public interface IBaseRepository<TDbModel> where TDbModel : BaseModel
{
    Task<List<TDbModel>> GetAll();
    Task<TDbModel?> Get(Guid id);
    Task<TDbModel> Create(TDbModel model);
    Task<TDbModel> Update(TDbModel model);
    Task Delete(Guid id);
}
