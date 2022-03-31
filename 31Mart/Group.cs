using System;
using System.Collections.Generic;
using System.Text;

namespace _31Mart
{
    internal class Group
    {
        private static int _no = 100;
        private string _noLetterP = "P";
        private string _noLetterD = "D";
        private string _noLetterS = "S";
        public Group(GroupType type)
        {
            _no++;
            if (type == GroupType.Design)
            {
                _noLetterD += _no;
                this.No = _noLetterD;
            }
            else if (type == GroupType.Programming)
            {
                _noLetterP += _no;
                this.No = _noLetterP;
            }
            else if (type == GroupType.System)
            {
                _noLetterS += _no;
                this.No = _noLetterS;
            }
            this.Type = type;
        }
        
        public string No { get; }
        public GroupType Type { get; set; }

        public Student[] Students = new Student[0];
        public Student FindStudentByNo(int no)
        {
            foreach (Student student in Students)
            {
                if(student.No == no)
                {
                    return student;
                }
            }
            return null;
        }
    }
}

