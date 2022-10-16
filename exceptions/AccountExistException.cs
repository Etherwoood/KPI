using System;

namespace Lab1;

public class AccountExistException: Exception
{
    public AccountExistException() : base("Account with this name is already exist") 
    {
    
    }    
}