namespace WpfCustomControlItemToolTip
{
    public class SubItem
    {
        public SubItem(string name, object data)
        {
            Name = name;
            Data = data;
        }

        public string Name { get; }

        public object Data { get; }
    }
}