﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask.DataAccess.Abstractions
{
    public interface IOrderRepository<T>
    {
        T GetData(int id);
        IEnumerable<T> GetAllData();
        void AddData(T data);
        void UpdateData(T data);
        void DeleteData(T data);
    }
}
