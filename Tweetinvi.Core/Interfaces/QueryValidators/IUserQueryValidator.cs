﻿using Tweetinvi.Core.Interfaces.Models;

namespace Tweetinvi.Core.Interfaces.QueryValidators
{
    public interface IUserQueryValidator
    {
        bool CanUserBeIdentified(IUserIdentifier userIdentifier);
        bool IsScreenNameValid(string screenName);
        bool IsUserIdValid(long? userId);
        bool IsUserIdValid(long userId);

        void ThrowIfUserCannotBeIdentified(long? userId);
        void ThrowIfUserCannotBeIdentified(IUserIdentifier userIdentifier, string parameterName = "User");
    }
}