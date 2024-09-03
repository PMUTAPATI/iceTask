using Azure.Data.Tables;
using iceTask.Models;

namespace iceTask.Services
{
    public class TableStorageService
    {
        private readonly TableServiceClient _tableServiceClient;
        private readonly string _tableName = "TreasureSubmissions";

        public TableStorageService(string connectionString)
        {
            _tableServiceClient = new TableServiceClient(connectionString);
            _tableServiceClient.CreateTableIfNotExists(_tableName);
        }

        public async Task GetAllTreasureSubmissionAsync(TreasureSubmission submission)
        {
            var tableClient = _tableServiceClient.GetTableClient(_tableName);
            await tableClient.AddEntityAsync(submission);
        }

        public async Task<List<TreasureSubmission>> GetAllTreasureSubmissionAsync()
        {
            var tableClient = _tableServiceClient.GetTableClient(_tableName);
            var results = new List<TreasureSubmission>();

            await foreach (var entity in tableClient.QueryAsync<TreasureSubmission>())
            {
                results.Add(entity);
            }

            return results;
        }
    
}
}
