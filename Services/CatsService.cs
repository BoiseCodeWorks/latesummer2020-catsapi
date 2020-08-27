using System;
using System.Collections;
using System.Collections.Generic;
using catsAPI.DB;
using catsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace catsAPI.Services
{
    public class CatsService
    {
        public IEnumerable<Cat> GetCats()
        {
            return FakeDB.Cats;
        }

        public Cat GetById(string id)
        {
            Cat foundCat = FakeDB.Cats.Find(cat => cat.Id == id);
            if (foundCat != null)
            {
                return foundCat;
            }
            throw new Exception("Opps no cat by that Id");
        }

        internal object Create(Cat newCat)
        {
            FakeDB.Cats.Add(newCat);
            return newCat;
        }
    }
}