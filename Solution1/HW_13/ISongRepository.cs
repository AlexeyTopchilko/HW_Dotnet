using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW_13.Song;

namespace HW_13
{
    interface ISongRepository
    {
        void Create(Song song);

        void Read(int id);

        void ReadAll();

        void Update(int id, string author, string title, int minutes, int year, Genres genre);

        void DeleteById(int id);
    }
}