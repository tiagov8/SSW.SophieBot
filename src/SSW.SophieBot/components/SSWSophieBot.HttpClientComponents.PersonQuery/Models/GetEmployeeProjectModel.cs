﻿namespace SSWSophieBot.HttpClientAction.Models
{
    public class GetEmployeeProjectModel
    {
        public string ProjectId { get; set; }
        public string CrmProjectId { get; set; }
        public string CrmClientId { get; set; }
        public string ProjectName { get; set; }
        public string CustomerName { get; set; }
        public double BillableHours { get; set; }
    }
}
