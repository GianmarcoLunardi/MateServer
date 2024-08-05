﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Models.DTO.OutComing
{
    
    
        public class UserOutComingDto
        {
            
            public string Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string city { get; set; }
            public string State { get; set; }
            public string Country { get; set; }

            public DateTime SubmittedDate { get; set; }
            public string JobSection { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Password { get; set; }

            public DateTime ApprovedOn { get; set; }



        }
    
}