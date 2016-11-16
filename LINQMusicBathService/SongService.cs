using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LINQMusicBathLogic;
using LINQMusicBathBDO;

namespace LINQMusicBathService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class SongService : ISongService
    {
        // public string GetData(int value)
        SongLogic songLogic = new SongLogic();
        public Song GetSong(int id)
        {
            SongBDO songBDO = null;
            try
            {
                songBDO = songLogic.GetSong(id);
            }
            catch (Exception e)
            {
                string msg = e.Message;
                string reason = "GetSong Exception";
                throw new FaultException<SongFault>
                (new SongFault(msg), reason);
            }
            if (songBDO == null)
            {
                string msg =
                string.Format("No song found for id {0}",
                id);
                string reason = "GetSong Empty";
                throw new FaultException<SongFault>
                (new SongFault(msg), reason);
            }
            Song song = new Song();
            TranslateSongBDOToSongDTO(songBDO,
            song);
            return song;
        }
        public bool UpdateSong(ref Song song,
        ref string message)
        {
            bool result = true;

            // Name can't be empty
            if (string.IsNullOrEmpty(song.SongName))
            {
                message = "Song name cannot be empty";
                result = false;
            }
            else
            {
                try
                {
                    var songBDO = new SongBDO();
                    TranslateSongDTOToSongBDO(song,
                    songBDO);
                    result = songLogic.UpdateSong(
                    ref songBDO, ref message);
                    song.RowVersion = songBDO.RowVersion;
                }
                catch (Exception e)
                {
                    string msg = e.Message;
                    throw new FaultException<SongFault>
                    (new SongFault(msg), msg);
                }
            }
            return result;
        }
        private void TranslateSongBDOToSongDTO(
SongBDO songBDO,
Song song)
        {
            song.SongID = songBDO.SongID;
            song.SongName = songBDO.SongName;
            song.RowVersion = songBDO.RowVersion;
        }
        private void TranslateSongDTOToSongBDO(
        Song song,
        SongBDO songBDO)
        {
            songBDO.SongID = song.SongID;
            songBDO.SongName = song.SongName;
            songBDO.RowVersion = song.RowVersion;
        }
    }
}
