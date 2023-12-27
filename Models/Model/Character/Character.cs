using Models.Model.Base;
using System.Runtime.CompilerServices;

namespace Rick_Morty.Model.Character
{

    public class CharacterResult : BaseMain
    {
        public List<Character> results { get; set; }
    }


    public class Character : BaseMovie
    {

        public string Status { get; set; }

        public string Species { get; set; }

        public string Gender { get; set; }

        public Origin Origin { get; set; }

        public CharacterLocation Location { get; set; }
        public List<string> Episode { get; set; }

        public string Image { get; set; }

    }
    public class Origin
    {


        public string Name { get; set; }
        public string Url { get; set; }

    }
    public class CharacterLocation
    {


        public string Name { get; set; }
        public string Url { get; set; }
    }



}
