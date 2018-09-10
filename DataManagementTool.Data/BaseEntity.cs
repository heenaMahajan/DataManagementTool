using System;

namespace DataManagementTool.Data
{
    public class BaseEntity
    {
        public Int64 Id { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
