using Dating.BusinessLayer.Interface;
using Dating.BusinessLayer.Service.Repository;
using Dating.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dating.BusinessLayer.Service
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;
        /// <summary>
        /// Inject userRepository object
        /// </summary>
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Call user repository method to Add user profile
        /// </summary>
        /// <param name="profile"></param>
        /// <returns></returns>
        public async Task<Profile> AddProfile(Profile profile)
        {
            //Business logic goes here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Call user repository method to create new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<string> CreateNewUser(User user)
        {
            //Business logic goes here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Call user repository method to return list of all Members details
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<User>> ListOfMembers()
        {
            //Business logic goes here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Call user repository method to verify user exist or not
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public async Task<User> VerifyUser(string UserName, string Password)
        {
            //Business logic goes here
            throw new NotImplementedException();
        }
    }
}
