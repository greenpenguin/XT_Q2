﻿using System;

namespace Entities
{
    public class Award
    {
        public int Id { get; private set; }

        public string Title { get; private set; }
        
        public Award()
        {}
        
        public Award(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public override string ToString()
        {
            return $"{Id} {Title}";

        }
    }
}