using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute 
{
    [AttributeUsage(AttributeTargets.Struct |
                    AttributeTargets.Class |
                    AttributeTargets.Interface |
                    AttributeTargets.Method |
                    AttributeTargets.Enum)]

    class Attribute : System.Attribute
    {
        // field version
        private double version;

        //constructor
    public Attribute(double version)
    {
        this.version = version;
    }
        //property version
    public double Version
    {
        get
        {
            return this.version;
        }
    }
        //override ToString method to dispaly version
    public override string ToString()
    {
        return string.Format("{0}",Version);
    }
    }
}
