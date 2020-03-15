﻿using DSM.UI.Api.Models.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DSM.UI.Api.Models.Server
{
    public class Server
    {
        [Key]
        public int ServerId { get; set; }
        [Required]
        public string ServerName { get; set; }
        [Required]
        public string HostName { get; set; }
        //[Column("Company")]
        //public string CmpFix { get; set; }
        public string IpAddress { get; set; }
        public string CustomIp { get; set; }
        public string PhysicalLocation { get; set; }
        public string Responsible { get; set; }
        public string ServerType { get; set; }
        //public DateTime DateCurrent { get; set; }
        public DateTime? LastBackup { get; set; }
        public string OperatingSystem { get; set; }
        public DateTime? Boottime { get; set; }
        public int? TotalCPU { get; set; }
        public int? TotalMemory { get; set; }
        public int? MemoryUsage { get; set; }
        public string ToolsRunningStatus { get; set; }
        public string ESXI { get; set; }
        public string Cluster { get; set; }
        public string Notes { get; set; }
        public int CompanyId { get; set; }
        public virtual Company.Company Company { get; set; }
        public virtual List<ServerDisk> ServerDisks { get; set; }
        public virtual List<ScheduledJobItem> ScheduledJobs { get; set; }
    }
}
// ServerId, ServerName, HostName, Company, IpAddress, CustomIp, PhysicalLocation, Responsible, ServerType, LastBackup, OperatingSystem, Boottime, TotalCPU, TotalMemory, MemoryUsage, ToolsRunningStatus, ESXI, 
//Cluster, Notes
