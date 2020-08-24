using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dating.BusinessLayer.Interface;
using Dating.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Dating.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;

        }

        /// <summary>
        /// Show Index page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            //Business logic goes here
            throw new NotImplementedException();
        }
        public IActionResult Login()
        {
            //Business logic goes here
            throw new NotImplementedException();
        }


        /// <summary>
        /// verify user exist or not
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Login(String UserName, String Password)
        {
            //Business logic goes here
            throw new NotImplementedException();

        }

        /// <summary>
        /// Create new user
        /// </summary>
        /// <returns></returns>
        public IActionResult CreateNewUser()
        {
            //Business logic goes here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateNewUser(User user)
        {
            //Business logic goes here
            throw new NotImplementedException();

        }


        /// <summary>
        /// Add profile of user
        /// </summary>
        /// <returns></returns>
        public IActionResult AddProfile()
        {
            //Business logic goes here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Show all users in db
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> AllMembers()
        {
            //Business logic goes here
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Show user profile
        /// </summary>
        /// <param name="profile"></param>
        /// <returns></returns>
        
        public IActionResult UserProfile(Profile profile)
        {
            //Business logic goes here
            throw new NotImplementedException();
        }
   
        /// <summary>
        /// Add user profile
        /// </summary>
        /// <param name="profile"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddProfile(Profile profile)
        {
            //Business logic goes here
            throw new NotImplementedException();

        }
    }
}
