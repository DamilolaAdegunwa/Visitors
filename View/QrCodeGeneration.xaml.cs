using Microsoft.Win32;
using Spire.Barcode;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Visitors.DAO;
using Visitors.DAOImpl;
using Visitors.entity;

namespace Visitors.View
{
    /// <summary>
    /// Interaction logic for QrCodeGeneration.xaml
    /// </summary>
    public partial class QrCodeGeneration : Window
    {
        public QrCodeGeneration()
        {
            InitializeComponent();
        }
       
        private void qrBtn_Click(object sender, RoutedEventArgs e)
        {
            BarcodeSettings.ApplyKey("your key");//you need a key from e-iceblue, otherwise the watermark 'E-iceblue' will be shown in barcode
            BarcodeSettings settings = new BarcodeSettings();
            settings.Type = BarCodeType.QRCode;
            settings.Unit = GraphicsUnit.Pixel;
            settings.ShowText = false;
            settings.ResolutionType = ResolutionType.UseDpi;
            //input data
            UserMaster u = new UserMaster();
            UserMasterDAO usrDAO = new UserMasterDAOImpl();
            u = usrDAO.findbyprimaryKey(6);

            string data = "UserName :" + u.username + "\n Password : " + u.pwd + "\nMobileNo : " + u.mobileNo + "\ngender : " + u.gender;
          
            Console.WriteLine("Usren mae:{0} password:{1} Mobile No={2} gender={3}", u.username, u.pwd, u.mobileNo, u.gender);
            settings.Data = data;
            string foreColor = "Black";
            string backColor = "White";
            settings.ForeColor = System.Drawing.Color.FromName(foreColor);
            settings.BackColor = System.Drawing.Color.FromName(backColor);
            settings.X = Convert.ToInt16(30);
            short leftMargin = 1;
              settings.LeftMargin = leftMargin;
            short rightMargin = 1;
            settings.RightMargin = rightMargin;
            short topMargin = 1;
            settings.TopMargin = topMargin;
            short bottomMargin = 1;
            settings.BottomMargin = bottomMargin;
            settings.QRCodeECL = QRCodeECL.L;

            BarCodeGenerator generator = new BarCodeGenerator(settings);
            Image QRbarcode = generator.GenerateImage();

            image1.Source = BitmapToImageSource(QRbarcode);
           
        }

        private ImageSource BitmapToImageSource(Image bitmap)
        {
            //throw new NotImplementedException();
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();

                return bitmapimage;
            }
        }
    }
}
