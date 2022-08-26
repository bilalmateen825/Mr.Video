﻿namespace MovieTicketBookingClient.Models
{
    public class ActorAndMovie
    {
        public int MovieId { get; set; }

        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
