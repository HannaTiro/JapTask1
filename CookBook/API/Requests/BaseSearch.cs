using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Requests
{
    public class BaseSearch
    {
        public BaseSearch()
        {
            Includes = new List<string>();
        }
        public int? PageSize { get; set; }
        public int? Page { get; set; }
        public bool? RetriveAll { get; set; }
        public bool? IncludeCount { get; set; }
        public string SortBy { get; set; }
        public SortOrder SortOrder { get; set; }
        public IList<string> Includes { get; set; }
    }
}
