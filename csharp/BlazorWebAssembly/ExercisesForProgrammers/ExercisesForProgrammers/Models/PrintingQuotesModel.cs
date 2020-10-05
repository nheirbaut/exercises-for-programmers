namespace ExercisesForProgrammers.Models
{
    public class PrintingQuotesModel
    {
        public string Quote { get; set; }
        public string Who { get; set; }

        public string FullQuote => $"{Who} says, \"{Quote}\"";
    }
}