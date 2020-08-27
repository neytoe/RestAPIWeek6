using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RestAPILibrary
{
    //This class Implements the required methods for the IMethodImplementation Interface
    public class MethodImplementation : IMethodImplementation
    {
        /*
        This function would retrieve the names of the most active authors
        (using submission count as the criteria) according to a set threshold.
        */
        public  List<string> GetUsernames(int threshold)
        {

            /*using query method,this method loops through the list gotten from
             * the Api call, compares the SubmissionCount property with the inputted 
             * threshold and returns the names of the authors that match this criteria
             * in descending order
             */

            var result = (from Author in GetApiData.OurList
                          where Author.SubmissionCount >= threshold
                          orderby Author.SubmissionCount descending
                          select Author.Username).ToList();
                            
                         return result;

        }


        /*This Method would retrieve and return
         * the name of the author with the highest comment count.
         */ 
         public string GetUsernameWithHighestCommentCount()
         {

            /*using query method,this method loops through the list gotten from
             * the Api call, sorts using the CommentCount Property in descending order
             * and returns the first author(which will be the author with the highest 
             * CommentCount)
             */

            var result = from Author in GetApiData.OurList
                          orderby Author.CommentCount descending
                          select Author.Username;

             var answer = result.FirstOrDefault();
             return answer.ToString();

         }


         /* This function would retrieve the names of authors sorted by
         when their record was created according to a set threshold.
         */
        public List<string> GetUsernamesSortedByRecordDate(int threshold)
        {
           /*using query method,this method loops through the list gotten from
            * the Api call, compares the createdAt property with the inputted 
            * threshold and returns the names of the authors that match this criteria,
            * in ascending order and saves it in a list
            */
            var result = (from Author in GetApiData.OurList
                          where Author.CreatedAt <= threshold
                          orderby Author.CreatedAt ascending
                          select Author.Username).ToList();


            return result;
        }



    }

}
