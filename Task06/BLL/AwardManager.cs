using System.Collections.Generic;
using BLL.Interface;
using DAL.Interface;
using Entities;

namespace BLL
{
    public class AwardManager : IAwardManager
    {
        private readonly IAwardDao _awardDao;

        public AwardManager(IAwardDao awardDao)
        {
            _awardDao = awardDao;
        }
        
        public bool AddAward(Award award)
        {
            _awardDao.AddAward(award);
            return true;
        }
        
        public bool DeleteAward(Award award)
        {
            _awardDao.DeleteAward(award);
            return true;
        }
        
        public ICollection<Award> GetAllAwards()
        {
            return _awardDao.GetAllAwards();
        }
        
    }
}