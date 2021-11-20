using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class Admins :IEntity
    {
        public int Id { get; set; }
        public string Admin { get; set; }
        public string Parola { get; set; }
    }
}
