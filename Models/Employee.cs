﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace AddNestedIssue.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}