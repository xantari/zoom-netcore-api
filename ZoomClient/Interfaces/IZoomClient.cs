﻿using AndcultureCode.ZoomClient.Models.Meetings;
using AndcultureCode.ZoomClient.Models.Users;

namespace AndcultureCode.ZoomClient.Interfaces
{
    public interface IZoomClient
    {
        /// <summary>
        /// List meetings for a user. https://zoom.github.io/api/#list-meetings
        /// </summary>
        /// <param name="userId">Can be userId or user email address</param>
        /// <returns></returns>
        ListMeetings GetMeetings(string userId);

        /// <summary>
        /// Create a new user on your account. https://zoom.github.io/api/#create-a-user
        /// </summary>
        /// <param name="createUser">User object</param>
        /// <returns></returns>
        User CreateUser(CreateUser createUser);

        /// <summary>
        /// List users on your account. https://zoom.github.io/api/#list-users
        /// </summary>
        /// <returns></returns>
        ListUsers GetUsers();
    }
}
