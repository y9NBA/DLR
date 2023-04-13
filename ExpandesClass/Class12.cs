using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpandesClass
{
    public class Theme_LessonType
    {
        private readonly Theme theme;
        private readonly LessonType lessonType;
        private readonly uint hours;

        public Theme Theme { get => theme; }
        public LessonType LessonType { get => lessonType; }
        public uint Hours { get => hours; }


        public Theme_LessonType(Theme theme, LessonType lessonType, uint hours)
        {
            this.theme = theme;
            this.lessonType = lessonType;
            this.hours = hours;
        }
    }
}