using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RestAPILibrary
{
    /* This class is responsible for holding the properties 
     * from the root of the returned Json object
     */

    public class Root
    {
        [JsonPropertyName("page")]
        public string Page { get; set; }

        [JsonPropertyName("per_page")]
        public int PerPage { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("data")]
        public List<Datum> Data { get; set; }
    }


}