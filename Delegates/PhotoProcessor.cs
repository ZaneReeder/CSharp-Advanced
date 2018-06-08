using System;

namespace Delegates
{
    public class PhotoProcessor
    {

        //public delegate void PhotoFilterHandler(Photo photo);


        public void Process(string path, Action<Photo> filterHandler)
        {

            //Orignal not extensible.
            //Use Delegates so that filters may
            //be developed without having to 
            //recompile and deploy all of the code.

            //System.Action<>; //Built in delegate points to a void method with up to 16params
            
            //System.Func<> //Built in delegate points to method that returns a type 

            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}
