using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class PaginationHeader
    {

        public PaginationHeader(int currentPage, int itemPerPage, int totalItems, int totalPages)
        {
            TotalPages = totalPages;
            TotalItems = totalItems;
            ItemsPerPage = itemPerPage;
            CurrentPage = currentPage;
        }

        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
    }
}