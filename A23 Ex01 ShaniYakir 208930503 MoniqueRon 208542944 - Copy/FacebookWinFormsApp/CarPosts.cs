using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace BasicFacebookFeatures
{

    public class CarPosts
    {
        [JsonProperty("carPosts")]
        public List<CarPost> carPosts { get; set; }
        public CarPost getItemByIndex(int index)
        {
            return this.carPosts[index];
        }
    }

    public class CarPost
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("postText")]
        public string PostText { get; set; }

        [JsonProperty("nameOfGroup")]
        public string NameOfGroup { get; set; }

        [JsonProperty("postDate")]
        public string PostDate { get; set; }

        public string toString()
        {
            string returnValue = "";
            string user_Name = this.UserName;
            string post_Text = this.PostText;
            string name_Of_Group = this.NameOfGroup;
            string post_Date = this.PostDate;
            returnValue = "User Name: " + user_Name + "\n" + "Post Text: " + post_Text + "\n" + "Name of group: " + name_Of_Group + "\n" + "Post Date: " + post_Date;

            return returnValue;
        }
    }
}