using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammerServer.Entity
{
    public class Users
    {
        [Key]
        public int Uid { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string IdentityCode { get; set; }
        public string headIcon { get; set; }
    }
}
