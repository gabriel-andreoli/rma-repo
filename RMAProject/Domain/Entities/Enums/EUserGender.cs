using System.ComponentModel;

namespace RMAProject.Domain.Entities.Enums
{
    public enum EUserGender
    {
        [Description("Nenhum")]
        None = 0,
        [Description("Masculino")]
        Male = 1,
        [Description("Feminino")]
        Female = 2
    }
}
