﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServiceBusShared.Models
{
    public class PersonModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LasName { get; set; }

    }
}
