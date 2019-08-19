using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class EntityData<T> where T: class 
    {
        //Get ALl
        public List<T> GetAll()
        {
            using (PCBVIEntities context = DbContextFactory.Create())// DB컨텍스트
            {
                return context.Set<T>().ToList();
            }
        }
        //Get Count 숫자
        public int GetCount()
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {
                return context.Set<T>().Count();
            }
        }
        //등록
        public void Insert(T entity)
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        //리스트 등록

        public void InsertALL(List<T> entiList)
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {
                entiList.ForEach(n=> context.Set<T>().Add(n));
                context.SaveChanges();
                // companies.ForEach(n => context.AddToCompanies(n));
            }
        }
        //수정
        public void Update(T entity)
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {
                context.Entry(entity).State = EntityState.Modified;
               
                context.SaveChanges();
            }
        }
        //삭제
        public void Delete(T entity)
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {
                context.Entry(entity).State = EntityState.Deleted;

                context.SaveChanges();
            }
        }
    }
}
