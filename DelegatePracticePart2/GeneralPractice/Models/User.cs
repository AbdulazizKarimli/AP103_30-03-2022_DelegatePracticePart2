using GeneralPractice.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Utils.Enums;

namespace GeneralPractice.Models
{
    internal class User : IEntity
    {
        private static int _id;
        public int Id { get; }
        public Role Role { get; set; }


        public User()
        {
            _id++;
            Id = _id;
        }
    }
}
