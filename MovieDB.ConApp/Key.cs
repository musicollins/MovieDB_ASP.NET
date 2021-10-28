namespace MovieDB.ConApp
{
    public class Key
    {
        public string ValueOfKey { get; set; }

        public override string ToString()
        {
            return $"Key : {ValueOfKey}";
        }
    }
}
