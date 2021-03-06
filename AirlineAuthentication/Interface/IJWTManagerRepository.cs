using AirlineAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineAuthentication.Interface
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(Users users);
    }
}
