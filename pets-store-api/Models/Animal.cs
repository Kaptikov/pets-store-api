﻿namespace pets_store_api.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Breed { get; set; }
        public int? Age { get; set; }
        public User? Users { get; set; }
    }
}
