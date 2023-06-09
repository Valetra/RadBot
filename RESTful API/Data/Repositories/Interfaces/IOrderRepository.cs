﻿using RESTful_API.Data.Models;

namespace RESTful_API.Data.Repositories.Interfaces;

public interface IOrderRepository
{
    Task<List<Order>> GetAll();
    Task<Order?> Get(Guid id);
    Task<Order> Create(Order order);
    Task<Order> Update(Order order);
    Task Delete(Guid id);
}
