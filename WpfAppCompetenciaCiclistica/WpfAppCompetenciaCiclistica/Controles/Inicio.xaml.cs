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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppCompetenciaCiclistica.Clases;


namespace WpfAppCompetenciaCiclistica.Controles
{
    using MahApps.Metro.Controls;
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : UserControl
    {
        MainWindow objVen = new MainWindow();
        public Inicio()
        {
            InitializeComponent();
            
        }

        private void tlSimular_Click(object sender, RoutedEventArgs e)
        {
         

                foreach (clase1 indice in objVen.Competidores)
                {
                    MessageBox.Show(indice.Apellido);
                }
           

        }
    }
}
