
using CodeFirstRelation.Data.UserEntity;
public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int UserId { get; set; }
        public required User User { get; set; } 




}

