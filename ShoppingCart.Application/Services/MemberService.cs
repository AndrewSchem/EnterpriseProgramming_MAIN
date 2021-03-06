﻿using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.ViewModels;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.Services
{
    public class MembersService : IMembersService
    {
        private IMemberRepository _membersRepo;

        public MembersService(IMemberRepository membersRepository)
        {
            _membersRepo = membersRepository;
        }

        public void AddMember(MemberViewModel m)
        {
            Member member = new Member();
            member.Email = m.Email;
            member.FirstName = m.FirstName;
            member.LastName = m.LastName;
            _membersRepo.AddMember(member);
        }
    }
}
