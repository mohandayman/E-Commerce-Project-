    using CommonService.DatabaseLayer.Models;
    using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

    namespace User.Management.Service.Data_Access_Layer__DAL_.Models
    {
        public  class UserModel : IdentityUser , IEntity<string>
        {

            public DateTime LastLoginTime { get; set; }
        }
    }
