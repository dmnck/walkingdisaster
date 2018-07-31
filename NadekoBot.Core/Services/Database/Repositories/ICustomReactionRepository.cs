﻿using System.Collections.Generic;
using NadekoBot.Core.Services.Database.Models;

namespace NadekoBot.Core.Services.Database.Repositories
{
    public interface ICustomReactionRepository : IRepository<CustomReaction>
    {
        CustomReaction[] GetGlobal();
        CustomReaction[] GetFor(IEnumerable<ulong> ids);
        CustomReaction[] ForId(ulong id);
        int ClearFromGuild(ulong id);
        CustomReaction GetByGuildIdAndInput(ulong? guildId, string input);
    }
}
