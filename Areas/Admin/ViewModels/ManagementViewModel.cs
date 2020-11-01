using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS_420_Project.Models;

namespace CIS_420_Project.Areas.Admin.ViewModels
{
    public class ManagementViewModel
    {
        public Users tblUsers { get; set; }
        public Articles tblArticles { get; set; }

    }
}
