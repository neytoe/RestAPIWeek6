using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;


namespace RestAPILibrary
{
    /// <summary>
    /// This interface acts as a blueprint to the MethodImplementation Class
    /// </summary>
   public interface IMethodImplementation
    {
       //The GetUsernames method will be implemented in the MethodImplementation
        public  List<string> GetUsernames(int threshold);

        /*The GetUsernamesWithHighestCommentCount method will be implemented 
         in the MethodImplementation
        */
        public string GetUsernameWithHighestCommentCount();


        /*The GetUsenamesSortedByRecordDate method will be implemented 
         in the MethodImplementation
        */
        public List<string> GetUsernamesSortedByRecordDate(int threshold);
    }
}
