﻿namespace Registration.Api.Events
{
    public class RoyalRegisterEvent
    {
        public string Email { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}