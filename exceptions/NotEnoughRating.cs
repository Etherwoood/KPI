using System;

namespace Lab;

public class NotEnoughRatingException : Exception
{
    public NotEnoughRatingException() : base("Incorrect value. Opponent has not much rating")
    {
    
    }
}