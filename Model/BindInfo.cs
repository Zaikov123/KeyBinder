using System.Windows.Input;

namespace KeyBinderV1.Model
{
    public struct BindInfo
    {
        public string Name { get; set; }
        public string[] Action { get; set; }
        public Key Key { get; set; }
    }
}
