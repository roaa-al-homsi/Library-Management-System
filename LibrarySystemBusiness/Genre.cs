using LibrarySystemDataAccess;

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
        public Genre Find(int Id)
        {
            //
        }
    }
}
