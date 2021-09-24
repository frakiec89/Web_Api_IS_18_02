using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
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

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private  void Button_ClickAsync(object sender, RoutedEventArgs e)
        {
            var us = new User()
            {
                Name = tbName.Text,
                Login = tnLogin.Text,
                Password = tbPassword.Text
            };

            WebRequest request = WebRequest.Create($"{tbAdrees.Text}");
            request.Method = "POST"; // для отправки используется метод Post

            string jsonString = JsonSerializer.Serialize(us);
            request.ContentType = "application/json";
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(jsonString);
            request.ContentLength = byteArray.Length;

            //записываем данные в поток запроса
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }


            WebResponse response =  request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    MessageBox.Show(reader.ReadToEnd());
                }
            }
            response.Close();

        }

            public class User
            {
                public string Name { get; set; }
                public string Login { get; set; }
                public string Password { get; set; }
            }
    }
}
