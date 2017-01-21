using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;

namespace ev3Logger
{
    public partial class Ev3Lover : Form
    {
        static bool _cont;
        public Ev3Lover()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //! 利用可能なシリアルポート名の配列を取得する.
            string[] PortList = System.IO.Ports.SerialPort.GetPortNames();

            cmbPortName.Items.Clear();

            //! シリアルポート名をコンボボックスにセットする.
            foreach (string PortName in PortList)
            {
                cmbPortName.Items.Add(PortName);
            }
            if (cmbPortName.Items.Count > 0)
            {
                cmbPortName.SelectedIndex = 0;
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen == true)
            {
                //! シリアルポートをクローズする.
                SerialPort.Close();

                //! ボタンの表示を[切断]から[接続]に変える.
                ConnectButton.Text = "Connect";

                _cont = false;
            }
            else
            {
                //! オープンするシリアルポートをコンボボックスから取り出す.
                SerialPort.PortName = cmbPortName.SelectedItem.ToString();

                //! ボーレートをコンボボックスから取り出す.
                SerialPort.BaudRate = 9600;

                //! データビットをセットする. (データビット = 8ビット)
                SerialPort.DataBits = 8;

                //! パリティビットをセットする. (パリティビット = なし)
                SerialPort.Parity = Parity.None;

                //! ストップビットをセットする. (ストップビット = 1ビット)
                SerialPort.StopBits = StopBits.One;

                //! フロー制御をコンボボックスから取り出す.
                SerialPort.Handshake = Handshake.None;

                //! 文字コードをセットする.
                SerialPort.Encoding = Encoding.ASCII;

                SerialPort.NewLine = "\n";

                try
                {
                    //! シリアルポートをオープンする.
                    SerialPort.Open();

                    //! ボタンの表示を[接続]から[切断]に変える.
                    ConnectButton.Text = "DisConnect";

                    //! ログスレッドを開始する。
                    _cont = true;
                    LogFileWriterThread.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LogFileWriterThread_DoWork(object sender, DoWorkEventArgs e)
        {
            string path = Environment.CurrentDirectory + @"\" + System.DateTime.Now.Year.ToString()+
                System.DateTime.Now.Month.ToString() + System.DateTime.Now.Day.ToString() + 
                System.DateTime.Now.Hour.ToString() + System.DateTime.Now.Minute.ToString() +
                System.DateTime.Now.Second.ToString() + ".csv";

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.AutoFlush = true;
                sw.NewLine = "\n";
                while (_cont)
                {
                    try
                    {
                        char c = (char)SerialPort.ReadChar();
                        if(c == '\r')
                        {
                            SerialPort.WriteLine(c.ToString());
                        }
                        else
                        {
                            SerialPort.Write(c.ToString());
                        }
                        sw.WriteLine(c.ToString());
                    }
                    catch (Exception) { break; }
                }
            }
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            ofd.FileName = "default.html";
            //はじめに表示されるフォルダを指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = @"C:\";
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しないとすべてのファイルが表示される
            ofd.Filter = "HTMLファイル(*.html;*.htm)|*.html;*.htm|すべてのファイル(*.*)|*.*";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            ofd.FilterIndex = 2;
            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileNameLabel.Text = ofd.FileName;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(File.OpenRead(FileNameLabel.Text));
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine() + '\r';
                    SerialPort.WriteLine(line);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
