using System.Collections.Generic;
using Lab;

namespace Lab1;
public class AccountManager
{
    IDictionary<string, UserAccount> store = new Dictionary<string, UserAccount>();
    public UserAccount Get (string username)
    {
        UserAccount currentAccount;
        store.TryGetValue(username, out currentAccount);
        return currentAccount;
    }

    public UserAccount Create(string username)
    {
        UserAccount account = new UserAccount(username);
        if (store.ContainsKey(username))
        {
            throw new AccountExistException();
        }

        store.Add(username, account);

        return account;
    }
}