using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;
namespace MvvmGuia.Conexion
{
   public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmguia-default-rtdb.firebaseio.com/");

    }
}
