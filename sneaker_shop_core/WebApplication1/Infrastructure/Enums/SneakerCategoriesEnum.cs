using System.ComponentModel;

namespace WebApplication1.Infrastructure.Enums
{
    public enum SneakerCategoriesEnum
    {
        [Description("Boots")]
        Boots = 1,
        [Description("LifeStyle")]
        LifeStyle = 2,
        [Description("Running")]
        Running = 3,
        [Description("Sandal")]
        Sandals = 4,
        [Description("Skateboarding")]
        Skateboarding = 5,
        [Description("Basketball")]
        Basketball = 6
    }
}
