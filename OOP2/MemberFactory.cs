﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public static class MemberFactory
    {
        public enum MemberKind
        {
            Silver,
            Gold,
            Platinum
        }

        public static IMember Create(MemberKind member)
        {
            if(member == MemberKind.Gold)
            {
                return new GoldMember();
            }
            if (member == MemberKind.Platinum)
            {
                return new GoldMember();
            }
            
            return new SilverMember();

        }
    }
}
