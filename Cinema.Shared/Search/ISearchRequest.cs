﻿using Cinema.Shared.Enums;
using System.Collections.Generic;

namespace Cinema.Shared.Search
{
    public interface ISearchRequest
    {
        int PageIndex { get; set; }
        int PageSize { get; set; }
        string SortColumn { get; set; }
        ICollection<string> Includes { get; set; }
        bool ReturnAll { get; set; }
        SortOrder? SortOrder { get; set; }
    }
}
