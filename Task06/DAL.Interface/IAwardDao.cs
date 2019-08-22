using System.Collections.Generic;
using Entities;

namespace DAL.Interface
{
    public interface IAwardDao
    {
        bool AddAward(Award award);
        bool DeleteAward(Award award);
        ICollection<Award> GetAllAwards();
    }
}