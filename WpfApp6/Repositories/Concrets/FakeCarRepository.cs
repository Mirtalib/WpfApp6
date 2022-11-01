﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp6.Models;
using WpfApp6.Repositories.Abstract;
using WpfApp6.Repositories.Contexts;

namespace WpfApp6.Repositories.Concrets
{
    internal class FakeCarRepository : ICarRepository
    {
        public void Add(Car entity)
            =>FakeDbContext.Cars?.Add(entity);
        

        public Car? Get(Func<Car, bool> predicate)
            =>FakeDbContext.Cars?.FirstOrDefault(predicate);

        public List<Car>? GetList(Func<Car, bool>? predicate = null)
        => (predicate is null) switch
        {
            true => FakeDbContext.Cars,
            false => FakeDbContext.Cars?.Where(predicate).ToList(),
        };

        public void Remove(Car entity)
            =>FakeDbContext.Cars?.Remove(entity);
        

        public void Update(Car entity)
        {
            var index = FakeDbContext.Cars.IndexOf(entity);

            FakeDbContext.Cars[index] = entity;
        }
    }
}
