using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class SystemActivity
    {
        public int Id { get; set; }
        public string ActionName { get; set; }
        public DateTime ActionDate { get; set; }
        public int functionId { get; set; }
        public int UserId { get; set; }
        public string ClientIP { get; set; }


    }
}
