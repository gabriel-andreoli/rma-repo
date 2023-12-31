﻿using RMAProject.Domain.Commands;

namespace RMAProject.Presentation.Services.Interfaces
{
    public interface IUserService
    {
        Task RegisterUser(UserRegisterCommand command);
    }
}
