using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DAL.Interface;
using Entities;

namespace DAL
{
    public class AwardDao : IAwardDao
    {
        private static List<Award> Awards = new List<Award>();
        private readonly string entitiesInformationFile = Directory.GetCurrentDirectory() + "/EntitiesInformation.txt";
        
        public bool AddAward(Award award)
        {
            if (Awards.Any(n => n.Id == award.Id))
                return false;

            Awards.Add(award);
            
            StreamWriter writer = new StreamWriter(entitiesInformationFile);
            writer.WriteLine(award.ToString());
            writer.Close();

            return true;
        }

        public bool DeleteAward(Award award)
        {
            if (Awards.Any(n => n.Id != award.Id))
                return false;

            Awards.Remove(award);

            StreamReader reader = new StreamReader(entitiesInformationFile);
            StreamWriter writer = new StreamWriter(entitiesInformationFile);
            string line = null;
            
            while ((line = reader.ReadLine()) != null) 
            {
                if (String.Compare(line, award.ToString()) == 0)
                {
                    continue;
                }

                writer.WriteLine(line);
            }
            
            reader.Close();
            writer.Close();
            
            return true;
        }

        public ICollection<Award> GetAllAwards()
        {
            Awards.Clear();
            
            StreamReader reader = new StreamReader(entitiesInformationFile);
            string[] strFromFile = reader.ReadToEnd().Split('\n');
            
            foreach (var s in strFromFile)
            {
                var element = s.Split(' ');
                if (element.Length == 2)
                {
                    if (int.TryParse(element[0], out var idValue))
                    {
                        AddAward(new Award(idValue, element[1]));
                    }
                    else
                    {
                        throw new ArgumentException("Error in reading award's data.");
                    }
                }
            }
            
            reader.Close();

            return Awards;
        }
    }
}