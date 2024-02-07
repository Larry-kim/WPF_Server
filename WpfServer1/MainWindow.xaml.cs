using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfServer1
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

        StreamReader StreamReaders;  // 데이타 읽기 위한 스트림리더
        StreamWriter StreamWriters;  // 데이타 쓰기 위한 스트림라이터
        

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            Thread AcceptThread = new Thread(new ThreadStart(Accept)); // AcceptThread 객체 생성, 별도 쓰레드에서 Accept 함수 실행
            AcceptThread.IsBackground = true; // WPF 종료시 AcceptThread도 종료, 데몬쓰레드 선언
            AcceptThread.Start(); // thread 시작

            // StartBtn.IsEnabled = false; // 버튼끄기
        }

        private void Accept() // 연결 쓰레드 함수
        {
            try
            {
                TcpListener Listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 1000); // IP: 127.0.0.1, PORT: 1000
                Listener.Start(); // 서버 시작
                ConnectRichTextbox("Ready to connect ...");

                TcpClient Client = Listener.AcceptTcpClient(); // 클라이언트 접속 확인
                ConnectRichTextbox("Client connected!");

                StreamReaders = new StreamReader(Client.GetStream()); // 읽기 스트림 연결
                StreamWriters = new StreamWriter(Client.GetStream()); // 쓰기 스트림 연결
                StreamWriters.AutoFlush = true; // 쓰기 버퍼 자동처리
                
                while (true)
                {
                    string AcceptData = StreamReaders.ReadLine(); // 수신 데이터를 읽어서 AcceptData 변수에 저장
                    WriteRichTextbox("[Client] " + AcceptData); // 데이터를 수신창에 쓰기
                }
            }

            catch (Exception ex) 
            {
                ConnectRichTextbox("Disconnected to Client!");
            }
        }


        private void WriteRichTextbox(string str)  // RichTextbox1 에 쓰기 함수
        {
            RichTextBox1.Dispatcher.Invoke(delegate { RichTextBox1.AppendText(str + "\n"); }); // 데이타를 수신창에 표시, 반드시 invoke 사용. 충돌피함.
            RichTextBox1.Dispatcher.Invoke(delegate { RichTextBox1.ScrollToEnd(); });  // 스크롤을 젤 밑으로.
        }

        private void ConnectRichTextbox(string str) // RichTextbox2 에 쓰기 함수
        {
            RichTextBox2.Dispatcher.Invoke(delegate { RichTextBox2.AppendText(str + "\n"); }); // 데이타를 수신창에 표시, 반드시 invoke 사용. 충돌피함.
            RichTextBox2.Dispatcher.Invoke(delegate { RichTextBox2.ScrollToEnd(); });  // 스크롤을 젤 밑으로.
        }

        private void StopBtn_Click(object sender, RoutedEventArgs e) // 서버 연결 해제 버튼
        {
            
        }

    }
}