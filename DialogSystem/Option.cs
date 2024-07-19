namespace DialogSystem
{
    public class Option
    {
        public string Description { get; }
        public bool IsCorrect { get; }

        public Option(string description, bool isCorrect)
        {
            Description = description;
            IsCorrect = isCorrect;
        }
        public Option(string description)
        {
            Description = description;
            IsCorrect = false;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}