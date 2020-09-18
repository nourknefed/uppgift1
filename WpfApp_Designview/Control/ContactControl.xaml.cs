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

namespace Wpf3_customControl.Control
{
    /// <summary>
    /// Interaction logic for ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }
        public ImageSource Contactimage
        {
            get { return contactimage.Source; }
            set { contactimage.Source = value; }
        }
        public string ContactName 
        {
            get { return Contactname.Text; }
            set { Contactname.Text = value; }
        }
        public string Contactrole
        {
            get { return ContactRole.Text; }
            set { ContactRole.Text = value; }
        }
    }
}
