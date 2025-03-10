﻿namespace Super_Advanced_Super_Cool.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set;}
        public DateTime UpdatedDate { get; set;} 

        public enum status
        {
            CANCELLED,
            DONE,
            INPROGRESS,
            STARTED
        }
    }
}
