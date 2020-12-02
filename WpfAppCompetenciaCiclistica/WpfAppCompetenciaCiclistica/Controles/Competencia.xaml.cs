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

namespace WpfAppCompetenciaCiclistica.Controles
{
    /// <summary>
    /// Lógica de interacción para Competencia.xaml
    /// </summary>
    public partial class Competencia : UserControl
    {
        public Competencia()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            IngresoCompetencia objIngreso = new IngresoCompetencia();
            objIngreso.ShowDialog();
        }
    }
}
