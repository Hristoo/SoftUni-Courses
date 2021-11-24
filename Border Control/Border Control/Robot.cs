
namespace BorderControl
{
    public class Robot : IIdentifible
    {
        public Robot(string id, string model)
        {
            Id = id;
            Model = model;
        }

        public string Id { get; }

        public string Model { get; set; }
    }
}
