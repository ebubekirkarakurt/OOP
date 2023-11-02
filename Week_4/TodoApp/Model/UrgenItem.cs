namespace TodoApp.Models;

class UrgentItem : ImportantItem
{
    public bool IsUrgent { get; set; }

    // Constructor
    public UrgentItem(int level)
    : base(level)
    {

    }
    public UrgentItem(bool IsUrgent, int level)
    : base(level)
    {
        this.IsUrgent = IsUrgent;
    }
}