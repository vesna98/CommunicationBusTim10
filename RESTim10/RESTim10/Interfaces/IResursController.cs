﻿using RESTim10.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTim10.Interfaces
{
   public interface IResursController
    {
        List<Resurs> GetAll();
        Resurs GetOne(string zahtev);
        bool Insert(string zahtev);
        bool Update(string zahtev);
        bool Delete(string zahtev);
        void SaveChanges();
    }
}
