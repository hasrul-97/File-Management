using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProfile.Query.Abstraction.DataAccess;

namespace UserProfile.Query.DataAccess
{
    public class Repository : IRepository
    {
        private static string _connectionString = "";
        private static IDbConnection _sqlConnection;

        public Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("connectionString");
            _sqlConnection = new SqlConnection(_connectionString);
        }
        public async Task<int> AddToDatabase(string sqlQuery)
        {
            _sqlConnection.Open();
            try
            {
                int numberOfRowsAffected = await _sqlConnection.ExecuteAsync(sqlQuery);
                return numberOfRowsAffected;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }

        public async Task<int> AddToDatabaseWithParameter(string sqlQuery, object parameter)
        {
            _sqlConnection.Open();
            try
            {
                int numberOfRowsAffected = await _sqlConnection.ExecuteAsync(sqlQuery, parameter);
                return numberOfRowsAffected;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }

        public async Task<int> Delete(string sqlQuery)
        {
            _sqlConnection.Open();
            try
            {
                int numberOfRowsAffected = await _sqlConnection.ExecuteAsync(sqlQuery);
                return numberOfRowsAffected;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }

        public async Task<int> DeleteWithParameter(string sqlQuery, object parameter)
        {
            _sqlConnection.Open();
            try
            {
                int numberOfRowsAffected = await _sqlConnection.ExecuteAsync(sqlQuery, parameter);
                return numberOfRowsAffected;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }

        public async Task<List<T>> FetchList<T>(string sqlQuery)
        {
            _sqlConnection.Open();
            try
            {
                List<T> result = (await _sqlConnection.QueryAsync<T>(sqlQuery)).ToList();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }

        public async Task<List<T>> FetchListWithParameter<T>(string sqlQuery, object parameter)
        {
            _sqlConnection.Open();
            try
            {
                List<T> result = (await _sqlConnection.QueryAsync<T>(sqlQuery, parameter)).ToList();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }

        public async Task<int> Update(string sqlQuery)
        {
            _sqlConnection.Open();
            try
            {
                int numberOfRowsAffected = await _sqlConnection.ExecuteAsync(sqlQuery);
                return numberOfRowsAffected;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }

        public async Task<int> UpdateWithParameter(string sqlQuery, object parameter)
        {
            _sqlConnection.Open();
            try
            {
                int numberOfRowsAffected = await _sqlConnection.ExecuteAsync(sqlQuery, parameter);
                return numberOfRowsAffected;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }
    }
}
