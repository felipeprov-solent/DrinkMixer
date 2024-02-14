using System.Runtime.Serialization;

namespace DrinkMixer.Lib.DTO
{
    [DataContract]
    public class SearchRecipeParameter
    {
        [DataMember]
        public long? Id { get; set; }

        [DataMember]
        public string? Name { get; set; }
    }
}
