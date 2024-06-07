namespace WebApp.Models
{
    public class CardData()
    {
        public int ID { get; set; }
        public string Href { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string ImageFilePath { get; set; }

        public ProjectType_Value ProjectType { get; set; }

        public List<Platform> Platforms { get; set; }

        public class Platform()
        {
            public Platform_Value Type { get; set; }
            public string Icon => GetIcon(Type);

            public string GetIcon(Platform_Value? platform)
            {
                switch (platform)
                {
                    case Platform_Value.unity:
                        return "fa-brands fa-unity";
                    default:
                        return "";
                }

            }
        }

        public enum Platform_Value
        {
            unity = 0,
            unreal = 1,
            cplusplus = 2,
        }
        public enum ProjectType_Value
        {
            All = 0,
            Uni = 1,
            GameJams = 2,
            Studio = 3,
        }
    }

}
