﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();
    }
}
