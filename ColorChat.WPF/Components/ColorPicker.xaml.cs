using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColorChat.WPF.Components
{
    /// <summary>
    /// Interaction logic for ColorPicker.xaml
    /// </summary>
    public partial class ColorPicker : UserControl
    {
        public static readonly DependencyProperty RedProperty =
           DependencyProperty.Register(nameof(Red), typeof(byte), typeof(ColorPicker), 
               new FrameworkPropertyMetadata((byte)0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, RGBPropertyChanged));

        public static readonly DependencyProperty GreenProperty =
            DependencyProperty.Register(nameof(Green), typeof(byte), typeof(ColorPicker),
               new FrameworkPropertyMetadata((byte)0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, RGBPropertyChanged));

        public static readonly DependencyProperty BlueProperty =
            DependencyProperty.Register(nameof(Blue), typeof(byte), typeof(ColorPicker),
               new FrameworkPropertyMetadata((byte)0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, RGBPropertyChanged));

        public static readonly DependencyProperty ColorBrushProperty =
           DependencyProperty.Register(nameof(ColorBrush), typeof(Brush), typeof(ColorPicker),
               new FrameworkPropertyMetadata(new SolidColorBrush(Colors.Black)));

        public byte Red
        {
            get { return (byte)GetValue(RedProperty); }
            set { SetValue(RedProperty, value); }
        }
        public byte Green
        {
            get { return (byte)GetValue(GreenProperty); }
            set { SetValue(GreenProperty, value); }
        }

        public byte Blue
        {
            get { return (byte)GetValue(BlueProperty); }
            set { SetValue(BlueProperty, value); }
        }

        public Brush ColorBrush
        {
            get { return (Brush)GetValue(ColorBrushProperty); }
            set { SetValue(ColorBrushProperty, value); }
        }

        public ColorPicker()
        {
            InitializeComponent();
        }

        private static void RGBPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(d is ColorPicker colorPicker)
            {
                colorPicker.UpdateColorBrush();
            }
        }

        private void UpdateColorBrush()
        {
            ColorBrush = new SolidColorBrush(Color.FromRgb(Red, Green, Blue));
        }
    }
}
