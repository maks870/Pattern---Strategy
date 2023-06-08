using System.Collections.Generic;
using System.Text;

namespace Pattern___Strategy
{
    public interface IWeapon
    {
        public string Name { get; }
        public void UseWeapon();
    }
}
