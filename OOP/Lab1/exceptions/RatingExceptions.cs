using System;

namespace Lab;

public class RatingException : Exception
{
    public RatingException() : base("Incorrect value. Rating must be more then 0")
    {

    }

}
