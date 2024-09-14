﻿using System;
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
using System.Windows.Shapes;

namespace SIGEN.View
{
    /// <summary>
    /// Lógica de interacción para AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Poder arrastrar la ventana
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow LoginWindow = new LoginWindow();
            LoginWindow.Show();
            this.Close();
        }

        private void BtnSalaries_Click(object sender, RoutedEventArgs e)
        {
            _ = MessageBox.Show("Funcionalidad no implementada aún.");
        }

        private void BtnAgenda_Click(object sender, RoutedEventArgs e)
        {
            _ = MessageBox.Show("Funcionalidad no implementada aún.");
        }

        private void BtnQuota_Click(object sender, RoutedEventArgs e)
        {
            _ = MessageBox.Show("Funcionalidad no implementada aún.");
        }
    }
}
