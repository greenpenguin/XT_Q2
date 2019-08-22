using System.Collections.Generic;
using Entities;

namespace BLL.Interface
{
    public interface IAwardManager
    {
        bool AddAward(Award award);
        bool DeleteAward(Award award);
        ICollection<Award> GetAllAwards();
    }
}