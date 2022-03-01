using System.ComponentModel;

namespace WebApplication1.Infrastructure.Enums
{
    public enum UserRoleEnum
    {
        [Description("superAdmin")]
        superAdmin = 0,
        [Description("admin")]
        admin = 1,
        [Description("user")]
        user = 2
    }
}
