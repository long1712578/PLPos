using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos.data.Entities
{
    public class BasicEntity
    {
        public long Id { get; set; }
    }
    public interface ICreateEntity
    {
        public string CreatedId { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
    public interface IUpdateEntity
    {
        public string UpdatedId { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
