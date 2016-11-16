using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQMusicBathBDO;

namespace LINQMusicBathDAL
{
    public class SongDAO
    {
        public SongBDO GetSong(int id)
        {
            SongBDO songBDO = null;
            using (var MBEntities = new MusicBathEntities())
            {
                Song song = (from s in MBEntities.Song
                             where s.SongID == id
                             select s).FirstOrDefault();
                if (song != null)
                    songBDO = new SongBDO()
                    {
                        SongID = song.SongID,
                        Name = song.Name,
                        RowVersion = song.RowVersion
                    };
            }
            return songBDO;
        }

        public bool UpdateSong(
    ref SongBDO songBDO,
    ref string message)
        {
            message = "song updated successfully";
            bool ret = true;
            using (var MBEntities = new MusicBathEntities())
            {
                var songID = songBDO.SongID;
                Song songInDB =
                (from s
                in MBEntities.Song
                 where s.SongID == songID
                 select s).FirstOrDefault();
                // check songg
                if (songInDB == null)
                {
                    throw new Exception("No song with ID " +
                    songBDO.SongID);
                }
                MBEntities.Song.Remove(songInDB);
                // update song
                songInDB.Name = songBDO.Name;
                songInDB.RowVersion = songBDO.RowVersion;
                MBEntities.Song.Attach(songInDB);
                MBEntities.Entry(songInDB).State =
                System.Data.Entity.EntityState.Modified;
                int num = MBEntities.SaveChanges();
                songBDO.RowVersion = songInDB.RowVersion;
                if (num != 1)
                {
                    ret = false;
                    message = "no song is updated";
                }
            }
            return ret;
        }
    }
}