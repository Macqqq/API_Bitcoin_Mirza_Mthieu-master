using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace API_Bitcoin.View
{
    public partial class Page_Index : UserControl
    {
        public Page_Index()
        {
            InitializeComponent();

        }



        private void BTN_7d_Click(object sender, RoutedEventArgs e)
        {
            // Charger l'image correspondante pour le bouton 7d
            IMG_Index.Source = new BitmapImage(new Uri("C:\\Users\\SLAB60\\AppData\\Local\\Temp\\8369712b-77c7-4010-9237-d5ac4ef7fb39_Ressources.zip.b39\\Ressources\\Image\\Index_7d.jpeg"));
        }

        private void BTN_1m_Click(object sender, RoutedEventArgs e)
        {
            // Charger l'image correspondante pour le bouton 1m
            IMG_Index.Source = new BitmapImage(new Uri("C:\\Users\\SLAB60\\AppData\\Local\\Temp\\11562722-bfcd-4fa0-8aed-4da0c5871d75_Ressources.zip.d75\\Ressources\\Image\\Index_1m.jpeg"));
        }

        private void BTN_1y_Click(object sender, RoutedEventArgs e)
        {
            // Charger l'image correspondante pour le bouton 1y
            IMG_Index.Source = new BitmapImage(new Uri("C:\\Users\\SLAB60\\AppData\\Local\\Temp\\00da00da-19c0-4e6e-b458-42d9bb07d5ce_Ressources.zip.5ce\\Ressources\\Image\\Index_1y.jpeg"));
        }

        private void BTN_All_Click(object sender, RoutedEventArgs e)
        {
            // Charger l'image correspondante pour le bouton All
            IMG_Index.Source = new BitmapImage(new Uri("C:\\Users\\SLAB60\\AppData\\Local\\Temp\\620dcf3f-0337-4678-8d88-5a10b5ec0682_Ressources.zip.682\\Ressources\\Image\\Index_All.jpeg"));
        }


    }
}

