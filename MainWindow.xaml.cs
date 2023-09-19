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

namespace WpfApp6_Store
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Image SonI = new();
        public Label SonL = new();
        public Dictionary<Image, Label> Sebet = new();
        public MainWindow()
        {
            InitializeComponent();

            

            Dictionary<string, string> names_and_images = new()
            {
                { "Cola",   "https://www.bakenroll.az/en/image/coca-cola.jpg" },
                { "Ayran",  "https://bazarstore.az/17732-home_default/milla-ayran-375-gr.jpg" },
                { "Nike",   "https://cdn.dsmcdn.com/ty201/product/media/images/20211017/17/150622744/266557882/1/1_org_zoom.jpg" },
                {"DeFacto",        "https://cdn.dsmcdn.com/ty953/product/media/images/20230615/13/385779009/496224798/1/1_org_zoom.jpg" },
                {"Zeytin",  "https://bazarstore.az/23764-home_default/zeytun-baglari-zeytun-yagi-750-ml-rafine.jpg" },
                {"Saville", " https://bazarstore.az/38-home_default/saville-makaron-linguine-500-gr.jpg" },
                {"Bershka",    " https://cdn.dsmcdn.com/ty690/product/media/images/20230117/16/260380302/676670014/1/1_org_zoom.jpg" },
                {"1wqwq",   " https://cdn.dsmcdn.com/ty913/product/media/images/20230526/18/362615524/952297698/1/1_org_zoom.jpg" },
                {"sasas",    " https://cdn.dsmcdn.com/ty500/product/media/images/20220806/16/155477155/480412690/1/1_org_zoom.jpg" },
                {"Casio",      " https://cdn.dsmcdn.com/ty29/product/media/images/20201202/20/34559427/115432407/0/0_org_zoom.jpg" },
                {"lss",     " https://cdn.dsmcdn.com/ty941/product/media/images/20230603/23/380179877/669092803/1/1_org_zoom.png" },
                { "Coins",  " https://cdn.dsmcdn.com/ty369/product/media/images/20220323/13/75011760/70714887/1/1_org_zoom.jpg"}



            };
            

            foreach (var src in names_and_images)
            {
                StackPanel SP = new StackPanel();
                Image image = new Image();

                // BitmapImage oluşturma
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(src.Value , UriKind.RelativeOrAbsolute);
                bitmap.EndInit();
                image.Source = bitmap;

                Button myButton = new Button();
                myButton.Style = (Style)Application.Current.Resources["StyleProductBtn"];
                myButton.Content = image;    

                myButton.Click += MyButton_Click;






                Label myLabel = new();
                myLabel.Content = src.Key ;
                myLabel.Style = (Style)Application.Current.Resources["StyleNameLabel"];


                SP.Children.Add(myButton);
                SP.Children.Add(myLabel);


                WP.Children.Add(SP);
            }

           

        }


        public bool add = false;

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {

            if (sender is Button btn)
            {
                if (btn.Content is Image  jpg)
                {
                     ImageProd.Source  = jpg.Source ;
                    SonI.Source = jpg.Source;
                    //MessageBox.Show("adsd");
                }
               
                if(btn.Parent is StackPanel SP)
                {
                    foreach(var item in SP.Children)
                    {
                        if(item is Label Lb)
                        {
                            LabelProd.Content = Lb.Content;
                            SonL.Content = Lb.Content;
                        }
                    }
                }

                //StackPanel sp = new();
                //sp.Children.Add(SonI); sp.Children.Add(SonL); 
                
               
                if (add == true) { Sebet.Add(SonI, SonL); add = false;

                }
            }
            
            


            //foreach (var item in WP.Children)
            //{
            //    if(item is Button btn)
            //    {


            //        STP.Children.Add()

            //    }
            //}
        }

        public void AddProd(object sender, RoutedEventArgs e)
        {
            if(sender is Button btn)
            {
                add = true;

            }
        }

        private void ShowList(object sender, RoutedEventArgs e)
        {
             Image img = new();
             Label lb = new();
             foreach(var item in Sebet)
             {
                 img.Source = item.Key.Source;
                 lb.Content = item.Value.Content;
             }
             Window W2 = new();
             W2.ShowDialog();
             //W2.Content = 
        }
    }
}
