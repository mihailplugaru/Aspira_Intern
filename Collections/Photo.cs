using System;

namespace Collections
{
    class Photo
    {
        public string Source { get; set; }
        private DateTime TimeStamp { get; set; }

        public Photo(string originDevice)
        {
            Source = originDevice;
            TimeStamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{this.Source} - {this.TimeStamp}";
        }
    }
}
