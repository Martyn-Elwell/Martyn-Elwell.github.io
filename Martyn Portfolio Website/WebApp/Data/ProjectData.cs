using WebApp.Models;

namespace WebApp.Data
{
    public class ProjectData
    {
        public static List<CardData> Data => new()
        {
            new()
            {
                ID = 0,Href="/portfolio/quad-bikes",Title = "Quad Bikes",
                Description = "Made for the Speed 2024 game jam, Quad Bikes is an arcade racer set in a picturesque forest.",
                Date = "Febuary 2024", ImageFilePath = "images/quad-bikes.png",
                Platforms=new() { new(){ Type = CardData.Platform_Value.unity }/*, new(){ Type = Platform_Value.unity },*/ },
                ProjectType = CardData.ProjectType_Value.GameJams
            },
            new()
            {
                ID = 0,Href="/portfolio/quad-bikes",Title = "Quad Bikes",
                Description = "Made for the Speed 2024 game jam, Quad Bikes is an arcade racer set in a picturesque forest.",
                Date = "Febuary 2024", ImageFilePath = "images/quad-bikes.png",
                Platforms=new() { new(){ Type = CardData.Platform_Value.unity }/*, new(){ Type = Platform_Value.unity },*/ },
                ProjectType = CardData.ProjectType_Value.GameJams
            },
            new()
            {
                ID = 0,Href="/portfolio/quad-bikes",Title = "Quad Bikes",
                Description = "Made for the Speed 2024 game jam, Quad Bikes is an arcade racer set in a picturesque forest.",
                Date = "Febuary 2024", ImageFilePath = "images/quad-bikes.png",
                Platforms=new() { new(){ Type = CardData.Platform_Value.unity }/*, new(){ Type = Platform_Value.unity },*/ },
                ProjectType = CardData.ProjectType_Value.GameJams
            },
            new()
            {
                ID = 0,Href="/portfolio/quad-bikes",Title = "Quad Bikes",
                Description = "Made for the Speed 2024 game jam, Quad Bikes is an arcade racer set in a picturesque forest.",
                Date = "Febuary 2024", ImageFilePath = "images/quad-bikes.png",
                Platforms=new() { new(){ Type = CardData.Platform_Value.unity }/*, new(){ Type = Platform_Value.unity },*/ },
                ProjectType = CardData.ProjectType_Value.GameJams
            },
            new()
            {
                ID = 0,Href="/portfolio/quad-bikes",Title = "Quad Bikes",
                Description = "Made for the Speed 2024 game jam, Quad Bikes is an arcade racer set in a picturesque forest.",
                Date = "Febuary 2024", ImageFilePath = "images/quad-bikes.png",
                Platforms=new() { new(){ Type = CardData.Platform_Value.unity }/*, new(){ Type = Platform_Value.unity },*/ },
                ProjectType = CardData.ProjectType_Value.GameJams
            },
            new()
            {
                ID = 0,Href="/portfolio/quad-bikes",Title = "Quad Bikes",
                Description = "Made for the Speed 2024 game jam, Quad Bikes is an arcade racer set in a picturesque forest.",
                Date = "Febuary 2024", ImageFilePath = "images/quad-bikes.png",
                Platforms=new() { new(){ Type = CardData.Platform_Value.unity }/*, new(){ Type = Platform_Value.unity },*/ },
                ProjectType = CardData.ProjectType_Value.GameJams
            }/*
            new()
            {
                ID = 1,Href="/portfolio/quad-bike",Title = "Quad Bikes",
                Description = "Made for the Speed 2024 game jam, Quad Bikes is an arcade racer set in a picturesque forest.",
                Date = "Febuary 2024", ImageFilePath = "images/quad-bikes.png", PlatformTag = Platform.unity, SecondaryPlatformTag= null,
                ProjectType = ProjectType.gameJams
            },*/
        };
        public static CardData GetCard(int id)
        {
            return Data.FirstOrDefault(x => x.ID == id);
        }
    }
}
