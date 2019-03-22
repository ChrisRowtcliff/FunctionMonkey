using FunctionMonkey.Abstractions.Builders.Model;

namespace FunctionMonkey.Model.OutputBindings
{
    public class ServiceBusTopicOutputBinding : AbstractConnectionStringOutputBinding
    {
        public string TopicName { get; set; }

        public ServiceBusTopicOutputBinding(string commandResultTypeName, string connectionStringSettingName) : base(commandResultTypeName, connectionStringSettingName)
        {
        }
    }
}