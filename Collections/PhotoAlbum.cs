using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Collections

{
    class PhotoAlbum : IEnumerable, IEnumerator
    {
        Photo[] photoAlbum;

        public PhotoAlbum(int size)
        {
            photoAlbum = new Photo[size];
            AddSomePhotos();
        }

        int position = -1;
        public object Current => photoAlbum[position];

        public bool MoveNext()
        {
            if (position < photoAlbum.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public Photo this[int index]
        {
            get => photoAlbum[index];
            set => photoAlbum[index] = value;
        }

        internal int Length => photoAlbum.Length;

        internal Photo Last { 
            get => photoAlbum[Length - 1]; 
            set => photoAlbum[Length - 1] = value; 
        }

        private void AddSomePhotos()
        {
            try
            {
                photoAlbum[0] = new Photo("My Phone");
                photoAlbum[1] = new Photo("My Camera");
                photoAlbum[2] = new Photo("Security Camera");
                Thread.Sleep(1000);
                photoAlbum[3] = new Photo("Internet");
                photoAlbum[4] = new Photo("Unknown");
            }
            catch
            {
                Console.WriteLine("Try to create a bigger album in order to fit all initial photos ( > 5).");
            }
        }
    }
}



