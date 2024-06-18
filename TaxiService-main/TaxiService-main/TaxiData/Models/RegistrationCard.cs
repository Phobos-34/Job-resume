namespace TaxiData.Models
{
    public class RegistrationCard
    {
        public string Name { get; private set; }
        public int Id { get; private set; }

        public RegistrationCard(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetId(int id)
        {
            Id = id;
        }
    }
}
