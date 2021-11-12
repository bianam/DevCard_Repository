using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Client { get; set; }

        public Project(long Id , string Name , string Description , string Image , string Client)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Image = Image;
            this.Client = Client;
        }
    }
}
