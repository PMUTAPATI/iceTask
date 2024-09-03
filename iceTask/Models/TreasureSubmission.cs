using Azure;
using Azure.Data.Tables;
using System.ComponentModel.DataAnnotations;

namespace iceTask.Models
{
    public class TreasureSubmission : ITableEntity
    {
        [Key]
        public int TreasureSubmissionId { get; set; }   
        public string? TreasureSubmissionName { get; set; }
        public string? TreasureSubmissionDescription { get; set; }
        public string? TreasureFindings { get; set; }
        public DateTime Timestamp { get; set; }


        public string? PartitionKey { get; set; }
        public string? Rowkey { get; set; }
        public ETag ETag { get; set; }
        public DateTimeOffset? TimestampOffset { get; set; }

    }
}
