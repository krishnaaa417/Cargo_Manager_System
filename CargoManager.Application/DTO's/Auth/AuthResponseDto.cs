﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.DTO_s.Auth
{
    public class AuthResponseDto
    {
        public bool IsSuccess {  get; set; }
        public string Token { get; set; }
       public List<string>? Errors { get; set; }
    }
}
