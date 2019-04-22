using System.Collections.Generic;

namespace WpfCustomControlItemToolTip
{
    public class Item
    {
        public Item(string displayName, IEnumerable<SubItem> subItems)
        {
            DisplayName = displayName;
            SubItems = subItems;
        }

        public string DisplayName { get; }

        public IEnumerable<SubItem> SubItems { get; }
    }
}