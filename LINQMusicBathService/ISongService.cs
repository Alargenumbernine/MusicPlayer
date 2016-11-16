using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LINQMusicBathService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ISongService

    {
        [OperationContract]
        [FaultContract(typeof(SongFault))]
        Song GetSong(int id);
        [OperationContract]
        [FaultContract(typeof(SongFault))]
        bool UpdateSong(ref Song song,
        ref string message);
    }
    [DataContract]
    public class Song
    {
        [DataMember]
        public int SongID { get; set; }
        [DataMember]
        public string SongName { get; set; }
        [DataMember]
        public byte[] RowVersion { get; set; }
    }
    [DataContract]
    public class SongFault
    {
        public SongFault(string msg)
        {
            FaultMessage = msg;
        }
        [DataMember]
        public string FaultMessage;
    }
}