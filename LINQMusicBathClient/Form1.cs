using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using LINQMusicBathClient.SongServiceRef;

namespace LINQMusicBathClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblSongDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnGetSong_Click(object sender, EventArgs e)
        {

            var client = new SongServiceClient();
            string result = "";
            try
            {
                int songID = Int32.Parse(txtSongID.Text);
                var song = client.GetSong(songID);
                var sb = new StringBuilder();
                sb.Append("SongID:" +
                song.SongID.ToString() + "\r\n");
                sb.Append("SongName:" +
                song.SongName + "\r\n");
                sb.Append("RowVersion:");
                foreach (var x in song.RowVersion.AsEnumerable())
                {
                    sb.Append(x.ToString());
                    sb.Append(" ");
                }
                result = sb.ToString();
            }
            catch (TimeoutException ex)
            {
                result = "The service operation timed out. " +
                ex.Message;
            }
            catch (FaultException<SongFault> ex)
            {
                result = "SongFault returned: " +
                ex.Detail.FaultMessage;
            }
            catch (FaultException ex)
            {
                result = "Unknown Fault: " +
                ex.ToString();
            }
            catch (CommunicationException ex)
            {
                result = "There was a communication problem. " +
                ex.Message + ex.StackTrace;
            }
            catch (Exception ex)
            {
                result = "Other exception: " +
                ex.Message + ex.StackTrace;
            }
            txtSongDetails.Text = result;
        }
    }
    }

