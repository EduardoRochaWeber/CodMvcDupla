using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppMvcDupla.Models;

namespace WebAppMvcDupla.Repository
{
    public class BaseRepository<T> where T: BaseModel
    {
        private static List<T> list = new List<T>();

        public void Create(T model)
        {
            list.Add(model);
        }
        public List<T> Read()
        {
            return list;
        }
        public T Read(int id)
        {
            return list.Find(a => a.Id == id);
        }
        public void Update(T model)
        {
            int index = list.FindIndex(a => a.Id == model.Id);
            if (index != -1)
            {
                list[index] = model;
            }
        }
        public void Delete(int id)
        {
            list.Remove(Read(id));
        }
    }
}