﻿using ReCapProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetAll();

        List<Car> GetById(Car car);

    }
}
