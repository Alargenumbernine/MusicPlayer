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
                Song product = (from s in MBEntities.Songs
                                   where s.SongID == id
                                   select s).FirstOrDefault();
                if (product != null)
                    songBDO = new SongBDO()
                    {
                        SongID = product.SongID,
                        SongName = product.SongName,
                    };
            }
            return songBDO;
        }
    }
}
