using System;
using System.Net;
using System.Net.Sockets;

/*
 * NetworkTimeServer
 * By Peter Slade
 * Email: pete@sladehome.com
 * Web: http://www.sladehome.com
 *
 * THIS CODE IS PROVIDED WITHOUT ANY WARRANTY, AND WITHOUT ANY IMPLIED WARRANTIES
 * WITH REGARD TO MERCHANTABILITY OR FITNESS FOR A PARTICULAR PURPOSE.
 *
 * USE AT YOUR OWN RISK. YOU ASSUME ALL LIABILITIES!!!
 *
 */


namespace DigitalWatch.NetworkTime
{
    /// Network Time Client
    /// Provides time information from a specified NTP server

    public class NetworkTimeClient
    {

        private byte[] ntpData = new byte[48]; // Structure - per RFC 2030
        // timestamp location in NTP Structure
        private const byte offsetTransmitTime = 40;
        private string server = "time-a.nist.gov"; // default server address
        private int port = 123; // default port
        private DateTime receiveTime; // time request received by server

        private IPEndPoint endPoint;
        private UdpClient udpSocket;

        /// 

        /// Default Constructor
        /// 

        public NetworkTimeClient()
        {
        }

        /// 

        /// Constructor
        /// 

        /// 
        public NetworkTimeClient(string server)
        {
            this.server = server;
        }

        /// 

        /// Constructor
        /// 

        /// NTP Server
        /// Port Number
        public NetworkTimeClient(string server, int port)
        {
            this.server = server;
            this.port = port;
        }

        /// 

        /// Connect to the NTP server and return the date/time
        /// 

        public void connect()
        {
            udpSocket = null;

            // resolve the IP address of the time server
            IPHostEntry address = Dns.GetHostEntry(this.server);
            endPoint = new IPEndPoint(address.AddressList[0], this.port);

            // Connect to the time server
            udpSocket = new UdpClient();
            udpSocket.Connect(endPoint);
        }

        public bool checkConnection()
        {
            return udpSocket.Client != null;
        }

        /// 
        public DateTime Time
        {
            get{
                       try {
                           connect();
                            // Initialize data structure 
                           /*
                           * Per RFC 2030
                           * It is advisable to fill the non-significant
                           * low order bits of the timestamp with a random
                           * unbiased bitstring, both to avoid systematic
                           * roundoff errors and as a means of loop detection
                           * and replay detection. One way of doing this is to
                           * generate a random bitstring in a 64-bit word, then
                           * perform an arithmetic right shift a number of bits
                           * equal to the number of significant bits of the
                           * timestamp, then add the result to the original
                           * timestamp
                           */

                           ntpData[0] = 0x1B; // Set version to 4, mode to client
                           for(int i = 1; i < 48; i++) { // pad with 0's
                                 ntpData[i] = 0;
                           }

                           udpSocket.Send(ntpData, ntpData.Length);
                           ntpData = udpSocket.Receive(ref endPoint);
                           receiveTime = DateTime.Now;
                           // Calc the time difference and offset for NTP time
                           ulong intpart = 0;
                           ulong fractpart = 0;
                           for(int i = 0; i <= 3; i++) {
                                 intpart = 256 * intpart
                                          + ntpData[offsetTransmitTime + i];
                           }
                           for(int i = 4; i<=7; i++) {
                             fractpart =
                               256 * fractpart + ntpData[offsetTransmitTime + i];
                           }
                           ulong milliseconds =
                             (intpart * 1000 + (fractpart * 1000) / 0x100000000L);
                           // Calculate the date
                           /*
                           * NTP timestamps are represented as a 64-bit unsigned
                           * fixed-point number, in seconds relative to
                           * 0h on 1 January 1900. The integer part is in the
                           * first 32 bits and the fraction part in the last
                           * 32 bits. In the fraction part, the non-significant
                           * low order can be set to 0.
                           */
                           TimeSpan timeSpan =
                              TimeSpan.FromMilliseconds( (double) milliseconds);
                           DateTime dateTime = new DateTime(1900, 1, 1);
                           dateTime += timeSpan;
                           // Calculate the timezone offset for the user
                           TimeSpan offsetAmount =
                                  TimeZone.CurrentTimeZone.GetUtcOffset(dateTime);
                           DateTime networkDateTime = (dateTime + offsetAmount);
                           return networkDateTime;
                     } catch(SocketException ex) {
                           throw new Exception(ex.Message);
                     } finally{
                           if (udpSocket != null){
                                 try{
                                       udpSocket.Close();
                                 } catch (Exception){}
                           }
                     }
                 }
        }

        /// 

        /// Return Network Date/Time or exception detail
        /// 

        /// 
        public override string ToString()
        {
            try
            {
                return this.Time.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        /// 

        /// Static method to return the network time
        /// 

        /// Network Time Server Date/Time
        public DateTime GetNetworkTime()
        {
            NetworkTimeClient ntc = new NetworkTimeClient();
            return ntc.Time;
        }

        /// 

        /// Static method to return the network time
        /// 

        /// time server address
        /// Network Time Server Date/Time
        public static DateTime GetNetworkTime(string server)
        {
            NetworkTimeClient ntc = new NetworkTimeClient(server);
            return ntc.Time;
        }

        /// 

        /// Static method to return the network time
        /// 

        /// time server address
        /// time server port
        /// Network Time Server Date/Time
        public static DateTime GetNetworkTime(string server, int port)
        {
            NetworkTimeClient ntc = new NetworkTimeClient(server, port);
            return ntc.Time;
        }

    } // class
} // namespace