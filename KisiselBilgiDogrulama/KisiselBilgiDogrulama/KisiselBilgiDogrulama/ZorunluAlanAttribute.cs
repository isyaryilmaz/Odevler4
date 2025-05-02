using System;

namespace KisiselBilgiDogrulama.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ZorunluAlanAttribute : Attribute
    {
        public string HataMesaji { get; }

        public ZorunluAlanAttribute(string hataMesaji)
        {
            HataMesaji = hataMesaji;
        }
    }
}
