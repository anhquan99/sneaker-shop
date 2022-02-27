using System.ComponentModel;

namespace WebApplication1.Infrastructure.Enums
{
    public enum UserTypes
    {
        [Description("Men")]
        Men = 1;
        [Description("Women")]
        Women = 2;
        [Description("Youth")]
        Youth = 3;
    }
}
