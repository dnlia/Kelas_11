using System;

namespace Tugas_1
{
    class BangunRuang
    {
            public double LuasKubus(double s)
            {
                return 6 * s * s;
            }

            public double VolumeKubus(double s)
            {
                return s * s * s;
            }

            public double LuasBola(double r)
            {
                return 4 * Math.PI * r * r;
            }

            public double VolumeBola(double r)
            {
                return (4.0 / 3.0) * Math.PI * r * r * r;
            }
        
    }

}