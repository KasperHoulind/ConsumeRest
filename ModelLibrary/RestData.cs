using System;

namespace ModelLibrary
{
    public class RestData
    {
        private int _userid;
        private int _id;
        private string _title;
        private bool _completed;

        public RestData()
        {
        }


        public RestData(int userid, int id, string title, bool completed)
        {
            this._userid = userid;
            this._id = id;
            this._title = title;
            this._completed = completed;

        }

        public int Userid
        {
            get => _userid;
            set => _userid = value;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Title
        {
            get => _title;
            set => _title = value;

        }

        public bool Completed
        {
            get => _completed;
            set => _completed = value;

            
        }

        public override string ToString()
        {
            return $"{nameof(Userid)}: {Userid}, {nameof(Id)}: {Id}, {nameof(Title)}: {Title}, {nameof(Completed)}: {Completed}";
        }


        // tjekker for om to objekter er ens 
        protected bool Equals(RestData other)
        {
            return _userid == other._userid && _id == other._id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((RestData) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (_userid * 397) ^ _id;
            }
        }
    }


    
}
