﻿namespace RestSharpAPITests
{
    public class Task
    {
        public string title { get; set; }
        public int id { get; set; }
        public string description { get; set; }
        public string dateCreated { get; set; }
        public string dateModified { get; set; }
        public Board board { get; set; }
    }
}