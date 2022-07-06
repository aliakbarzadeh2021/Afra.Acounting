using Newtonsoft.Json;
using Afra.Message.Base;

namespace Afra.Logger.Extentions
{
    public static class CommandExtentions
    {
        public static string Serialize(this ICommandBase command)
        {
            return JsonConvert.SerializeObject(command);
        }
    }
}