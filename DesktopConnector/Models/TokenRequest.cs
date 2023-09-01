﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DesktopConnector.Models
{
	public class TokenRequest
	{
            [Required]
            public string Email { get; set; }

            [Required]
            public string Password { get; set; }
	}
}

