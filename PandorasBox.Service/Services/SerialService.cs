using System.IO.Ports;

namespace PandorasBox.Service.Services
{
    public class SerialService
    {
        private readonly SerialPort _serial;

        public SerialService(string port, int baudRate)
        {
            _serial = new SerialPort(port, baudRate);
        }

        public bool IsOpen() => _serial.IsOpen;

        public void Open() => _serial.Open();

        public void Close() => _serial.Close();

        public void Send(string content, out string error)
        {
            error = string.Empty;

            using (_serial)
            {
                try
                {
                    if (!_serial.IsOpen)
                        _serial.Open();

                    _serial.WriteLine(content);
                }
                catch (Exception ex)
                {
                    error = ex.ToString();
                }
            }
        }

        public string Receive(out string error)
        {
            error = string.Empty;

            using (_serial)
            {
                try
                {
                    if (!_serial.IsOpen)
                        _serial.Open();

                    return _serial.ReadLine();
                }
                catch (Exception ex)
                {
                    error = ex.ToString();

                    return string.Empty;
                }
            }
        }
    }
}
