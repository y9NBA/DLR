﻿using System.Text.RegularExpressions;

namespace ExpandesClass
{
    public class Lesson
    {
        private readonly Discipline discipline;
        private readonly Employee employee;
        private readonly Group group;
        private readonly Pair pair;
        private readonly LessonType lessonType;

        public Discipline Discipline { get => discipline; }
        public Employee Employee { get => employee; }
        public Group Group { get => group; }
        public Pair Pair { get => pair; }
        public LessonType LessonType { get => lessonType; }

        public Lesson(Discipline discipline, Employee employee, Group group, Pair pair, LessonType lessonType)
        {
            this.discipline = discipline;
            this.employee = employee;
            this.group = group;
            this.pair = pair;
            this.lessonType = lessonType;
        }
    }
}