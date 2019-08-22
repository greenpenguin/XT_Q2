using BLL.Interface;
using BLL;
using DAL;
using DAL.Interface;

namespace Common
{
    public static class DependensiesClass
    {
        private static IUserDao _userDao;

        public static IUserDao UsertDao => _userDao ?? (_userDao = new UserDao());

        private static IUserManager _userManager;

        public static IUserManager UserManager => _userManager ?? (_userManager = new UserManager(UsertDao));
        
        private static IAwardDao _awardDao;

        public static IAwardDao AwardDao => _awardDao ?? (_awardDao = new AwardDao());

        private static IAwardManager _awardManager;

        public static IAwardManager AwardManager => _awardManager ?? (_awardManager = new AwardManager(AwardDao));
        
        private static IUserAndAwardsDao _userAndAwardsDao;

        public static IUserAndAwardsDao UserAndAwardsDao => _userAndAwardsDao ?? (_userAndAwardsDao = new UserAndAwardsDao());

        private static IUserAndAwardsManager _userAndAwardsManager;

        public static IUserAndAwardsManager UserAndAwardsManager => _userAndAwardsManager ?? (_userAndAwardsManager 
                                                                        = new UserAndAwardsManager(UserAndAwardsDao));
    }
}