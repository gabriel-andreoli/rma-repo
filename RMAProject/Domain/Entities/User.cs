﻿using RMAProject.Domain.Entities.Enums;
using RMAProject.Domain.Entities.GenericsEntities;

namespace RMAProject.Domain.Entities
{
    public class User : BaseClass
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int BornDate { get; set; }
        public EUserGender UserGender { get; set; }
        public Company Company { get; set; }
        public Guid CompanyId { get; set; }
        public User() { }
    }
}