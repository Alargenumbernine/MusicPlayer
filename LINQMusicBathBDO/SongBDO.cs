﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQMusicBathBDO
{
    public class SongBDO
    {
        public int SongID { get; set; }
        public string Name { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
