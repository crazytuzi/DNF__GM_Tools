using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.SuperTool.Models
{
    /// <summary>
    /// 职业树
    /// </summary>
    public class JobTreeModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// 职业Id
        /// </summary>
        public int JobId { get; set; }

        /// <summary>
        /// 职业名
        /// </summary>
        public string? JobName { get; set; }

        public List<JobTreeModel> GrowJobs { get; set; }
    }
}
