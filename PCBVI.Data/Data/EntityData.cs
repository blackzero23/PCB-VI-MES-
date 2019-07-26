using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class EntityData<T> where T: class 
    {
        ////Get ALl
        //public List<T> GetAll()
        //{
        //    using(PcbVIEnterties context = DbContextFactory.Create())// DB컨텍스트
        //    {
        //        return context.Set<T>().ToList();
        //    }
        //}
        ////Get Count 숫자
        //public int GetCount()
        //{
        //    using(PcbVIEnterties context = new PcbVIEnterties())
        //    {
        //        return context.Set<T>().Count;
        //    }
        //}
        ////삽입
        //public void Insert(T entity)
        //{
        //    using(PcbVIEnterties context = new PcbVIEnterties())
        //    {
        //        context.Set<T>().Add(entity);
        //        context.SaveChanges();
        //    }
        //}
        ////수정
        //public void Update(T entity)
        //{
        //    using (PcbVIEnterties context = new PcbVIEnterties())
        //    {
        //        context.Entity(entity).State = EntityState.Modified;

        //        context.SaveChanges();
        //    }
        //}
        ////삭제
        //public void Delete(T entity)
        //{
        //    using(PcbViEnterties context = new PcbViEnterties())
        //    {
        //        context.Entity(entity).State = EntityState.Deleted;

        //        context.SaveCahnges();
        //    }
        //}
    }
}
