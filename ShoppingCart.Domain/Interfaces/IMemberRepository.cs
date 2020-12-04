using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Domain.Interfaces
{
	public interface IMemberRepository
	{
		void AddMember(Member m);
	}
}
