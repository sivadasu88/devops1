using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CICD_Application.Models
{
    public class Students
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }

        public string CreateNewStudent()
        {
            Students obj = new Students();
            obj.Id = 1;
            obj.Name = "sravani";
            obj.Description = "Description";
            return obj.ToString();
        }
    }
}