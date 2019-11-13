using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CashDesk{
    /// <inheritdoc />
    public class DataAccess : IDataAccess{

        CashDeskContext context = null;
        /// <inheritdoc />

        public Task InitializeDatabaseAsync(){ 
            if(context == null){
                context = new CashDeskContext();
            }else{
                throw new InvalidOperationException("Method has already been called");
            }

            return Task.CompletedTask;
        }

        /// <inheritdoc />
        public Task<int> AddMemberAsync(string firstName, string lastName, DateTime birthday)
             => throw new NotImplementedException();

        /// <inheritdoc />
        public Task DeleteMemberAsync(int memberNumber) => throw new NotImplementedException();

        /// <inheritdoc />
        public Task<IMembership> JoinMemberAsync(int memberNumber) => throw new NotImplementedException();

        /// <inheritdoc />
        public Task<IMembership> CancelMembershipAsync(int memberNumber) => throw new NotImplementedException();

        /// <inheritdoc />
        public Task DepositAsync(int memberNumber, decimal amount) => throw new NotImplementedException();

        /// <inheritdoc />
        public Task<IEnumerable<IDepositStatistics>> GetDepositStatisticsAsync() 
            => throw new NotImplementedException();

        /// <inheritdoc />
        public void Dispose() => throw new NotImplementedException();
    }
}
