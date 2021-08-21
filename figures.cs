using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_Table
{
    class figures
    {
        private List<Scene> _scenes = new List<Scene>();
        public void AddShape(Scene scene)
        {
            _scenes.Add(scene);
        }
        public double CalculateSurface()
        {
            var surface = 0.0;
            foreach (var scene in _scenes)
                surface += scene.CalculateSurface();

            return surface;
        }
    }
}
