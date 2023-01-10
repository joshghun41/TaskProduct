﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask.DataAccess.Abstractions
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        IProductRepository ProductRepository { get; }
        IOrderDetailsRepository OrderDetailsRepository { get; }
        IOrderRepository orderRepository { get; }
        ICustomerRepository CustomerRepository { get; }
    }
}
