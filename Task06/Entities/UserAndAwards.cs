using System;
using System.Collections.Generic;

namespace Entities
{
    public class UserAndAwards
    {
        public int UserId { get; private set; }
        
        public List<int> ListOfAwards { get; set; }

        public UserAndAwards(int userId)
        {
            UserId = userId;
            ListOfAwards = new List<int>();
        }
        
        public override string ToString()
        {
            string awardsIndexes = String.Empty;
            foreach (var elem in ListOfAwards)
            {
                awardsIndexes += elem.ToString();
            }
            return $"{UserId} {awardsIndexes}";

        }
    }
}