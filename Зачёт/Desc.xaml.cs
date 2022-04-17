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
using System.Windows.Shapes;

namespace Зачёт
{
    /// <summary>
    /// Логика взаимодействия для Desc.xaml
    /// </summary>
    public partial class Desc : Window
    {
        List<DescrElis> DElis = BaseClass.BD.DescrElis.ToList();
        public Desc(string title, int arID)
        {
            InitializeComponent();

            for (int i = 0; i <= DElis.Count(); i++)
            {
                if (i == arID)
                {
                    TBTitle.Text = title;
                    TBDescr.Text = DElis[arID-1].Description;
                }  
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
