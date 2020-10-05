using Microsoft.AspNetCore.Components;

namespace ExercisesForProgrammers.Models
{
    public class MadLibsModel
    {
        public string Noun { get; set; }
        public string Verb { get; set; }
        public string Adjective { get; set; }
        public string Adverb { get; set; }

        public string Story => $"Do you {Verb} your {Adjective} {Noun} {Adverb}? That's hilarious!";
    }
}