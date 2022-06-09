﻿using BibliothequeClassesVSC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VuesVSC
{
    /// <summary>
    /// Interaction logic for UCAmelioration.xaml
    /// </summary>
    public partial class UCAmelioration : UserControl
    {
        public Manager Mgr => (App.Current as App).Manager;
        public UCAmelioration()
        {
            InitializeComponent();
            DataContext = Mgr;
        }
        public string Texte
        {
            get { return (string)GetValue(TexteProperty); }
            set { SetValue(TexteProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Texte.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TexteProperty =
            DependencyProperty.Register("Texte", typeof(string), typeof(UCAmelioration), new PropertyMetadata("N/A"));



        public string ImageName
        {
            get { return (string)GetValue(ImageNameProperty); }
            set { SetValue(ImageNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageNameProperty =
            DependencyProperty.Register("ImageName", typeof(string), typeof(UCAmelioration), new PropertyMetadata("N/A"));

        public string TexteDescription
        {
            get { return (string)GetValue(TexteDescriptionProperty); }
            set { SetValue(TexteDescriptionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TexteDescription.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TexteDescriptionProperty =
            DependencyProperty.Register("TexteDescription", typeof(string), typeof(UCAmelioration), new PropertyMetadata("N/A"));

        private void lBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mgr.ArmeSélectionné = e.AddedItems[0] as Arme;
        }
    }
}