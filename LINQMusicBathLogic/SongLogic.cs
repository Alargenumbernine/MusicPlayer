using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQMusicBathBDO;
using LINQMusicBathDAL;

namespace LINQMusicBathLogic
{
    public class SongLogic
    {
        SongDAO songDAO = new SongDAO();
        public SongBDO GetSong(int id)
        {
            return songDAO.GetSong(id);
        }

        public bool UpdateSong(
ref SongBDO songBDO,
ref string message)
        {
            var songInDB =
            GetSong(songBDO.SongID);
            // invalid song to update
            if (songInDB == null)
            {
                message = "cannot get song for this ID";
                return false;
            }
            {
                return songDAO.UpdateSong(ref songBDO,
                ref message);
            }
        }
    }
}
