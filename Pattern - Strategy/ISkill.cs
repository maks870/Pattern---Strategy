using System.Collections.Generic;
using System.Text;

namespace Pattern___Strategy
{
    public interface ISkill
    {
        public string Name { get; }
        public void UseSkill();
    }
}
