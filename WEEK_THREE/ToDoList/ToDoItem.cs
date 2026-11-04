using System;


class ToDoItem
{
    public string Title { get; }
    public bool IsDone { get; private set; }

    public ToDoItem(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException("Title can't be empty.", nameof(title));
        }
        Title = title.Trim();
    }

    public void MarkDone() => IsDone = true;
}