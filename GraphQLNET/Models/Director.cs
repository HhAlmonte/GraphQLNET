﻿namespace GraphQLNET.Models
{
    public class Director
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }

        public virtual ICollection<Video>? Videos { get; set; }
    }
}
