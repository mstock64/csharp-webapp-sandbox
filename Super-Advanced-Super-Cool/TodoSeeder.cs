using Super_Advanced_Super_Cool.Models;

namespace Super_Advanced_Super_Cool.Utils
{
    public class TodoSeeder
    {
        
        public static List<TodoItem> GetSeeds()
        {
            return new List<TodoItem>() { 
                new TodoItem() { 
                    Title = "Walk the dog",
                    Status = status.DONE,
                    Description = "PlaceHolder",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
            },
            new TodoItem() {
                    Title = "Change Underwear",
                    Status = status.CANCELLED,
                    Description = "PlaceHolder",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
            }, 
            new TodoItem()
            {
                    Title = "Brush Teeth",
                    Status = status.STARTED,
                    Description = "PlaceHolder",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
            },
            new TodoItem()
            {
                    Title = "Study for exam",
                    Status = status.INPROGRESS,
                    Description = "PlaceHolder",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
            },
            
            new TodoItem() {
                        Title= "Start Exploring the Data Collection",
                        Description= "Get familiar with the variety of records in this dataset.",
                        CreatedDate= DateTime.Now,
                        UpdatedDate= DateTime.Now,
                        Status= status.STARTED
            },
            new TodoItem() {
                        Title= "Uncover Insights (Record 2)",
                        Description= "Analyze record 2 to find valuable information.",
                        CreatedDate= DateTime.Now,
                        UpdatedDate= DateTime.Now,
                        Status= status.CANCELLED
            },
            new TodoItem() {
                        Title= "Review Record 1000 for Context",
                        Description= "See how record 1000 contributes to the overall understanding of the data.",
                        CreatedDate= DateTime.Now,
                        UpdatedDate= DateTime.Now,
                        Status= status.INPROGRESS
            },
            new TodoItem() {
                        Title= "Analyze Technical Details (Record 3)",
                        Description= "Take a closer look at the technical specifications in record 3.",
                        CreatedDate= DateTime.Now,
                        UpdatedDate= DateTime.Now,
                        Status= status.STARTED
            },
  new TodoItem(){
                        Title= "Investigate Details in Record 4",
                        Description= "Dig deeper to uncover interesting information within record 4.",
                        CreatedDate= DateTime.Now,
                        UpdatedDate= DateTime.Now,
                        Status= status.CANCELLED
            },
  new TodoItem(){
                        Title= "Write a Report (Maybe)",
                        Description= "Consider creating a report based on your findings (optional).",
                        CreatedDate= DateTime.Now,
                        UpdatedDate= DateTime.Now,
                        Status= status.INPROGRESS
            },
  new TodoItem(){
                        Title= "Prioritize Tasks",
                        Description= "Identify the most important tasks related to the data analysis.",
                        CreatedDate= DateTime.Now,
                        UpdatedDate= DateTime.Now,
                        Status= status.STARTED
            },
  new TodoItem(){
                        Title= "Schedule Meetings (Optional)",
                        Description= "Discuss findings and next steps with your team (if applicable).",
                        CreatedDate= DateTime.Now,
                        UpdatedDate= DateTime.Now,
                        Status= status.INPROGRESS
            },
            new TodoItem() {
                        Title= "Visualize the Data",
                        Description= "Create charts or graphs to represent your findings in an engaging way.",
                        CreatedDate= DateTime.Now,
                        UpdatedDate= DateTime.Now,
                        Status= status.STARTED
            },
            new TodoItem() {
                        Title= "Take a Break!",
                        Description= "Step away for a while to refresh your mind and come back with renewed focus.",
                        CreatedDate= DateTime.Now,
                        UpdatedDate= DateTime.Now,
                        Status= status.STARTED
            },
            new TodoItem() {
                        Title= "Celebrate Your Accomplishments",
                        Description= "Acknowledge your progress and reward yourself for a job well done!",
                        CreatedDate= DateTime.Now,
                        UpdatedDate= DateTime.Now,
                        Status= status.INPROGRESS
            },

            new TodoItem() {
                          Title= "Crack Open that Textbook (Finally)",
                          Description= "Ugh, time to conquer that assigned reading for tomorrow's class.",
                          CreatedDate= DateTime.Now,
                          UpdatedDate= DateTime.Now,
                          Status= status.INPROGRESS
                                  },
                                  new TodoItem() {
                          Title= "Hunt Down Missing Notes (From Last Week)",
                          Description= "Seriously, where did I put those notes from Professor Smith's lecture?",
                          CreatedDate= DateTime.Now,
                          UpdatedDate= DateTime.Now,
                          Status= status.STARTED
                                  },
                                  new TodoItem() {
                          Title= "Fuel Up for that Afternoon Exam (Coffee Time!)",
                          Description= "Gotta stay alert for that upcoming history exam. Extra espresso shot, anyone?",
                          CreatedDate= DateTime.Now,
                          UpdatedDate= DateTime.Now,
                          Status= status.STARTED
                                  },
                                  new TodoItem() {
                          Title= "Practice Problems (Maybe Later?)",
                          Description= "Those practice problems Professor Lee assigned... should I do them now or after that nap?",
                          CreatedDate= DateTime.Now,
                          UpdatedDate= DateTime.Now,
                          Status= status.INPROGRESS
                                  },
                                  new TodoItem() {
                          Title= "Don't Forget Roommate's Birthday Dinner!",
                          Description= "Pizza and cake time! Gotta grab a gift for Sarah before heading over.",
                          CreatedDate= DateTime.Now,
                          UpdatedDate= DateTime.Now,
                          Status= status.STARTED
                                  },
                                  new TodoItem() {
                          Title= "Laundry (Ugh, Adulting is Hard)",
                          Description= "The hamper is overflowing... time to face the mountain of dirty clothes.",
                          CreatedDate= DateTime.Now,
                          UpdatedDate= DateTime.Now,
                          Status= status.INPROGRESS
                                  },
                                  new TodoItem() {
                          Title= "Catch Up on that Assigned Podcast (Finally!)",
                          Description= "Professor Jones' podcast on existentialism sounds interesting... gotta find some listening time.",
                          CreatedDate= DateTime.Now,
                          UpdatedDate= DateTime.Now,
                          Status= status.INPROGRESS
                                  },
                                  new TodoItem() {
                          Title= "Check Financial Aid Update (Fingers Crossed)",
                          Description= "Did that scholarship application go through? Time to check my student portal!",
                          CreatedDate= DateTime.Now,
                          UpdatedDate= DateTime.Now,
                          Status= status.STARTED
                                  },
                                  new TodoItem() {
                          Title= "Practice for that Upcoming Play (Break a Leg!)",
                          Description= "Gotta memorize those lines for the upcoming college play. Time to channel my inner thespian!",
                          CreatedDate= DateTime.Now,
                          UpdatedDate= DateTime.Now,
                          Status = status.DONE
                                  }



            };
        } 
    }
}
