using System.Collections.ObjectModel;

namespace SearchingTours.Application.Abstractions.Persistence.Queries;

public class UserQuery
{
    public Collection<Guid> Ids { get; } = new();

    public Collection<string> Names { get; } = new();

    public Collection<string> Emails { get; } = new();

    public Collection<string> Phones { get; } = new();

    public ushort? Limit { get; private set; }

    public ushort? Offset { get; private set; }

    public UserQuery WithId(Guid id)
    {
        Ids.Add(id);
        return this;
    }

    public UserQuery WithIds(IEnumerable<Guid> ids)
    {
        foreach (var id in ids)
            WithId(id);
        return this;
    }

    public UserQuery WithName(string name)
    {
        Names.Add(name);
        return this;
    }

    public UserQuery WithNames(IEnumerable<string> names)
    {
        foreach (var name in names)
            WithName(name);
        return this;
    }

    public UserQuery WithEmail(string email)
    {
        Emails.Add(email);
        return this;
    }

    public UserQuery WithEmails(IEnumerable<string> emails)
    {
        foreach (var email in emails)
            WithEmail(email);
        return this;
    }

    public UserQuery WithPhone(string phone)
    {
        Phones.Add(phone);
        return this;
    }

    public UserQuery WithPhones(IEnumerable<string> phones)
    {
        foreach (var phone in phones)
            WithPhone(phone);
        return this;
    }

    public UserQuery WithLimit(ushort limit)
    {
        Limit = limit;
        return this;
    }

    public UserQuery WithOffset(ushort offset)
    {
        Offset = offset;
        return this;
    }
}