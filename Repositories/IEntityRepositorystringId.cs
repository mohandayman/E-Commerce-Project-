using CommonService.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonService.DatabaseLayer.Repositories
{
    public interface IEntityRepositorystringId<T> where T : class, IEntity<string>
    {
        public Task<List<T>> GetAllAsync();
        public Task<T> GetById(string id);
        public Task<List<T>> Filter(T FilteringAttrebutes);
        public Task<bool> Add(T Element);
        public Task<bool> Update(T UpdatedValue);
        public Task<bool> Delete(string ID);

    }
}
