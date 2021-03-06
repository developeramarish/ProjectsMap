﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectsMap.WebApi.Models
{
    public class ProjectRole
    {
        public int EmployeeId { get; set; }
        public int EmployeeCompanyId { get; set; }
        public virtual Employee Employee { get; set; }

        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }

        public string Role { get; set; }

    }
}