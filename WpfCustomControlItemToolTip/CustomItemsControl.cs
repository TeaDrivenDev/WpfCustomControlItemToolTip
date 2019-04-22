using System.Windows;
using System.Windows.Controls;

namespace WpfCustomControlItemToolTip
{
    public class CustomItemsControl : ItemsControl
    {
        static CustomItemsControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(CustomItemsControl),
                new FrameworkPropertyMetadata(typeof(CustomItemsControl)));
        }

        public static readonly DependencyProperty DisplayNameProperty =
            DependencyProperty.Register(
                nameof(DisplayName),
                typeof(string),
                typeof(CustomItemsControl),
                new PropertyMetadata(default(string)));

        public string DisplayName
        {
            get => (string)GetValue(DisplayNameProperty);
            set => SetValue(DisplayNameProperty, value);
        }

        public static readonly DependencyProperty ItemToolTipTemplateProperty =
            DependencyProperty.Register(
                nameof(ItemToolTipTemplate),
                typeof(ControlTemplate),
                typeof(CustomItemsControl),
                new FrameworkPropertyMetadata(default(ControlTemplate)));

        public ControlTemplate ItemToolTipTemplate
        {
            get => (ControlTemplate)GetValue(ItemToolTipTemplateProperty);
            set => SetValue(ItemToolTipTemplateProperty, value);
        }
    }
}
