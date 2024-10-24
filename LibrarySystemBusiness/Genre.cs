using LibrarySystemDataAccess;
using System.Data;

namespace LibrarySystemBusiness
{
    public class Genre
    {
        private enum Mode { Add, Update };
        private Mode _Mode;
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre()
        {
            this.Id = -1;
            this.Name = string.Empty;
            _Mode = Mode.Add;
        }
        private Genre(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        private bool _Add()
        {//validation
            this.Id = GenreData.Add(this.Id, this.Name);
            return (this.Id != -1);
        }
        private bool _Update()
        {//validation
            return GenreData.Update(this.Id, this.Name);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case Mode.Add:
                    return _Add();
                case Mode.Update:
                    return _Update();
                default: return false;
            }
        }
        static public Genre Find(int Id)
        {
            string Name = string.Empty;
            if (GenreData.GetGenreById(Id, ref Name))
            {
                return new Genre(Id, Name);
            }
            return null;
        }
        static public DataTable All()
        {
            return GenreData.All();
        }
        static public DataTable GetGenresNames()
        {
            return GenreData.GetGenresNames();
        }
        static public string GetNameGenreById(int Id)
        {
            return GenreData.GetNameGenreById(Id);
        }
        static public int GetGenreIdByName(string Name)
        {
            return GenreData.GetGenreIdByName(Name);
        }

    }
}
