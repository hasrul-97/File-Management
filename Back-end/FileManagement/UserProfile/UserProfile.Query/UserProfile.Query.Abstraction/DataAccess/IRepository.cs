using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserProfile.Query.Abstraction.DataAccess
{
    public interface IRepository
    {
        public Task<int> AddToDatabase(string sqlQuery);
        public Task<List<T>> FetchList<T>(string sqlQuery);
        public Task<int> Update(string sqlQuery);
        public Task<int> Delete(string sqlQuery);
        public Task<int> AddToDatabaseWithParameter(string sqlQuery, object parameter);
        public Task<List<T>> FetchListWithParameter<T>(string sqlQuery, object parameter);
        public Task<int> UpdateWithParameter(string sqlQuery, object parameter);
        public Task<int> DeleteWithParameter(string sqlQuery, object parameter);
    }
}
