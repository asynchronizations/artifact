﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Voat.Domain.Command
{
    public class UpdateSubverseRuleCommand : Command<CommandResponse>
    {
        protected override Task<CommandResponse> ProtectedExecute()
        {
            throw new NotImplementedException();
        }
    }
}
