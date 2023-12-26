namespace Rick_Morty.Model.Character
{

    public class CharacterResult
    {

        public Info info { get; set; }
        public List<Character> results { get; set; }


    }

    public class Info
    {


        public int Count { get; set; }
        public int Pages { get; set; }
        public string Next { get; set; }
        //{
        //    //get { return Next; }   // get method
        //    //set { Next = value.Replace("https://rickandmortyapi.com", "http://localhost:7012"); }  // set method
        //}




        public string Prev { get; set; }
    }
    public class Character
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public string Species { get; set; }

        public string Gender { get; set; }

        public Origin Origin { get; set; }

        public Location Location { get; set; }

        public string Image { get; set; }

    }
    public class Origin
    {


        public string Name { get; set; }
        public string Url { get; set; }

    }
    public class Location
    {


        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Episode
    {



    }

}
