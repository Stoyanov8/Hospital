﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
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
using HospitalApp.Data;
using Models;
namespace Hospital.App.Pages
{
    /// <summary>
    /// Interaction logic for Patients.xaml
    /// </summary>
    public partial class Patients : Page
    {
        public Patients()
        {
            InitializeComponent();

            var context = new HospitalAppEntities();
         
            var patians = context.Patients.ToList();
            this.DataContext = patians;
            //xmlns:data="clr-namespace:Models;assembly=Models"
            // xmlns:local="clr-namespace:Hospital.App.Pages"
        }
    }
}
